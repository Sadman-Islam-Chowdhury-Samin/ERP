using HR.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void grdLeave_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // REQUIRED to avoid runtime error
            // Actual delete is handled in RowCommand
        }

        private void ClearControl()
        {
            txtEmployeeName.Text = "";
            txtLeaveDuration.Text = "";
            txtID.Text = "";
            btnDelete.Visible = false;
        }

        private void ShowLeave()
        {
            LeaveBLL objLeaveBLL = new LeaveBLL();
            grdLeave.DataSource = objLeaveBLL.ShowAllLeaves();
            grdLeave.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            LeaveBLL objLeaveBLL = new LeaveBLL();
            objLeaveBLL.AddLeave(txtEmployeeName.Text, txtLeaveDuration.Text);

            ShowLeave();
            ClearControl();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowLeave();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            LeaveBLL objLeaveBLL = new LeaveBLL();
            objLeaveBLL.UpdateLeave(
                Convert.ToInt32(txtID.Text),
                txtEmployeeName.Text,
                txtLeaveDuration.Text
            );

            ShowLeave();
            ClearControl();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LeaveBLL objLeaveBLL = new LeaveBLL();
            objLeaveBLL.DeleteLeave(Convert.ToInt32(txtID.Text));

            ShowLeave();
            ClearControl();
        }

        protected void grdLeave_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Select")
            {
                txtEmployeeName.Text =
                    ((Label)grdLeave.Rows[index].FindControl("lblName")).Text;

                txtLeaveDuration.Text =
                    ((Label)grdLeave.Rows[index].FindControl("lblDuration")).Text;

                txtID.Text =
                    ((Label)grdLeave.Rows[index].FindControl("lblID")).Text;

                btnDelete.Visible = true;
            }
            else if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(
                    ((Label)grdLeave.Rows[index].FindControl("lblID")).Text);

                LeaveBLL objLeaveBLL = new LeaveBLL();
                objLeaveBLL.DeleteLeave(id);

                ShowLeave();
            }
        }
    }
}
