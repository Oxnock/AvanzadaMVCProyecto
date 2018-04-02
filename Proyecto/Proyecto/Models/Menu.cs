using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Menu
    {
		public int MenuId { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		public string Texto { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		public string Enlace { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		[Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero valido")]
		public int Orden { get; set; }




		public IEnumerable<Tipo> Tipo { get; set; }
	}
}
