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
    public class UsuarioCarrerasController : Controller
    {
        private readonly ProyectoIdentityContext _context;

        public UsuarioCarrerasController(ProyectoIdentityContext context)
        {
            _context = context;
        }

        // GET: UsuarioCarreras
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioCarrera.ToListAsync());
        }

        // GET: UsuarioCarreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioCarrera = await _context.UsuarioCarrera
                .SingleOrDefaultAsync(m => m.UsuarioCarreraId == id);
            if (usuarioCarrera == null)
            {
                return NotFound();
            }

            return View(usuarioCarrera);
        }

        // GET: UsuarioCarreras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioCarreras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioCarreraId,FechaInicial,FechaFinal")] UsuarioCarrera usuarioCarrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioCarrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioCarrera);
        }

        // GET: UsuarioCarreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioCarrera = await _context.UsuarioCarrera.SingleOrDefaultAsync(m => m.UsuarioCarreraId == id);
            if (usuarioCarrera == null)
            {
                return NotFound();
            }
            return View(usuarioCarrera);
        }

        // POST: UsuarioCarreras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioCarreraId,FechaInicial,FechaFinal")] UsuarioCarrera usuarioCarrera)
        {
            if (id != usuarioCarrera.UsuarioCarreraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioCarrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioCarreraExists(usuarioCarrera.UsuarioCarreraId))
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
            return View(usuarioCarrera);
        }

        // GET: UsuarioCarreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioCarrera = await _context.UsuarioCarrera
                .SingleOrDefaultAsync(m => m.UsuarioCarreraId == id);
            if (usuarioCarrera == null)
            {
                return NotFound();
            }

            return View(usuarioCarrera);
        }

        // POST: UsuarioCarreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioCarrera = await _context.UsuarioCarrera.SingleOrDefaultAsync(m => m.UsuarioCarreraId == id);
            _context.UsuarioCarrera.Remove(usuarioCarrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioCarreraExists(int id)
        {
            return _context.UsuarioCarrera.Any(e => e.UsuarioCarreraId == id);
        }
    }
}
