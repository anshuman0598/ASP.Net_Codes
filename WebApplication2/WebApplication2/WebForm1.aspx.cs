using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cnstr = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection cn = new SqlConnection(cnstr);
            string sqlstr = "Select * from Register2";
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            SqlDataReader dr;
            cn.Open();
            MyLabel.Text = "Database Connect.\n\n";
            dr=cmd.ExecuteReader();
            while(dr.Read()==true)
            {
                MyLabel.Text = MyLabel.Text + "  "+dr.GetValue(0) + "  ,  " + dr.GetValue(1) + "  ,  " + dr.GetValue(2) +"  ,  "+ dr.GetValue(3)+" ||| ";
            }
            dr.Close();
            cn.Close();
            MyLabel.Text += "\n\nDatabase Disconnect.\n\n";

        }

        //protected void OnClick(object sender, EventArgs e)
        //{
        //    string cnstr = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=B15;integrated security=true;";
        //    SqlConnection cn = new SqlConnection(cnstr);
        //    cn.Open();
        //    Button1.Text = "Ashte Tipun Kaka";
        //    MyLabel.Text = "Successfully Connected";
        //    cn.Close();
        //}
    }
}