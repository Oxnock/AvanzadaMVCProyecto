using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoIdentity.Models;

namespace ProyectoIdentity.Models
{
    public class ProyectoIdentityContext : DbContext
    {
        public ProyectoIdentityContext (DbContextOptions<ProyectoIdentityContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoIdentity.Models.Accion> Accion { get; set; }

        public DbSet<ProyectoIdentity.Models.Asistencia> Asistencia { get; set; }

        public DbSet<ProyectoIdentity.Models.AsistenciaProfesor> AsistenciaProfesor { get; set; }

        public DbSet<ProyectoIdentity.Models.Beca> Beca { get; set; }

        public DbSet<ProyectoIdentity.Models.Carrera> Carrera { get; set; }

        public DbSet<ProyectoIdentity.Models.DuracionBeca> DuracionBeca { get; set; }

        public DbSet<ProyectoIdentity.Models.Evaluacion> Evaluacion { get; set; }

        public DbSet<ProyectoIdentity.Models.Grupo> Grupo { get; set; }

        public DbSet<ProyectoIdentity.Models.Materia> Materia { get; set; }

        public DbSet<ProyectoIdentity.Models.Matricula> Matricula { get; set; }

        public DbSet<ProyectoIdentity.Models.Menu> Menu { get; set; }

        public DbSet<ProyectoIdentity.Models.Parametros> Parametros { get; set; }

        public DbSet<ProyectoIdentity.Models.Permiso> Permiso { get; set; }

        public DbSet<ProyectoIdentity.Models.PreguntaEvaluacion> PreguntaEvaluacion { get; set; }

        public DbSet<ProyectoIdentity.Models.Requisito> Requisito { get; set; }

        public DbSet<ProyectoIdentity.Models.RespuestaEvaluacion> RespuestaEvaluacion { get; set; }

        public DbSet<ProyectoIdentity.Models.Semana> Semana { get; set; }

        public DbSet<ProyectoIdentity.Models.Tipo> Tipo { get; set; }

        public DbSet<ProyectoIdentity.Models.TipoUsuario> TipoUsuario { get; set; }

        public DbSet<ProyectoIdentity.Models.Usuario> Usuario { get; set; }

        public DbSet<ProyectoIdentity.Models.UsuarioCarrera> UsuarioCarrera { get; set; }
    }
}
