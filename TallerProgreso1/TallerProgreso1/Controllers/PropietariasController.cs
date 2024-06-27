using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerProgreso1.Data;
using TallerProgreso1.Models;

namespace TallerProgreso1.Controllers
{
    public class PropietariasController : Controller
    {
        private readonly TallerProgreso1Context _context;

        public PropietariasController(TallerProgreso1Context context)
        {
            _context = context;
        }

        // GET: Propietarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Propietaria.ToListAsync());
        }

        // GET: Propietarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietaria = await _context.Propietaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propietaria == null)
            {
                return NotFound();
            }

            return View(propietaria);
        }

        // GET: Propietarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propietarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,FechaNacimeinto,Ecuatoriano")] Propietaria propietaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propietaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propietaria);
        }

        // GET: Propietarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietaria = await _context.Propietaria.FindAsync(id);
            if (propietaria == null)
            {
                return NotFound();
            }
            return View(propietaria);
        }

        // POST: Propietarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,FechaNacimeinto,Ecuatoriano")] Propietaria propietaria)
        {
            if (id != propietaria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propietaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropietariaExists(propietaria.Id))
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
            return View(propietaria);
        }

        // GET: Propietarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietaria = await _context.Propietaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propietaria == null)
            {
                return NotFound();
            }

            return View(propietaria);
        }

        // POST: Propietarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propietaria = await _context.Propietaria.FindAsync(id);
            if (propietaria != null)
            {
                _context.Propietaria.Remove(propietaria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropietariaExists(int id)
        {
            return _context.Propietaria.Any(e => e.Id == id);
        }
    }
}
