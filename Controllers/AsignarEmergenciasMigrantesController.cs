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
    public class AsignarEmergenciasMigrantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AsignarEmergenciasMigrantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AsignarEmergenciasMigrantes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AsignarEmergenciasMigrante.Include(a => a.EmergenciasMigrantes).Include(a => a.EntidadServicioEmergencia);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AsignarEmergenciasMigrantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignarEmergenciasMigrante = await _context.AsignarEmergenciasMigrante
                .Include(a => a.EmergenciasMigrantes)
                .Include(a => a.EntidadServicioEmergencia)
                .FirstOrDefaultAsync(m => m.IdAsignarEmergenciasMigrante == id);
            if (asignarEmergenciasMigrante == null)
            {
                return NotFound();
            }

            return View(asignarEmergenciasMigrante);
        }

        // GET: AsignarEmergenciasMigrantes/Create
        public IActionResult Create()
        {
            ViewData["IdEmergenciasMigrantes"] = new SelectList(_context.EmergenciasMigrantes, "IdEmergenciasMigrantes", "IdEmergenciasMigrantes");
            ViewData["IdEntidadEmergencia"] = new SelectList(_context.EntidadServicioEmergencia, "IdEntidadServicioEmergencia", "NombreEntidad");
            return View();
        }

        // POST: AsignarEmergenciasMigrantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAsignarEmergenciasMigrante,IdEntidadEmergencia,IdEmergenciasMigrantes,Detalle,Estado")] AsignarEmergenciasMigrante asignarEmergenciasMigrante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asignarEmergenciasMigrante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmergenciasMigrantes"] = new SelectList(_context.EmergenciasMigrantes, "IdEmergenciasMigrantes", "IdEmergenciasMigrantes", asignarEmergenciasMigrante.IdEmergenciasMigrantes);
            ViewData["IdEntidadEmergencia"] = new SelectList(_context.EntidadServicioEmergencia, "IdEntidadServicioEmergencia", "NombreEntidad", asignarEmergenciasMigrante.IdEntidadEmergencia);
            return View(asignarEmergenciasMigrante);
        }

        // GET: AsignarEmergenciasMigrantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignarEmergenciasMigrante = await _context.AsignarEmergenciasMigrante.FindAsync(id);
            if (asignarEmergenciasMigrante == null)
            {
                return NotFound();
            }
            ViewData["IdEmergenciasMigrantes"] = new SelectList(_context.EmergenciasMigrantes, "IdEmergenciasMigrantes", "IdEmergenciasMigrantes", asignarEmergenciasMigrante.IdEmergenciasMigrantes);
            ViewData["IdEntidadEmergencia"] = new SelectList(_context.EntidadServicioEmergencia, "IdEntidadServicioEmergencia", "NombreEntidad", asignarEmergenciasMigrante.IdEntidadEmergencia);
            return View(asignarEmergenciasMigrante);
        }

        // POST: AsignarEmergenciasMigrantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAsignarEmergenciasMigrante,IdEntidadEmergencia,IdEmergenciasMigrantes,Detalle,Estado")] AsignarEmergenciasMigrante asignarEmergenciasMigrante)
        {
            if (id != asignarEmergenciasMigrante.IdAsignarEmergenciasMigrante)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asignarEmergenciasMigrante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsignarEmergenciasMigranteExists(asignarEmergenciasMigrante.IdAsignarEmergenciasMigrante))
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
            ViewData["IdEmergenciasMigrantes"] = new SelectList(_context.EmergenciasMigrantes, "IdEmergenciasMigrantes", "IdEmergenciasMigrantes", asignarEmergenciasMigrante.IdEmergenciasMigrantes);
            ViewData["IdEntidadEmergencia"] = new SelectList(_context.EntidadServicioEmergencia, "IdEntidadServicioEmergencia", "NombreEntidad", asignarEmergenciasMigrante.IdEntidadEmergencia);
            return View(asignarEmergenciasMigrante);
        }

        // GET: AsignarEmergenciasMigrantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignarEmergenciasMigrante = await _context.AsignarEmergenciasMigrante
                .Include(a => a.EmergenciasMigrantes)
                .Include(a => a.EntidadServicioEmergencia)
                .FirstOrDefaultAsync(m => m.IdAsignarEmergenciasMigrante == id);
            if (asignarEmergenciasMigrante == null)
            {
                return NotFound();
            }

            return View(asignarEmergenciasMigrante);
        }

        // POST: AsignarEmergenciasMigrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asignarEmergenciasMigrante = await _context.AsignarEmergenciasMigrante.FindAsync(id);
            _context.AsignarEmergenciasMigrante.Remove(asignarEmergenciasMigrante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsignarEmergenciasMigranteExists(int id)
        {
            return _context.AsignarEmergenciasMigrante.Any(e => e.IdAsignarEmergenciasMigrante == id);
        }
    }
}
