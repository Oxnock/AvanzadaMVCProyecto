using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Parametros
    {
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
		public DateTime fechaLimOrd { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
		public DateTime fechaLimExt { get; set; }

		[Required(ErrorMessage = "Campo  Requerido")]
		[Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero valido")]
		public int descuento { get; set; }

		[Required(ErrorMessage = "Campo  Requerido")]
		[Range(0, 20, ErrorMessage = "Ingrese un numero valido entre 0-20")]
		public int maxCred { get; set; }
	}
}
