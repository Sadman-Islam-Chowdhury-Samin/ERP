using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class UserDAL
    {
        private readonly string _connectionString;

        public UserDAL()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["dberpbatch2connection"].ToString();
        }

        public bool ValidateUser(string username, string password)
        {
            const string sql = @"
                SELECT COUNT(*) 
                FROM [dbo].[User]
                WHERE Username = @Username AND Password = @Password";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}