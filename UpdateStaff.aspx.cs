using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class UpdateStaff : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
 
    protected void Page_Load(object sender, EventArgs e)
    {
      
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(connection_string);


            SqlCommand cmd = new SqlCommand("select * from StaffEntry where username=@username and emailid=@emailid", con);
            cmd.Parameters.AddWithValue("@username", txtUSerName.Text);
            cmd.Parameters.AddWithValue("@emailid", txtEmail.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                Session["username"] = txtUSerName.Text;
                Response.Redirect("UpdateStaffFinal.aspx");
                Session.RemoveAll();
                //  Label2.Text = "Your username and password is correct";

            }
            else
            {
                Response.Write("Your username and password is incorrect");
            }
        }

        catch (Exception e1)
        {
            Response.Write(e1.Message);
        }
        
    }
}