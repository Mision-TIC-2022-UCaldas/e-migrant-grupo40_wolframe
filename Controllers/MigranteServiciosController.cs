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
    public class MigranteServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MigranteServiciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MigranteServicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MigranteServicio.Include(m => m.Migrantes).Include(m => m.Servicios);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MigranteServicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteServicio = await _context.MigranteServicio
                .Include(m => m.Migrantes)
                .Include(m => m.Servicios)
                .FirstOrDefaultAsync(m => m.IdMigranteServicio == id);
            if (migranteServicio == null)
            {
                return NotFound();
            }

            return View(migranteServicio);
        }

        // GET: MigranteServicios/Create
        public IActionResult Create()
        {
            ViewData["IdMigrantes"] = new SelectList(_context.migrantes, "Id", "Apellidos");
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "Estado");
            return View();
        }

        // POST: MigranteServicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMigranteServicio,Detalle,Fecha,IdServicioEntidad,EstadoServicios,IdMigrantes,TipoDeUsuario")] MigranteServicio migranteServicio)
        {
            if (ModelState.IsValid)
            {
                //igranteNecesidad sp = (
                //                    from su in _context.SuplirNecesidad
                //                    join nm in _context.MigranteNecesidad on su.IdMigranteNecesidad equals nm.IdMigranteNecesidad
                //                    //where nm.IdMigranteNecesidad == suplirNecesidad.IdMigranteNecesidad
                //                    select new MigranteNecesidad()
                //                    {
                //                        IdMigrante = nm.IdMigrante,
                //                        Necesidad = nm.Necesidad,
                //                    }).FirstOrDefault();

                //MigranteServicio migranteServicio = new MigranteServicio
                //{
                //    Fecha = suplirNecesidad.Fecha,
                //    Detalle = suplirNecesidad.Detalle,
                //    IdServicioEntidad = suplirNecesidad.IdServicioEntidad,
                //    EstadoServicios = suplirNecesidad.EstadoServicios,
                //    IdMigrantes = sp.IdMigrante
                //};

                _context.Add(migranteServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMigrantes"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteServicio.IdMigrantes);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "Estado", migranteServicio.IdServicioEntidad);
            return View(migranteServicio);
        }

        // GET: MigranteServicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteServicio = await _context.MigranteServicio.FindAsync(id);
            if (migranteServicio == null)
            {
                return NotFound();
            }
            ViewData["IdMigrantes"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteServicio.IdMigrantes);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "Estado", migranteServicio.IdServicioEntidad);
            return View(migranteServicio);
        }

        // POST: MigranteServicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMigranteServicio,Detalle,Fecha,IdServicioEntidad,EstadoServicios,IdMigrantes,TipoDeUsuario")] MigranteServicio migranteServicio)
        {
            if (id != migranteServicio.IdMigranteServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(migranteServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MigranteServicioExists(migranteServicio.IdMigranteServicio))
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
            ViewData["IdMigrantes"] = new SelectList(_context.migrantes, "Id", "Apellidos", migranteServicio.IdMigrantes);
            ViewData["IdServicioEntidad"] = new SelectList(_context.servicios, "IdServicioEntidad", "Estado", migranteServicio.IdServicioEntidad);
            return View(migranteServicio);
        }

        // GET: MigranteServicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migranteServicio = await _context.MigranteServicio
                .Include(m => m.Migrantes)
                .Include(m => m.Servicios)
                .FirstOrDefaultAsync(m => m.IdMigranteServicio == id);
            if (migranteServicio == null)
            {
                return NotFound();
            }

            return View(migranteServicio);
        }

        // POST: MigranteServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var migranteServicio = await _context.MigranteServicio.FindAsync(id);
            _context.MigranteServicio.Remove(migranteServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MigranteServicioExists(int id)
        {
            return _context.MigranteServicio.Any(e => e.IdMigranteServicio == id);
        }
    }
}
