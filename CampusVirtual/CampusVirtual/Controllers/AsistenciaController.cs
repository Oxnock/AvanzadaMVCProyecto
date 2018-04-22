using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.AsistenciaViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtual.Controllers
{
    public class AsistenciaController : Controller
    {
		private readonly UserManager<Usuario> _userManager;
		private CampusContext _context;
		public IActionResult Index()
        {
		//	return View(new IndexViewModel() { Lista = _context.Asistencias.ToList() });
			return View();
        }

		//[Authorize(Roles = "Administrador")]
		public IActionResult Asignar(int id)
		{
			return View(new AsignarViewModel()
			{
				Lista = _context.Asistencias.Find(id)
			});
		}


		//[Authorize(Roles = "Administrador")]
		[HttpPost]
		public IActionResult Asignar(AsignarViewModel model)
		{

			var Curso = _context.Asistencias.Find(model.Lista);
			if (Curso != null)
			{
				Curso.Asistio = model.Asistio;
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}