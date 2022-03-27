using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ServiceService _service;

        public ServiceController(ServiceService service)
        {
            _service = service;
        }
        // GET: ServiceController
        public ActionResult Index()
        {
            ServiceIndexVM courseVM = new()
            {
                Services = _service.GetAll(),
            };
            return View(courseVM);

           
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceController/Create
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

        // GET: ServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServiceController/Edit/5
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

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServiceController/Delete/5
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
