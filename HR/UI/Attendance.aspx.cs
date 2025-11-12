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
    public partial class Attendance : System.Web.UI.Page
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
            txtDay1.Text = string.Empty;
            txtID.Text = string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = txtEmployeeName.Text;
                string day1 = txtDay1.Text;

                AttendanceBLL ObjAttendanceBLL = new AttendanceBLL();
                ObjAttendanceBLL.AddAttendance(employeeName, day1);


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
                AttendanceBLL ObjAttendanceBLL = new AttendanceBLL();
                DataTable dtAttendance = ObjAttendanceBLL.ShowAllAttendance();

                grdAttendance.DataSource = dtAttendance;
                grdAttendance.DataBind();

            }
            catch (Exception msgException)
            {

                throw msgException;
            }
        }
    }
}