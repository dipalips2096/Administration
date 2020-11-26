using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Invoice : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
    int price;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }

        SqlConnection con = new SqlConnection(connection_string);
        try
        {
            con.Open();
            // Response.Write("Connection Created");
        }
        catch (Exception objEx)
        {
            Response.Redirect(objEx.Message);
        }
        finally
        {
            con.Close();
        }
        string cmd = "select * from Products";
        SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();
        DropDownList1.DataTextField = "prodname";
        DropDownList1.DataValueField = "prodid";
        DropDownList1.DataBind();    
    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        int prodid = Convert.ToInt32(DropDownList1.SelectedValue);
        string prodname = DropDownList1.SelectedItem.ToString();


        SqlConnection con1 = new SqlConnection(connection_string);
        con1.Open();

        SqlCommand command = new SqlCommand("SELECT * FROM Products  where prodid=@prodid;", con1);
        command.Parameters.AddWithValue("@prodid", prodid);

        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                //Response.Write(reader["price"].ToString() + ", ");
                price =Convert.ToInt32( reader["price"]);
            }
        }
        else
        {
            Console.WriteLine("No rows found.");
        }
        reader.Close();
        con1.Close();
        int quantity = Convert.ToInt32(txtQuantity.Text);
        
        Response.Write(prodid);
        Response.Write(prodname);
        Response.Write(price);
        Response.Write(quantity);

    
        Label2.Text = prodname.ToString();
        Label3.Text = price.ToString();
        Label4.Text = quantity.ToString();
        int gst=18%(price);
        double finalbill = (gst + price) * quantity;
        Label6.Text = finalbill.ToString();

       

    }
}