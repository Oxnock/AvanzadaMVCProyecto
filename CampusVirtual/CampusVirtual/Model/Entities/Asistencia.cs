using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public bool Asistio { get; set; }
        public DateTime Fecha { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
