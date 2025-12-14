using HR.BLL;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class CompanySetup : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void ClearControl()
        {
            txtCompanyName.Text = string.Empty;
            txtCompanyAddress.Text = string.Empty;
            txtCompanyEmail.Text = string.Empty;
            txtID.Text = string.Empty;
        }

        private void ShowCompany()
        {
            CompanyBLL objBLL = new CompanyBLL();
            DataTable dt = objBLL.ShowAllCompany();
            grdCompany.DataSource = dt;
            grdCompany.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CompanyBLL objBLL = new CompanyBLL();
            objBLL.AddCompany(
                txtCompanyName.Text,
                txtCompanyAddress.Text,
                txtCompanyEmail.Text);

            ShowCompany();
            ClearControl();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowCompany();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            CompanyBLL objBLL = new CompanyBLL();
            objBLL.UpdateCompany(
                Convert.ToInt32(txtID.Text),
                txtCompanyName.Text,
                txtCompanyAddress.Text,
                txtCompanyEmail.Text);

            ShowCompany();
            ClearControl();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CompanyBLL objBLL = new CompanyBLL();
            objBLL.DeleteCompany(Convert.ToInt32(txtID.Text));

            ShowCompany();
            ClearControl();
        }

        protected void grdCompany_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Select")
            {
                txtCompanyName.Text =
                    ((Label)grdCompany.Rows[index].FindControl("lblName")).Text;
                txtCompanyAddress.Text =
                    ((Label)grdCompany.Rows[index].FindControl("lblAddress")).Text;
                txtCompanyEmail.Text =
                    ((Label)grdCompany.Rows[index].FindControl("lblEmail")).Text;
                txtID.Text =
                    ((Label)grdCompany.Rows[index].FindControl("lblID")).Text;

                btnDelete.Visible = true;
            }
            else if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(
                    ((Label)grdCompany.Rows[index].FindControl("lblID")).Text);

                CompanyBLL objBLL = new CompanyBLL();
                objBLL.DeleteCompany(id);

                ShowCompany();
            }
        }

        protected void grdCompany_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // required but handled in RowCommand
        }
    }
}
