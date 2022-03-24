using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MasterPageApplicationDemo
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "Select * from Employee2";
            using (SqlConnection con = new SqlConnection(source))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void Row_Editing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
        protected void Row_Updating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string name = (row.FindControl("nametxt") as TextBox).Text;
            string mob = (row.FindControl("mobiletxt") as TextBox).Text;
            int age = Convert.ToInt32((row.FindControl("agetxt") as TextBox).Text);
            string gender = (row.FindControl("gendertxt") as TextBox).Text;
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "UPDATE Employee2 set Name=@0,Mobile=@1,Age=@2,Gender=@3 Where ID = @4";
            using (SqlConnection con = new SqlConnection(source))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("4", id);
                    cmd.Parameters.AddWithValue("0", name);
                    cmd.Parameters.AddWithValue("1", mob);
                    cmd.Parameters.AddWithValue("2", age);
                    cmd.Parameters.AddWithValue("3", gender);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.BindGrid();

        }

        protected void Row_Deleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "Delete from Employee2 Where ID = @0";
            using (SqlConnection con = new SqlConnection(source))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("0", Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.BindGrid();
        }

        protected void Row_CancellingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();

        }
    }
}