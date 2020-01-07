using Microsoft.AspNetCore.Mvc;
using Stopify.Services;
using Stopify.Services.Models;
using Stopify.Web.InputModels;
using System.Threading.Tasks;
using System.Linq;
using Stopify.Web.ViewModels;

namespace Stopify.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var allProductTypes = await this.productService.GetAllProductTypes();

            this.ViewData["types"] = allProductTypes.Select(productType => new ProductCreateProductTypeViewModel
            {
                Name = productType.Name
            }).ToList();

            return this.View();
        }

        [HttpPost(Name = "Create")]
        public async Task<IActionResult> Create(ProductCreateInputModel inputModel)
        {
            ProductServiceModel serviceModel = new ProductServiceModel
            {
                Name = inputModel.Name,
                Price = inputModel.Price,
                Picture = inputModel.Picture,
                ManufacturedOn = inputModel.ManufacturedOn,
                ProdudctType = new ProductTypeServiceModel
                {
                    Name = inputModel.ProductType
                }
            };

            await this.productService.Create(serviceModel);

            return Redirect("/");
        }

        [HttpGet(Name = "CreateType")]
        public async Task<IActionResult> CreateType()
        {
            return this.View();
        }

        [HttpPost(Name ="CreateType")]

        public async Task<IActionResult> CreateType(ProductTypeCreateInputModel inputModel)
        {
            ProductTypeServiceModel productTypeServiceModel = new ProductTypeServiceModel
            {
                Name = inputModel.Name
            };

            await this.productService.CreateProductType(productTypeServiceModel);

            return this.Redirect("/Home/Index");
        }

    }
}