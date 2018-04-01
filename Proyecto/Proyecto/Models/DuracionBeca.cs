using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class DuracionBeca
    {
		public Beca BecaId { get; set; }
		public Usuario Carne { get; set; }
		public DateTime FechaInicial { get; set; }
		public DateTime FechaFinal { get; set; }
	}
}
