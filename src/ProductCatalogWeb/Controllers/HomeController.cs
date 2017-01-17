using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogWeb.Models;

namespace ProductCatalogWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = new TrainingProductManager();

            var model = new ProductViewModel();
            model.TrainingProducts = data.Get();

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
