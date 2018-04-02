using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Proyecto.Models
{
    public class DuracionBeca
    {
		public Beca BecaId { get; set; }
        Usuario Carne { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, 31)]
        public DateTime FechaInicial { get; set; }

        [Range(1, 31)]
        public DateTime FechaFinal { get; set; }
	}
}
