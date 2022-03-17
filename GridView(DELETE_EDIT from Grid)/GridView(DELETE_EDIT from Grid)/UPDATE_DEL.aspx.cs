using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace GridView_DELETE_EDIT_from_Grid_
{
    public partial class UPDATE_DEL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using(SqlCommand cmd = new SqlCommand("Employee2_CRUD"))
                {
                    cmd.Parameters.AddWithValue("@Action", "SELECT");
                    using (SqlDataAdapter sda= new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void GridView1_RowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Employee2_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.BindGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string name = (row.FindControl("txtname") as TextBox).Text;
            string mob = (row.FindControl("txtmob") as TextBox).Text;
            int age = Convert.ToInt32((row.FindControl("txtage") as TextBox).Text);
            string gender = (row.FindControl("txtgender") as TextBox).Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Employee2_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UPDATE");
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Mobile", mob);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    cmd.Connection=con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
    }
}
