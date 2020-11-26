using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class DeleteEmployee : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connection_string);
         con.Open();
        
     
 SqlCommand  cmd = new SqlCommand("delete from StaffEntry where username='" + txtUserName.Text + "'", con);
    cmd.ExecuteNonQuery();
    con.Close();
    Response.Write("<script>alert(' Record deleted')</script>");
            
        }
        
        
    }
 