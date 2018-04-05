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
    public class AsistenciaProfesorsController : Controller
    {
        private readonly ProyectoIdentityContext _context;

        public AsistenciaProfesorsController(ProyectoIdentityContext context)
        {
            _context = context;
        }

        // GET: AsistenciaProfesors
        public async Task<IActionResult> Index()
        {
            return View(await _context.AsistenciaProfesor.ToListAsync());
        }

        // GET: AsistenciaProfesors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistenciaProfesor = await _context.AsistenciaProfesor
                .SingleOrDefaultAsync(m => m.AsistenciaProfesorId == id);
            if (asistenciaProfesor == null)
            {
                return NotFound();
            }

            return View(asistenciaProfesor);
        }

        // GET: AsistenciaProfesors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AsistenciaProfesors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AsistenciaProfesorId,Semana,Entrada,Salida")] AsistenciaProfesor asistenciaProfesor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asistenciaProfesor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(asistenciaProfesor);
        }

        // GET: AsistenciaProfesors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistenciaProfesor = await _context.AsistenciaProfesor.SingleOrDefaultAsync(m => m.AsistenciaProfesorId == id);
            if (asistenciaProfesor == null)
            {
                return NotFound();
            }
            return View(asistenciaProfesor);
        }

        // POST: AsistenciaProfesors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AsistenciaProfesorId,Semana,Entrada,Salida")] AsistenciaProfesor asistenciaProfesor)
        {
            if (id != asistenciaProfesor.AsistenciaProfesorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asistenciaProfesor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsistenciaProfesorExists(asistenciaProfesor.AsistenciaProfesorId))
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
            return View(asistenciaProfesor);
        }

        // GET: AsistenciaProfesors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistenciaProfesor = await _context.AsistenciaProfesor
                .SingleOrDefaultAsync(m => m.AsistenciaProfesorId == id);
            if (asistenciaProfesor == null)
            {
                return NotFound();
            }

            return View(asistenciaProfesor);
        }

        // POST: AsistenciaProfesors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asistenciaProfesor = await _context.AsistenciaProfesor.SingleOrDefaultAsync(m => m.AsistenciaProfesorId == id);
            _context.AsistenciaProfesor.Remove(asistenciaProfesor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsistenciaProfesorExists(int id)
        {
            return _context.AsistenciaProfesor.Any(e => e.AsistenciaProfesorId == id);
        }
    }
}
