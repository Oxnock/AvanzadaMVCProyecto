using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CursoViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "Lista de cursos")]
        public List<Curso> Cursos { get; set; }
    }
}
