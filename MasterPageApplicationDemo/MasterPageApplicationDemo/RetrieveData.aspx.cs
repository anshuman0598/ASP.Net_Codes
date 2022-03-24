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
    public partial class RetrieveData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            string query = "Select * from Employee2 Where Name = '" + Name.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Goutput.DataSource = ds;
                Goutput.DataBind();
                result.Text = "Search Successful";
            }
            else
            {
                result.Text = "Record Not Found";
                Goutput.DataSource = ds;
                Goutput.DataBind();
            }
        }
    }
}