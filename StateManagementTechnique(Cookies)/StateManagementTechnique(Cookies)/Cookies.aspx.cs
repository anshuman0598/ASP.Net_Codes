using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementTechnique_Cookies_
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Fname.Text + " " +Lname.Text ;
            
            HttpCookie ck = new HttpCookie("username",name);
            Response.Cookies.Add(ck);
            Response.Redirect("Default.aspx");
        }
    }
}