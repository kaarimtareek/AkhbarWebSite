using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using AkhbarWebSite.DTOs.Category;
using AkhbarWebSite.IServices;
using AkhbarWebSite.Models;
using AkhbarWebSite.Validators;
using AkhbarWebSite.ViewModels.Home;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AkhbarWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAkhbarServices akhbarServices;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IAkhbarServices akhbarServices, IMapper mapper)
        {
            _logger = logger;
            this.akhbarServices = akhbarServices;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var entities = await akhbarServices.GetCategories();
            var categories = mapper.Map<IEnumerable<CategoryDto>>(entities);
            //for validating categories ,this method can be used to validate another dtos 
            //var categoryValidator = new CategoryValidator();
            //foreach (var category in categories)
            //{
            //    var result = categoryValidator.Validate(category);
            //}
            var viewModel = new IndexViewModel
            {
                Categories = categories
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
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