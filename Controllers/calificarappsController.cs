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
    public class calificarappsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public calificarappsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: calificarapps
        public async Task<IActionResult> Index()
        {
            return View(await _context.calificarapp.ToListAsync());
        }

        // GET: calificarapps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificarapp = await _context.calificarapp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificarapp == null)
            {
                return NotFound();
            }

            return View(calificarapp);
        }

        // GET: calificarapps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: calificarapps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,correo,calificacion,comentarios")] calificarapp calificarapp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calificarapp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calificarapp);
        }

        // GET: calificarapps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificarapp = await _context.calificarapp.FindAsync(id);
            if (calificarapp == null)
            {
                return NotFound();
            }
            return View(calificarapp);
        }

        // POST: calificarapps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,correo,calificacion,comentarios")] calificarapp calificarapp)
        {
            if (id != calificarapp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calificarapp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!calificarappExists(calificarapp.Id))
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
            return View(calificarapp);
        }

        // GET: calificarapps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificarapp = await _context.calificarapp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificarapp == null)
            {
                return NotFound();
            }

            return View(calificarapp);
        }

        // POST: calificarapps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calificarapp = await _context.calificarapp.FindAsync(id);
            _context.calificarapp.Remove(calificarapp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool calificarappExists(int id)
        {
            return _context.calificarapp.Any(e => e.Id == id);
        }
    }
}
