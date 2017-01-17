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
            var model = new ProductViewModel();
            model.BindData();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ProductViewModel inputModel)
        {
            if (inputModel.EventCommand == "add")
            {
                inputModel.EnableDetailView();
            }
            else
            {
                inputModel.BindData();
            }

            return View(inputModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
