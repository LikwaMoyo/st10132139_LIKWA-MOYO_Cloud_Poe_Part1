using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Cloud_Poe_PartOne
{
    public partial class CreateAccountPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = confirmPassword.Text.Trim();
            string role = SlRole.DataTextField;
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (password == confirm)
            {
                // Insert new user into the database
                string connectionString = "Server=tcp:sqlserverkhumalo.database.windows.net,1433;Initial Catalog=khumaloDBpoe;Persist Security Info=False;User ID=st1013213;Password=lolboy12HH;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (Email, Name, Password, Role, PhoneNumber) VALUES (@Email, @Name, @Password, @Role, @PhoneNumber)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Note: This should be hashed in a real application
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                // Redirect to a different page after successful account creation
                Response.Redirect("Login.aspx");
            }
            else
            {
                // Display error message for password mismatch
                // lblError.Visible = true;
                // lblError.Text = "Passwords do not match.";
            }
        }

        public void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
