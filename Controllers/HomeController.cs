using assignment_5_real.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //created the object that will hold our repository information
        private ILibroRepository _repository;

        //in the contructor we added some pertanent some peramitors needed and we set _repository
        public HomeController(ILogger<HomeController> logger, ILibroRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Here is this method we return the main view and send 
        //the _repository object with it to populate the main page/table
        public IActionResult Index()
        {
            return View(_repository.Libros);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
