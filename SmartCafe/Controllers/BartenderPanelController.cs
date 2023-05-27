using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Data;
using SmartCafe.Models;

namespace SmartCafe.Controllers
{
    public class BartenderPanelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BartenderPanelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BartenderPanel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bartenders.ToListAsync());
        }

        // GET: BartenderPanel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bartender = await _context.Bartenders
                .FirstOrDefaultAsync(m => m.id == id);
            if (bartender == null)
            {
                return NotFound();
            }

            return View(bartender);
        }

        // GET: BartenderPanel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BartenderPanel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,username,password,role")] Bartender bartender)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bartender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bartender);
        }

        // GET: BartenderPanel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bartender = await _context.Bartenders.FindAsync(id);
            if (bartender == null)
            {
                return NotFound();
            }
            return View(bartender);
        }

        // POST: BartenderPanel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,username,password,role")] Bartender bartender)
        {
            if (id != bartender.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bartender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BartenderExists(bartender.id))
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
            return View(bartender);
        }

        // GET: BartenderPanel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bartender = await _context.Bartenders
                .FirstOrDefaultAsync(m => m.id == id);
            if (bartender == null)
            {
                return NotFound();
            }

            return View(bartender);
        }

        // POST: BartenderPanel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bartender = await _context.Bartenders.FindAsync(id);
            _context.Bartenders.Remove(bartender);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BartenderExists(int id)
        {
            return _context.Bartenders.Any(e => e.id == id);
        }
    }
}
