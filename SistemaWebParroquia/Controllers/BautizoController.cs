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
    public class BautizoController : Controller
    {
        private readonly ParroquiaContext _context;

        public BautizoController(ParroquiaContext context)
        {
            _context = context;
        }

        // GET: Bautizo
        public async Task<IActionResult> Index()
        {
              return _context.bautizos != null ? 
                          View(await _context.bautizos.ToListAsync()) :
                          Problem("Entity set 'ParroquiaContext.bautizos'  is null.");
        }

        // GET: Bautizo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.bautizos == null)
            {
                return NotFound();
            }

            var bautizo = await _context.bautizos
                .FirstOrDefaultAsync(m => m.ID_bautizos == id);
            if (bautizo == null)
            {
                return NotFound();
            }

            return View(bautizo);
        }

        // GET: Bautizo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bautizo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_bautizos,Personas,FechaBautizo,LugarBautizo,presbitero,padre,madre,Abuelo_Paterno,Abuela_Paterno,Abuelo_Materno,Abuela_Materno,Padrinos,madrina,libro_B,folio_B,asiento_B")] Bautizo bautizo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bautizo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bautizo);
        }

        // GET: Bautizo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.bautizos == null)
            {
                return NotFound();
            }

            var bautizo = await _context.bautizos.FindAsync(id);
            if (bautizo == null)
            {
                return NotFound();
            }
            return View(bautizo);
        }

        // POST: Bautizo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_bautizos,Personas,FechaBautizo,LugarBautizo,presbitero,padre,madre,Abuelo_Paterno,Abuela_Paterno,Abuelo_Materno,Abuela_Materno,Padrinos,madrina,libro_B,folio_B,asiento_B")] Bautizo bautizo)
        {
            if (id != bautizo.ID_bautizos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bautizo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BautizoExists(bautizo.ID_bautizos))
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
            return View(bautizo);
        }

        // GET: Bautizo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.bautizos == null)
            {
                return NotFound();
            }

            var bautizo = await _context.bautizos
                .FirstOrDefaultAsync(m => m.ID_bautizos == id);
            if (bautizo == null)
            {
                return NotFound();
            }

            return View(bautizo);
        }

        // POST: Bautizo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.bautizos == null)
            {
                return Problem("Entity set 'ParroquiaContext.bautizos'  is null.");
            }
            var bautizo = await _context.bautizos.FindAsync(id);
            if (bautizo != null)
            {
                _context.bautizos.Remove(bautizo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BautizoExists(int id)
        {
          return (_context.bautizos?.Any(e => e.ID_bautizos == id)).GetValueOrDefault();
        }
    }
}
