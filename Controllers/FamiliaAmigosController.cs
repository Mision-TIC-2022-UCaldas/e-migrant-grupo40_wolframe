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
    public class FamiliaAmigosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FamiliaAmigosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FamiliaAmigos
        public async Task<IActionResult> Index()
        {
            return View(await _context.FamiliaAmigos.ToListAsync());
        }

        // GET: FamiliaAmigos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaAmigos = await _context.FamiliaAmigos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiaAmigos == null)
            {
                return NotFound();
            }

            return View(familiaAmigos);
        }

        // GET: FamiliaAmigos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FamiliaAmigos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellidos,Tipodoc,Documento,Pais,Fecha_nacimiento,Correo,Telefono,Direccion,Ciudad,Situacionlaboral,TipoAfinidad,IdMigrantes")] FamiliaAmigos familiaAmigos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familiaAmigos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(familiaAmigos);
        }

        // GET: FamiliaAmigos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaAmigos = await _context.FamiliaAmigos.FindAsync(id);
            if (familiaAmigos == null)
            {
                return NotFound();
            }
            return View(familiaAmigos);
        }

        // POST: FamiliaAmigos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellidos,Tipodoc,Documento,Pais,Fecha_nacimiento,Correo,Telefono,Direccion,Ciudad,Situacionlaboral,TipoAfinidad,IdMigrantes")] FamiliaAmigos familiaAmigos)
        {
            if (id != familiaAmigos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familiaAmigos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaAmigosExists(familiaAmigos.Id))
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
            return View(familiaAmigos);
        }

        // GET: FamiliaAmigos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaAmigos = await _context.FamiliaAmigos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiaAmigos == null)
            {
                return NotFound();
            }

            return View(familiaAmigos);
        }

        // POST: FamiliaAmigos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familiaAmigos = await _context.FamiliaAmigos.FindAsync(id);
            _context.FamiliaAmigos.Remove(familiaAmigos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliaAmigosExists(int id)
        {
            return _context.FamiliaAmigos.Any(e => e.Id == id);
        }
    }
}
