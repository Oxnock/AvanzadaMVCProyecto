using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CampusVirtual.Model
{
    public class CampusContext:IdentityDbContext<IdentityUser>
    {
        public CampusContext(DbContextOptions<CampusContext> options) : base(options) { }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }

        
    }
}
