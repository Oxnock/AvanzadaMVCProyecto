using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Semana
    {
		public int SemanaId { get; set; }
		public Grupo Grupo { get; set; }
		public string Contenido { get; set; }
		public DateTime Fecha { get; set; }

	}
}
