using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Accion
    {
		public int AccionId { get; set; }
		public string Nombre { get; set; }

		public IEnumerable<Permiso> Permisos { get; set; }
	}
}
