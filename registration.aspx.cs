using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void registerButton2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtNewUser.Text;
            string password = txtNewPwd.Text;
            string confirmPassword = txtConPwd.Text;
            if (password != confirmPassword)
            {
                throw new Exception("Password Mismatch");
            }
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO USERS(EMAIL, USERNAME, PASSWORD, CONFIRMPASSWORD)VALUES(@EMAIL, @USERNAME, @PASSWORD, @CONFIRMPASSWORD)";
                using (SqlCommand insCommand = new SqlCommand(query, connection))
                {
                    insCommand.Parameters.AddWithValue("@EMAIL", email);
                    insCommand.Parameters.AddWithValue("@USERNAME", username);
                    insCommand.Parameters.AddWithValue("@PASSWORD", password);
                    insCommand.Parameters.AddWithValue("@CONFIRMPASSWORD", confirmPassword);
                    connection.Open();
                    int filledRows = insCommand.ExecuteNonQuery();
                    if (filledRows > 0)
                    {
                        Response.Write("Registration successful\n");
                    }
                    else
                    {
                        Response.Write("Registration falied\n");
                    }
                    connection.Close();
                }

                string query2 = "SELECT * FROM USERS";

                using (SqlCommand selCommand = new SqlCommand(query2, connection))
                {
                    connection.Open();
                    SqlDataReader reader=selCommand.ExecuteReader();
                    if(reader.Read())
                    {
                        Response.Write($"Email:{email},Username:{username}");
                    }
                    reader.Close();
                    connection.Close();
                }
            }

        }  
            
    }
}