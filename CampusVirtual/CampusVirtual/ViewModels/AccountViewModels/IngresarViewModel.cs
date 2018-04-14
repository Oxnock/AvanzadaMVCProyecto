using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.AccountViewModels
{
    public class IngresarViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }
    }
}
