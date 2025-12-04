using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class HRContext : DbContext
    {
        public HRContext() : base("dberpbatch2connection")
        {

        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<User> Users { get; set; }


    }
}