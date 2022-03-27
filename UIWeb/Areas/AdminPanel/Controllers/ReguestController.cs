using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class ReguestController : Controller
    {
        public ReguestService ReguestService { get; }

        public ReguestController(ReguestService reguestService)
        {
            ReguestService = reguestService;
        }

        // GET: ReguestController
        public ActionResult Index()
        {
            return View(ReguestService.GetAll());
        }

        // GET: ReguestController/Details/5
        public ActionResult Details(int id)
        {

            return View(ReguestService.GetById(id));    
          
        }

        // GET: ReguestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReguestController/Create
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

        // GET: ReguestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReguestController/Edit/5
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

        // GET: ReguestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReguestController/Delete/5
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
