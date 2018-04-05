using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class AsistenciaProfesor
    {
		public int AsistenciaProfesorId { get; set; }
		public Grupo Grupo { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[Range(1, int.MaxValue, ErrorMessage = "Numero de semana no puede ser negativa")]
		public int Semana { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public DateTime Entrada { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public DateTime Salida { get; set; }
	}
}
