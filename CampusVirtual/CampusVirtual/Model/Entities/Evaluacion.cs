using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public Curso Curso { get; set; }
    }
}
