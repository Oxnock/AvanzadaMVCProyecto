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
    public class RequisitoesController : Controller
    {
        private readonly ProyectoContext _context;

        public RequisitoesController(ProyectoContext context)
        {
            _context = context;
        }

        // GET: Requisitoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Requisito.ToListAsync());
        }

        // GET: Requisitoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisito = await _context.Requisito
                .SingleOrDefaultAsync(m => m.RequisitoId == id);
            if (requisito == null)
            {
                return NotFound();
            }

            return View(requisito);
        }

        // GET: Requisitoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requisitoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequisitoId,MateriaRequisito")] Requisito requisito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisito);
        }

        // GET: Requisitoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisito = await _context.Requisito.SingleOrDefaultAsync(m => m.RequisitoId == id);
            if (requisito == null)
            {
                return NotFound();
            }
            return View(requisito);
        }

        // POST: Requisitoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequisitoId,MateriaRequisito")] Requisito requisito)
        {
            if (id != requisito.RequisitoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisitoExists(requisito.RequisitoId))
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
            return View(requisito);
        }

        // GET: Requisitoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisito = await _context.Requisito
                .SingleOrDefaultAsync(m => m.RequisitoId == id);
            if (requisito == null)
            {
                return NotFound();
            }

            return View(requisito);
        }

        // POST: Requisitoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requisito = await _context.Requisito.SingleOrDefaultAsync(m => m.RequisitoId == id);
            _context.Requisito.Remove(requisito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisitoExists(int id)
        {
            return _context.Requisito.Any(e => e.RequisitoId == id);
        }
    }
}
