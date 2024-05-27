using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cloud_Poe_PartOne
{

    public class DbHelper
    {

        string connectionString = "Server=tcp:sqlserverkhumalo.database.windows.net,1433;Initial Catalog=khumaloDBpoe;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";
  
            public List < Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT * From user";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader  = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader.GetValue(0).ToString());
                string email = reader.GetValue(1).ToString();
                string name = reader.GetValue(2).ToString();
                string password = reader.GetValue(3).ToString();
                string role = reader.GetValue(4).ToString();
                string phone = reader.GetValue(5).ToString();
                
                Users user = new Users(id, email, name, password, role, phone);
                users.Add(user);
    }
            command.Dispose();
            con.Close();

            return users;
        }
            }
}