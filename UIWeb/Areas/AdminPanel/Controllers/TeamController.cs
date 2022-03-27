using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{


    [Area(nameof(AdminPanel))]
    public class TeamController : Controller
    {
        public readonly TeamService _teamService;
        public readonly IWebHostEnvironment _environment;

        public TeamController(TeamService teamService, IWebHostEnvironment environment)
        {
            _teamService = teamService;
            _environment = environment;
        }

        // GET: TeamController
        public ActionResult Index()
        {
            var team = _teamService.GetAll();
            return View(team);
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {
            return View(_teamService.GetById(id));
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Team team, IFormFile Image)
        {
            string path = "/files" + Guid.NewGuid() + Image.FileName;

            using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
            {
                await Image.CopyToAsync(fileStream);
            };

            team.PhotoUrl = path;
            _teamService.Add(team); 
            return RedirectToAction(nameof(Index));


        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_teamService.GetById(id));
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Team team, IFormFile Image, string OldPhoto)
        {


            if (Image != null)
            {
                string path = "/files" + Guid.NewGuid() + Image.FileName;

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    Image.CopyToAsync(fileStream);

                };
                team.PhotoUrl = path;
            }
            else
            {
                team.PhotoUrl = OldPhoto;
            }


            try
            {
                _teamService.Update(team);

            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Team team)
        {
            if (id == null) return NotFound();
            if (team == null) return NotFound();
            try
            {
                _teamService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
