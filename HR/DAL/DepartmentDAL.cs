using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.DAL
{
    public class DepartmentDAL
    {

        private readonly string _connectionstring;

        public DepartmentDAL()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        }
        public void InsertDepartment(string departmentName, string employeeNumber)
        {

            try
            {
                const string sql = "INSERT INTO [dbo].[Department] ([DepartmentName] ,[EmployeeNumber])  VALUES (@DepartmentName, @EmployeeNumber)";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50) { Value = (object)departmentName ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@EmployeeNumber", SqlDbType.NVarChar, 15) { Value = (object)employeeNumber ?? DBNull.Value });


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {

                throw msgException;
            }

        }

        public DataTable ShowAllDepartments()
        {
            try
            {
                const string sql = @"SELECT [DepartmentName], [EmployeeNumber], [ID] FROM [dbo].[Department]";
                DataTable dtDepartment = new DataTable();

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtDepartment);
                }

                return dtDepartment;
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void UpdateDepartment(int id, string departmentName,  string employeeNumber)
        {
            try
            {
                const string sql = @"UPDATE [dbo].[Department] 
                             SET [DepartmentName] = @DepartmentName, 
                                 [EmployeeNumber] = @EmployeeNumber 
                             WHERE [ID] = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
                    cmd.Parameters.Add(new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50) { Value = (object)departmentName ?? DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@EmployeeNumber", SqlDbType.NVarChar, 15) { Value = (object)employeeNumber ?? DBNull.Value });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void DeleteDepartment(int ID)
        {
            try
            {
                const string sql = "DELETE FROM [dbo].[Department] WHERE ID = @ID";

                using (var con = new SqlConnection(_connectionstring))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = ID });

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }
}