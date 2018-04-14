using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CursoViewModels
{
    public class EditarViewModel
    {
        public Curso Curso { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del curso")]
        public string Nombre { get; set; }
    }
}
