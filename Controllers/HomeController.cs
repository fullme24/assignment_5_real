﻿using assignment_5_real.Models;
using assignment_5_real.Models.ViewModels;
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

        //this part sets up how many books we will display per page
        public int PageSize = 5;

        //in the contructor we added some pertanent some peramitors needed and we set _repository
        public HomeController(ILogger<HomeController> logger, ILibroRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Here is this method we return the main view and send 
        //the object that contains the information we need to populate our page with books and pagination
        public IActionResult Index(int page = 1)
        {
            return View(new ProjectListViewModel
            {
                Libros = _repository.Libros
                    .OrderBy(p => p.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Libros.Count()
                }
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
