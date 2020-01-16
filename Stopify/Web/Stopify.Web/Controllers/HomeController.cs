using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stopify.Services;
using Stopify.Web.Models;
using Stopify.Web.ViewModels.Home.Index;

namespace Stopify.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productservice;

        public HomeController(IProductService productservice)
        {
            this.productservice = productservice;
        }

        public async Task<IActionResult> Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var productTypeServiceModels = this.productservice.GetAllProductTypes();

                List<ProductHomeViewModel> productHomeViewModels = await productTypeServiceModels
                    .Select(product => new ProductHomeViewModel
                    {
                    }).ToList();
            }

            return View();
        }
    }
}
