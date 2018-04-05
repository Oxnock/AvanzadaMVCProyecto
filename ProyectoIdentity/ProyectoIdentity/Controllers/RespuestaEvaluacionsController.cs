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
    public class RespuestaEvaluacionsController : Controller
    {
        private readonly ProyectoIdentityContext _context;

        public RespuestaEvaluacionsController(ProyectoIdentityContext context)
        {
            _context = context;
        }

        // GET: RespuestaEvaluacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.RespuestaEvaluacion.ToListAsync());
        }

        // GET: RespuestaEvaluacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuestaEvaluacion = await _context.RespuestaEvaluacion
                .SingleOrDefaultAsync(m => m.RespuestaEvaluacionId == id);
            if (respuestaEvaluacion == null)
            {
                return NotFound();
            }

            return View(respuestaEvaluacion);
        }

        // GET: RespuestaEvaluacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RespuestaEvaluacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RespuestaEvaluacionId,Respuesta")] RespuestaEvaluacion respuestaEvaluacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(respuestaEvaluacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuestaEvaluacion);
        }

        // GET: RespuestaEvaluacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuestaEvaluacion = await _context.RespuestaEvaluacion.SingleOrDefaultAsync(m => m.RespuestaEvaluacionId == id);
            if (respuestaEvaluacion == null)
            {
                return NotFound();
            }
            return View(respuestaEvaluacion);
        }

        // POST: RespuestaEvaluacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RespuestaEvaluacionId,Respuesta")] RespuestaEvaluacion respuestaEvaluacion)
        {
            if (id != respuestaEvaluacion.RespuestaEvaluacionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuestaEvaluacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RespuestaEvaluacionExists(respuestaEvaluacion.RespuestaEvaluacionId))
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
            return View(respuestaEvaluacion);
        }

        // GET: RespuestaEvaluacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuestaEvaluacion = await _context.RespuestaEvaluacion
                .SingleOrDefaultAsync(m => m.RespuestaEvaluacionId == id);
            if (respuestaEvaluacion == null)
            {
                return NotFound();
            }

            return View(respuestaEvaluacion);
        }

        // POST: RespuestaEvaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var respuestaEvaluacion = await _context.RespuestaEvaluacion.SingleOrDefaultAsync(m => m.RespuestaEvaluacionId == id);
            _context.RespuestaEvaluacion.Remove(respuestaEvaluacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RespuestaEvaluacionExists(int id)
        {
            return _context.RespuestaEvaluacion.Any(e => e.RespuestaEvaluacionId == id);
        }
    }
}
