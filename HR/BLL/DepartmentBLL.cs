using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class DepartmentBLL
    {

        public void AddDepartment(string departmentName, string employeeNumber)
        {
            try
            {
                // Call DAL to save department
                DepartmentDAL ObjDepartmentDAL = new HR.DAL.DepartmentDAL();
                ObjDepartmentDAL.InsertDepartment(departmentName, employeeNumber);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllDepartments()
        {
            try
            {
                DepartmentDAL ObjDepartmentDAL = new HR.DAL.DepartmentDAL();
                return ObjDepartmentDAL.ShowAllDepartments();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void UpdateDepartment(int id, string departmentName, string employeeNumber)
        {
            try
            {
                DepartmentDAL ObjDepartmentDAL = new DepartmentDAL();
                ObjDepartmentDAL.UpdateDepartment(id, departmentName, employeeNumber);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void DeleteDepartment(int ID)
        {
            try
            {
                // Call DAL to delete employee
                DepartmentDAL ObjDepartmentDAL = new HR.DAL.DepartmentDAL();
                ObjDepartmentDAL.DeleteDepartment(ID);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}