using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Data;
using SmartCafe.Interfaces;
using SmartCafe.Models;

namespace SmartCafe.Controllers
{
    [Authorize (Roles = "Administrator")]
    public class AdminPanelController : Controller, IStatistic, IPrototype
    {
        private readonly ApplicationDbContext _context;

        public AdminPanelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminPanel
        public IActionResult Index()
        {
            // Calculate the necessary values
            double todayProfit = DailyProfit();
            double totalProfit = TotalProfit();
            string mostSoldCocktailName = MostSoldDrink();

            // Pass the values to the ViewBag
            ViewBag.TodayProfit = todayProfit;
            ViewBag.TotalProfit = totalProfit;
            ViewBag.MostSoldCocktailName = mostSoldCocktailName;

            // Retrieve the list of drinks from the database
            var drinks = _context.Drinks.ToList();

            return View(drinks);
        }

        // GET: AdminPanel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.id == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }

        // GET: AdminPanel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,price")] Drink drink)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drink);
        }

        // GET: AdminPanel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null)
            {
                return NotFound();
            }
            return View(drink);
        }

        // POST: AdminPanel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,price")] Drink drink)
        {
            if (id != drink.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkExists(drink.id))
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
            return View(drink);
        }

        // GET: AdminPanel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.id == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }

        // POST: AdminPanel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drink = await _context.Drinks.FindAsync(id);
            _context.Drinks.Remove(drink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkExists(int id)
        {
            return _context.Drinks.Any(e => e.id == id);
        }
        public double DailyProfit()
        {
            DateTime today = DateTime.Today;

            double dailyProfit = _context.Orders
                .Where(o => o.orderTime.Date == today)
                .Join(_context.OrderItems, o => o.id, oi => oi.idOrder, (order, orderItem) => new { Order = order, OrderItem = orderItem })
                .Sum(oi => oi.OrderItem.price);

          

            return dailyProfit;
        }

        public double TotalProfit()
        {
            double totalProfit = _context.Orders
                .Join(_context.OrderItems, o => o.id, oi => oi.idOrder, (order, orderItem) => new { Order = order, OrderItem = orderItem })
                .Sum(oi => oi.OrderItem.price);


            return totalProfit;
        }
        private Drink MostUsedDrink()
        {
            var drinkOrderItems = _context.Drinks
               .Join(
                   _context.OrderItems,
                   d => d.id,
                   o => o.idDrink,
                   (d, o) => new { Drink = d, OrderItem = o }
               )
               .ToList(); // Retrieve the data from the database

            var query = drinkOrderItems
                .GroupBy(x => x.Drink)
                .Select(g => new { Drink = g.Key, OrderItemCount = g.Count() })
                .OrderByDescending(x => x.OrderItemCount)
                .FirstOrDefault();

            return query?.Drink;
        }
        public string MostSoldDrink()
        {
            return MostUsedDrink().name;
        }

        public void Clone()
        {
            Drink drink = MostUsedDrink();
        }
    }
}
