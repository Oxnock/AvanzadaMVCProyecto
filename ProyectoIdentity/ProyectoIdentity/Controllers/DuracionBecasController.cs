using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoIdentity.Models;

namespace ProyectoIdentity.Controllers
{
    public class DuracionBecasController : Controller
    {
        private readonly ProyectoIdentityContext _context;

        public DuracionBecasController(ProyectoIdentityContext context)
        {
            _context = context;
        }

        // GET: DuracionBecas
        public async Task<IActionResult> Index()
        {
            return View(await _context.DuracionBeca.ToListAsync());
        }

        // GET: DuracionBecas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionBeca = await _context.DuracionBeca
                .SingleOrDefaultAsync(m => m.DuracionBecaId == id);
            if (duracionBeca == null)
            {
                return NotFound();
            }

            return View(duracionBeca);
        }

        // GET: DuracionBecas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DuracionBecas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DuracionBecaId,FechaInicial,FechaFinal")] DuracionBeca duracionBeca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duracionBeca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duracionBeca);
        }

        // GET: DuracionBecas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionBeca = await _context.DuracionBeca.SingleOrDefaultAsync(m => m.DuracionBecaId == id);
            if (duracionBeca == null)
            {
                return NotFound();
            }
            return View(duracionBeca);
        }

        // POST: DuracionBecas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DuracionBecaId,FechaInicial,FechaFinal")] DuracionBeca duracionBeca)
        {
            if (id != duracionBeca.DuracionBecaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duracionBeca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuracionBecaExists(duracionBeca.DuracionBecaId))
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
            return View(duracionBeca);
        }

        // GET: DuracionBecas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionBeca = await _context.DuracionBeca
                .SingleOrDefaultAsync(m => m.DuracionBecaId == id);
            if (duracionBeca == null)
            {
                return NotFound();
            }

            return View(duracionBeca);
        }

        // POST: DuracionBecas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var duracionBeca = await _context.DuracionBeca.SingleOrDefaultAsync(m => m.DuracionBecaId == id);
            _context.DuracionBeca.Remove(duracionBeca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuracionBecaExists(int id)
        {
            return _context.DuracionBeca.Any(e => e.DuracionBecaId == id);
        }
    }
}
