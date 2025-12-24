using HR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class UserBLL
    {
        public bool Login(string username, string password)
        {
            UserDAL objUserDAL = new UserDAL();
            return objUserDAL.ValidateUser(username, password);
        }

  //     <connectionStrings>
	 // <add connectionString = "Data Source=MSI\SQLEXPRESS;Initial Catalog=dberpbatch2;User ID=sa;Password=aspdotnetcourse;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" name="dberpbatch2connection" />
  //</connectionStrings>
    }
}