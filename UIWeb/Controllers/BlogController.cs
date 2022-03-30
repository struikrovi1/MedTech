using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class BlogController : Controller
    {

        private readonly BlogService _blogservice;
        private readonly TagService _tagService;
        private readonly MedDBContext _context;


        public BlogController(BlogService blogservice, TagService tagService, MedDBContext context)
        {
            _blogservice = blogservice;
            _tagService = tagService;
            _context = context;
        }

        // GET: BlogController
        public ActionResult Index(int? id, string searchText)
        {

            var blogs = _context.Blogs.Include(x => x.Tag).AsQueryable();

            if (id != null)
            {
                blogs = blogs.Where(x => x.TagId == id);
            }
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                blogs = blogs.Where(c => c.Title.Contains(searchText));
            }

            BlogVM bvm = new()
            {
                Blogs = blogs.ToList(),
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
