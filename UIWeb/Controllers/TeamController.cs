using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class TeamController : Controller
    {


        private readonly TeamService _tservice;

        public TeamController(TeamService tservice)
        {
            _tservice = tservice;
        }

        // GET: TeamController
        public ActionResult Index()
        {
            TeamVM courseVM = new()
            {
               Teams = _tservice.GetAll(),
            };
            return View(courseVM);
           
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int? id)
        {
            TeamDetailVM teamDetailVM = new()
            {
                SingleTeam = _tservice.GetById(id.Value),
            };

            return View(teamDetailVM);
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController/Create
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

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamController/Edit/5
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

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController/Delete/5
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
