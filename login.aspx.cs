using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    protected void Button1_Click1(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(connection_string);


            SqlCommand cmd = new SqlCommand("select * from StaffEntry where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {

                Session["id"] = txtUserName.Text;
                Response.Redirect("Dashboard.aspx");
                Session.RemoveAll();


            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        catch (Exception e1)
        {
            Response.Write(e1.Message);
        } 
    }
}