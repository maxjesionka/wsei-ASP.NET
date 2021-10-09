using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WseiLab7.Controllers
{
    public class ProductsController : Controller
    {
    public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,

            };
            return View(viewModel);
        }

    }
}
