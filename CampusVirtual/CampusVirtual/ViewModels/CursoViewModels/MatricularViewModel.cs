using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CursoViewModels
{
    public class MatricularViewModel
    {
        [Required]
        public IEnumerable<Curso> Cursos { get; set; } 
    }
}
