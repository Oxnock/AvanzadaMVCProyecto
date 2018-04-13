using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Controllers
{
    public class CursoController:Controller
    {
		ICursosRepository repositorio;
		public CursoController(ICursosRepository _repositorio)
		{
			repositorio = _repositorio;
		}

		// GET: /<controller>/
		public IActionResult Index()
		{
			IndexViewModel modelo = new IndexViewModel();
			modelo.Title = "Lista de Animales";
			modelo.List = repositorio.ObtenerAnimales();
			return View(modelo);
		}

		public IActionResult Crear()
		{
			CrearViewModel modelo = new CrearViewModel();
			modelo.Title = "Crear Animal";
			modelo.TipoAnimales = new List<SelectListItem>();
			foreach (var valor in Enum.GetValues(typeof(Animal.TipoAnimal)))
			{
				modelo.TipoAnimales.Add(new SelectListItem
				{
					Value = valor.ToString(),
					Text = Enum.GetName(typeof(Animal.TipoAnimal), valor)
				});
			}
			return View(modelo);
		}

		[HttpPost]
		public IActionResult Crear(CrearViewModel modelo)
		{
			if (!ModelState.IsValid || repositorio.ExisteAnimal(modelo.Id))
			{
				if (repositorio.ExisteAnimal(modelo.Id))
				{
					modelo.ExisteAnimal = true;
				}
				modelo.TipoAnimales = new List<SelectListItem>();
				foreach (var valor in Enum.GetValues(typeof(Animal.TipoAnimal)))
				{
					modelo.TipoAnimales.Add(new SelectListItem
					{
						Value = valor.ToString(),
						Text = Enum.GetName(typeof(Animal.TipoAnimal), valor)
					});
				}
				return View(modelo);
			}
			repositorio.CrearAnimal(new Animal()
			{
				AnimalId = modelo.Id,
				Nombre = modelo.Nombre,
				Tipo = (Animal.TipoAnimal)Enum.Parse(typeof(Animal.TipoAnimal), modelo.TipoAnimal)
			});

			return RedirectToAction("Index");
		}

		public IActionResult Editar()
		{
			EditarViewModel modelo = new EditarViewModel();
			modelo.Title = "Editar Animal";
			modelo.TipoAnimales = new List<SelectListItem>();
			foreach (var valor in Enum.GetValues(typeof(Animal.TipoAnimal)))
			{
				modelo.TipoAnimales.Add(new SelectListItem
				{
					Value = valor.ToString(),
					Text = Enum.GetName(typeof(Animal.TipoAnimal), valor)
				});
			}
			return View(modelo);
		}

		[HttpPost]
		public IActionResult Editar(EditarViewModel modelo)
		{
			repositorio.EditarAnimal(new Animal()
			{
				AnimalId = modelo.Id,
				Nombre = modelo.Nombre,
				Tipo = (Animal.TipoAnimal)Enum.Parse(typeof(Animal.TipoAnimal), modelo.TipoAnimal)
			});

			return RedirectToAction("Index");
		}

		public IActionResult Eliminar()
		{
			return View(new EliminarViewModel());
		}

		[HttpPost]
		public IActionResult Eliminar(int id)
		{
			repositorio.EliminarAnimal(id);
			return RedirectToAction("Index");
		}

	}
}
