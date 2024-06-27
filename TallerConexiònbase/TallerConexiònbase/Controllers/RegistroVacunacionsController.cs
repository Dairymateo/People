using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallerConexiònbase.Data;
using TallerConexiònbase.Models;

namespace TallerConexiònbase.Controllers
{
    public class RegistroVacunacionsController : Controller
    {
        private readonly TallerConexiònbaseContext _context;

        public RegistroVacunacionsController(TallerConexiònbaseContext context)
        {
            _context = context;
        }

        // GET: RegistroVacunacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroVacunacion.ToListAsync());
        }

        // GET: RegistroVacunacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVacunacion = await _context.RegistroVacunacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroVacunacion == null)
            {
                return NotFound();
            }

            return View(registroVacunacion);
        }

        // GET: RegistroVacunacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroVacunacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaVacunacion")] RegistroVacunacion registroVacunacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroVacunacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroVacunacion);
        }

        // GET: RegistroVacunacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVacunacion = await _context.RegistroVacunacion.FindAsync(id);
            if (registroVacunacion == null)
            {
                return NotFound();
            }
            return View(registroVacunacion);
        }

        // POST: RegistroVacunacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaVacunacion")] RegistroVacunacion registroVacunacion)
        {
            if (id != registroVacunacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroVacunacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroVacunacionExists(registroVacunacion.Id))
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
            return View(registroVacunacion);
        }

        // GET: RegistroVacunacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVacunacion = await _context.RegistroVacunacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroVacunacion == null)
            {
                return NotFound();
            }

            return View(registroVacunacion);
        }

        // POST: RegistroVacunacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroVacunacion = await _context.RegistroVacunacion.FindAsync(id);
            if (registroVacunacion != null)
            {
                _context.RegistroVacunacion.Remove(registroVacunacion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroVacunacionExists(int id)
        {
            return _context.RegistroVacunacion.Any(e => e.Id == id);
        }
    }
}
