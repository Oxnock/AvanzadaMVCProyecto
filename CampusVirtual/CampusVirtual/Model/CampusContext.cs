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
    public class CampusContext:IdentityDbContext<Usuario>
    {
        public CampusContext(DbContextOptions<CampusContext> options) : base(options) { }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Curso> Cursos { get; set; } 
        public DbSet<UsuarioCurso> UsuarioCurso { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Grupos> Grupos { get; set; }
		public DbSet<Carreras> Carreras { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Curso>()
                .HasMany(c => c.UsuarioCursos)
                .WithOne(uc => uc.Curso)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
