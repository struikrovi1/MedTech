using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{

    [Area(nameof (AdminPanel))]
    public class GearController : Controller
    {

        private readonly GearService _gservice;

        public GearController(GearService gservice)
        {
            _gservice = gservice;
        }

        // GET: GearController
        public ActionResult Index()
        {
            var gear = _gservice.GetAll();
            if (gear.Count != 0)
            {
                ViewBag.Sayi = 1;
            }
            else
            {
                ViewBag.Sayi = 0;
            }

            return View(gear);
        }

        // GET: GearController/Details/5
        public ActionResult Details(int? id)
        {
            return View(_gservice.GetById(id));
        }

        // GET: GearController/Create
        public ActionResult Create()
        { 
            return View();
        }

        // POST: GearController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Gear collection)
        {

            _gservice.Add(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GearController/Edit/5
        public ActionResult Edit(int id)
        {
            var collection = _gservice.GetById(id);
            return View(collection);
        }

        // POST: GearController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Gear collection)
        {

           
            try
            {
                _gservice.Update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GearController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var selectedProduct = _gservice.GetById(id.Value);

            if (selectedProduct == null) return NotFound();

            return View(selectedProduct);
            
        }

        // POST: GearController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Gear collection)
        {
            if (id == null) return NotFound();
            if (collection == null) return NotFound();
            try
            {
                _gservice.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
