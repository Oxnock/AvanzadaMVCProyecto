using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using CampusVirtual.ViewModels.NotasViewModels;
namespace CampusVirtual.Controllers
{
    public class NotasController : Controller
    {
        private readonly CampusContext _context;

        public NotasController(CampusContext context)
        {
            _context = context;
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
            var campusContext = _context.Notas.Include(n => n.Usuario);
            return View(await campusContext.ToListAsync());
        }


	}
}
