using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Permiso
    {
		public Accion Accion { get; set; }
		public Tipo Tipo { get; set; }
		public int vPermiso { get; set; }
	}
}
