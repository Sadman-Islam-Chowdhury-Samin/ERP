using HR.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class CompanySetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private static void ExecuteSql(string sql)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
                var myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                new SqlCommand(sql, myConnection).ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        private void ClearControl()
        {
            txtCompanyName.Text = string.Empty;
            txtCompanyEmail.Text = string.Empty;
            txtCompanyAddress.Text = string.Empty;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyBLL ObjCompanyBLL = new CompanyBLL();
                DataTable dtCompany = ObjCompanyBLL.ShowAllCompany();

                grdShow.DataSource = dtCompany;
                grdShow.DataBind();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ecompanyName = txtCompanyName.Text;
                string companyEmail = txtCompanyEmail.Text;
                string companyAddress = txtCompanyAddress.Text;

                CompanyBLL ObjCompanyBLL = new CompanyBLL();
                ObjCompanyBLL.AddCompany(ecompanyName, companyAddress, companyEmail);


                ClearControl();
            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }
    }
}