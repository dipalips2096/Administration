using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;  
public partial class ViewStaffDetails : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {
       // int empid = Convert.ToInt32(Session["empid"].ToString()); 
      show();
    }
    public void show()
    {
        {
            SqlConnection con = new SqlConnection(connection_string);
            string strSQL = "Select * from StaffEntry";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            dt.Fill(ds, "UserDetail");
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //TextBoxUserID.Text = GridView1.SelectedRow.Cells[1].Text;
        //TextBoxUserName.Text = GridView1.SelectedRow.Cells[2].Text;  
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Customers.xls"));
        Response.ContentType = "application/ms-excel";
        DataTable dt =  GetDatafromDatabase();
        string str = string.Empty;
        foreach (DataColumn dtcol in dt.Columns)
        {
            Response.Write(str + dtcol.ColumnName);
            str = "\t";
        }
        Response.Write("\n");
        foreach (DataRow dr in dt.Rows)
        {
            str = "";
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Response.Write(str + Convert.ToString(dr[j]));
                str = "\t";
            }
            Response.Write("\n");
        }
        Response.End();

    }
      protected DataTable GetDatafromDatabase()
    {
        DataTable dt = new DataTable();
       SqlConnection con = new SqlConnection(connection_string);

         
         
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StaffEntry", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
         
        return dt;
    }
}
