using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
            var drinks = _context.Drinks.Where(d => drinkIds.Contains(d.id)).ToList();

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

            TempData["SelectedDrinksList"] = selectedDrinksList;
            TempData["TableNumber"] = tableNumber;

            if (TempData["OrderSaved"] != null && (bool)TempData["OrderSaved"])
            {
                ViewBag.OrderSaved = true; // Postavljamo ViewBag.OrderSaved na true ako je narudžba uspješno spremljena
                TempData["OrderSaved"] = false; // Resetiramo privremene podatke
            }

            return View(await applicationDbContext.ToListAsync());
        }


        public async Task AfterIndex(List<Tuple<string, int, double>> selectedDrinksList, string tableNumber)
        {
            // Delay for 10 secs before calling SaveOrder
            await Task.Delay(10000);

            // Call SaveOrder action
            SaveOrder(selectedDrinksList, tableNumber);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveOrder(List<Tuple<string, int, double>> selectedDrinksList, string tableNumber)
        {
            if (int.TryParse(tableNumber, out int tableNumberValue))
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer("Data Source=SQL6031.site4now.net;Initial Catalog=db_a99f6b_techtrifecta1;User Id=db_a99f6b_techtrifecta1_admin;Password=Prekucatcuovo1!"); // Zamijenite sa stvarnim Connection Stringom

                using (var context = new ApplicationDbContext(optionsBuilder.Options))
                {
                    var order = await context.Orders.FirstOrDefaultAsync(o => o.tableNumber == tableNumberValue && !o.done);

                    if (order == null)
                    {
                        order = new Order
                        {
                            done = false,
                            tableNumber = int.Parse(tableNumber),
                            orderTime = DateTime.Now,
                            Guest = new Guest() // Zamijeni sa stvarnim gostom
                        };

                        context.Orders.Add(order);
                        await context.SaveChangesAsync(); // Spremi narudžbu kako bismo dobili ID
                    }

                    foreach (var tuple in selectedDrinksList)
                    {
                        var drinkName = tuple.Item1;

                        var drink = context.Drinks.FirstOrDefault(d => d.name == drinkName);

                        if (drink != null)
                        {
                            for (int i = 0; i < tuple.Item2; i++)
                            {
                                var orderItem = new OrderItem
                                {
                                    Drink = drink,
                                    Order = order,
                                    price = tuple.Item3
                                };

                                context.OrderItems.Add(orderItem);
                            }
                        }
                    }

                    await context.SaveChangesAsync();

                    TempData["OrderSaved"] = true; // Postavljamo privremene podatke za redirekciju
                }
            }

            return View("Index");
        }


        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            // Dohvati podatke iz TempData
            var selectedDrinksList = TempData["SelectedDrinksList"] as List<Tuple<string, int, double>>;
            var tableNumber = TempData["TableNumber"] as string;

            if (selectedDrinksList != null && tableNumber != null)
            {
                // Pozovi AfterIndex metodu
                AfterIndex(selectedDrinksList, tableNumber);
            }
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
