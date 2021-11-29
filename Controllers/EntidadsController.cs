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
    public class EntidadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntidadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Entidads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entidad.ToListAsync());
        }

        // GET: Entidads/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidad = await _context.Entidad
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (entidad == null)
            {
                return NotFound();
            }

            return View(entidad);
        }

        // GET: Entidads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entidads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nit,RazonSocial,Direccion,Ciudad,Telefono,Sector,PaginaWeb,Correo")] Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entidad);
        }

        // GET: Entidads/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidad = await _context.Entidad.FindAsync(id);
            if (entidad == null)
            {
                return NotFound();
            }
            return View(entidad);
        }

        // POST: Entidads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Nit,RazonSocial,Direccion,Ciudad,Telefono,Sector,PaginaWeb,Correo")] Entidad entidad)
        {
            if (id != entidad.Nit)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntidadExists(entidad.Nit))
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
            return View(entidad);
        }

        // GET: Entidads/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entidad = await _context.Entidad
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (entidad == null)
            {
                return NotFound();
            }

            return View(entidad);
        }

        // POST: Entidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var entidad = await _context.Entidad.FindAsync(id);
            _context.Entidad.Remove(entidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntidadExists(string id)
        {
            return _context.Entidad.Any(e => e.Nit == id);
        }
        public async Task<IActionResult> Index2(string SearchString,string Ciudad)
        {
            var pacientes = GetAllnovedades(); // Obtiene todos los saludos
            if (pacientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(SearchString) && !String.IsNullOrEmpty(Ciudad))
                {
                    pacientes = pacientes.Where(s => s.Nit.Contains(SearchString) && s.Ciudad.Contains(Ciudad));
                }
                else if (!String.IsNullOrEmpty(SearchString) && String.IsNullOrEmpty(Ciudad))
                {
                    pacientes = pacientes.Where(s => s.Nit.Contains(SearchString) );
                }
                else if(String.IsNullOrEmpty(SearchString) && !String.IsNullOrEmpty(Ciudad))
                {
                    pacientes = pacientes.Where(s => s.Ciudad.Contains(Ciudad));
                }
                else if (String.IsNullOrEmpty(SearchString) && String.IsNullOrEmpty(Ciudad))
                {
                    return NotFound();
                }

            }
            return View(pacientes);

        }
        public IEnumerable<Entidad> GetAllnovedades()
        {
            return _context.Entidad;
        }
    }
}
