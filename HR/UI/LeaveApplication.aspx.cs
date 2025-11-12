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
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            txtEmployeeName.Text = string.Empty;
            txtLeaveDuration.Text = string.Empty;
            txtID.Text = string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = txtEmployeeName.Text;
                string duration = txtLeaveDuration.Text;

                LeaveBLL ObjLeaveBLL = new LeaveBLL();
                ObjLeaveBLL.AddLeave(employeeName, duration);


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
                LeaveBLL ObjLeaveBLL = new LeaveBLL();
                DataTable dtLeave = ObjLeaveBLL.ShowAllLeaves();

                grdLeave.DataSource = dtLeave;
                grdLeave.DataBind();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }

        
    }
}