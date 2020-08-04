using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AkhbarWebSite.Models;
using AkhbarWebSite.IServices;

namespace AkhbarWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAkhbarServices akhbarServices;

        public HomeController(ILogger<HomeController> logger, IAkhbarServices akhbarServices)
        {
            _logger = logger;
            this.akhbarServices = akhbarServices;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await akhbarServices.GetCategories();
            return View(categories);
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
