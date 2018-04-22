using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.CursoViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampusVirtual.Controllers
{
    public class CursoController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private CampusContext _context;

        public CursoController(CampusContext context,
             UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            var Roles = await _userManager.GetRolesAsync(CurrentUser);

            if (Roles.Contains("Administrador"))
            {
                return View(new IndexViewModel() { Cursos = _context.Cursos.ToList() });
            }

            return View(new IndexViewModel()
            {
                Cursos = _context.UsuarioCurso
                        .Where(uc => uc.Usuario == CurrentUser)
                        .Select(uc => uc.Curso).ToList()
            });
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Crear()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult Crear(CrearViewModel crearViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(crearViewModel);
            }
            if (!_context.Cursos.Any(c => c.Nombre == crearViewModel.Nombre))
            {
                _context.Cursos.Add(new Curso() { Nombre = crearViewModel.Nombre, Codigo = crearViewModel.Codigo, CarreraId=crearViewModel.CarreraId, CarrerasC=crearViewModel.CarrerasC });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Eliminar(int id)
        {
            var Curso = _context.Cursos.Find(id);
            if (Curso != null)
            {
                _context.Cursos.Remove(Curso);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Editar(int id)
        {
            return View(new EditarViewModel()
            {
                Curso = _context.Cursos.Find(id)
            });
        }


        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult Editar(EditarViewModel model)
        {

            var Curso = _context.Cursos.Find(model.Id);
            if (Curso != null)
            {
                Curso.Nombre = model.Nombre;
                Curso.Codigo = model.Codigo;
				Curso.CarrerasC = model.CarrerasC;
				Curso.CarreraId = model.CarreraId;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Estudiante")]
        public IActionResult Matricular()
        {
            return View(new MatricularViewModel()
            {
                Cursos = _context.Cursos.ToList()
            });
        }
    }
}