using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Models.BindingModels
{
    public class EventCreateBindingModel
    {
        [Required]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start")]
        [DataType(DataType.DateTime)]

        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "End")]
        [DataType(DataType.DateTime)]
        public DateTime End { get; set; }

        [Required]
        [Display(Name = "TotalTickets")]
        [Range(0, int.MaxValue, ErrorMessage = "Total tickets must be possitive!")]
        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "PricePerTicket")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be possitive!")]
        public decimal PricePerTicket { get; set; }
    }
}
