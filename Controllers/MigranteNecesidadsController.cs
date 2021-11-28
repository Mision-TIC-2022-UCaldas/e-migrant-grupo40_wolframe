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
    public class MigranteNecesidadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MigranteNecesidadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MigranteNecesidads
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MigranteNecesidad.Include(m => m.Migrantes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MigranteNecesidads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteNecesidad = await _context.MigranteNecesidad
                .Include(m => m.Migrantes)
                .FirstOrDefaultAsync(m => m.IdMigranteNecesidad == id);
            if (migranteNecesidad == null)
            {
                return NotFound();
            }

            return View(migranteNecesidad);
        }

        // GET: MigranteNecesidads/Create
        public IActionResult Create()
        {
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Nombre");
            return View();
        }

        // POST: MigranteNecesidads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMigranteNecesidad,Necesidad,IdMigrante,Prioridad,Detalle")] MigranteNecesidad migranteNecesidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(migranteNecesidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteNecesidad.IdMigrante);
            return View(migranteNecesidad);
        }

        // GET: MigranteNecesidads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteNecesidad = await _context.MigranteNecesidad.FindAsync(id);
            if (migranteNecesidad == null)
            {
                return NotFound();
            }
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteNecesidad.IdMigrante);
            return View(migranteNecesidad);
        }

        // POST: MigranteNecesidads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMigranteNecesidad,Necesidad,IdMigrante,Prioridad,Detalle")] MigranteNecesidad migranteNecesidad)
        {
            if (id != migranteNecesidad.IdMigranteNecesidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(migranteNecesidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MigranteNecesidadExists(migranteNecesidad.IdMigranteNecesidad))
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
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteNecesidad.IdMigrante);
            return View(migranteNecesidad);
        }

        // GET: MigranteNecesidads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteNecesidad = await _context.MigranteNecesidad
                .Include(m => m.Migrantes)
                .FirstOrDefaultAsync(m => m.IdMigranteNecesidad == id);
            if (migranteNecesidad == null)
            {
                return NotFound();
            }

            return View(migranteNecesidad);
        }

        // POST: MigranteNecesidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var migranteNecesidad = await _context.MigranteNecesidad.FindAsync(id);
            _context.MigranteNecesidad.Remove(migranteNecesidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MigranteNecesidadExists(int id)
        {
            return _context.MigranteNecesidad.Any(e => e.IdMigranteNecesidad == id);
        }
    }
}
