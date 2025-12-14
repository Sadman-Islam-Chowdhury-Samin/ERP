//using HR.BLL;
//using System;
//using System.Data;
//using System.Web.UI;

//namespace HR.UI
//{
//    public partial class Attendance : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        private void ClearControl()
//        {
//            txtEmployeeName.Text = string.Empty;
//            txtAttendanceDate.Text = string.Empty;
//            ddlPresent.SelectedIndex = 0;
//        }

//        protected void btnSave_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string employeeName = txtEmployeeName.Text;
//                DateTime attendanceDate = Convert.ToDateTime(txtAttendanceDate.Text);
//                bool isPresent = ddlPresent.SelectedValue == "true";

//                AttendanceBLL ObjAttendanceBLL = new AttendanceBLL();
//                ObjAttendanceBLL.AddAttendance(employeeName, attendanceDate, isPresent);

//                ClearControl();
//            }
//            catch (Exception msgException)
//            {
//                throw msgException;
//            }
//        }

//        protected void btnShow_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                AttendanceBLL ObjAttendanceBLL = new AttendanceBLL();
//                DataTable dtAttendance = ObjAttendanceBLL.ShowAllAttendance();

//                grdAttendance.DataSource = dtAttendance;
//                grdAttendance.DataBind();
//            }
//            catch (Exception msgException)
//            {
//                throw msgException;
//            }
//        }
//    }
//}


using HR.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        private void ClearControl()
        {
            txtEmployeeName.Text = "";
            txtAttendanceDate.Text = "";
            ddlPresent.SelectedIndex = 0;
            txtID.Text = "";
            btnDelete.Visible = false;
        }

        private void ShowAttendance()
        {
            AttendanceBLL objBLL = new AttendanceBLL();
            grdAttendance.DataSource = objBLL.ShowAllAttendance();
            grdAttendance.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AttendanceBLL objBLL = new AttendanceBLL();
            objBLL.AddAttendance(
                txtEmployeeName.Text,
                Convert.ToDateTime(txtAttendanceDate.Text),
                ddlPresent.SelectedValue == "true"
            );

            ShowAttendance();
            ClearControl();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            AttendanceBLL objBLL = new AttendanceBLL();
            objBLL.UpdateAttendance(
                Convert.ToInt32(txtID.Text),
                txtEmployeeName.Text,
                Convert.ToDateTime(txtAttendanceDate.Text),
                ddlPresent.SelectedValue == "true"
            );

            ShowAttendance();
            ClearControl();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            AttendanceBLL objBLL = new AttendanceBLL();
            objBLL.DeleteAttendance(Convert.ToInt32(txtID.Text));

            ShowAttendance();
            ClearControl();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowAttendance();
        }

        protected void grdAttendance_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Select")
            {
                txtEmployeeName.Text = ((Label)grdAttendance.Rows[index].FindControl("lblName")).Text;
                txtAttendanceDate.Text = ((Label)grdAttendance.Rows[index].FindControl("lblDate")).Text;
                ddlPresent.SelectedValue = ((Label)grdAttendance.Rows[index].FindControl("lblPresent")).Text.ToLower();
                txtID.Text = ((Label)grdAttendance.Rows[index].FindControl("lblID")).Text;

                btnDelete.Visible = true;
            }
            else if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(((Label)grdAttendance.Rows[index].FindControl("lblID")).Text);
                new AttendanceBLL().DeleteAttendance(id);
                ShowAttendance();
            }
        }

        protected void grdAttendance_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // REQUIRED to avoid RowDeleting error
        }
    }
}
