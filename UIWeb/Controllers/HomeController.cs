using Entitites;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;
using UIWeb.Models;
using UIWeb.ViewModels;

namespace UIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HeaderService _oneservice;
        private readonly ServiceService _servservice;
        private readonly RatingService _ratingservice;
        private readonly GearService _gearservice;
        private readonly NewsService _newsservice;
        private readonly ReguestService _requestservice;
        private readonly TeamService _teamservice;


        public HomeController(ILogger<HomeController> logger, HeaderService oneservice, ServiceService servservice, RatingService ratingservice, GearService gearservice, NewsService newsservice, ReguestService requestService, TeamService teamservice)
        {
            _logger = logger;
            _oneservice = oneservice;
            _servservice = servservice;
            _ratingservice = ratingservice;
            _gearservice = gearservice;
            _newsservice = newsservice;
            _requestservice = requestService;
            _teamservice = teamservice;
        }

        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                Header = _oneservice.GetAll().FirstOrDefault(),
                Service = _servservice.GetAll(),
                Rating = _ratingservice.GetAll(),
                Gears = _gearservice.GetAll().FirstOrDefault(),
                News = _newsservice.GetAll(),
                Reguests = _requestservice.GetAll(),
                Teams = _teamservice.GetAll(),

            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(Reguest reguest)
        {
           
            _requestservice.Add(reguest);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}