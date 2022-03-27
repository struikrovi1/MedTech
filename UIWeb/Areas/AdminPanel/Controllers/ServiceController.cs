using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{

    [Area(nameof(AdminPanel))]

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
            return View(_service.GetAll());
            
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {


            return View(_service.GetById(id));
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Service collection)
        {
            try
            {
                _service.Add(collection);

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
            var collection = _service.GetById(id);
            return View(collection);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Service collection)
        {


            try
            {
                _service.Update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var selectedProduct = _service.GetById(id.Value);

            if (selectedProduct == null) return NotFound();

            return View(selectedProduct);
          
        }

        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Service collection)
        {
            if (id == null) return NotFound();
            if (collection == null) return NotFound();
            try
            {

                _service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
