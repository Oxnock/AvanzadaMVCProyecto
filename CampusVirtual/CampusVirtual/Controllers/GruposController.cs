using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.GrupoViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampusVirtual.Controllers
{
    
		public class GruposController : Controller
		{
			private readonly UserManager<Usuario> _userManager;
			private CampusContext _context;

			public GruposController(CampusContext context,
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

            //if (Roles.Contains("Administrador"))
            //{
                return View(new IndexViewModel() { Grupo = _context.Grupos.ToList() });
           
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
				if (!_context.Grupos.Any(c => c.NumeroGrupo == crearViewModel.NumeroGrupo))
				{
					_context.Grupos.Add(new Grupos() {NumeroGrupo  = crearViewModel.NumeroGrupo,Horario =crearViewModel.Horario });
					_context.SaveChanges();
					return RedirectToAction("Index");
				}

				return View();
			}

        [Authorize(Roles = "Administrador")]
        public IActionResult Eliminar(int id)
        {
            var Curso = _context.Grupos.Find(id);
            if (Curso != null)
            {
                _context.Grupos.Remove(Curso);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Editar(int id)
			{
				return View(new EditarViewModel()
				{
					Grupo = _context.Grupos.Find(id)
				});
			}


			[Authorize(Roles = "Administrador")]
			[HttpPost]
			public IActionResult Editar(EditarViewModel model)
			{

				var Curso = _context.Grupos.Find(model.Grupo.GruposId);
				if (Curso != null)
				{
					Curso.NumeroGrupo = model.NumeroGrupo;
				Curso.Horario = model.Horario;
				_context.SaveChanges();
				}
				return RedirectToAction("Index");
			}
		
	}


	
}
