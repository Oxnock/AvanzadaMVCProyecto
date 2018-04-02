using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class PreguntaEvaluacion
    {
		
		public int PreguntaId { get; set; }
		public Evaluacion Evaluacion { get; set; }
		[Required(ErrorMessage = "Campo Requerido")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "Ingrese una pregunta valida")]
		public string Pregunta { get; set; }
	}
}
