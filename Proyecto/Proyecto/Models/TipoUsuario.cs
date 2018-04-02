using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class TipoUsuario
    {
		public int TipoUsuarioId { get; set; }
		public Usuario Carne { get; set; }
		public Tipo Tipo { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		[StringLength(25, MinimumLength = 1, ErrorMessage = "Es demasiado corto")]
		public string Prioridad { get; set; }
	}
}
