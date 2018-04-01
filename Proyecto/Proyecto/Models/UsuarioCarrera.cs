using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class UsuarioCarrera
    {
		public Usuario Usuario { get; set; }
		public Carrera Carrera { get; set; }
		public DateTime FechaInicial { get; set; }
		public DateTime FechaFinal { get; set; }
	}
}
