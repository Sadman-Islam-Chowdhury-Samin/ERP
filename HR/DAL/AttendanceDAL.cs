using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class AttendanceDAL
    {

        private readonly string _connectionstring;

        public AttendanceDAL()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }
        public void InsertAttendance(string name, string day1)
        {

            try
            {
                const string sql = "INSERT INTO [dbo].[Attendance] ([EmployeeName]  ,[Day1])  VALUES (@Name, @Day1)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = (object)name ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@Day1", SqlDbType.NVarChar, 15) { Value = (object)day1 ?? DBNull.Value });


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }

        public DataTable ShowAllAttendance()
        {
            try
            {
                const string sql = @"SELECT [EmployeeName], [Day1], [ID] FROM [dbo].[Attendance]";
                DataTable dtAttendance = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtAttendance);
                }

                return dtAttendance;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}