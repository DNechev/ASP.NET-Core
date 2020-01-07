using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Stopify.Data.Models
{
    public class StopifyUser : IdentityUser
    {
        public StopifyUser()
        {
        }

        public string FullName { get; set; }
    }
}
