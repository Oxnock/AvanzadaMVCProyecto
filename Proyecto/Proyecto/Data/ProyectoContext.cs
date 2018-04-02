using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Models
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext (DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Accion> Accion { get; set; }

        public DbSet<Proyecto.Models.Asistencia> Asistencia { get; set; }

        public DbSet<Proyecto.Models.AsistenciaProfesor> AsistenciaProfesor { get; set; }

        public DbSet<Proyecto.Models.Beca> Beca { get; set; }

        public DbSet<Proyecto.Models.Carrera> Carrera { get; set; }

        public DbSet<Proyecto.Models.DuracionBeca> DuracionBeca { get; set; }

        public DbSet<Proyecto.Models.Evaluacion> Evaluacion { get; set; }

        public DbSet<Proyecto.Models.Grupo> Grupo { get; set; }

        public DbSet<Proyecto.Models.Materia> Materia { get; set; }

        public DbSet<Proyecto.Models.Matricula> Matricula { get; set; }

        public DbSet<Proyecto.Models.Menu> Menu { get; set; }

        public DbSet<Proyecto.Models.Parametros> Parametros { get; set; }

        public DbSet<Proyecto.Models.Permiso> Permiso { get; set; }

        public DbSet<Proyecto.Models.PreguntaEvaluacion> PreguntaEvaluacion { get; set; }

        public DbSet<Proyecto.Models.Requisito> Requisito { get; set; }

        public DbSet<Proyecto.Models.Semana> Semana { get; set; }

        public DbSet<Proyecto.Models.Tipo> Tipo { get; set; }

        public DbSet<Proyecto.Models.TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Proyecto.Models.Usuario> Usuario { get; set; }

        public DbSet<Proyecto.Models.UsuarioCarrera> UsuarioCarrera { get; set; }
    }
}
