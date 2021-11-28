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
    public class serviciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public serviciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: servicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.servicios.Include(s => s.Entidad);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.servicios
                .Include(s => s.Entidad)
                .FirstOrDefaultAsync(m => m.IdServicioEntidad == id);
            if (servicios == null)
            {
                return NotFound();
            }

            return View(servicios);
        }

        // GET: servicios/Create
        public IActionResult Create()
        {
            ViewData["NitEntidad"] = new SelectList(_context.Entidad, "Nit", "Nit");
            return View();
        }

        // POST: servicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdServicioEntidad,NombreServicio,NumeroPersonas,FechaInico,FechaFinal,Estado,NitEntidad")] servicios servicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NitEntidad"] = new SelectList(_context.Entidad, "Nit", "Nit", servicios.NitEntidad);
            return View(servicios);
        }

        // GET: servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.servicios.FindAsync(id);
            if (servicios == null)
            {
                return NotFound();
            }
            ViewData["NitEntidad"] = new SelectList(_context.Entidad, "Nit", "Nit", servicios.NitEntidad);
            return View(servicios);
        }

        // POST: servicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdServicioEntidad,NombreServicio,NumeroPersonas,FechaInico,FechaFinal,Estado,NitEntidad")] servicios servicios)
        {
            if (id != servicios.IdServicioEntidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!serviciosExists(servicios.IdServicioEntidad))
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
            ViewData["NitEntidad"] = new SelectList(_context.Entidad, "Nit", "Nit", servicios.NitEntidad);
            return View(servicios);
        }

        // GET: servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicios = await _context.servicios
                .Include(s => s.Entidad)
                .FirstOrDefaultAsync(m => m.IdServicioEntidad == id);
            if (servicios == null)
            {
                return NotFound();
            }

            return View(servicios);
        }

        // POST: servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicios = await _context.servicios.FindAsync(id);
            _context.servicios.Remove(servicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool serviciosExists(int id)
        {
            return _context.servicios.Any(e => e.IdServicioEntidad == id);
        }
        public async Task<IActionResult> Index2(string SearchString)
        {
            var pacientes = GetAllservicios(); // Obtiene todos los saludos
            if (pacientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(SearchString))
                {
                    pacientes = pacientes.Where(s => s.Estado.Contains(SearchString));
                }

            }
            return View(pacientes);

        }
        public IEnumerable<servicios> GetAllservicios()
        {
            return _context.servicios;
        }
    }
}
