using HR.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = txtEmployeeName.Text;
                string employeeEmail = txtEmail.Text;
                string employeeMobileNumber = txtMobileNumber.Text;

                EmployeeBLL ObjEmployeeBLL = new EmployeeBLL();
                ObjEmployeeBLL.AddEmployee(employeeName, employeeEmail, employeeMobileNumber);


                ClearControl();
            }
            catch (Exception msgException)
            {

                throw msgException;
            } 
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
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtID.Text = string.Empty;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = txtEmployeeName.Text;
                string employeeEmail = txtEmail.Text;
                string employeeMobileNumber = txtMobileNumber.Text;
                int employeeID = Convert.ToInt32(txtID.Text);

                EmployeeBLL ObjEmployeeBLL = new EmployeeBLL();
                ObjEmployeeBLL.UpdateEmployee(employeeID, employeeName, employeeEmail, employeeMobileNumber);


                ClearControl();
            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
   
                int employeeID = Convert.ToInt32(txtID.Text);

                EmployeeBLL ObjEmployeeBLL = new EmployeeBLL();
                ObjEmployeeBLL.DeleteEmployee(employeeID);

                ClearControl();
            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeBLL ObjEmployeeBLL = new EmployeeBLL();
                DataTable dtEmployee = ObjEmployeeBLL.ShowAllEmployees();

                grdEmployee.DataSource = dtEmployee;
                grdEmployee.DataBind();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }
    }
}