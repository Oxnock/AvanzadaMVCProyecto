using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.GrupoViewModels
{
    public class IndexViewModel
    {
		[Display(Name = "Lista de Grupos")]
		public List<Grupos> Grupo { get; set; }
	}
}
