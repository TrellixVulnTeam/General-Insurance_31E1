﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class Login
    {
        public Login()
        {
            CustomerRegistration = new HashSet<CustomerRegistration>();
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CustomerRegistration> CustomerRegistration { get; set; }
    }
}
