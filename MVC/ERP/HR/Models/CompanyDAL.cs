using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class CompanyDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();
        //_connectionString = ConfigurationManager.ConnectionStrings["dberpbatch2connection"].ToString();


        // ✔ CREATE
        public bool AddCompany(Company c)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Company(CompanyName, Address, Email) VALUES(@CompanyName, @Address, @Email)", con);

                cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Email", c.Email);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ✔ READ ALL
        public List<Company> GetAllCompanies()
        {
            List<Company> list = new List<Company>();

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Company", con);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Company
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        CompanyName = dr["CompanyName"].ToString(),
                        Address = dr["Address"].ToString(),
                        Email = dr["Email"].ToString()
                    });
                }
            }
            return list;
        }

        // ✔ READ BY ID
        public Company GetCompanyById(int id)
        {
            Company c = null;

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Company WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    c = new Company
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        CompanyName = dr["CompanyName"].ToString(),
                        Address = dr["Address"].ToString(),
                        Email = dr["Email"].ToString()
                    };
                }
            }

            return c;
        }

        // ✔ UPDATE
        public bool UpdateCompany(Company c)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Company SET CompanyName=@CompanyName, Address=@Address, Email=@Email WHERE ID=@ID", con);

                cmd.Parameters.AddWithValue("@ID", c.ID);
                cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Email", c.Email);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ✔ DELETE
        public bool DeleteCompany(int id)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Company WHERE ID=@ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}