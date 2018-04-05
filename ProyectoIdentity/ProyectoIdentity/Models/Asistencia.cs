using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Asistencia
    {
		public int AsistenciaId { get; set; }
		public Matricula Matricula { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[Range(1, int.MaxValue, ErrorMessage = "Numero de semana no puede ser negativa")]
		public int Semana { get; set; }

		[RegularExpression("^[a-zA-Z ]*$")]
		[Required(ErrorMessage = "Campo requerido")]
		public string vAsistencia { get; set; }
	}
}
