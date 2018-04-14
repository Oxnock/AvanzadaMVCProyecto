using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Evaluacion
    {
        public Evaluacion() {
            Notas = new List<Nota>();
        }
        public int EvaluacionId { get; set; }
        public string  Nombre { get; set; }
        public Curso Curso { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }
}
