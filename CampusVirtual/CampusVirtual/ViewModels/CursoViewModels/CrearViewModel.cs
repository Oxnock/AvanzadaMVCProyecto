using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CursoViewModels
{
    public class CrearViewModel
    {
        [Required]
        [Display(Name = "Nombre del curso")]
        public string Nombre { get; set; }
        [Required]
        public string Codigo { get; set; } //add
    }
}
