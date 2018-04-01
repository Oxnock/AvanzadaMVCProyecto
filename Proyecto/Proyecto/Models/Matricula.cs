using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Matricula
    {
		public int MatriculaId { get; set; }
		public Usuario Usuario { get; set; }
		public Grupo Grupo { get; set; }
		public string Asistente { get; set; }
		public string Cuatrimestre { get; set; }
		public int Descuento { get; set; }
		public DateTime Fecha { get; set; }
		public string Estado { get; set; }
		public string Modalidad { get; set; }

		public IEnumerable<Asistencia> Asistencia { get; set; }
		public IEnumerable<RespuestaEvaluacion> RespuestaEvaluacion { get; set; }
	}
}
