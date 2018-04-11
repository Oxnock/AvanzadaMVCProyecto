using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class UsuarioCursoAsistencia
    {
        public int UsuarioCursoAsistenciaId { get; set; }
        public ICollection<Asistencia> Asistencias { get; set; }
        public ICollection<Curso> Cursos { get; set; }
        public string UsuarioId { get; set; }
    }
}
