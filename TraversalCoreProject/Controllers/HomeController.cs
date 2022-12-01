using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TraversalCorProject.Models;

namespace TraversalCorProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Sayfası Çağrıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            string tarih = DateTime.Now.ToLongDateString();
            _logger.LogInformation($"{tarih} Privacy Sayfası Çağrıldı");
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test Sayfası Çağrıldı");
            _logger.LogError("Error Log Çağrıldı.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
