﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class Login
    {
        public int? UserId { get; set; }
        public string Password { get; set; }
        public int LoginId { get; set; }

        public virtual CustomerRegistration User { get; set; }
    }
}
