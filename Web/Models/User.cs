﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class User : IdentityUser<int>
    {
        public int Year { get; set; }
        public List<Order> Orders { get; set; }
    }
}