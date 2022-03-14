using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
namespace DataTableUsingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a DataSet, nameSpace and Student Table with Name and Address Columns
                DataSet ds = new DataSet("DS");
                ds.Namespace = "StdNamespace";
                DataTable dt = new DataTable("Student");
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                dt.Columns.Add(col1);
                dt.Columns.Add(col2);
                ds.Tables.Add(dt);

                // ADD STUDENT DATA ON TANLE

                DataRow newRow;
                newRow = dt.NewRow();
                newRow["Name"] = "Anshuman Das";
                newRow["Address"] = "Baruipur,WB";
                dt.Rows.Add(newRow);
                newRow = dt.NewRow();
                newRow["Name"] = "Saikat Mondal";
                newRow["Address"] = "Barsat,WB";
                dt.Rows.Add(newRow);
                newRow = dt.NewRow();
                newRow["Name"] = "Shreya Mondal";
                newRow["Address"] = "Baruipur,WB";
                dt.Rows.Add(newRow);
                newRow = dt.NewRow();
                newRow["Name"] = "Tamal Ghosh";
                newRow["Address"] = "Subhasgram,WB";
                dt.Rows.Add(newRow);
                ds.AcceptChanges();

                // Create a new StreamWriter and Save data in Xml file
                StreamWriter myStreamWriter = new StreamWriter(@"D:\StudentData.xml");
                // Writer Data to DataSet which actually creates the file
                ds.WriteXml(myStreamWriter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:  {0}",ex.ToString());
            }

            Console.ReadLine();
            return;

        }
    }
}
