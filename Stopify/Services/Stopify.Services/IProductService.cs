using Stopify.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stopify.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductServiceModel>> GettAllProducts();
        Task<IEnumerable<ProductTypeServiceModel>> GetAllProductTypes();
        Task<bool> Create(ProductServiceModel inputModel);
        Task<bool> CreateProductType(ProductTypeServiceModel inputModel);
    }
}
