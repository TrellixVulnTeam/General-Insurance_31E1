﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace General_InsuranceFinal.Models
{
    public partial class Vehicletypes
    {
        public Vehicletypes()
        {
            Policydetails = new HashSet<Policydetails>();
            Vehiclesdetails = new HashSet<Vehiclesdetails>();
        }

        public string VehicleType { get; set; }
        public int VehicleTypeId { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
        public virtual ICollection<Vehiclesdetails> Vehiclesdetails { get; set; }
    }
}
