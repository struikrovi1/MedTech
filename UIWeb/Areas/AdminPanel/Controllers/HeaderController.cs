using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class HeaderController : Controller
    {

        private readonly HeaderService _service;

        public HeaderController(HeaderService service)
        {
            _service = service;
        }

        // GET: HeaderController
        public ActionResult Index()
        {
            var header = _service.GetAll();
            if (header.Count > 0)
            {
                ViewBag.Sayi = 1;
            }
            else
            {
                ViewBag.Sayi = 0;
            }
           
            return View(header);
        }

        // GET: HeaderController/Details/5
        public ActionResult Details(int id)
        {

            
            return View(_service.GetById(id));
        }

        // GET: HeaderController/Create
        public ActionResult Create()
        {
            var header = _service.GetAll();
            if (header.Count > 0)
            {
                return RedirectToAction(nameof(Index));
            }
           
            return View();
        }

        // POST: HeaderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Header collection)
        {

            _service.Add(collection);
            
           
                return RedirectToAction(nameof(Index));
           
        }

        // GET: HeaderController/Edit/5
        public ActionResult Edit(int id)
        {

           
            return View(_service.GetById(id));
        }

        // POST: HeaderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Header collection)
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

        // GET: HeaderController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var selectedProduct = _service.GetById(id.Value);

            if (selectedProduct == null) return NotFound();

            return View(selectedProduct);
        }

        // POST: HeaderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Header collection)
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
