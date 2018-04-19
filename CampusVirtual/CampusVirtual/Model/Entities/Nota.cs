using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class Nota
    {
        public int NotaId { get; set; }
        public string UsuarioId { get; set; }
        public virtual Evaluacion Evaluacion { get; set; } //GetNombreCurso
        public virtual Usuario Usuario { get; set; }
    }
}
