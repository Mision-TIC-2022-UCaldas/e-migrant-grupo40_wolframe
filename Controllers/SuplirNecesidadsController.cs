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
    public class SuplirNecesidadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuplirNecesidadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuplirNecesidads
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SuplirNecesidad.Include(s => s.Migrantes).Include(s => s.Servicios);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SuplirNecesidads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplirNecesidad = await _context.SuplirNecesidad
                .Include(s => s.Migrantes)
                .Include(s => s.Servicios)
                .FirstOrDefaultAsync(m => m.IdMigranteServicio == id);
            if (suplirNecesidad == null)
            {
                return NotFound();
            }

            return View(suplirNecesidad);
        }

        // GET: SuplirNecesidads/Create
        public IActionResult Create()
        {
            ViewData["IdMigranteNecesidad"] = new SelectList(_context.MigranteNecesidad, "IdMigranteNecesidad", "IdMigrante");
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "NombreServicio");
            return View();
        }

        // POST: SuplirNecesidads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMigranteServicio,Detalle,Fecha,IdServicioEntidad,EstadoServicios,IdMigranteNecesidad")] SuplirNecesidad suplirNecesidad)
        {
            MigranteServicio migranteServicio = ;
            
            if (ModelState.IsValid)
            {
                _context.Add(suplirNecesidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
       
                

            }
            ViewData["IdMigranteNecesidad"] = new SelectList(_context.MigranteNecesidad, "IdMigranteNecesidad", "IdMigrante", suplirNecesidad.IdMigranteNecesidad);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "NombreServicio", suplirNecesidad.IdServicioEntidad);
            return View(suplirNecesidad);
        }

        // GET: SuplirNecesidads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplirNecesidad = await _context.SuplirNecesidad.FindAsync(id);
            if (suplirNecesidad == null)
            {
                return NotFound();
            }
            ViewData["IdMigranteNecesidad"] = new SelectList(_context.MigranteNecesidad, "IdMigranteNecesidad", "IdMigrante", suplirNecesidad.IdMigranteNecesidad);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "NombreServicio", suplirNecesidad.IdServicioEntidad);
            return View(suplirNecesidad);
        }

        // POST: SuplirNecesidads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMigranteServicio,Detalle,Fecha,IdServicioEntidad,EstadoServicios,IdMigranteNecesidad")] SuplirNecesidad suplirNecesidad)
        {
            if (id != suplirNecesidad.IdMigranteServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplirNecesidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplirNecesidadExists(suplirNecesidad.IdMigranteServicio))
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
            ViewData["IdMigranteNecesidad"] = new SelectList(_context.MigranteNecesidad, "IdMigranteNecesidad", "IdMigrante", suplirNecesidad.IdMigranteNecesidad);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "NombreServicio", suplirNecesidad.IdServicioEntidad);
            return View(suplirNecesidad);
        }

        // GET: SuplirNecesidads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplirNecesidad = await _context.SuplirNecesidad
                .Include(s => s.Migrantes)
                .Include(s => s.Servicios)
                .FirstOrDefaultAsync(m => m.IdMigranteServicio == id);
            if (suplirNecesidad == null)
            {
                return NotFound();
            }

            return View(suplirNecesidad);
        }

        // POST: SuplirNecesidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplirNecesidad = await _context.SuplirNecesidad.FindAsync(id);
            _context.SuplirNecesidad.Remove(suplirNecesidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplirNecesidadExists(int id)
        {
            return _context.SuplirNecesidad.Any(e => e.IdMigranteServicio == id);
        }
    }
}
