using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CarrerasViewModels
{
    public class EditarViewModel
    {
		public string Nombre { get; set; }
		[Required]
		public int Id { get; set; }
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public string Director { get; set; }
		public Carreras Carreras { get; set; }
	}
}
