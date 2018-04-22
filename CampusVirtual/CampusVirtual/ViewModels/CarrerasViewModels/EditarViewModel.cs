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
        [Required(ErrorMessage = "El nombre de carrera es requerido")]
        public string Nombre { get; set; }
		[Required]
		public int Id { get; set; }
        [Required(ErrorMessage = "El codigo de carrera es requerido")]
        public string Codigo { get; set; } //add
        [Required(ErrorMessage = "La descripción es requerida")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        
		public Carreras Carreras { get; set; }
	}
}
