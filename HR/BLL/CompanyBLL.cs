using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace HR.BLL
{
    public class CompanyBLL
    {
        public void AddCompany(string name, string address, string email)
        {
            try
            {
                CompanyDAL ObjCompanyDAL = new HR.DAL.CompanyDAL();
                ObjCompanyDAL.InsertCompany(name, address, email);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllCompany()
        {
            try
            {
                CompanyDAL ObjCompanyDAL = new HR.DAL.CompanyDAL();
                return ObjCompanyDAL.ShowAllCompany();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void UpdateCompany(int id, string name, string address, string email)
        {
            try
            {
                CompanyDAL objDAL = new CompanyDAL();
                objDAL.UpdateCompany(id, name, address, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCompany(int id)
        {
            try
            {
                CompanyDAL objDAL = new CompanyDAL();
                objDAL.DeleteCompany(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}