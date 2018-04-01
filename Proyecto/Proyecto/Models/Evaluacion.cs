using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Evaluacion
    {
		public int EvaluacionId { get; set; }
		public string Nombre { get; set; }
		public IEnumerable<Evaluacion> Evaluaciones { get; set; }
	}
}
