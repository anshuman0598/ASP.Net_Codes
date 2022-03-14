using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace DataReader_GridView_
{
    public partial class GridViewDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Source = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=Training2;integrated security=true;";
            SqlConnection cn = new SqlConnection(Source);
            string query = "Select  * from Employee";
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