using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class PreguntaEvaluacion
    {
		public int PreguntaId { get; set; }
		public Evaluacion Evaluacion { get; set; }
		public string Pregunta { get; set; }
	}
}
