using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Menu
    {
		public int MenuId { get; set; }
		public string Texto { get; set; }
		public string Enlace { get; set; }
		public int Orden { get; set; }
		public IEnumerable<Tipo> Tipo { get; set; }
	}
}
