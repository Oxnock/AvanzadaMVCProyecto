using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.Model.Entities
{
    interface ICursosRepository
    {
		bool Crear(Curso curso);
		bool Editar(Curso curso);
		bool Eliminar(int id);
		bool Existe(int id);
		Curso ObtenerCursoPorId(int id);
		List<Curso> ObtenerCursos();

	}
}
