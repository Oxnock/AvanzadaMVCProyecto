using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class RespuestaEvaluacion
    {
		public int RespuestaEvaluacionId { get; set; }
		public Matricula Matricula { get; set; }
		public PreguntaEvaluacion PreguntaEvaluacion { get; set; }
		public string Respuesta { get; set; }
	}
}
