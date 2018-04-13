using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.Curso
{
    public class Crear
    {

		[Required(ErrorMessage = "El nombre del curso es requerido.")]
		[Display(Name = "Nombre del Curso")]
		public string Nombre { get; set; }
		[Display(Name = "UCs")]
		public ICollection<UsuarioCurso> UCs { get; set; }
		[Display(Name = "Evaluaciones")]
		public ICollection<Evaluacion> Evaluaciones { get; set; }
		public string Title { get; set; }
		public bool ExisteCurso { get; set; }
	}
}
