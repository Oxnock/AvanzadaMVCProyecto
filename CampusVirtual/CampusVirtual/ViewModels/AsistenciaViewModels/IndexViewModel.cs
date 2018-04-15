using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.AsistenciaViewModels
{
    public class IndexViewModel
    {
		[Display(Name = "Lista de Estudiantes")]
		public List<Asistencia> Lista { get; set; }
	}
}
