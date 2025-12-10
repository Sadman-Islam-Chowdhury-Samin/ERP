using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HR.DAL
{
    public class AttendanceDAL
    {
        private readonly string _connectionstring;

        public AttendanceDAL()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }

        public void InsertAttendance(string employeeName, DateTime attendanceDate, bool isPresent)
        {
            try
            {
                const string sql = @"INSERT INTO Attendance
                                     (EmployeeName, AttendanceDate, IsPresent)
                                     VALUES (@EmployeeName, @AttendanceDate, @IsPresent)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 50).Value = employeeName;
                    cmd.Parameters.Add("@AttendanceDate", SqlDbType.Date).Value = attendanceDate;
                    cmd.Parameters.Add("@IsPresent", SqlDbType.Bit).Value = isPresent;

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
                const string sql = @"SELECT ID, EmployeeName, AttendanceDate, IsPresent
                                     FROM Attendance";

                DataTable dt = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }
    }
}
