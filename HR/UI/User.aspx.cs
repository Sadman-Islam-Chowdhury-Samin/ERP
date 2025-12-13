using HR.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            UserBLL objUserBLL = new UserBLL();
            bool isValid = objUserBLL.Login(username, password);

            if (isValid)
            {
                // OPTIONAL: keep session
                Session["Username"] = username;

                // 🔴 THIS IS THE REDIRECT YOU WANT
                Response.Redirect("~/UI/StartPage.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }
        }
    }
}