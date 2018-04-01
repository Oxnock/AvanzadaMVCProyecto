using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Carrera
    {
		public int CarreraId { get; set; }
		public string Nombre { get; set; }
		public string Director { get; set; }
		public Double MontoMatricula { get; set; }

		public IEnumerable<UsuarioCarrera> UsuariosCarreras { get; set; }
		public IEnumerable<Materia> Materias { get; set; }
	}
}
