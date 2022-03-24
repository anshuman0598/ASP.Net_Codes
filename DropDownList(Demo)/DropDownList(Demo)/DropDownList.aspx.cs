using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DropDownList_Demo_
{
    public partial class DropDownList : System.Web.UI.Page
    {
        string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                this.DropDown();
            }
            
            
        }
        private void DropDown()
        {
            SqlConnection con = new SqlConnection(source);
            string query = "Select Name from Employee2";
            //SqlCommand com = new SqlCommand(query, con);

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Name";
            DropDownList1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(source);
            string query = "Select * from Employee2 Where Name = @0";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@0", DropDownList1.SelectedValue);
            
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            }
        }
    }
}