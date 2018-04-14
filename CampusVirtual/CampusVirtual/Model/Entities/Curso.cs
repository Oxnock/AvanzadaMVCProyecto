using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Curso
    {
        public Curso() {
            UsuarioCursos = new List<UsuarioCurso>();
            Evaluaciones = new List<Evaluacion>();
        }

        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<UsuarioCurso> UsuarioCursos { get; set; }
        public virtual ICollection<Evaluacion> Evaluaciones { get; set; }
    }
}
