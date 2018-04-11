using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class UsuarioCurso
    {
        public int UsuarioCursoId { get; set; }
        public Curso Curso { get; set; }
        public string UsuarioId { get; set; }
    }
}
