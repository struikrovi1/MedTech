using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Controllers
{
    public class ReguestController : Controller
    {

        private readonly ReguestService _rservice;
        private readonly ServiceService _service;
        private readonly TeamService _teamService;

        public ReguestController(ReguestService rservice, ServiceService service, TeamService teamService)
        {
            _rservice = rservice;
            _service = service;
            _teamService = teamService;
        }

        // GET: ReguestController


        
        public ActionResult Index()
        {
           
            return View();
        }


        // GET: ReguestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

    internal class RequestVM
    {
    }
}
