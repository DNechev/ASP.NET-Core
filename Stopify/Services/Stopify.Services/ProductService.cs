using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stopify.Data;
using Stopify.Data.Models;
using Stopify.Services.Models;

namespace Stopify.Services
{
    public class ProductService : IProductService
    {
        private readonly StopifyDbContext context;

        public ProductService(StopifyDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(ProductServiceModel inputModel)
        {
            Product product = new Product
            {
                Name = inputModel.Name,
                Price = inputModel.Price,
                ManufacturedOn = inputModel.ManufacturedOn,
                ProdudctType = new ProductType
                {
                    Name = inputModel.ProdudctType.Name
                }
            };

            await context.Products.AddAsync(product);
            int result = await context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> CreateProductType(ProductTypeServiceModel inputModel)
        {
            ProductType productType = new ProductType
            {
                Name = inputModel.Name
            };

            await context.ProductTypes.AddAsync(productType);
            int result = await context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IEnumerable<ProductTypeServiceModel>> GetAllProductTypes()
        {
            return await this.context.ProductTypes.Select(x => new ProductTypeServiceModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
