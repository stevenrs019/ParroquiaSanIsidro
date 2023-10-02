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
    public class ConfirmacionesController : Controller
    {
        private readonly ParroquiaContext _context;

        public ConfirmacionesController(ParroquiaContext context)
        {
            _context = context;
        }

        // GET: Confirmaciones
        public async Task<IActionResult> Index()
        {
              return _context.confirmacion != null ? 
                          View(await _context.confirmacion.ToListAsync()) :
                          Problem("Entity set 'ParroquiaContext.confirmacion'  is null.");
        }

        // GET: Confirmaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.confirmacion == null)
            {
                return NotFound();
            }

            var confirmacion = await _context.confirmacion
                .FirstOrDefaultAsync(m => m.ID_confirmacion == id);
            if (confirmacion == null)
            {
                return NotFound();
            }

            return View(confirmacion);
        }

        // GET: Confirmaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Confirmaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_confirmacion,Personas,FechaConfirmacion,LugarConfirmacion,encargado,padrino,obispo,fechaBautizo,lugarBautizo,libro_C,folio_C,asiento_C,libro_B,folio_B,asiento_B")] Confirmacion confirmacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(confirmacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(confirmacion);
        }

        // GET: Confirmaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.confirmacion == null)
            {
                return NotFound();
            }

            var confirmacion = await _context.confirmacion.FindAsync(id);
            if (confirmacion == null)
            {
                return NotFound();
            }
            return View(confirmacion);
        }

        // POST: Confirmaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_confirmacion,Personas,FechaConfirmacion,LugarConfirmacion,encargado,padrino,obispo,fechaBautizo,lugarBautizo,libro_C,folio_C,asiento_C,libro_B,folio_B,asiento_B")] Confirmacion confirmacion)
        {
            if (id != confirmacion.ID_confirmacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(confirmacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfirmacionExists(confirmacion.ID_confirmacion))
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
            return View(confirmacion);
        }

        // GET: Confirmaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.confirmacion == null)
            {
                return NotFound();
            }

            var confirmacion = await _context.confirmacion
                .FirstOrDefaultAsync(m => m.ID_confirmacion == id);
            if (confirmacion == null)
            {
                return NotFound();
            }

            return View(confirmacion);
        }

        // POST: Confirmaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.confirmacion == null)
            {
                return Problem("Entity set 'ParroquiaContext.confirmacion'  is null.");
            }
            var confirmacion = await _context.confirmacion.FindAsync(id);
            if (confirmacion != null)
            {
                _context.confirmacion.Remove(confirmacion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfirmacionExists(int id)
        {
          return (_context.confirmacion?.Any(e => e.ID_confirmacion == id)).GetValueOrDefault();
        }
    }
}
