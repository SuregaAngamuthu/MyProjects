using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
        protected void loginBtn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}