using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class AttendanceDAL
    {
        private readonly string _connectionString;

        public AttendanceDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }

        // INSERT
        public void InsertAttendance(Attendance obj)
        {
            const string sql = @"INSERT INTO Attendance (EmployeeName, AttendanceDate, IsPresent)
                                 VALUES (@EmployeeName, @AttendanceDate, @IsPresent)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@EmployeeName", obj.EmployeeName);
                cmd.Parameters.AddWithValue("@AttendanceDate", obj.AttendanceDate);
                cmd.Parameters.AddWithValue("@IsPresent", obj.IsPresent);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public void UpdateAttendance(Attendance obj)
        {
            const string sql = @"UPDATE Attendance 
                                 SET EmployeeName = @EmployeeName,
                                     AttendanceDate = @AttendanceDate,
                                     IsPresent = @IsPresent
                                 WHERE ID = @ID";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@EmployeeName", obj.EmployeeName);
                cmd.Parameters.AddWithValue("@AttendanceDate", obj.AttendanceDate);
                cmd.Parameters.AddWithValue("@IsPresent", obj.IsPresent);
                cmd.Parameters.AddWithValue("@ID", obj.ID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void DeleteAttendance(int id)
        {
            const string sql = "DELETE FROM Attendance WHERE ID = @ID";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // GET BY ID
        public Attendance GetAttendanceById(int id)
        {
            Attendance obj = null;

            const string sql = @"SELECT ID, EmployeeName, AttendanceDate, IsPresent 
                                 FROM Attendance WHERE ID = @ID";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        obj = new Attendance
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EmployeeName = reader["EmployeeName"].ToString(),
                            AttendanceDate = Convert.ToDateTime(reader["AttendanceDate"]),
                            IsPresent = Convert.ToBoolean(reader["IsPresent"])
                        };
                    }
                }
            }

            return obj;
        }

        // GET ALL
        public List<Attendance> GetAllAttendance()
        {
            List<Attendance> list = new List<Attendance>();

            const string sql = @"SELECT ID, EmployeeName, AttendanceDate, IsPresent FROM Attendance";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Attendance
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            EmployeeName = reader["EmployeeName"].ToString(),
                            AttendanceDate = Convert.ToDateTime(reader["AttendanceDate"]),
                            IsPresent = Convert.ToBoolean(reader["IsPresent"])
                        });
                    }
                }
            }

            return list;
        }
    }
}