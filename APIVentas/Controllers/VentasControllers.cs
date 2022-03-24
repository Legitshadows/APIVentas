using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    public class VentasControllers : Controller
    {
        // GET: VentasControllers
        public ActionResult Index()
        {
            return View();
        }

        // GET: VentasControllers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VentasControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VentasControllers/Create
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

        // GET: VentasControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VentasControllers/Edit/5
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

        // GET: VentasControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VentasControllers/Delete/5
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
