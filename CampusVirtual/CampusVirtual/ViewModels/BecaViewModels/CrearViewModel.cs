using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.BecaViewModels
{
    public class CrearViewModel
    {
        [Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Porcentaje requerido")]
        public int Porcentaje { get; set; }
	}
}
