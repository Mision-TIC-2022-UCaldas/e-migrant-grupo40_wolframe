﻿using System;
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
    public class NovedadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NovedadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Novedads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Novedad.ToListAsync());
        }

        // GET: Novedads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novedad = await _context.Novedad
                .FirstOrDefaultAsync(m => m.IdNovedades == id);
            if (novedad == null)
            {
                return NotFound();
            }

            return View(novedad);
        }

        // GET: Novedads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Novedads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNovedades,Detalle,Fecha,NumeroDias,TipoUsuario,Ciudad,Estado")] Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(novedad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(novedad);
        }

        // GET: Novedads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novedad = await _context.Novedad.FindAsync(id);
            if (novedad == null)
            {
                return NotFound();
            }
            return View(novedad);
        }

        // POST: Novedads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNovedades,Detalle,Fecha,NumeroDias,TipoUsuario,Ciudad,Estado")] Novedad novedad)
        {
            if (id != novedad.IdNovedades)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(novedad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NovedadExists(novedad.IdNovedades))
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
            return View(novedad);
        }

        // GET: Novedads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novedad = await _context.Novedad
                .FirstOrDefaultAsync(m => m.IdNovedades == id);
            if (novedad == null)
            {
                return NotFound();
            }

            return View(novedad);
        }

        // POST: Novedads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var novedad = await _context.Novedad.FindAsync(id);
            _context.Novedad.Remove(novedad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NovedadExists(int id)
        {
            return _context.Novedad.Any(e => e.IdNovedades == id);
        }
        public async Task<IActionResult> Index2(string SearchString,string Ciudad)
        {
            var pacientes = GetAllnovedades(); // Obtiene todos los saludos
            if (pacientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(SearchString))
                {
                    pacientes = pacientes.Where(s => s.TipoUsuario.Contains(SearchString) && s.Ciudad.Contains(Ciudad));
                }

            }
            return View(pacientes);

        }
        public IEnumerable<Novedad> GetAllnovedades()
        {
            return _context.Novedad;
        }
    }
}
