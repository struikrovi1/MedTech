using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class BlogController : Controller
    {

        private readonly BlogService _blogservice;
        private readonly TagService _tagService;


        public BlogController(BlogService blogservice, TagService tagService)
        {
            _blogservice = blogservice;
            _tagService = tagService;
        }

        // GET: BlogController
        public ActionResult Index()
        {
            

            BlogVM bvm = new()
            {
                Blogs = _blogservice.GetAll(),
               Tag = _tagService.GetAll(),
            };
            return View(bvm);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int? id)
        {
            //BlogDetailVM bwm = new()
            //{
            //    SingleBlog = _blogservice.GetById(id.Value);
            //};

            return View();
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
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

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
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

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
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
