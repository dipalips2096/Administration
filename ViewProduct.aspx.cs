using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;  
public partial class ViewProduct : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
  
    protected void Page_Load(object sender, EventArgs e)
    {
        show();
    }
    public void show()
    {
        {
            SqlConnection con = new SqlConnection(connection_string);
            string strSQL = "Select * from Products";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            dt.Fill(ds, "ProdDetail");
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}