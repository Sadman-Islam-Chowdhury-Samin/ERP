using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoToEmployeeInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeInformation.aspx");
        }

        protected void btnGoToCompanySetup_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanySetup.aspx");

        }

        protected void btnGoToDepartmentSetup_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepartmentSetup.aspx");

        }

        protected void btnGoToAttendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("Attendance.aspx");

        }

        protected void btnGoToLeaveApplication_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveApplication.aspx");

        }
    }
}