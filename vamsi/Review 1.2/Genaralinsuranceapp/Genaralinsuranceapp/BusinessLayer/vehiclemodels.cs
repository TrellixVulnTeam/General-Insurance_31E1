﻿using System;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class vehiclemodels
    {
        public string Manufacturer { get; set; }
        public long? CustomerId { get; set; }
        public string VehicleType { get; set; }
        public int? PolicyNumber { get; set; }
        public string Model { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Policydetails PolicyNumberNavigation { get; set; }
    }
}
