<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ManpowerManageWeb.Login" %>

<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->

<html lang="en">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <title>Manpower Management System</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta content="" name="description" />
    <meta content="" name="author" />
    <link href="assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/metro.css" rel="stylesheet" />
    <link href="assets/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />
    <link href="assets/css/style_responsive.css" rel="stylesheet" />
    <link href="assets/css/style_default.css" rel="stylesheet" id="style_color" />
    <link rel="stylesheet" type="text/css" href="assets/gritter/css/jquery.gritter.css" />
    <link rel="stylesheet" type="text/css" href="assets/uniform/css/uniform.default.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-daterangepicker/daterangepicker.css" />
    <link href="assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css" rel="stylesheet" />
    <link href="assets/jqvmap/jqvmap/jqvmap.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="assets/data-tables/DT_bootstrap.css" media="screen" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="favicon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body class="">

    <form id="form1" runat="server">
        <table width="100%" cellpadding="0" cellspacing="0" height="100%" border="0">
            <tr>
                <td>
                    <!-- BEGIN HEADER -->
                    <div class="header navbar navbar-inverse navbar-fixed-top">
                        <!-- BEGIN TOP NAVIGATION BAR -->
                        <div class="navbar-inner">
                            <div class="container-fluid">
                                <!-- BEGIN LOGO -->
                                <a class="brand" href="Login.aspx">
                                    <img src="images/img/logo.png" class="logoImg" style="max-width: 300px; height: auto;" alt="manpower Management System" />
                                </a>
                                <!-- END LOGO -->

                                <!-- END TOP NAVIGATION MENU -->
                            </div>
                        </div>
                        <!-- END TOP NAVIGATION BAR -->
                    </div>
                    <!-- END HEADER -->
                </td>
            </tr>
           <tr>
               <td height="200">&nbsp;</td>
           </tr>
            <tr>
                <td align="center">
                   
                        <table border="0" width="50%">
                          
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="formtd_lt">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Text="User Name:"
                                        ></asp:Label></td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="UserName" runat="server" CssClass="textboxStyle" MaxLength="30" TabIndex="1"></asp:TextBox>
                                    <%-- <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                                CssClass="clsValidator" SetFocusOnError="true" Display="None" ErrorMessage="User Name is required." 
                                                                ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_rt">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Text="Password:"
                                       ></asp:Label></td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="textboxStyle"
                                        MaxLength="15" TabIndex="2"></asp:TextBox>
                                    <%--  <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                                CssClass="clsValidator" SetFocusOnError="true"   Display="None" ErrorMessage="Password is required."
                                                                ToolTip="Password is required." ValidationGroup="Login1" >*</asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" >
                                    <asp:Label ID="FailureText"  runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <%-- <asp:HyperLink ID="hlNewRegister" CssClass="ClsLoginHlink" runat="server" NavigateUrl="~/Profiles/Registration.aspx">New Register</asp:HyperLink>
                                                            &nbsp;&nbsp;--%>
                                    <asp:HyperLink ID="hlForgotPassword" CssClass="ClsLoginHlink" Font-Underline="true" runat="server" TabIndex="5" Font-Size="Small">Forgot Password ?</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="BtnLogin" CssClass="btn green"  runat="server" CommandName="Login" Text="Log In" BorderStyle="None"  TabIndex="3"
                                        ValidationGroup="Login1" OnClick="BtnLogin_Click" />&nbsp;&nbsp;
                                    <asp:Button ID="btnClear" CssClass="btn lightgreen"  TabIndex="4" runat="server" CommandName="Clear" Text="Clear" BorderStyle="None" 
                                        ToolTip="Clear" />
                                    <%-- <asp:ValidationSummary DisplayMode="List" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="Login1" ID="validationsummary"/>--%>
                                </td>
                            </tr>
                         
                        </table>
                    
                </td>
            </tr>
             <tr>
               <td height="200">&nbsp;</td>
           </tr>
            <tr>
                <td>

                    <!-- BEGIN FOOTER -->
                    <div class="footer">
                        2013 &copy; All Rights Reserved.
  <div class="span pull-right"><span class="go-top"><i class="icon-angle-up"></i></span></div>
                    </div>
                    <!-- END FOOTER -->
                </td>
            </tr>
        </table>
        <!-- BEGIN JAVASCRIPTS -->
        <!-- Load javascripts at bottom, this will reduce page load time -->
        <script src="assets/js/jquery-1.8.3.min.js"></script>
        <!--[if lt IE 9]>
	<script src="assets/js/excanvas.js"></script>
	<script src="assets/js/respond.js"></script>	
	<![endif]-->
        <script src="assets/breakpoints/breakpoints.js"></script>
        <script src="assets/jquery-slimscroll/jquery-ui-1.9.2.custom.min.js"></script>
        <script src="assets/jquery-slimscroll/jquery.slimscroll.min.js"></script>
        <script src="assets/fullcalendar/fullcalendar/fullcalendar.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.blockui.js"></script>
        <script src="assets/js/jquery.cookie.js"></script>
        <script src="assets/flot/jquery.flot.js"></script>
        <script src="assets/flot/jquery.flot.resize.js"></script>
        <script type="text/javascript" src="assets/gritter/js/jquery.gritter.js"></script>
        <script type="text/javascript" src="assets/uniform/jquery.uniform.min.js"></script>
        <script type="text/javascript" src="assets/js/jquery.pulsate.min.js"></script>
        <script type="text/javascript" src="assets/bootstrap-daterangepicker/date.js"></script>
        <script type="text/javascript" src="assets/bootstrap-daterangepicker/daterangepicker.js"></script>
        <script src="assets/js/app.js"></script>
        <script type="text/javascript" src="assets/data-tables/jquery.dataTables.js"></script>
        <script type="text/javascript" src="assets/data-tables/DT_bootstrap.js"></script>
        <script>
            jQuery(document).ready(function () {
                App.setPage("index");  // set current page
                App.init(); // init the rest of plugins and elements
            });
        </script>

        <!-- END JAVASCRIPTS -->

    </form>
</body>
</html>
