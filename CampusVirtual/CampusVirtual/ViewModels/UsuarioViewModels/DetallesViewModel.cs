using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.UsuarioViewModels
{
    public class DetallesViewModel
    {
        public Usuario Usuario { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
