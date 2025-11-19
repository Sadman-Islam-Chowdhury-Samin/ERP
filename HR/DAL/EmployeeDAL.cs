using HR.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class EmployeeDAL
    {
        private readonly string _connectionstring;

        public EmployeeDAL() {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }
        public void InsertEmployee(Employee objEmployee) {

            try
            {
                const string sql = "INSERT INTO [dbo].[Employee] ([Name]  ,[Email] ,[MobileNumber])  VALUES (@Name, @Email, @MobileNumber)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = (object)objEmployee._name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = (object)objEmployee._email ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@MobileNumber", SqlDbType.NVarChar, 15) { Value = (object)objEmployee._mobileNumber ?? DBNull.Value });


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }

        public void UpdateEmployee(int id, string name, string email, string mobileNumber)
        {
            try
            {
                const string sql = @"UPDATE [dbo].[Employee] 
                             SET [Name] = @Name, 
                                 [Email] = @Email, 
                                 [MobileNumber] = @MobileNumber 
                             WHERE [ID] = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = (object)name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = (object)email ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@MobileNumber", SqlDbType.NVarChar, 15) { Value = (object)mobileNumber ?? DBNull.Value });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            try
            {
                const string sql = "DELETE FROM [dbo].[Employee] WHERE ID = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = employeeID });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllEmployees()
        {
            try
            {
                const string sql = @"SELECT [Name], [Email], [MobileNumber], [ID] FROM [dbo].[Employee]";
                DataTable dtEmployee = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtEmployee);
                }

                return dtEmployee;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }



    }
}