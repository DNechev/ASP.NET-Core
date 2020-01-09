using Microsoft.AspNetCore.Http;
using System;

namespace Stopify.Services.Models
{
    public class ProductServiceModel
    {
        public string Name { get; set; }

        public ProductTypeServiceModel ProdudctType { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public DateTime ManufacturedOn { get; set; }
    }
}
