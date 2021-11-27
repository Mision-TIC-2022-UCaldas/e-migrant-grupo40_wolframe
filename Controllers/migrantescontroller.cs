using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto.Data;
using proyecto.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        /*
          public IActionResult GetOneMigrantes(numeroDocumento)
        {
            migrantes migrante = _context.migrantes.FirstOrDefault(p => p.Documento == numeroDocumento);;
            return View(migrante);
        }
         
         */

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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaAmigos = await _context.migrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiaAmigos == null)
            {
                return NotFound();
            }

            return View(familiaAmigos);
        }
    }
}
