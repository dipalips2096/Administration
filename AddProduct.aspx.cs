using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class AddProduct : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connection_string);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Products(prodname,price,details) values (@prodname,@price,@details)", con);
          
            cmd.Parameters.AddWithValue("prodname", txtProdName.Text);
            cmd.Parameters.AddWithValue("price", txtPrice.Text);
            cmd.Parameters.AddWithValue("details", txtDetails.Text);
  
            cmd.ExecuteNonQuery();
             
            Response.Write("<script>alert('Record inserted');</script>");
         
        }
        catch (Exception objEx)
        {
            Response.Redirect(objEx.Message);
        }
        finally
        {
            con.Close();
        }  
    }
}