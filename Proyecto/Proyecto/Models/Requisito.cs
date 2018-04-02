using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Requisito
    {
		public int RequisitoId { get; set; }
		public Materia MateriaId { get; set; }
		[Required(ErrorMessage = "Campo  Requerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "El codigo es demasiado corto")]
		public string MateriaRequisito { get; set; }
	}
}
