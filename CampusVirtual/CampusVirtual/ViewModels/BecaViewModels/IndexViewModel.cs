using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.BecaViewModels
{
    public class IndexViewModel
    {
		[Display(Name = "Lista de Becas")]
		public List<Beca> Becas{ get; set; }
	}
}
