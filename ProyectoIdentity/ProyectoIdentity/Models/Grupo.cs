using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Grupo
    {
		public int GrupoId { get; set; }
		public Materia Materia { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Profesor { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string Horario { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[Range(0, 100, ErrorMessage = "Nota debe estar entre 0-100")]
		public Double Nota { get; set; }

		public IEnumerable<Matricula> Matriculas { get; set; }
		public IEnumerable<AsistenciaProfesor> AsistenciaProfesores { get; set; }
		public IEnumerable<Semana> Semanas { get; set; }
	}
}
