using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Usuario
    {
		public int UsuarioId { get; set; }

		[Required(ErrorMessage = "Campo Nombre Requerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "El nombre es demasiado corto")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "Campo Apellido Requerido")]
		[StringLength(25, MinimumLength = 4, ErrorMessage = "El apellido es demasiado corto")]
		public string Apellido { get; set; }

		[Required(ErrorMessage = "Campo Correo Requerido")]
		[StringLength(50, MinimumLength = 8, ErrorMessage = "El correo es demasiado corto")]
		public string Correo { get; set; }

		[Required(ErrorMessage = "Campo contraseña Requerido")]
		[StringLength(25, MinimumLength = 8, ErrorMessage = "La contraseña es demasiado corto")]
		public string Contrasena { get; set; }

		[Required(ErrorMessage = "Campo ciudad Requerido")]
		[StringLength(25, MinimumLength = 4, ErrorMessage = "La contraseña es demasiado corto")]
		public string Ciudad { get; set; }

		[Required(ErrorMessage = "Campo Pais Requerido")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "El pais no tiene formato correcto")]
		public string Pais { get; set; }

		[Required(ErrorMessage = "Campo Cedula Requerido")]
		[StringLength(9, MinimumLength = 7, ErrorMessage = "La Cedula es demasiado corto")]
		public string Cedula { get; set; }

		[Required(ErrorMessage = "Campo Estado Requerido")]
		public Boolean Estado { get; set; }

		public IEnumerable<TipoUsuario> TipoUsuarios { get; set; }
		public IEnumerable<DuracionBeca> DuracionBecas { get; set; }
		public IEnumerable<UsuarioCarrera> UsuariosCarreras { get; set; }
		public IEnumerable<Matricula> Matriculas { get; set; }
	}
}
