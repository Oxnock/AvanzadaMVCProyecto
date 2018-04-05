using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Evaluacion
    {
		public int EvaluacionId { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Nombre { get; set; }

		public IEnumerable<Evaluacion> Evaluaciones { get; set; }
	}
}
