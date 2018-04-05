using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Materia
    {
		public int MateriaId { get; set; }
		public Carrera Carrera { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[Range(0, Double.MaxValue, ErrorMessage = "Monto no puede ser negativo")]
		public Double Precio { get; set; }
	}
}
