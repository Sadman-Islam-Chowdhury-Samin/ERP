using HR.BLL;
using System;
using System.Data;
using System.Web.UI;

namespace HR.UI
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ClearControl()
        {
            txtEmployeeName.Text = string.Empty;
            txtAttendanceDate.Text = string.Empty;
            ddlPresent.SelectedIndex = 0;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = txtEmployeeName.Text;
                DateTime attendanceDate = Convert.ToDateTime(txtAttendanceDate.Text);
                bool isPresent = ddlPresent.SelectedValue == "true";

                AttendanceBLL ObjAttendanceBLL = new AttendanceBLL();
                ObjAttendanceBLL.AddAttendance(employeeName, attendanceDate, isPresent);

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
