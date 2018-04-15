using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
	public class Carreras
	{
		public int CarrerasId { get; set; }
		public string Nombre { get; set; }
		public string Descripcion{ get; set; }
		public string Director { get; set; }
		public Usuario Director1 { get; set; }
	}
}
