using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace WebPresentationLayer
{
    public partial class Ulazi : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "SELECT * FROM [dbo].[Transakcije] WHERE Vrsta='Ulaz'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center>");
                sb.Append("<h1>Evidencija Ulaza </h1>");
                sb.Append("<h2>Ovde možete videti evidenciju svih ulaza posebno</h2>");
                sb.Append("<hr/>");
                sb.Append("<table border= 1>");
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dc.ColumnName.ToUpper());
                    sb.Append("</th>");
                }
                sb.Append("</tr>");
                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append("<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");
                    }
                    sb.Append("</tr>");

                }
                sb.Append("</table>");
                sb.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
                sqlconn.Close();



            }
        }
    }
}