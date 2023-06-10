using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Data;
using SmartCafe.Interfaces;
using SmartCafe.Models;

namespace SmartCafe.Controllers
{
    public class ModifyOrderController : Controller, IDrink
    {
        private readonly ApplicationDbContext _context;

        public ModifyOrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(Dictionary<int, int> selectedDrinks, int tableNumber)
        {
            TempData["SelectedTableNumber"] = tableNumber;
            var applicationDbContext = _context.Orders.Include(o => o.Guest);

            var drinkIds = selectedDrinks.Keys.ToList();
            var drinks = await _context.Drinks.Where(d => drinkIds.Contains(d.id)).ToListAsync();

            var selectedDrinksList = new List<Tuple<string, int, double>>();

            foreach (var drink in drinks)
            {
                if (selectedDrinks.TryGetValue(drink.id, out var quantity))
                {
                    var price = drink.price;
                    selectedDrinksList.Add(Tuple.Create(drink.name, quantity, price));
                }
            }

            ViewBag.SelectedDrinks = selectedDrinksList;

            if (TempData.ContainsKey("SelectedTableNumber"))
            {
                ViewBag.SelectedTableNumber = TempData["SelectedTableNumber"].ToString();
            }

            return View(await applicationDbContext.ToListAsync());
        }



        // GET: ModifyOrder/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: ModifyOrder/Create
        public IActionResult Create()
        {
            ViewData["idGuest"] = new SelectList(_context.Guests, "id", "id");
            return View();
        }

        // POST: ModifyOrder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,done,tableNumber,orderTime,idGuest")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idGuest"] = new SelectList(_context.Guests, "id", "id", order.idGuest);
            return View(order);
        }

        // GET: ModifyOrder/Edit/5
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

        // POST: ModifyOrder/Edit/5
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

        // GET: ModifyOrder/Delete/5
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

        // POST: ModifyOrder/Delete/5
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveOrder([FromBody] Dictionary<int, int> selectedDrinks, int tableNumber)
        {
            // Stvaranje nove narudžbe
            var order = new Order
            {
                done = false,
                tableNumber = tableNumber,
                orderTime = DateTime.Now,
                idGuest = tableNumber
            };

            // Dodavanje nove narudžbe u bazu podataka
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Iteriranje kroz odabrana pića i stvaranje povezanih OrderItem zapisa
            foreach (var drinkEntry in selectedDrinks)
            {
                var drinkId = drinkEntry.Key;
                var quantity = drinkEntry.Value;

                // Pronalaženje odabranog pića iz baze podataka
                var drink = await _context.Drinks.FindAsync(drinkId);

                if (drink != null)
                {
                    // Stvaranje novog OrderItem zapisa
                    var orderItem = new OrderItem
                    {
                        idDrink = drinkId,
                        idOrder = order.id, // ID nove narudžbe
                        price = drink.price
                    };

                    // Dodavanje OrderItem zapisa u bazu podataka
                    _context.OrderItems.Add(orderItem);
                }
            }

            // Spremanje promjena u bazu podataka
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
