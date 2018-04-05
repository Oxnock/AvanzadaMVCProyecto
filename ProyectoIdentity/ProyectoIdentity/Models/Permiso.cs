using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Permiso
    {

		public Accion Accion { get; set; }
		public Tipo Tipo { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		[Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero valido")]
		public int PermisoId { get; set; }
	}
}
