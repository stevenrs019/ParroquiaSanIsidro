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
    public class PrimeraComunionController : Controller
    {
        private readonly ParroquiaContext _context;

        public PrimeraComunionController(ParroquiaContext context)
        {
            _context = context;
        }

        // GET: PrimeraComunions
        public async Task<IActionResult> Index()
        {
              return _context.primeraComunion != null ? 
                          View(await _context.primeraComunion.ToListAsync()) :
                          Problem("Entity set 'ParroquiaContext.primeraComunion'  is null.");
        }

        // GET: PrimeraComunions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.primeraComunion == null)
            {
                return NotFound();
            }

            var primeraComunion = await _context.primeraComunion
                .FirstOrDefaultAsync(m => m.ID_comunion == id);
            if (primeraComunion == null)
            {
                return NotFound();
            }

            return View(primeraComunion);
        }

        // GET: PrimeraComunions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrimeraComunions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_comunion,Personas,FechaComunion,LugarComunion,encargado,FechaBautizo,LugarBautizo,libro_P,folio_P,asiento_P,libro_B,folio_B,asiento_B")] PrimeraComunion primeraComunion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(primeraComunion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(primeraComunion);
        }

        // GET: PrimeraComunions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.primeraComunion == null)
            {
                return NotFound();
            }

            var primeraComunion = await _context.primeraComunion.FindAsync(id);
            if (primeraComunion == null)
            {
                return NotFound();
            }
            return View(primeraComunion);
        }

        // POST: PrimeraComunions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_comunion,Personas,FechaComunion,LugarComunion,encargado,FechaBautizo,LugarBautizo,libro_P,folio_P,asiento_P,libro_B,folio_B,asiento_B")] PrimeraComunion primeraComunion)
        {
            if (id != primeraComunion.ID_comunion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(primeraComunion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrimeraComunionExists(primeraComunion.ID_comunion))
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
            return View(primeraComunion);
        }

        // GET: PrimeraComunions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.primeraComunion == null)
            {
                return NotFound();
            }

            var primeraComunion = await _context.primeraComunion
                .FirstOrDefaultAsync(m => m.ID_comunion == id);
            if (primeraComunion == null)
            {
                return NotFound();
            }

            return View(primeraComunion);
        }

        // POST: PrimeraComunions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.primeraComunion == null)
            {
                return Problem("Entity set 'ParroquiaContext.primeraComunion'  is null.");
            }
            var primeraComunion = await _context.primeraComunion.FindAsync(id);
            if (primeraComunion != null)
            {
                _context.primeraComunion.Remove(primeraComunion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrimeraComunionExists(int id)
        {
          return (_context.primeraComunion?.Any(e => e.ID_comunion == id)).GetValueOrDefault();
        }
    }
}
