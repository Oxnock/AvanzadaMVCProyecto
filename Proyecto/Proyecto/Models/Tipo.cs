using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Tipo
    {
		public int TipoId { get; set; }
		[Required(ErrorMessage = "Campo Nombre Requerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "El nombre es demasiado corto")]
		public string Nombre { get; set; }
		public Menu Menu { get; set; }

		public IEnumerable<Permiso> Permiso { get; set; }
		public IEnumerable<Semana> Semana { get; set; }
	}
}
