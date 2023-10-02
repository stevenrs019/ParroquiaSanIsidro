using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWebParroquia.Data;
using SistemaWebParroquia.Models;

namespace SistemaWebParroquia.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ParroquiaContext _context;

        public PersonasController(ParroquiaContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
              return _context.personas != null ? 
                          View(await _context.personas.ToListAsync()) :
                          Problem("Entity set 'ParroquiaContext.personas'  is null.");
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.personas == null)
            {
                return NotFound();
            }

            var personas = await _context.personas
                .FirstOrDefaultAsync(m => m.ID_personas == id);
            if (personas == null)
            {
                return NotFound();
            }

            return View(personas);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_personas,nombre,apellido1,apellido2,cedula,padre,madre,Abuelo_Paterno,Abuela_Paterno,Abuelo_Materno,Abuela_Materno,Padrino,Madrina,FechaNacimiento,Lugarnacimiento,bautizos,comunion,confirmacion,matrimonio")] Personas personas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personas);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.personas == null)
            {
                return NotFound();
            }

            var personas = await _context.personas.FindAsync(id);
            if (personas == null)
            {
                return NotFound();
            }
            return View(personas);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_personas,nombre,apellido1,apellido2,cedula,padre,madre,Abuelo_Paterno,Abuela_Paterno,Abuelo_Materno,Abuela_Materno,Padrino,Madrina,FechaNacimiento,Lugarnacimiento,bautizos,comunion,confirmacion,matrimonio")] Personas personas)
        {
            if (id != personas.ID_personas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonasExists(personas.ID_personas))
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
            return View(personas);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.personas == null)
            {
                return NotFound();
            }

            var personas = await _context.personas
                .FirstOrDefaultAsync(m => m.ID_personas == id);
            if (personas == null)
            {
                return NotFound();
            }

            return View(personas);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.personas == null)
            {
                return Problem("Entity set 'ParroquiaContext.personas'  is null.");
            }
            var personas = await _context.personas.FindAsync(id);
            if (personas != null)
            {
                _context.personas.Remove(personas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonasExists(int id)
        {
          return (_context.personas?.Any(e => e.ID_personas == id)).GetValueOrDefault();
        }
    }
}
