using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace FormDemo_TakingInput_and_StoringData_
{
    public partial class FormDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string source = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=Training2;integrated security=true;";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            // Without using Stored Procedure
            //string query = "Insert into Employee2 values ('" + name.Text + "','" + mob.Text + "'," + age.Text + ",'" + gender.SelectedValue + "')";
            //SqlCommand cmd = new SqlCommand(query2, conn);

            //Using the Stored Procedure
            SqlCommand cmd = new SqlCommand("sp_InputData", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", name.Text);
            cmd.Parameters.AddWithValue("mob", mob.Text);
            cmd.Parameters.AddWithValue("age", age.Text);
            cmd.Parameters.AddWithValue("g", gender.SelectedValue);


            int i = cmd.ExecuteNonQuery();


            if (i > 0)
                Registered.Text = "Successfully Registered";
            else
                Registered.Text = "Not Registered Due to Invalid Input";
            conn.Close();
        }
    }
}