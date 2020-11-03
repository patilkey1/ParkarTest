using System;
using System.Collections.Generic;
using System.Text;

namespace LeaseManagement.ClientModels
{
    public class LeaseViewModel
    {
        public string Street_Address { get; set; }
        public string Appartment_Other { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Int64 Zip_Code { get; set; }
        public decimal Delivery_Fee { get; set; }
        public string Term { get; set; }
    }
}
