using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class LeaveDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();

        // ----------- Insert -------------
        public bool InsertLeave(Leave model)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Leave (EmployeeName, LeaveDuration) VALUES (@EmployeeName, @LeaveDuration)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                cmd.Parameters.AddWithValue("@LeaveDuration", model.LeaveDuration);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ----------- Update ---------------
        public bool UpdateLeave(Leave model)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Leave SET EmployeeName=@EmployeeName, LeaveDuration=@LeaveDuration WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                cmd.Parameters.AddWithValue("@LeaveDuration", model.LeaveDuration);
                cmd.Parameters.AddWithValue("@ID", model.ID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ----------- Delete ---------------
        public bool DeleteLeave(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Leave WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ----------- ShowAll ---------------
        public List<Leave> GetAllLeave()
        {
            List<Leave> list = new List<Leave>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT ID, EmployeeName, LeaveDuration FROM Leave ORDER BY ID DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Leave obj = new Leave
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        EmployeeName = rdr["EmployeeName"].ToString(),
                        LeaveDuration = rdr["LeaveDuration"].ToString()
                    };

                    list.Add(obj);
                }
            }

            return list;
        }

        // ----------- Get Single by ID (for Edit) ---------------
        public Leave GetLeaveById(int id)
        {
            Leave obj = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT ID, EmployeeName, LeaveDuration FROM Leave WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    obj = new Leave
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        EmployeeName = rdr["EmployeeName"].ToString(),
                        LeaveDuration = rdr["LeaveDuration"].ToString()
                    };
                }
            }

            return obj;
        }
    }
}