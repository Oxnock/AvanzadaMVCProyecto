using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class UsuarioCurso
    {
        public int UsuarioCursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
