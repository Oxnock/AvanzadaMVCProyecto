using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
	public class CursoMockRepository : ICursosRepository
	{
		private List<Curso> ListaDeCursos;
		public CursoMockRepository()
		{
			InicializarCursos();
		}

		private void InicializarCursos()
		{
			ListaDeCursos = new List<Curso>();
			ListaDeCursos.Add(new Curso() { CursoId = 1, Nombre = "Curso1" });
			ListaDeCursos.Add(new Curso() { CursoId = 2, Nombre = "Curso2" });

		}




		public bool Crear(Curso curso)
		{
			try
			{
				ListaDeCursos.Add(curso);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Editar(Curso curso)
		{
			try
			{
				var CursoOriginal = ListaDeCursos.SingleOrDefault(a => a.CursoId == curso.CursoId);
				CursoOriginal.Nombre = curso.Nombre;
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Eliminar(int id)
		{
			try
			{
				ListaDeCursos.Remove(ListaDeCursos.Where(a => a.CursoId == id).Single());
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Existe(int id)
		{
			return ListaDeCursos.Any(a => a.CursoId== id);
		}

		public Curso ObtenerCursoPorId(int id)
		{
			return ListaDeCursos.Where(a => a.CursoId == id).SingleOrDefault();
		}

		public List<Curso> ObtenerCursos()
		{
			return ListaDeCursos;
		}
	}
}
