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
    public class EmergenciasMigrantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmergenciasMigrantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmergenciasMigrantes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EmergenciasMigrantes.Include(e => e.migrantes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EmergenciasMigrantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciasMigrantes = await _context.EmergenciasMigrantes
                .Include(e => e.migrantes)
                .FirstOrDefaultAsync(m => m.IdEmergenciasMigrantes == id);
            if (emergenciasMigrantes == null)
            {
                return NotFound();
            }

            return View(emergenciasMigrantes);
        }

        // GET: EmergenciasMigrantes/Create
        public IActionResult Create()
        {
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Documento");
            return View();
        }

        // POST: EmergenciasMigrantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmergenciasMigrantes,Fecha,IdMigrante,Estado,Tipoemergencia,Ciudad")] EmergenciasMigrantes emergenciasMigrantes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergenciasMigrantes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Documento", emergenciasMigrantes.IdMigrante);
            return View(emergenciasMigrantes);
        }

        // GET: EmergenciasMigrantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciasMigrantes = await _context.EmergenciasMigrantes.FindAsync(id);
            if (emergenciasMigrantes == null)
            {
                return NotFound();
            }
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Documento", emergenciasMigrantes.IdMigrante);
            return View(emergenciasMigrantes);
        }

        // POST: EmergenciasMigrantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmergenciasMigrantes,Fecha,IdMigrante,Estado,Tipoemergencia,Ciudad")] EmergenciasMigrantes emergenciasMigrantes)
        {
            if (id != emergenciasMigrantes.IdEmergenciasMigrantes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergenciasMigrantes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmergenciasMigrantesExists(emergenciasMigrantes.IdEmergenciasMigrantes))
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
            ViewData["IdMigrante"] = new SelectList(_context.migrantes, "Id", "Documento", emergenciasMigrantes.IdMigrante);
            return View(emergenciasMigrantes);
        }

        // GET: EmergenciasMigrantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciasMigrantes = await _context.EmergenciasMigrantes
                .Include(e => e.migrantes)
                .FirstOrDefaultAsync(m => m.IdEmergenciasMigrantes == id);
            if (emergenciasMigrantes == null)
            {
                return NotFound();
            }

            return View(emergenciasMigrantes);
        }

        // POST: EmergenciasMigrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergenciasMigrantes = await _context.EmergenciasMigrantes.FindAsync(id);
            _context.EmergenciasMigrantes.Remove(emergenciasMigrantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmergenciasMigrantesExists(int id)
        {
            return _context.EmergenciasMigrantes.Any(e => e.IdEmergenciasMigrantes == id);
        }
        public async Task<IActionResult> Index2(string SearchString, string Ciudad)
        {
            var pacientes = GetAllnovedades(); // Obtiene todos los saludos
            if (pacientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(SearchString))
                {
                    pacientes = pacientes.Where(s => s.Tipoemergencia.Contains(SearchString) && s.Ciudad.Contains(Ciudad));
                }

            }
            return View(pacientes);

        }
        public IEnumerable<EmergenciasMigrantes> GetAllnovedades()
        {
            return _context.EmergenciasMigrantes;
        }
        public async Task<IActionResult> Index3(/*string SearchString, string Ciudad,*/string TipoEstado)
        {
            var pacientes = GetAllnovedades(); // Obtiene todos los saludos
            if (pacientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(TipoEstado))
                {
                    pacientes = pacientes.Where(s => /*s.Tipoemergencia.Contains(SearchString) && s.Ciudad.Contains(Ciudad)&&*/ s.Estado.Contains(TipoEstado));
                }

            }
            return View(pacientes);

        }
    }
}
