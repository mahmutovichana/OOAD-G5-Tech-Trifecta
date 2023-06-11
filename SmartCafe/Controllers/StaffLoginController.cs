using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartCafe.Controllers
{
    public class StaffLoginController : Controller
    {
        private bool prijavaUspela;

        // GET: StaffLoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StaffLoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffLoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffLoginController/Create
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

        // GET: StaffLoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffLoginController/Edit/5
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

        // GET: StaffLoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffLoginController/Delete/5
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

        // GET: StaffLoginController/Login
        public ActionResult Login()
        {
            return View();
        }
    }
}
