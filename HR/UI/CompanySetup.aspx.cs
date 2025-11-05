using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class CompanySetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            lblCompanyName.Text = "Company Name: " + companyName;
        }

        protected void btnShowAddress_Click(object sender, EventArgs e)
        {
            string companyAddress = txtCompanyAddress.Text;
            lblCompanyAddress.Text = "Address: " + companyAddress;
        }

        protected void btnShowContact_Click(object sender, EventArgs e)
        {
            string companyContact = txtCompanyContact.Text;
            lblCompanyContact.Text = "Contact: " + companyContact;
        }

        protected void btnShowEmail_Click(object sender, EventArgs e)
        {
            string companyEmail = txtCompanyEmail.Text;
            lblCompanyEmail.Text = "Email: " + companyEmail;
        }

        protected void btnShowEstablished_Click(object sender, EventArgs e)
        {
            string companyEstablished = txtCompanyEstablished.Text;
            lblCompanyEstablished.Text = "Established: " + companyEstablished;
        }
    }
}