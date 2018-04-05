using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Matricula
    {
		public int MatriculaId { get; set; }
		public Usuario Usuario { get; set; }
		public Grupo Grupo { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Asistente { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string Cuatrimestre { get; set; }

		[Required(ErrorMessage = "El numero de porcentaje es requerido")]
		[Range(0, 100, ErrorMessage = "El porcentaje debe estar entre los rangos 0%-100%")]
		public int Descuento { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public DateTime Fecha { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Estado { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Modalidad { get; set; }

		public IEnumerable<Asistencia> Asistencia { get; set; }
		public IEnumerable<RespuestaEvaluacion> RespuestaEvaluacion { get; set; }
	}
}
