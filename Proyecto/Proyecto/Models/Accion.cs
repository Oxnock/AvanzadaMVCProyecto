using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Proyecto.Models
{
    public class Accion
    {
		public int AccionId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }

		public IEnumerable<Permiso> Permisos { get; set; }
	}
}
