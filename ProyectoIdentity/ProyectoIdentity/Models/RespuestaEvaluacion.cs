using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class RespuestaEvaluacion
    {
		public int RespuestaEvaluacionId { get; set; }
		public Matricula Matricula { get; set; }
		public PreguntaEvaluacion PreguntaEvaluacion { get; set; }
		[Required(ErrorMessage = "Campo Requerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "la Respuesta es demasiado corta")]
		public string Respuesta { get; set; }
	}
}
