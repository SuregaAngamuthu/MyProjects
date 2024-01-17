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
            string employee_id = txtEmpId.Text;
            string password = txtNewPwd.Text;
            string confirmPassword = txtConPwd.Text;
            string employee_name = txtNewEmp.Text;
            string salary = txtSal.Text;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insCommand = new SqlCommand("REGEMPLOYEES", connection))
                {
                    insCommand.CommandType = CommandType.StoredProcedure;
                    insCommand.Parameters.AddWithValue("@EMPLOYEE_ID", employee_id);
                    insCommand.Parameters.AddWithValue("@EMPLOYEE_NAME", employee_name);
                    insCommand.Parameters.AddWithValue("@SALARY", salary);
                    insCommand.Parameters.AddWithValue("@PASSWORD", password);
                    insCommand.Parameters.AddWithValue("@CONFIRMPASSWORD", confirmPassword);
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

                string query2 = "SELECT * FROM EMPLOYEE";

                using (SqlCommand selCommand = new SqlCommand(query2, connection))
                {
                    connection.Open();
                    SqlDataReader reader=selCommand.ExecuteReader();
                    if(reader.Read())
                    {
                        //Response.Write($"Employee_id:{employee_id},Employee_name:{employee_name}");
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Write("Registration falied");
                    }
                    reader.Close();
                    connection.Close();
                }
            }

        }  
            
    }
}