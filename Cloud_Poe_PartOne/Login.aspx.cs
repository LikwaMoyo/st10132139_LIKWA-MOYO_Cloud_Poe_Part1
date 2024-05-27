using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI;

namespace Cloud_Poe_PartOne
{
    public partial class LoginPage : Page
    {
        public static int LoggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkCreateAccount_Click(object sender, EventArgs e)
           
        {
            Response.Redirect("CreateAccountPage.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            List<Users> users = db.GetUsers();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateUser(email, password))
            {
                // Redirect to a different page after successful login
                Users account = users.Where(x => x.Email == email).FirstOrDefault();
                LoggedInUser = account.UserID;

                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //lblError.Visible = true;
                //lblError.Text = "Invalid email or password.";
            }
        }
        

        private bool ValidateUser(string email, string password)
        {
            bool isValid = false;

            // Connection string from web.config
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password); // Note: This should be hashed in a real application

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    isValid = true;
                }
                con.Close();
            }

            return isValid;
        }
    }
}
