using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Data;
using SmartCafe.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Controllers
{
    [Authorize(Roles = "Konobar")]
    public class BartenderPanelController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BartenderPanelController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: BartenderPanelController
        public IActionResult Index()
        {
            var Drinks = _context.Drinks.ToList();
            var orderItems = _context.OrderItems.ToList();
            ViewBag.Drinks = Drinks;
            ViewBag.OrderItems = orderItems;
            var orders = _context.Orders.Include(o => o.Guest).ToList();
            return View(orders);
        }

        // GET: BartenderPanelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BartenderPanelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BartenderPanelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["idGuest"] = new SelectList(_context.Guests, "id", "id", order.idGuest);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,done,tableNumber,orderTime,idGuest")] Order order)
        {
            if (id != order.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.id))
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
            ViewData["idGuest"] = new SelectList(_context.Guests, "id", "id", order.idGuest);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Guest)
                .FirstOrDefaultAsync(m => m.id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.id == id);
        }
    }

    }

