using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Grupo
    {
		public int GrupoId { get; set; }
		public Materia Materia { get; set; }
		public string Profesor { get; set; }
		public string Horario { get; set; }
		public Double Nota { get; set; }

		public IEnumerable<Matricula> Matriculas { get; set; }
		public IEnumerable<AsistenciaProfesor> AsistenciaProfesores { get; set; }
		public IEnumerable<Semana> Semanas { get; set; }
	}
}
