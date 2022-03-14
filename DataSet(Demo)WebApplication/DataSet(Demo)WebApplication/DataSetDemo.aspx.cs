using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace DataSet_Demo_WebApplication
{
    public partial class DataSetDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetEmployeeData();
        }

        public void GetEmployeeData()
        {
            string source = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=Training2;integrated security=true;";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            string query = "Select * from Employee";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            EmployeeGrid.DataSource = ds;
            EmployeeGrid.DataBind();
            conn.Close();

        }
    }
}