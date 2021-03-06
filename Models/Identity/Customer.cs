﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularClient.Models.Identity
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public ApplicationUser Identity { get; set; }  // navigation property
        public string Gender { get; set; }
    }
}
