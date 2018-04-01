using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class TipoUsuario
    {
		public Usuario Carne { get; set; }
		public Tipo Tipo { get; set; }
		public string Prioridad { get; set; }
	}
}
