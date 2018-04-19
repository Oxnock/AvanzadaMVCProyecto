using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CampusVirtual.Model
{
    public class CampusVirtualInitializer
    {
        public static void Seed(CampusContext context, UserManager<Usuario> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            if (!context.Cursos.Any())
            {
                context.AddRange
                (
                    new Curso() { Nombre = "Introducción a la Informática", Codigo = "INF-I" },
                    new Curso() { Nombre = "Inglés I", Codigo = "ING-I" },
                    new Curso() { Nombre = "Programación I", Codigo = "PRG-I" },
                    new Curso() { Nombre = "Cálculo I", Codigo = "CLC-I" },
                    new Curso() { Nombre = "Bases de Datos I", Codigo = "BDT-I" },
                    new Curso() { Nombre = "Biología", Codigo = "BIO-I" },
                    new Curso() { Nombre = "Física", Codigo = "FIS-I" },
                    new Curso() { Nombre = "Psicología", Codigo = "PSI-I" }
                );
                context.SaveChanges();
            }

            if (!context.Carreras.Any())
            {
                context.AddRange
                (
                    new Carreras() { Nombre = "Ingenieria en sistemas", Codigo = "SIST", Descripcion = "Ingenieria" },
                    new Carreras() { Nombre = "Administracion de empresas", Codigo = "ADMI", Descripcion = "Ciencias economicas" },
                    new Carreras() { Nombre = "Ingenieria industrial", Codigo = "INDU", Descripcion = "Ingenieria" },
                    new Carreras() { Nombre = "Publicidad", Codigo = "PUBL", Descripcion = "Ciencias economicas" },
                    new Carreras() { Nombre = "Contaduria", Codigo = "CONT", Descripcion = "Ciencias economicas" },
                    new Carreras() { Nombre = "Medicina", Codigo = "MEDI", Descripcion = "Ciencias de la salud" }

                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                _roleManager.CreateAsync(new IdentityRole("Administrador"));//Crear Tipo de Usuario
                Thread.Sleep(1000);
                _roleManager.CreateAsync(new IdentityRole("Profesor"));//Crear Tipo de Usuario
                Thread.Sleep(1000);
                _roleManager.CreateAsync(new IdentityRole("Estudiante"));//Crear Tipo de Usuario

                var user1 = new Usuario() { UserName = "Admin" };//Crear usuario con Nombre
                var user2 = new Usuario() { UserName = "Andre" };//Crear usuario con Nombre              
                var user3 = new Usuario() { UserName = "Alfredo" };//Crear usuario con Nombre

                var result1 = _userManager.CreateAsync(user1, "Admin4!");//Asignar clave
                Thread.Sleep(1000);
                var result2 = _userManager.CreateAsync(user2, "Admin4!");//Asignar clave
                Thread.Sleep(1000);
                var result3 = _userManager.CreateAsync(user3, "Admin4!");//Asignar clave
                Thread.Sleep(1000);

                _userManager.AddToRoleAsync(user1, "Administrador");//Asignar tipo de usuario
                Thread.Sleep(1000);
                _userManager.AddToRoleAsync(user2, "Profesor");//Asignar tipo de usuario 
                Thread.Sleep(1000);
                _userManager.AddToRoleAsync(user3, "Estudiante"); //Asignar tipo de usuario 
                Thread.Sleep(1000);

            }
            if (!context.UsuarioCurso.Any())
            {
                context.UsuarioCurso.Add(new UsuarioCurso() { Usuario = context.Usuarios.SingleOrDefault(c => c.UserName == "Alfredo"), Curso = context.Cursos.SingleOrDefault(c => c.Nombre == "Psicología") });// Asignar curso a Usuario
                   
                context.SaveChanges();
            }
        }
    }
}