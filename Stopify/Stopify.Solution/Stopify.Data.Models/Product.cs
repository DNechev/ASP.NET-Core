using System;
using System.Collections.Generic;
using System.Text;

namespace Stopify.Data.Models
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ProductType ProdudctType { get; set; }

        public int ProdudctTypeId { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public DateTime ManufacturedOn { get; set; }
    }
}
