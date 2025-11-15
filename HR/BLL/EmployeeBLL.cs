using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL ObjEmployeeDAL;

        public void AddEmployee(string name, string email, string mobileNumber)
        {
            try
            {
                // Call DAL to save employee
                ObjEmployeeDAL = new HR.DAL.EmployeeDAL();
                ObjEmployeeDAL.InsertEmployee(name, email, mobileNumber);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void UpdateEmployee(int id, string name, string email, string mobileNumber)
        {
            try
            {
                EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
                ObjEmployeeDAL.UpdateEmployee(id, name, email, mobileNumber);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            try
            {
                // Call DAL to delete employee
                EmployeeDAL ObjEmployeeDAL = new HR.DAL.EmployeeDAL();
                ObjEmployeeDAL.DeleteEmployee(employeeID);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllEmployees()
        {
            try
            {
                EmployeeDAL ObjEmployeeDAL = new HR.DAL.EmployeeDAL();
                return ObjEmployeeDAL.ShowAllEmployees();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }




    }
}