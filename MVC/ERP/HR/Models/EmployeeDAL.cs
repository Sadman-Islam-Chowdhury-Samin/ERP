//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace HR.Models
//{
//    public class EmployeeDAL
//    {
//        public void InsertEmployee(Employee objEmployee)
//        {
//            string _connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
//            const string sql = @"INSERT INTO [dbo].[Employee] ([Name], [Email], [MobileNumber]) VALUES (@Name, @Email, @MobileNumber);";

//            using (var con = new SqlConnection(_connectionString))
//            using (var cmd = new SqlCommand(sql, con))
//            {

//                cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = (object)objEmployee.Name ?? DBNull.Value });
//                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = (object)objEmployee.Email ?? DBNull.Value });
//                cmd.Parameters.Add(new SqlParameter("@MobileNumber", SqlDbType.NVarChar, 15) { Value = (object)objEmployee.MobileNumber ?? DBNull.Value });

//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HR.Models
{
    public class EmployeeDAL
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();

        public void InsertEmployee(Employee objEmployee)
        {
            const string sql = @"INSERT INTO [dbo].[Employee] ([Name], [Email], [MobileNumber])
                                 VALUES (@Name, @Email, @MobileNumber);";
            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Name", (object)objEmployee.Name ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)objEmployee.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MobileNumber", (object)objEmployee.MobileNumber ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetAll()
        {
            var list = new List<Employee>();
            const string sql = "SELECT ID, [Name], [Email], [MobileNumber] FROM [dbo].[Employee]";
            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Employee
                        {
                            Id = Convert.ToInt32(r["ID"]),
                            Name = r["Name"] as string,
                            Email = r["Email"] as string,
                            MobileNumber = r["MobileNumber"] as string
                        });
                    }
                }
            }
            return list;
        }

        public Employee GetById(int id)
        {
            const string sql = "SELECT ID, [Name], [Email], [MobileNumber] FROM [dbo].[Employee] WHERE ID = @ID";
            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        return new Employee
                        {
                            Id = Convert.ToInt32(r["ID"]),
                            Name = r["Name"] as string,
                            Email = r["Email"] as string,
                            MobileNumber = r["MobileNumber"] as string
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateEmployee(Employee emp)
        {
            const string sql = @"UPDATE [dbo].[Employee] 
                                 SET [Name]=@Name, [Email]=@Email, [MobileNumber]=@MobileNumber
                                 WHERE ID=@ID";
            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", emp.Id);
                cmd.Parameters.AddWithValue("@Name", (object)emp.Name ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)emp.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MobileNumber", (object)emp.MobileNumber ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            const string sql = "DELETE FROM [dbo].[Employee] WHERE ID=@ID";
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
