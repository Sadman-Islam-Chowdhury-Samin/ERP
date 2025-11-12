using HR.BLL;
using HR.DAL;
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
    public partial class DepartmentSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEmployeeNumber_TextChanged(object sender, EventArgs e)
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
            txtDepartmentName.Text = string.Empty;
            txtEmployeeNumber.Text = string.Empty;
            txtID.Text = string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentName = txtDepartmentName.Text;
                string employeeNumber = txtEmployeeNumber.Text;


                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                ObjDepartmentBLL.AddDepartment(departmentName, employeeNumber);


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
                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                DataTable dtDepartment = ObjDepartmentBLL.ShowAllDepartments();

                grdDepartment.DataSource = dtDepartment;
                grdDepartment.DataBind();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentName = txtDepartmentName.Text;
                string employeeNumber = txtEmployeeNumber.Text;
                int departmentID = Convert.ToInt32(txtID.Text);

                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                ObjDepartmentBLL.UpdateDepartment(departmentID, departmentName, employeeNumber);


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

                int ID = Convert.ToInt32(txtID.Text);

                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                ObjDepartmentBLL.DeleteDepartment(ID);

                ClearControl();
            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }
    }
}