﻿using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CursoViewModels
{
    public class CrearViewModel
    {
        [Required(ErrorMessage = "El nombre de curso es requerido")]
        [Display(Name = "Nombre del curso")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El codigo de curso es requerido")]
        public string Codigo { get; set; } //add
		public string CarreraId { get; set; }
		public ICollection<Carreras> Carreras { get; set; }
	}
}
