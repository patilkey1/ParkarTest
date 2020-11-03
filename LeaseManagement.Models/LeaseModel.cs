using System;
using System.Collections.Generic;
using System.Text;

namespace LeaseManagement.Models
{
    public class LeaseModel
    {
        public string streetaddress { get; set; }
        public string appartment { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Int64 zipcode { get; set; }
        public decimal deliveryfee { get; set; }
        public string term { get; set; }
    }
}
