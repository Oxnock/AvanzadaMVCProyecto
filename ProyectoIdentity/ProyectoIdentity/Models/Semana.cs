using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Semana
    {
		public int SemanaId { get; set; }
		public Grupo Grupo { get; set; }
		[Required(ErrorMessage = "CampoRequerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "Es demasiado corto")]
		public string Contenido { get; set; }
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
		public DateTime Fecha { get; set; }
	}
}
