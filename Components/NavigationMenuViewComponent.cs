using assignment_5_real.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ILibroRepository repository;

        public NavigationMenuViewComponent(ILibroRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Libros
                .Select(l => l.BCategory)
                .Distinct()
                .OrderBy(l => l));
        }
    }
}
