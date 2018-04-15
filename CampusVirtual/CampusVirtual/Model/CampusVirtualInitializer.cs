using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
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
					new Curso() { Nombre = "Introducción a la Informática" },
					new Curso() { Nombre = "Inglés I" },
					new Curso() { Nombre = "Programación I" },
					new Curso() { Nombre = "Cálculo I" },
					new Curso() { Nombre = "Bases de Datos I" },
					new Curso() { Nombre = "Biología" },
					new Curso() { Nombre = "Física" },
					new Curso() { Nombre = "Psicología" }
				);
				context.SaveChanges();

				_roleManager.CreateAsync(new IdentityRole("Administrador"));//Crear Tipo de Usuario
				var user1 = new Usuario() { UserName = "Admin" };//Crear usuario con Nombre
				var result1 = _userManager.CreateAsync(user1, "Admin4!");//Asignar clave
				_userManager.AddToRoleAsync(user1, "Administrador");//Asignar tipo de usuario

				_roleManager.CreateAsync(new IdentityRole("Profesor"));//Crear Tipo de Usuario
				var user2 = new Usuario() { UserName = "Andre" };//Crear usuario con Nombre
				var result2 = _userManager.CreateAsync(user2, "Admin4!");//Asignar clave
				_userManager.AddToRoleAsync(user2, "Profesor");//Asignar tipo de usuario 


				_roleManager.CreateAsync(new IdentityRole("Estudiante"));//Crear Tipo de Usuario
				var user3 = new Usuario() { UserName = "Alfredo" };//Crear usuario con Nombre
				var result3 = _userManager.CreateAsync(user3, "Admin4!");//Asignar clave
				_userManager.AddToRoleAsync(user3, "Estudiante"); //Asignar tipo de usuario 
				context.UsuarioCurso.Add(new UsuarioCurso() { Usuario = user3, Curso = context.Cursos.SingleOrDefault(c => c.Nombre == "Psicología") });// Asignar curso a Usuario

				context.SaveChanges();
			}

			context.SaveChanges();
		}
	}
}
