using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginPage
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayEmployee();
            }
        }
        protected void displayEmployee()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DISPLAYEMPLOYEE", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                GridViewRegisteredEmployee.DataSource = dataTable;
                GridViewRegisteredEmployee.DataBind();
            }
        }
        protected void DeleteEmployee(object sender, GridViewDeleteEventArgs e)
        {
            string employee_id = GridViewRegisteredEmployee.DataKeys[e.RowIndex].Value.ToString();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand delCommand = new SqlCommand("DELETEEMPLOYEE", connection))
                {
                    delCommand.CommandType = CommandType.StoredProcedure;
                    delCommand.Parameters.AddWithValue("@EMPLOYEE_ID", Convert.ToInt32(employee_id));
                    int rowsaffected=delCommand.ExecuteNonQuery();
                    if(rowsaffected>0)
                    {
                        Response.Write("Deleted successfully");

                    }
                    else
                    {
                        Response.Write("Not Deleted successfully");
                    }

                }
                connection.Close();
            }
            displayEmployee();
        }
        protected void EditEmployee(object sender, GridViewEditEventArgs e)
        {
            GridViewRegisteredEmployee.EditIndex = e.NewEditIndex;
            displayEmployee();
        }
        protected void UpdateEmployee (object sender, GridViewUpdateEventArgs e)
        {
            //GridViewRow row = GridViewRegisteredEmployee.Rows[e.RowIndex];
            string employee_id = (GridViewRegisteredEmployee.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
            string employee_name = (GridViewRegisteredEmployee.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
            string employee_salary = (GridViewRegisteredEmployee.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString;
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand updateCommand = new SqlCommand("UPDATEEMPLOYEE",connection);
                updateCommand.CommandType = CommandType.StoredProcedure;
                updateCommand.Parameters.AddWithValue("@EMPLOYEE_ID", Convert.ToInt32(employee_id));
                updateCommand.Parameters.AddWithValue("@EMPLOYEE_NAME", employee_name);
                updateCommand.Parameters.AddWithValue("@SALARY", Convert.ToInt32(employee_salary));
                int rowsAffected = updateCommand.ExecuteNonQuery();
                connection.Close();

            }
            GridViewRegisteredEmployee.EditIndex= -1;
            displayEmployee();
        }

        

        protected void CancelEditEmployee(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewRegisteredEmployee.EditIndex = -1;
            displayEmployee();
        }
    }
}
