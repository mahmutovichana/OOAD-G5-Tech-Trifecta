using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCafe.Data;
using System;
using System.Linq;

namespace SmartCafe.Controllers
{
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
            var drinks = _context.Drinks.ToList();
            var orderItems = _context.OrderItems.ToList();
            ViewBag.Drinks = drinks;
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

        // GET: BartenderPanelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BartenderPanelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: BartenderPanelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BartenderPanelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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

    }
}
