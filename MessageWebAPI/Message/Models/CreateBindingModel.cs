using Message.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message.Models
{
    public class CreateBindingModel
    {
        public string Content { get; set; }

        public User User { get; set; }

    }
}
