using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class LeaveDAL
    {

        private readonly string _connectionstring;

        public LeaveDAL()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }
        public void InsertLeave(string name, string duration)
        {

            try
            {
                const string sql = "INSERT INTO [dbo].[Leave] ([EmployeeName]  ,[LeaveDuration])  VALUES (@EmployeeName, @LeaveDuration)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 50) { Value = (object)name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@LeaveDuration", SqlDbType.NVarChar, 15) { Value = (object)duration ?? DBNull.Value });


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }

        public DataTable ShowAllLeaves()
        {
            try
            {
                const string sql = @"SELECT [EmployeeName], [LeaveDuration], [ID] FROM [dbo].[Leave]";
                DataTable dtLeave = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtLeave);
                }

                return dtLeave;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}