using System.Diagnostics;
using DDS.Data;
using DDS.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Idds _dds;

        public HomeController(ILogger<HomeController> logger,Idds dds)
        {
            _logger = logger;
            _dds = dds;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ddsReg dds)
        {
            if (!ModelState.IsValid)
            {
                return View(dds);
            }
            _dds.Insert(dds);

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
