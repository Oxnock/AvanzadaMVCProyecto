using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Materia
    {
		public int MateriaId { get; set; }
		public Carrera Carrera { get; set; }
		public string Nombre { get; set; }
		public Double Precio { get; set; }
	}
}
