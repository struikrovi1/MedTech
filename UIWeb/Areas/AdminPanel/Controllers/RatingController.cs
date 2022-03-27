using Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UIWeb.Areas.AdminPanel.Controllers
{

    [Area(nameof(AdminPanel))]
    public class RatingController : Controller

        
    {

        private readonly RatingService _ratingservice;
        private readonly ServiceService _service;
        private readonly IWebHostEnvironment _environment;

        public RatingController(RatingService ratingservice, ServiceService service, IWebHostEnvironment environment)
        {
            _ratingservice = ratingservice;
            _service = service;
            _environment = environment;
        }

        // GET: RatingController
        public ActionResult Index()
        {
          
            
            return View(_ratingservice.GetAll());
        }

        // GET: RatingController/Details/5
        public ActionResult Details(int id)
        {

            
            return View(_ratingservice.GetById(id));
        }

        // GET: RatingController/Create
        public ActionResult Create()
        {

            ViewBag.ServiceList = _service.GetAll();
            return View();
        }

        // POST: RatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Rating rating, IFormFile Image)
        {
            string path = "/files" + Guid.NewGuid() + Image.FileName;

            using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
            {
                await Image.CopyToAsync(fileStream);
            };
          
            rating.AuthorPhoto= path;
                _ratingservice.Add(rating);
                return RedirectToAction(nameof(Index));
           
           
        }

        // GET: RatingController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ServiceList = _service.GetAll();
            var collection = _ratingservice.GetById(id);
            return View(collection);
        }

        // POST: RatingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Rating rating, IFormFile Image, string OldPhoto, string OldColor)
        {
            if(rating.Background == null)
            {
                rating.Background = OldColor;
            }
          
     
            if (Image != null)
            {
                string path = "/files" + Guid.NewGuid() + Image.FileName;

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                     Image.CopyToAsync(fileStream);

                };
               rating.AuthorPhoto = path;
            }
            else
            {
               rating.AuthorPhoto = OldPhoto;
            }


            try
            {
                _ratingservice.Update(rating);
               
            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: RatingController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var selectedProduct = _ratingservice.GetById(id.Value);

            if (selectedProduct == null) return NotFound();

            return View(selectedProduct);
           
        }

        // POST: RatingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Rating collection)
        {
            if (id == null) return NotFound();
            if (collection == null) return NotFound();
            try
            {
                _ratingservice.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
