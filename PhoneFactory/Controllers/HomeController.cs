using Microsoft.AspNetCore.Mvc;
using PhoneFactory.Factories;
using PhoneFactory.Models;
using System.Diagnostics;

namespace PhoneFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPhoneFactory _phonefactory;

        public HomeController(ILogger<HomeController> logger, IPhoneFactory phonefactory)
        {
            _logger = logger;
            _phonefactory = phonefactory;
        }

        public IActionResult Index()
        {
            var phone = _phonefactory.CreatePhone();
            ViewBag.PhoneDetails = phone.GetModelDetails();
            return View();
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
