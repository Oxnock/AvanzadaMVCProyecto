using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Accion
    {
		public int AccionId { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string Nombre { get; set; }

		public IEnumerable<Permiso> Permisos { get; set; }
	}
}
