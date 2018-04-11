using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        public string Tipo { get; set; }
        public string UsuarioId { get; set; }
    }
}
