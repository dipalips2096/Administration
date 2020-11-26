using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";

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
            Response.Redirect("Application_Form.aspx?Error=" + objEx.Message);
        }
        finally
        {
            con.Close();
        }  
        string cmd="select * from Designation";
        SqlDataAdapter sda=new SqlDataAdapter(cmd,con);
        DataTable dt=new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();
        DropDownList1.DataTextField = "Designation_Name";
        DropDownList1.DataValueField = "Desig_ID";
        DropDownList1.DataBind();    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

        int Desig_ID = Convert.ToInt32(DropDownList1.SelectedValue);
        string name = txtName.Text;
        string gender = "";
        if (RadioButton1.Checked)
        {
            gender = RadioButton1.Text;
        }
        else
        {
            gender = RadioButton2.Text;
        }
        string phone = txtPhone.Text;
        DateTime dob = Convert.ToDateTime(txtDate.SelectedDate);
        int age = Convert.ToInt32(txtAge.Text);
        string address = txtAddress.Text;
        int office_hrs = Convert.ToInt32(txtofficehrs.Text);
        string qualification = txtQualification.Text;
        int attendance = Convert.ToInt32(txtAttendance.Text);
        double salary = Convert.ToDouble(txtSalary.Text);
        string email = txtEmail.Text;
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        SqlConnection con = new SqlConnection(connection_string);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StaffEntry(Desig_ID,name,gender,phone,dob,age,address,officehrs,qualification,attendance,salary,emailid,username,password) values(@Desig_ID,@name,@gender,@phone,@dob,@age,@address,@office_hrs,@qualification,@attendance,@salary,@email,@username,@password)", con);
            cmd.Parameters.AddWithValue("Desig_ID", Desig_ID);
            cmd.Parameters.AddWithValue("name", name);

            cmd.Parameters.AddWithValue("gender", gender);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("dob", dob);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("office_hrs", office_hrs);
            cmd.Parameters.AddWithValue("qualification", qualification);

            cmd.Parameters.AddWithValue("attendance", attendance);
            cmd.Parameters.AddWithValue("salary", salary);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            cmd.ExecuteNonQuery();
            // Response.Write("Record inserted");
            Response.Write("<script>alert('Record inserted');</script>");
            Response.Redirect("Dashboard.aspx");
        }
        catch (Exception objEx)
        {
            Response.Redirect("Application_Form.aspx?Error=" + objEx.Message);
        }
        finally
        {
            con.Close();
        }  
    }
}