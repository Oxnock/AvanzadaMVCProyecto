using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class AsistenciaProfesor
    {
		public int AsistenciaProfesorId { get; set; }
		public Grupo Grupo { get; set; }
		public int Semana { get; set; }
		public string Entrada { get; set; }
		public string Salida { get; set; }
	}
}
