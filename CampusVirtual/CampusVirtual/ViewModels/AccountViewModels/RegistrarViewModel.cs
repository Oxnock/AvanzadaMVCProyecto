using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.AccountViewModels
{
    public class RegistrarViewModel
    {
        [Required(ErrorMessage = "El nombre del usuario es requerido")]
        [Display(Name = "Usuario")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Display(Name = "Tipos de usuario")]
        public List<SelectListItem> TipoUsuarios { get; set; }

        [Required(ErrorMessage = "El tipo de usuario es requerido")]
        public string TipoUsuario { get; set; }
    }
}