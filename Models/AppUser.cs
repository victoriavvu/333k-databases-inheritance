using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Vu_Victoria_HW4.Models
{
    public class AppUser : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName  { get; set; }

    }
}
