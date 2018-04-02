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
    public class BecasController : Controller
    {
        private readonly ProyectoContext _context;

        public BecasController(ProyectoContext context)
        {
            _context = context;
        }

        // GET: Becas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Beca.ToListAsync());
        }

        // GET: Becas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beca = await _context.Beca
                .SingleOrDefaultAsync(m => m.BecaId == id);
            if (beca == null)
            {
                return NotFound();
            }

            return View(beca);
        }

        // GET: Becas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Becas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BecaId,Nombre,Porcentaje")] Beca beca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beca);
        }

        // GET: Becas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beca = await _context.Beca.SingleOrDefaultAsync(m => m.BecaId == id);
            if (beca == null)
            {
                return NotFound();
            }
            return View(beca);
        }

        // POST: Becas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BecaId,Nombre,Porcentaje")] Beca beca)
        {
            if (id != beca.BecaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BecaExists(beca.BecaId))
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
            return View(beca);
        }

        // GET: Becas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beca = await _context.Beca
                .SingleOrDefaultAsync(m => m.BecaId == id);
            if (beca == null)
            {
                return NotFound();
            }

            return View(beca);
        }

        // POST: Becas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beca = await _context.Beca.SingleOrDefaultAsync(m => m.BecaId == id);
            _context.Beca.Remove(beca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BecaExists(int id)
        {
            return _context.Beca.Any(e => e.BecaId == id);
        }
    }
}
