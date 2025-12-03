using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceID { get; set; }

        public string EmployeeName { get; set; }

        [DataType(DataType.Date)]
        public DateTime AttendanceDate { get; set; }

        public bool IsPresent { get; set; }
    }
}