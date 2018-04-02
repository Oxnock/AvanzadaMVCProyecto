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
    public class SemanasController : Controller
    {
        private readonly ProyectoContext _context;

        public SemanasController(ProyectoContext context)
        {
            _context = context;
        }

        // GET: Semanas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Semana.ToListAsync());
        }

        // GET: Semanas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semana = await _context.Semana
                .SingleOrDefaultAsync(m => m.SemanaId == id);
            if (semana == null)
            {
                return NotFound();
            }

            return View(semana);
        }

        // GET: Semanas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Semanas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SemanaId,Contenido,Fecha")] Semana semana)
        {
            if (ModelState.IsValid)
            {
                _context.Add(semana);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(semana);
        }

        // GET: Semanas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semana = await _context.Semana.SingleOrDefaultAsync(m => m.SemanaId == id);
            if (semana == null)
            {
                return NotFound();
            }
            return View(semana);
        }

        // POST: Semanas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SemanaId,Contenido,Fecha")] Semana semana)
        {
            if (id != semana.SemanaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(semana);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SemanaExists(semana.SemanaId))
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
            return View(semana);
        }

        // GET: Semanas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semana = await _context.Semana
                .SingleOrDefaultAsync(m => m.SemanaId == id);
            if (semana == null)
            {
                return NotFound();
            }

            return View(semana);
        }

        // POST: Semanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var semana = await _context.Semana.SingleOrDefaultAsync(m => m.SemanaId == id);
            _context.Semana.Remove(semana);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SemanaExists(int id)
        {
            return _context.Semana.Any(e => e.SemanaId == id);
        }
    }
}
