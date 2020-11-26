\<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

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
                    <a class="navbar-brand" href="#"></i>&nbsp;ADMINISTRATION</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="logout.aspx">Logout</a></li>
                         
                    </ul>
                </div>

            </div>
        </div>
        <!-- /. NAV TOP  -->
        <nav class="navbar-default navbar-side" role="navigation">
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

        </nav>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h2>Update Employee</h2>
                    </div>
                    <div class="col-md-12">
                        <h3>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </h3>
                    </div>
                </div>
                <!-- /. ROW  -->
              
           
                <!-- /. ROW  -->
                <hr />
                <div class="row">
                    <div class="col-md-4">
                    <div class="form-group">
                           <!-- <asp:Label ID="lblEmpID" runat="server" Text="Label" Visible="False"></asp:Label>  </div>-->
                        
                        <div class="form-group">
                            <asp:Label ID="lblProdName" runat="server" Text="Product Name"></asp:Label>
                                 <asp:TextBox ID="txtProdName" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        

                         <div class="form-group">
                           <asp:Label ID="lblPrice" runat="server" Text="Product Price"></asp:Label>
                                 <asp:TextBox ID="txtPrice" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        
  

                <div class="form-group">
                         <asp:Label ID="lblDetails" runat="server" Text="Product Details"></asp:Label>
                    <asp:TextBox ID="txtDetails" runat="server" class="form-control"></asp:TextBox>
                        </div>

                         
 
                        <br />
                        <br />
                        <br />
                         <div class="form-group">
                            <label></label>
                             <asp:Button ID="Button1" runat="server" Text="Add Product"  
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