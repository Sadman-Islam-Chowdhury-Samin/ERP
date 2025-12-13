using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class UserDAL
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();

        public User ValidateUser(string username, string password)
        {
            const string sql = @"SELECT ID, Username 
                                 FROM [dbo].[User] 
                                 WHERE Username = @Username AND Password = @Password";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        ID = (int)reader["ID"],
                        Username = reader["Username"].ToString()
                    };
                }
            }
            return null;
        }
    }
}