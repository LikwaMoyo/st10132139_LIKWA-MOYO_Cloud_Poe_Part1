using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloud_Poe_PartOne
{
    public partial class MyWorkPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPurchase1_Click(object sender, EventArgs e)
        {
            // Add purchase logic for image 1
            DateTime purchasedDate = DateTime.Now;
            SaveTransaction(LoginPage.LoggedInUser, 2, purchasedDate);
            LblProd1.Text = "Product Purchased";
        }
        
        protected void btnPurchase2_Click(object sender, EventArgs e)
        {
            // Add purchase logic for image 2
            DateTime purchasedDate = DateTime.Now;
            SaveTransaction(LoginPage.LoggedInUser, 3, purchasedDate);
            LblProd2.Text = "Product Purchased";
        }

        protected void btnPurchase3_Click(object sender, EventArgs e)
        {
            DateTime purchasedDate = DateTime.Now;
            SaveTransaction(LoginPage.LoggedInUser, 4, purchasedDate);
            LblProd3.Text = "Product Purchased";
        }

        public void SaveTransaction(int userID, int ProductID, DateTime transactionDate)
        {
            string connectionString = "Server=tcp:sqlserverkhumalo.database.windows.net,1433;Initial Catalog=khumaloDBpoe;Persist Security Info=False;User ID=st1013213;Password=lolboy12HH;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO transactionData (userID, productID, transactionDate)" +
                    " VALUES (@UserID, @ProductID, @TransactionDate )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@TransactionDate", transactionDate); // Note: This should be hashed in a real application
             

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}