using Microsoft.AspNetCore.Mvc;
using proyecto.Data;
using proyecto.Models;
using System.Collections.Generic;

namespace proyecto.Controllers
{
    public class migrantescontroller : Controller

    {
        private readonly ApplicationDbContext _context;

        public migrantescontroller(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<migrantes> lista_migrantes = _context.migrantes;
            return View(lista_migrantes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(migrantes migrantes)
        {
            if (ModelState.IsValid)
            {
                _context.migrantes.Add(migrantes);
                _context.SaveChanges();

                TempData["mensaje"] = "se ha registrado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var migrante = _context.migrantes.Find(id);
            
            if (migrante == null)
            {
                return NotFound();
            }
            return View(migrante);
        }
        [HttpPost]
        public IActionResult Edit(migrantes migrantes)
        {
            if (ModelState.IsValid)
            {
                _context.migrantes.Update(migrantes);
                _context.SaveChanges();

                TempData["mensaje"] = "se ha editado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var migrante = _context.migrantes.Find(id);

            if (migrante == null)
            {
                return NotFound();
            }
            return View(migrante);
        }
        [HttpPost]
        public IActionResult Deletemigrante(int? id)
        {
            var migrante = _context.migrantes.Find(id);

            if (migrante == null)
            {
                return NotFound();
            }
            _context.migrantes.Remove(migrante);
            _context.SaveChanges();

            TempData["mensaje"] = "se ha eliminado correctamente";
            return RedirectToAction("Index");
            


        }
    }
}
