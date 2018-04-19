﻿using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.CarrerasViewModels
{
    public class IndexViewModel
    {
		[Display(Name = "Lista de Carreras")]
		public List<Carreras> Carrera { get; set; }
	}
}
