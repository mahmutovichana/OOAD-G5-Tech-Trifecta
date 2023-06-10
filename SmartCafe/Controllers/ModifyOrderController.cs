using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
        public async Task<IActionResult> Index(string tableNumber, Dictionary<int, int> selectedDrinks)
        {
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
            ViewBag.TableNumber = tableNumber;

            // Start background task to save the order
            await Task.Run(() => SaveOrder(selectedDrinksList, tableNumber));

            return RedirectToAction("Index", "ModifyOrder");
        }

        private void SaveOrder(List<Tuple<string, int, double>> selectedDrinksList, string tableNumber)
        {
            // Pretražite postojeće porudžbine na osnovu broja stola
            var existingOrder = _context.Orders.FirstOrDefault(o => o.tableNumber == tableNumberValue && !o.done);

            if (existingOrder != null)
            {
                // Ažurirajte postojeću porudžbinu
                foreach (var tuple in selectedDrinksList)
                {
                    // Proverite da li stavka već postoji u porudžbini
                    var existingOrderItem = existingOrder.OrderItems.FirstOrDefault(oi => oi.Drink.name == tuple.Item1);

                    if (existingOrderItem != null)
                    {
                        // Ažurirajte količinu ili bilo koju drugu informaciju
                        existingOrderItem.quantity += tuple.Item2;
                    }
                    else
                    {
                        // Dodajte novu stavku u porudžbinu
                        var orderItem = new OrderItem
                        {
                            Drink = new Drink { name = tuple.Item1, price = tuple.Item3 },
                            Order = existingOrder,
                            price = tuple.Item3,
                            quantity = tuple.Item2
                        };

                        _context.OrderItems.Add(orderItem);
                    }
                }
            }
            else
            {
                // Kreirajte novu porudžbinu
                var order = new Order
                {
                    done = false,
                    tableNumber = int.Parse(tableNumber),
                    orderTime = DateTime.Now,
                    Guest = new Guest() // Zamijenite sa stvarnim gostom
                };

                _context.Orders.Add(order);

                foreach (var tuple in selectedDrinksList)
                {
                    var orderItem = new OrderItem
                    {
                        Drink = new Drink { name = tuple.Item1, price = tuple.Item3 },
                        Order = order,
                        price = tuple.Item3,
                        quantity = tuple.Item2
                    };

                    _context.OrderItems.Add(orderItem);
                }
            }

            _context.SaveChanges();
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

        }
}
