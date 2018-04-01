using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Asistencia
    {
		public int AsistenciaId { get; set; }
		public Matricula Matricula { get; set; }
		public int Semana { get; set; }
		public string vAsistencia { get; set; }
	}
}
