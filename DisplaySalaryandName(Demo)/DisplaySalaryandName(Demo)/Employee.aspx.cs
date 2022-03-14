using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DisplaySalaryandName_Demo_
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string source = "data source = DESKTOP-NARUTO\\SQL2019; initial catalog = Training2; integrated security = true;";
            SqlConnection connect = new SqlConnection(source);
            string query = "Select Name,Age from Employee";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader dr;
            connect.Open();
            Emp.Text =" Database Connected ";
            dr=cmd.ExecuteReader();
            while(dr.Read()==true)
            {
                Emp.Text += " "+dr.GetValue(0)+" - "+dr.GetValue(1)+" || \n";
            }
            dr.Close();
            connect.Close();
            Emp.Text += " Database Disconnected ";

        }
    }
}