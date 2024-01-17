using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace LoginPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void loginBtn2_Click(object sender, EventArgs e)
        {
            string empname = txtEmpName.Text;
            string password = txtPwd.Text;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand selCommand = new SqlCommand("SELPWD", connection))
                {
                    selCommand.CommandType = CommandType.StoredProcedure;
                    selCommand.Parameters.AddWithValue("@EMPLOYEE_NAME", empname);
                    string pwdFromDB = (string)selCommand.ExecuteScalar();
                    if (empname == "ADMIN" && password == "123")
                    {
                        Response.Redirect("WebForm5.aspx");
                    }
                    else if (password == pwdFromDB)
                    {
                        Response.Redirect("WebForm2.aspx");
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