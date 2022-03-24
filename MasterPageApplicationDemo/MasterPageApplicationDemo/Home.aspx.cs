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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "Insert into Employee2 values (@0,@1,@2,@3)";
            using (SqlConnection con = new SqlConnection(source))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("0", name.Text);
                    cmd.Parameters.AddWithValue("1", mob.Text);
                    cmd.Parameters.AddWithValue("2", age.Text);
                    cmd.Parameters.AddWithValue("3", gender.SelectedValue);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Registered.Text = "Successfully Registered";
                    }
                    catch (Exception)
                    {
                        Registered.Text = "Not Registered Due to Invalid Input";
                    }



                    con.Close();

                }
            }

        }
    }
}