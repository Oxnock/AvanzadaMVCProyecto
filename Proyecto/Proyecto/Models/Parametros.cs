using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Parametros
    {
		public DateTime fechaLimOrd { get; set; }
		public DateTime fechaLimExt { get; set; }
		public int descuento { get; set; }
		public int maxCred { get; set; }
	}
}
