using HR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class EmployeeBLL
    {

        public void AddEmployee(string name, string email, string mobileNumber)
        {
            try
            {
                // Call DAL to save employee
                EmployeeDAL ObjEmployeeDAL = new HR.DAL.EmployeeDAL();
                ObjEmployeeDAL.InsertEmployee(name, email, mobileNumber);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}