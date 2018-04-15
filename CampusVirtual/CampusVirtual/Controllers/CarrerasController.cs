using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.CarrerasViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Controllers
{
    public class CarrerasController : Controller
	{
		private readonly UserManager<Usuario> _userManager;
		private CampusContext _context;

		public CarrerasController(CampusContext context,
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
				return View(new IndexViewModel() { Carrera = _context.Carreras.ToList() });
			//}

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
			if (!_context.Carreras.Any(c => c.Nombre == crearViewModel.Nombre))
			{
				_context.Carreras.Add(new Carreras() { Nombre = crearViewModel.Nombre,Descripcion=crearViewModel.Descripcion,Director=crearViewModel.Director });
				_context.SaveChanges();
				return RedirectToAction("Index");
			}

			return View();
		}

		[Authorize(Roles = "Administrador")]
		public IActionResult Eliminar(int id)
		{
			var Curso = _context.Carreras.Find(id);
			if (Curso != null)
			{
				_context.Carreras.Remove(Curso);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		[Authorize(Roles = "Administrador")]
		public IActionResult Editar(int id)
		{
			return View(new EditarViewModel()
			{
				Carreras = _context.Carreras.Find(id)
			});
		}


		[Authorize(Roles = "Administrador")]
		[HttpPost]
		public IActionResult Editar(EditarViewModel model)
		{

			var Curso = _context.Carreras.Find(model.Id);
			if (Curso != null)
			{
				Curso.Nombre = model.Nombre;
				Curso.Descripcion = model.Descripcion;
				Curso.Director = model.Director;
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}


	}
}
