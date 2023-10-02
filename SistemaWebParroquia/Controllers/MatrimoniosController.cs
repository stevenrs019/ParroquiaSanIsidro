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
    public class MatrimoniosController : Controller
    {
        private readonly ParroquiaContext _context;

        public MatrimoniosController(ParroquiaContext context)
        {
            _context = context;
        }

        // GET: Matrimonios
        public async Task<IActionResult> Index()
        {
              return _context.matrimonios != null ? 
                          View(await _context.matrimonios.ToListAsync()) :
                          Problem("Entity set 'ParroquiaContext.matrimonios'  is null.");
        }

        // GET: Matrimonios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.matrimonios == null)
            {
                return NotFound();
            }

            var matrimonios = await _context.matrimonios
                .FirstOrDefaultAsync(m => m.ID_matrimonio == id);
            if (matrimonios == null)
            {
                return NotFound();
            }

            return View(matrimonios);
        }

        // GET: Matrimonios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Matrimonios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_matrimonio,expediente,expediente_registro,Personas,FechaMatrimonio,LugarMatrimonio,presbitero,padre_1,madre_1,padre_2,madre_2,nacionalidad_1,nacionalidad_2,profesion_1,profesion_2,religion_1,religion_2,nacion_1,nacion_2,feligres_1,feligres_2,FechaBautizo1,FechaBautizo2,LugarBautizo1,LugarBautizo2,libro_M,folio_M,asiento_M,libro_C1,folio_C1,asiento_C1,libro_C2,folio_C2,asiento_C2,libro_P1,folio_P1,asiento_P1,libro_P2,folio_P2,asiento_P2,libro_B1,folio_B1,asiento_B1,libro_B2,folio_B2,asiento_B2")] Matrimonios matrimonios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matrimonios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matrimonios);
        }

        // GET: Matrimonios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.matrimonios == null)
            {
                return NotFound();
            }

            var matrimonios = await _context.matrimonios.FindAsync(id);
            if (matrimonios == null)
            {
                return NotFound();
            }
            return View(matrimonios);
        }

        // POST: Matrimonios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_matrimonio,expediente,expediente_registro,Personas,FechaMatrimonio,LugarMatrimonio,presbitero,padre_1,madre_1,padre_2,madre_2,nacionalidad_1,nacionalidad_2,profesion_1,profesion_2,religion_1,religion_2,nacion_1,nacion_2,feligres_1,feligres_2,FechaBautizo1,FechaBautizo2,LugarBautizo1,LugarBautizo2,libro_M,folio_M,asiento_M,libro_C1,folio_C1,asiento_C1,libro_C2,folio_C2,asiento_C2,libro_P1,folio_P1,asiento_P1,libro_P2,folio_P2,asiento_P2,libro_B1,folio_B1,asiento_B1,libro_B2,folio_B2,asiento_B2")] Matrimonios matrimonios)
        {
            if (id != matrimonios.ID_matrimonio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matrimonios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatrimoniosExists(matrimonios.ID_matrimonio))
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
            return View(matrimonios);
        }

        // GET: Matrimonios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.matrimonios == null)
            {
                return NotFound();
            }

            var matrimonios = await _context.matrimonios
                .FirstOrDefaultAsync(m => m.ID_matrimonio == id);
            if (matrimonios == null)
            {
                return NotFound();
            }

            return View(matrimonios);
        }

        // POST: Matrimonios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.matrimonios == null)
            {
                return Problem("Entity set 'ParroquiaContext.matrimonios'  is null.");
            }
            var matrimonios = await _context.matrimonios.FindAsync(id);
            if (matrimonios != null)
            {
                _context.matrimonios.Remove(matrimonios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatrimoniosExists(int id)
        {
          return (_context.matrimonios?.Any(e => e.ID_matrimonio == id)).GetValueOrDefault();
        }
    }
}
