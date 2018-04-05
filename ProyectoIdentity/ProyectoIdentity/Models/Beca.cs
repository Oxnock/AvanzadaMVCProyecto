using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIdentity.Models
{
    public class Beca
	{
		public int BecaId { get; set; }
		[Required(ErrorMessage = "El campo nombre es requerido")]
		[RegularExpression("^[a-zA-Z ]*$")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El numero de porcentaje es requerido")]
		[Range(0, 100, ErrorMessage = "El porcentaje debe estar entre los rangos 0%-100%")]
		public int Porcentaje { get; set; }

		public IEnumerable<DuracionBeca> DuracionBeca { get; set; }
	}
}
