using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CampusVirtual.ViewModels.UsuarioViewModels;
using Microsoft.AspNetCore.Identity;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;

namespace CampusVirtual.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private CampusContext _context;

        public UsuarioController(UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManager,
            CampusContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Index()
        {
            return View(new IndexViewModel()
            {
                Usuarios = _context.Usuarios.ToList()
            });
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Detalles(string id)
        {
            var Usuario = _context.Usuarios.Find(id);
            return View(new DetallesViewModel()
            {
                Usuario = Usuario,
                Cursos = _context.UsuarioCurso
                        .Where(uc => uc.Usuario.Id == Usuario.Id)
                        .Select(uc => uc.Curso).ToList()
            });
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Eliminar(string id)
        {
            var Usuario = _context.Usuarios.Find(id);
            _userManager.DeleteAsync(Usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}