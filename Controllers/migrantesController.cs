using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using login2.Data;
using login2.Models;

namespace login2.Controllers
{
    public class migrantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public migrantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: migrantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.migrantes.ToListAsync());
        }

        // GET: migrantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migrantes = await _context.migrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (migrantes == null)
            {
                return NotFound();
            }

            return View(migrantes);
        }

        // GET: migrantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: migrantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellidos,Tipodoc,Documento,Pais,Fecha_nacimiento,Correo,Telefono,Direccion,Ciudad,Situacionlaboral")] migrantes migrantes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(migrantes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(migrantes);
        }

        // GET: migrantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migrantes = await _context.migrantes.FindAsync(id);
            if (migrantes == null)
            {
                return NotFound();
            }
            return View(migrantes);
        }

        // POST: migrantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellidos,Tipodoc,Documento,Pais,Fecha_nacimiento,Correo,Telefono,Direccion,Ciudad,Situacionlaboral")] migrantes migrantes)
        {
            if (id != migrantes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(migrantes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!migrantesExists(migrantes.Id))
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
            return View(migrantes);
        }

        // GET: migrantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var migrantes = await _context.migrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (migrantes == null)
            {
                return NotFound();
            }

            return View(migrantes);
        }

        // POST: migrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var migrantes = await _context.migrantes.FindAsync(id);
            _context.migrantes.Remove(migrantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool migrantesExists(int id)
        {
            return _context.migrantes.Any(e => e.Id == id);
        }
    }
}
