using CampusVirtual.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusVirtual.ViewModels.BecaViewModels
{
    public class EditarViewModel
    {
		public string Nombre { get; set; }
		public int Porcentaje { get; set; }
		public Beca Becas { get; set; }
		public int Id { get; set; }
	}
}
