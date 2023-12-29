using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void loginBtn2_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPwd.Text;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select PASSWORD from USERS where username=@USERNAME";
                using(SqlCommand selCommand=new SqlCommand(query,connection))
                {
                    selCommand.Parameters.AddWithValue("@USERNAME",username);
                    string pwdFromDB = (string)selCommand.ExecuteScalar();                    
                    if(password==pwdFromDB)
                    {
                        Response.Redirect("loginSuccess.aspx");
                    }
                    else
                    {
                        Response.Write("Incorrect username or password");
                    }
                }
                connection.Close();
            }
        }
    }
}