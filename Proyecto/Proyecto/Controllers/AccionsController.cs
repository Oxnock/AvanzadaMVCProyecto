using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class AccionsController : Controller
    {
        private readonly ProyectoContext _context;

        public AccionsController(ProyectoContext context)
        {
            _context = context;
        }

        // GET: Accions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accion.ToListAsync());
        }

        // GET: Accions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accion = await _context.Accion
                .SingleOrDefaultAsync(m => m.AccionId == id);
            if (accion == null)
            {
                return NotFound();
            }

            return View(accion);
        }

        // GET: Accions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccionId,Nombre")] Accion accion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accion);
        }

        // GET: Accions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accion = await _context.Accion.SingleOrDefaultAsync(m => m.AccionId == id);
            if (accion == null)
            {
                return NotFound();
            }
            return View(accion);
        }

        // POST: Accions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccionId,Nombre")] Accion accion)
        {
            if (id != accion.AccionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccionExists(accion.AccionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(accion);
        }

        // GET: Accions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accion = await _context.Accion
                .SingleOrDefaultAsync(m => m.AccionId == id);
            if (accion == null)
            {
                return NotFound();
            }

            return View(accion);
        }

        // POST: Accions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accion = await _context.Accion.SingleOrDefaultAsync(m => m.AccionId == id);
            _context.Accion.Remove(accion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccionExists(int id)
        {
            return _context.Accion.Any(e => e.AccionId == id);
        }
    }
}
