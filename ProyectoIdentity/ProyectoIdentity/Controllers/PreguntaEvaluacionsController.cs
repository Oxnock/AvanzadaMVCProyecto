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
    public class PreguntaEvaluacionsController : Controller
    {
        private readonly ProyectoIdentityContext _context;

        public PreguntaEvaluacionsController(ProyectoIdentityContext context)
        {
            _context = context;
        }

        // GET: PreguntaEvaluacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.PreguntaEvaluacion.ToListAsync());
        }

        // GET: PreguntaEvaluacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preguntaEvaluacion = await _context.PreguntaEvaluacion
                .SingleOrDefaultAsync(m => m.PreguntaEvaluacionId == id);
            if (preguntaEvaluacion == null)
            {
                return NotFound();
            }

            return View(preguntaEvaluacion);
        }

        // GET: PreguntaEvaluacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PreguntaEvaluacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PreguntaEvaluacionId,Pregunta")] PreguntaEvaluacion preguntaEvaluacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preguntaEvaluacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preguntaEvaluacion);
        }

        // GET: PreguntaEvaluacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preguntaEvaluacion = await _context.PreguntaEvaluacion.SingleOrDefaultAsync(m => m.PreguntaEvaluacionId == id);
            if (preguntaEvaluacion == null)
            {
                return NotFound();
            }
            return View(preguntaEvaluacion);
        }

        // POST: PreguntaEvaluacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PreguntaEvaluacionId,Pregunta")] PreguntaEvaluacion preguntaEvaluacion)
        {
            if (id != preguntaEvaluacion.PreguntaEvaluacionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preguntaEvaluacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreguntaEvaluacionExists(preguntaEvaluacion.PreguntaEvaluacionId))
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
            return View(preguntaEvaluacion);
        }

        // GET: PreguntaEvaluacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preguntaEvaluacion = await _context.PreguntaEvaluacion
                .SingleOrDefaultAsync(m => m.PreguntaEvaluacionId == id);
            if (preguntaEvaluacion == null)
            {
                return NotFound();
            }

            return View(preguntaEvaluacion);
        }

        // POST: PreguntaEvaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preguntaEvaluacion = await _context.PreguntaEvaluacion.SingleOrDefaultAsync(m => m.PreguntaEvaluacionId == id);
            _context.PreguntaEvaluacion.Remove(preguntaEvaluacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreguntaEvaluacionExists(int id)
        {
            return _context.PreguntaEvaluacion.Any(e => e.PreguntaEvaluacionId == id);
        }
    }
}
