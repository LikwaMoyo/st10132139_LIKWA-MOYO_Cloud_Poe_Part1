using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Xml.Linq;

namespace Cloud_Poe_PartOne
{
    public partial class CreateAccountPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string role = SlRole.Value;
            string phoneNumber = txtPhoneNumber.Text;
            // inserts the user 
            CreateUser(email, name, password, role, phoneNumber);        

        }

        private void CreateUser(string email, string name,string password, string role, string phoneNumber)
        {
            // connection string
            string connectionString = "Data Source=sqlserverkhumalo.database.windows.net;Initial Catalog=khumaloDBpoe;Persist Security Info=True;User ID=st1013213;Password=lolboy12HH";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (email, name, password, role, phoneNumber) VALUES (@Email, @Name, @Password, @Role, @PhoneNumber)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        command.ExecuteNonQuery();
                        // You can add a message to notify the user of the success
                        Response.Write("<script>alert('User created successfully!');</script>");
                    }

                }
                catch (Exception ex)
                {
                    // Handle the exception (log it, display error message, etc.)
                    Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
                }               
                
            }
        }
    }
}
