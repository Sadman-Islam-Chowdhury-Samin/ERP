using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Leave
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string LeaveDuration { get; set; }
    }
}