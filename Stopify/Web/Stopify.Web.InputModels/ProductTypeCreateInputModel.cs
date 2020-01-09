using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stopify.Web.InputModels
{
    public class ProductTypeCreateInputModel
    {
        [Required]
        public string Name { get; set; }
    }
}
