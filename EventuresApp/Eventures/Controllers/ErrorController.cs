using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ErrorMessage()
        {
            return this.View();
        }
    }
}
