using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Services;
using UIWeb.Areas.AdminPanel.ViewModels;

namespace UIWeb.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class DashboardController : Controller
    {
        private readonly MedDBContext _context;
        private readonly ReguestService _reguestService;

        public DashboardController(MedDBContext context, ReguestService reguestService)
        {
            _context = context;
            _reguestService = reguestService;
        }

        public IActionResult Index()
        {
            var mail = _reguestService.GetAll();
            if (mail.Count > 0)
            {
                ViewBag.Sayi = 1;
            }
            else
            {
                ViewBag.Sayi = 0;
            }

            DashboardVM vm = new()
            {
                ServiceCount = _context.Services.Count(),
                RatingCount = _context.Ratings.Count(),
                MailCount = _context.Reguests.Count(),
                TeamCount = _context.Teams.Count(),
                NewsCount = _context.News. Count(),
            };
            return View(vm);

            
        }
    }
}
