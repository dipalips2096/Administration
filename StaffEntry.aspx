<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="StaffEntry.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <!-- BOOTSTRAP STYLES-->
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
    <!-- FONTAWESOME STYLES-->
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
    <!-- CUSTOM STYLES-->
    <link href="assets/css/custom.css" rel="stylesheet" />
    <!-- GOOGLE FONTS-->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="adjust-nav">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#"><i class="fa fa-square-o "></i>&nbsp;ADMINISTRATION</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        
                         
                        <li><a href="logout.aspx">LOGOUT</a></li>
                    </ul>
                </div>

            </div>
        </div>
        <!-- /. NAV TOP  -->
        <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
        <div class="sidebar-collapse">
                <ul class="nav" id="main-menu">
                    <li class="text-center user-image-back">
                        <img src="assets/img/find_user.png" class="img-responsive" />
                     
                    </li>

                    
                    <li>
                        <a href="Dashboard.aspx"><i class="fa fa-desktop "></i>Dashboard</a>
                    </li>
                    <li>
                        <a href="ViewStaffDetails.aspx"><i class="fa fa-edit "></i>View Staff Details<span class=""></span></a>
                        
                    </li>

                    <li>
                        <a href="StaffEntry.aspx"><i class="fa fa-table "></i>Employee Details Registration</a>
                    </li>
                    <li>
                        <a href="UpdateStaff.aspx"><i class="fa fa-edit "></i>Update Employee Details </a>
                    </li>


                    <li>
                        <a href="DeleteEmployee.aspx"><i class="fa fa-sitemap "></i>Delete Employee<span class=""></span></a>
                        
                    </li>
                    <li>
                        <a href="ViewStaffDetails.aspx"><i class="fa fa-qrcode "></i>Print Employee Records</a>
                    </li>
                    <li>
                        <a href="AddProduct.aspx"><i class="fa fa-bar-chart-o"></i>Add Products</a>
                    </li>

                    <li>
                        <a href="Invoice.aspx"><i class="fa fa-edit "></i>Invoice of products</a>
                    </li>
                    
                </ul>

            </div>

            </div>

        </nav>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h2>Add Employee</h2>
                    </div>
                </div>
                <!-- /. ROW  -->
              
           
                <!-- /. ROW  -->
                <hr />
                <div class="row">
                    <div class="col-md-4">
                    <div class="form-group">
                            <asp:Label ID="lblEmpID" runat="server" Text="Label" Visible="False"></asp:Label>  </div>
                        <div class="form-group">
                              <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
               
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" class="form-control"></asp:DropDownList>
                            
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                                 <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
                        </div>

                         <div class="form-group">
                              <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender"    /> 
                        </div>

                         <div class="form-group">
                           <asp:Label ID="lblPhone" runat="server" Text="Phone" ></asp:Label>
                                 <asp:TextBox ID="txtPhone" runat="server" class="form-control" MaxLength="10"></asp:TextBox>
                        </div>

                        

                         <div class="form-group">
                            <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                              <asp:TextBox ID="txtAge" runat="server"  class="form-control" MaxLength="3"></asp:TextBox> 
                        </div>

                         <div class="form-group">
                       <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                           <asp:TextBox ID="txtAddress" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                        </div>

                          <div class="form-group">
                         <asp:Label ID="lblOfficehrs" runat="server" Text="Office Hours"></asp:Label>
                          <asp:TextBox ID="txtofficehrs" runat="server" class="form-control"></asp:TextBox>
                        </div>

                            <div class="form-group">
                          <asp:Label ID="lblQualification" runat="server" Text="Qualification"></asp:Label>
                       <asp:TextBox ID="txtQualification" runat="server" class="form-control"></asp:TextBox>
                        </div>

                            <div class="form-group">
                          <asp:Label ID="lblAttendance" runat="server" Text="Attendance"></asp:Label>
                     <asp:TextBox ID="txtAttendance" runat="server"  class="form-control"></asp:TextBox>
                        </div>

                            <div class="form-group">
                           <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
           <asp:TextBox ID="txtSalary" runat="server" class="form-control"></asp:TextBox>     
             </div>

                <div class="form-group">
                         <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                     

                          <div class="form-group">
                           <asp:Label ID="lblUsername" runat="server" Text="UserName"></asp:Label>
                      <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
                        </div>

                          <div class="form-group">
                           <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                     <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>

                         <div class="form-group">
                          <asp:Label ID="lblDOB" runat="server" Text="DOB"></asp:Label>
                             <asp:Calendar ID="txtDate" runat="server"    ></asp:Calendar>        
                        </div>
                        <br />
                        <br />
                        <br />
                         <div class="form-group">
                            <label></label>
                             <asp:Button ID="Button1" runat="server" Text="Add Employee"  
                                 class="btn btn-danger btn-lg btn-block" onclick="Button1_Click1" /> 
                        </div>
                    </div>
                    
                   
                </div>
                <hr />
               


      
                <!-- /. ROW  -->
 
                <!-- /. ROW  -->

            </div>
            <!-- /. PAGE INNER  -->
        </div>
        <!-- /. PAGE WRAPPER  -->
    </div>
    <!-- /. WRAPPER  -->
    <!-- SCRIPTS -AT THE BOTOM TO REDUCE THE LOAD TIME-->
    <!-- JQUERY SCRIPTS -->
    <script src="assets/js/jquery-1.10.2.js"></script>
    <!-- BOOTSTRAP SCRIPTS -->
    <script src="assets/js/bootstrap.min.js"></script>
    <!-- METISMENU SCRIPTS -->
    <script src="assets/js/jquery.metisMenu.js"></script>
    <!-- CUSTOM SCRIPTS -->
    <script src="assets/js/custom.js"></script>

    </form>
</body>
</html>
