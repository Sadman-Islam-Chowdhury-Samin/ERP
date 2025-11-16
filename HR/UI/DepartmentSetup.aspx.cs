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
                //string departmentName = txtDepartmentName.Text;
                //string employeeNumber = txtEmployeeNumber.Text;


                //DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                //ObjDepartmentBLL.AddDepartment(departmentName, employeeNumber);

                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                ObjDepartmentBLL.AddDepartment(txtDepartmentName.Text, txtEmployeeNumber.Text);

                ShowDepartment();
                ClearControl();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowDepartment();
        }

        private void ShowDepartment()
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


                ShowDepartment();
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

        protected void grdDepartment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Select")
            {
                txtDepartmentName.Text = ((Label)grdDepartment.Rows[index].FindControl("lblDeptName")).Text;
                txtEmployeeNumber.Text = ((Label)grdDepartment.Rows[index].FindControl("lblEmpNumber")).Text;
                txtID.Text = ((Label)grdDepartment.Rows[index].FindControl("lblID")).Text;
            }
            else if (e.CommandName == "Delete")
            {
                DepartmentBLL ObjDepartmentBLL = new DepartmentBLL();
                int id = Convert.ToInt32(((Label)grdDepartment.Rows[index].FindControl("lblID")).Text);
                ObjDepartmentBLL.DeleteDepartment(id);

                ShowDepartment();
            }
        }

        protected void grdDepartment_RowDeleting(object sender, GridViewDeleteEventArgs e) { 
        }
    }
}