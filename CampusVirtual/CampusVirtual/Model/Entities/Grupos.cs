using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Grupos
    {
	public Curso Materia { get; set; } //GetNombreMateria, GetCodigo
	public int GruposId { get; set; }
	public int NumeroGrupo { get; set; }
	public string Horario { get; set; }
		public string CursoId { get; set; }
		public virtual Curso CursosC { get; set; }
	}
}
