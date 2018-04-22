using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.UsuarioViewModels
{
    public class EditarViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string UsuarioId { get; set; }
    }
}
