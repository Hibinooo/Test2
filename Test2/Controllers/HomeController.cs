using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestDb2Context testDb2Context;

        public HomeController(ILogger<HomeController> logger, TestDb2Context testDb2Context)
        {
            _logger = logger;
            this.testDb2Context = testDb2Context;
        }

        public IActionResult Index()
        {
            var customer = testDb2Context.Brands.ToList();

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