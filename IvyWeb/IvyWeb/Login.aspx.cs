using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IvyWeb
{
    public partial class Login : Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("Order");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtusername.Text == "kyquy" && txtpassword.Text == "kyquy") || (txtusername.Text == "hoaphat" && txtpassword.Text == "hoaphat"))
            {
                Session["Username"] = "kyquy";
                Response.Redirect("Order");
            }

            else
            {
                txtusername.Text = "";
                txtpassword.Text = "";
            }
        }
    }
}