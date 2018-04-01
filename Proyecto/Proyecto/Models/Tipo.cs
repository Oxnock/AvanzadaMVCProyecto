using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Tipo
    {
		public int TipoId { get; set; }
		public string Nombre { get; set; }
		public Menu Menu { get; set; }

		public IEnumerable<Permiso> Permiso { get; set; }
		public IEnumerable<Semana> Semana { get; set; }
	}
}
