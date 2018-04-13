using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.Curso
{
    public class Editar
    {
	
		public string Nombre { get; set; }
		public ICollection<UsuarioCurso> UCs { get; set; }
		public ICollection<Evaluacion> Evaluaciones { get; set; }
		public string Title { get; set; }
	}
}
