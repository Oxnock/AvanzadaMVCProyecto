using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.AsistenciaViewModels
{
    public class AsignarViewModel
    {
		[Required]
		public bool Asistio { get; set; }
		[Required]
		public DateTime Fecha { get; set; }

		public virtual Usuario Usuario { get; set; }

		public virtual Curso Curso { get; set; }
		public Asistencia Lista { get; set; }
	}
}
