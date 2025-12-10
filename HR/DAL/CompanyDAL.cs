using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class CompanyDAL
    {

        private readonly string _connectionstring;

        public CompanyDAL()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }
        public void InsertCompany(string name, string address, string email)
        {

            try
            {
                const string sql = "INSERT INTO [dbo].[Company] ([CompanyName]  ,[Address], [Email])  VALUES (@CompanyName, @Address, @Email)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 50) { Value = (object)name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = (object)email ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 15) { Value = (object)address ?? DBNull.Value });


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }
        public void UpdateCompany(int companyId, string name, string address, string email)
        {
            try
            {
                const string sql = @"UPDATE [dbo].[Company] 
                             SET [CompanyName] = @CompanyName, 
                                 [Address] = @Address, 
                                 [Email] = @Email
                             WHERE [ID] = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = companyId });
                    cmd.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 50) { Value = (object)name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200) { Value = (object)address ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = (object)email ?? DBNull.Value });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }


        public void DeleteCompany(int companyId)
        {
            try
            {
                const string sql = @"DELETE FROM [dbo].[Company] WHERE ID = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = companyId });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }


        public DataTable ShowAllCompany()
        {
            try
            {
                const string sql = @"SELECT [ID], [CompanyName], [Address], [Email] FROM [dbo].[Company]";
                DataTable dtCompany = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtCompany);
                }

                return dtCompany;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}