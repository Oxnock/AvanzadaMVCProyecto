using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.BecaViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampusVirtual.Controllers
{
    public class BecaController:Controller
    {
		private readonly UserManager<Usuario> _userManager;
		private CampusContext _context;

		public BecaController(CampusContext context,
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
				return View(new IndexViewModel() { Becas = _context.Becas.ToList() });
			//}

			//return View(new IndexViewModel()
			//{
			//	Becas = _context.UsuarioCurso
			//			.Where(uc => uc.Usuario == CurrentUser)
			//			.Select(uc => uc.Curso).ToList()
			//});
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
			if (!_context.Becas.Any(c => c.Nombre == crearViewModel.Nombre))
			{
				_context.Becas.Add(new Beca() { Nombre = crearViewModel.Nombre ,Porcentaje=crearViewModel.Porcentaje});
				_context.SaveChanges();
				return RedirectToAction("Index");
			}

			return View();
		}

		[Authorize(Roles = "Administrador")]
		public IActionResult Eliminar(int id)
		{
			var Curso = _context.Becas.Find(id);
			if (Curso != null)
			{
				_context.Becas.Remove(Curso);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		[Authorize(Roles = "Administrador")]
		public IActionResult Editar(int id)
		{
			return View(new EditarViewModel()
			{
				Becas = _context.Becas.Find(id)
			});
		}


		[Authorize(Roles = "Administrador")]
		[HttpPost]
		public IActionResult Editar(EditarViewModel model)
		{

			var Curso = _context.Becas.Find(model.Id);
			if (Curso != null)
			{
				Curso.Nombre = model.Nombre;
				Curso.Porcentaje = model.Porcentaje;
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

	

	}
}
