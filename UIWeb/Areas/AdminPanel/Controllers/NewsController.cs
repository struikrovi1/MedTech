using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class NewsController : Controller
    {

        private readonly NewsService _nservice;
        private readonly IWebHostEnvironment _environment;

        public NewsController(NewsService nservice, IWebHostEnvironment environment)
        {
            _nservice = nservice;
            _environment = environment;
        }

        // GET: NewsController
        public ActionResult Index()
        {
            return View(_nservice.GetAll());
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_nservice.GetById(id));
        }

        // GET: NewsController/Create
        public ActionResult Create(int id)
        {
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> CreateAync(News news, IFormFile Image)
        {

            string path = "/files" + Guid.NewGuid() + Image.FileName;

            using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
            {
                await Image.CopyToAsync(fileStream);
            };


            news.PhotoUrl = path;
            news.CreatedTime = DateTime.Now;
            news.CommentsCount = 3;
            _nservice.Add(news);
            return RedirectToAction(nameof(Index));


           
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController/Edit/5
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

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController/Delete/5
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
