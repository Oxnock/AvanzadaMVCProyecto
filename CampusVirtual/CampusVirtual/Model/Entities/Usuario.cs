using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Usuario:IdentityUser
    {
        public Usuario() {
            Cursos = new List<UsuarioCurso>();
            Notas = new List<Nota>();
            Asistencias = new List<Asistencia>();
        }

        public virtual ICollection<UsuarioCurso> Cursos { get; set; }
        public virtual ICollection<Nota> Notas { get; set; } 
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
