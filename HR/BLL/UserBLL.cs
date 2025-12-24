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

    //<connectionStrings>
    //    <add name = "dberpbatch2connection"
    //        connectionString="Data Source=161.153.47.14,1433;Initial Catalog=sadman_samin_001DB';User ID=sadman_samin_001;Password='sadman_samin_001!Pass123';MultipleActiveResultSets=True;TrustServerCertificate=True;"
    //        providerName="System.Data.SqlClient" />
    //</connectionStrings>
    }
}