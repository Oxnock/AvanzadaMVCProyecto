﻿using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.GrupoViewModels
{
    public class CrearViewModel
    {
		[Required]
		[Display(Name = "Numero de grupo")]
		public int NumeroGrupo { get; set; }
		[Required]
		[Display(Name = "Horario")]
		public string Horario { get; set; }
		public string CursoId { get; set; }
		public ICollection<Curso> Cursos { get; set; }
	}
}
