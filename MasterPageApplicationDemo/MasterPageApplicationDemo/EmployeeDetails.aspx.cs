using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace MasterPageApplicationDemo
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection cn = new SqlConnection(source);
            string query = "Select  * from Employee2";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr;
            cn.Open();
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            cn.Close();
        }
    }
}