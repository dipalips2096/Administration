using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class UpdateStaffFinal : System.Web.UI.Page
{ string connection_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\aspwebsite\NewVisionProject\App_Data\Office.mdf;Integrated Security=True;User Instance=True";
string uname; int empid; 
    protected void Page_Load(object sender, EventArgs e)
    {
        uname =Session["username"].ToString();
        Label1.Visible = false;
        if (!IsPostBack)
        {
        }

     /*   SqlConnection con = new SqlConnection(connection_string);
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

        */



    }


    protected void Button1_Click1(object sender, EventArgs e)
    {

        SqlConnection con1 = new SqlConnection(connection_string);
        con1.Open();

        SqlCommand command = new SqlCommand("SELECT Emp_ID FROM StaffEntry where username=@username;", con1);
        command.Parameters.AddWithValue("@username", uname);

        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                 
               empid=reader.GetInt32(0) ;
            }
        }
        else
        {
            Console.WriteLine("No rows found.");
        }
        reader.Close();
        con1.Close();




       
        //int Desig_ID = Convert.ToInt32(DropDownList1.SelectedValue);
        string name = txtName.Text;
     /*  string gender = "";
        if (RadioButton1.Checked)
        {
            gender = RadioButton1.Text;
        }
        else
        {
            gender = RadioButton2.Text;
        } */
        string phone = txtPhone.Text;
      //  DateTime dob = Convert.ToDateTime(txtDate.SelectedDate);
        // int age = Convert.ToInt32(txtAge.Text);
     //    string address = txtAddress.Text;
      //   int office_hrs = Convert.ToInt32(txtofficehrs.Text);
      //  string qualification = txtQualification.Text;
     //   int attendance = Convert.ToInt32(txtAttendance.Text);
    //    double salary = Convert.ToDouble(txtSalary.Text);
        string email = txtEmail.Text;
         string username = txtUsername.Text;
      //  string password = txtPassword.Text;
        SqlConnection con = new SqlConnection(connection_string);
        try
        {
            con.Open();
            int Emp_ID = empid;
      //  SqlCommand cmd = new SqlCommand("update StaffEntry set Emp_ID=@Emp_ID,Desig_ID=@Desig_ID,name=@name,gender=@gender,phone=@phone,dob=@dob,age=@age,address=@address,officehrs=@officehrs,qualification=@qualification,attendance=@attendance,salary=@salary,username=@username,password=@password where Emp_ID=@Emp_ID", con);
        
  string query="update StaffEntry SET name='"+txtName.Text+"'emailid='"+txtEmail.Text+"',phone='"+txtPhone.Text+"',username='"+txtUsername.Text+"'where Emp_ID='"+empid+"' ";
  string query1 = "update StaffEntry set name=@name,emailid=@emailid,phone=@phone,username=@username where Emp_ID=@Emp_ID";
  SqlCommand cmd = new SqlCommand(query1, con);

 // cmd.Parameters.AddWithValue("@Emp_ID", txtUsername.Text);
  cmd.Parameters.AddWithValue("Emp_ID", Emp_ID);
            cmd.Parameters.AddWithValue("@name", txtUsername.Text);
             
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            
            cmd.Parameters.AddWithValue("@emailid", txtEmail.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
          
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record updated');</script>");
           
            Response.Redirect("Dashboard.aspx");
        }
        catch (Exception objEx)
        {

          
        }
        finally
        {
            con.Close();
        }  
    }
}