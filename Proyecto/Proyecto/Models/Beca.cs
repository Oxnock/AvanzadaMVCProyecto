using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Beca
    {
		public int BecaId { get; set; }
		public string Nombre { get; set; }
		public int Porcentaje { get; set; }

		public IEnumerable<DuracionBeca> DuracionBeca { get; set; }

	}
}
