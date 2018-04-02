using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Proyecto.Models
{
    public class Carrera
    {
		public int CarreraId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El monto de la matricula no puede ser negativa")]
        public Double MontoMatricula { get; set; }

		public IEnumerable<UsuarioCarrera> UsuariosCarreras { get; set; }
		public IEnumerable<Materia> Materias { get; set; }
	}
}
