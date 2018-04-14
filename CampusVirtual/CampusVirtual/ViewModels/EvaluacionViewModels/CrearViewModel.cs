using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.EvaluacionViewModel
{
    public class CrearViewModel
    {
        [Required]
        [Display(Name = "Evaluacion")]
        public string Nombre { get; set; }

        [Required]
        public Curso Curso { get; set; }
    }
}
