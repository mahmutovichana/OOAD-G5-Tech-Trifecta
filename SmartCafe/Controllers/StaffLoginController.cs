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

        // POST: StaffLoginController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection collection)
        {
            try
            {
                // Proverite korisničke podatke i izvršite logiku prijave

                // Na osnovu rezultata prijave, možete preusmeriti korisnika na odgovarajuću stranicu
                // Na primer:
                if (prijavaUspela)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // U slučaju neuspešne prijave, možete prikazati odgovarajuću poruku ili vratiti korisnika na istu stranicu za prijavu
                    ModelState.AddModelError("", "Pogrešno korisničko ime ili lozinka");
                    return View();
                }
            }
            catch
            {
                // U slučaju greške, prikažite odgovarajuću poruku ili vratite korisnika na istu stranicu za prijavu
                ModelState.AddModelError("", "Došlo je do greške prilikom prijave");
                return View();
            }
        }
    }
}
