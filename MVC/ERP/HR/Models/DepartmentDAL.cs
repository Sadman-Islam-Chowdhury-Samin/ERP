using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class DepartmentDAL
    {
        private readonly string _connectionString;

        public DepartmentDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }

        // -----------------------------
        // CREATE
        // -----------------------------
        public void InsertDepartment(Department dept)
        {
            const string sql = @"INSERT INTO Department (DepartmentName, EmployeeNumber) 
                                 VALUES (@DepartmentName, @EmployeeNumber)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@DepartmentName", dept.DepartmentName);
                cmd.Parameters.AddWithValue("@EmployeeNumber", dept.EmployeeNumber);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // -----------------------------
        // READ ALL
        // -----------------------------
        public List<Department> GetAllDepartments()
        {
            const string sql = @"SELECT ID, DepartmentName, EmployeeNumber FROM Department";

            List<Department> departments = new List<Department>();

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    departments.Add(new Department
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        DepartmentName = dr["DepartmentName"].ToString(),
                        EmployeeNumber = dr["EmployeeNumber"].ToString()
                    });
                }
            }

            return departments;
        }

        // -----------------------------
        // GET ONE BY ID (FOR EDIT)
        // -----------------------------
        public Department GetDepartmentByID(int id)
        {
            const string sql = @"SELECT ID, DepartmentName, EmployeeNumber 
                                 FROM Department WHERE ID = @ID";

            Department dept = null;

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dept = new Department
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        DepartmentName = dr["DepartmentName"].ToString(),
                        EmployeeNumber = dr["EmployeeNumber"].ToString()
                    };
                }
            }

            return dept;
        }

        // -----------------------------
        // UPDATE
        // -----------------------------
        public void UpdateDepartment(Department dept)
        {
            const string sql = @"UPDATE Department 
                                 SET DepartmentName = @DepartmentName,
                                     EmployeeNumber = @EmployeeNumber
                                 WHERE ID = @ID";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", dept.ID);
                cmd.Parameters.AddWithValue("@DepartmentName", dept.DepartmentName);
                cmd.Parameters.AddWithValue("@EmployeeNumber", dept.EmployeeNumber);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // -----------------------------
        // DELETE
        // -----------------------------
        public void DeleteDepartment(int id)
        {
            const string sql = @"DELETE FROM Department WHERE ID = @ID";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
