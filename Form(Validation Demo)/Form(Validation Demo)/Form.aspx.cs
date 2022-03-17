using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Form_Validation_Demo_
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["source"].ConnectionString;
            string query = "Insert into FormDetails values (@0,@1,@2,@3,@4,@5)";
            using (SqlConnection con = new SqlConnection(source))
            {
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("0",name.Text);
                    cmd.Parameters.AddWithValue("1", mob.Text);
                    cmd.Parameters.AddWithValue("2", age.Text);
                    cmd.Parameters.AddWithValue("3", gender.Text);
                    cmd.Parameters.AddWithValue("4", email.Text);
                    cmd.Parameters.AddWithValue("5", password.Text);
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