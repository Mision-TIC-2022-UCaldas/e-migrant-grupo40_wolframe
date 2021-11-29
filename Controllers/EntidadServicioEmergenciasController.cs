using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto.Data;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class EntidadServicioEmergenciasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntidadServicioEmergenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EntidadServicioEmergencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.EntidadServicioEmergencia.ToListAsync());
        }

        // GET: EntidadServicioEmergencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidadServicioEmergencia = await _context.EntidadServicioEmergencia
                .FirstOrDefaultAsync(m => m.IdEntidadServicioEmergencia == id);
            if (entidadServicioEmergencia == null)
            {
                return NotFound();
            }

            return View(entidadServicioEmergencia);
        }

        // GET: EntidadServicioEmergencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EntidadServicioEmergencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEntidadServicioEmergencia,NombreEntidad,Numero,Tipo,Ciudad")] EntidadServicioEmergencia entidadServicioEmergencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entidadServicioEmergencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entidadServicioEmergencia);
        }

        // GET: EntidadServicioEmergencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidadServicioEmergencia = await _context.EntidadServicioEmergencia.FindAsync(id);
            if (entidadServicioEmergencia == null)
            {
                return NotFound();
            }
            return View(entidadServicioEmergencia);
        }

        // POST: EntidadServicioEmergencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEntidadServicioEmergencia,NombreEntidad,Numero,Tipo,Ciudad")] EntidadServicioEmergencia entidadServicioEmergencia)
        {
            if (id != entidadServicioEmergencia.IdEntidadServicioEmergencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entidadServicioEmergencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntidadServicioEmergenciaExists(entidadServicioEmergencia.IdEntidadServicioEmergencia))
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
            return View(entidadServicioEmergencia);
        }

        // GET: EntidadServicioEmergencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidadServicioEmergencia = await _context.EntidadServicioEmergencia
                .FirstOrDefaultAsync(m => m.IdEntidadServicioEmergencia == id);
            if (entidadServicioEmergencia == null)
            {
                return NotFound();
            }

            return View(entidadServicioEmergencia);
        }

        // POST: EntidadServicioEmergencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entidadServicioEmergencia = await _context.EntidadServicioEmergencia.FindAsync(id);
            _context.EntidadServicioEmergencia.Remove(entidadServicioEmergencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntidadServicioEmergenciaExists(int id)
        {
            return _context.EntidadServicioEmergencia.Any(e => e.IdEntidadServicioEmergencia == id);
        }
    }
}
