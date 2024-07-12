using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DAL.Entities;
using System.Data;

namespace DAL.Operations
{
    public class OEmployee
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EmployeeDb.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DBVPT6QU\SQLEXPRESS;Initial Catalog=EmployeeDb;Integrated Security=True");
        // CRUD
        public int Insert(EEmployee emp)
        {
            conn.Open();
            string query = "insert into Employee(Name, Email, Gender, Skills, Country) values('" + emp.Name + "', '" + emp.Email + "', '" + emp.Gender + "', '" + emp.Skills + "', '" + emp.Country + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
        }

        public int Delete(int id)
        {
            conn.Open();
            string query = "Delete from Employee Where Id = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
        }

        public int Update(EEmployee emp)
        {
            conn.Open();
            string query = "Update Employee set Name = '" + emp.Name + "', Email = '" + emp.Email + "', Gender = '" + emp.Gender + "', Skills = '" + emp.Skills + "', Country = '" + emp.Country + "' Where Id = " + emp.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
        }

        public SqlDataReader Select()
        {
            conn.Open();
            string query = "Select * from Employee";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataTable SelectAll()
        {
            string query = "Select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
