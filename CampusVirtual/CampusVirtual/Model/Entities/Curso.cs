using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public ICollection<UsuarioCurso> UCs { get; set; }
        public ICollection<Evaluacion> Evaluaciones { get; set; }
    }
}
