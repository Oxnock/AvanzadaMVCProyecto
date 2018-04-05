using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class UsuarioCarrera
    {
		public int UsuarioCarreraId { get; set; }
		public Usuario Usuario { get; set; }
		public Carrera Carrera { get; set; }
		public DateTime FechaInicial { get; set; }
		public DateTime FechaFinal { get; set; }
	}
}
