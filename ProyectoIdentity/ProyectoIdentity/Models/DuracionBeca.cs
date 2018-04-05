using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class DuracionBeca
    {
		public int DuracionBecaId { get; set; }
		public Beca BecaId { get; set; }
		public Usuario Carne { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[Range(1, 31)]
		public DateTime FechaInicial { get; set; }

		[Range(1, 31)]
		public DateTime FechaFinal { get; set; }
	}
}
