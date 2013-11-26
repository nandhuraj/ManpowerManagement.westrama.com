<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ManpowerManageWeb.ChangePassword" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid"> 
    <table width="100%" height="100%" border="0">
        <tr>
            <td valign="top" class="row-fluid">
                <!-- BREADCRUMB-->
                <table width="100%" border="0">
                   
                    <div class="row-fluid">
                        <div class="span12">
                            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                            <h3 class="page-title">Change Password</h3>
                            <ul class="breadcrumb">
                                <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Profile</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Change Password</a></li>
                                <li class="pull-right no-text-shadow"></li>
                            </ul>
                            <!-- END PAGE TITLE & BREADCRUMB-->
                        </div>
                      </div>
                </table>

            </td>
        </tr>
        <tr>
            <td>
                 <div class="row-fluid">
                <table width="95%" align="center" height="100%" border="0">
                   
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="formtd_lt">&nbsp;<asp:Label ID="lblCurrentPassword" runat="server" Text="Current Password:"></asp:Label></td>
                        <td class="formtd_rt">
                            <asp:TextBox ID="txtCurrentPassword" runat="server"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td class="formtd_lt">&nbsp;<asp:Label ID="Label1" runat="server" Text="New Password"></asp:Label></td>
                        <td class="formtd_rt">
                            <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td class="formtd_lt">&nbsp;<asp:Label ID="Label2" runat="server" Text="Confirm New Password:"></asp:Label></td>
                        <td class="formtd_rt">
                            <asp:TextBox ID="txtConfirmNewPassword" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="formtd_lt">
                            <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" CssClass="btn green"
                                OnClick="btnChangePassword_Click" /></td>
                        <td class="formtd_rt">
                            <asp:Button ID="btnClear" runat="server" CssClass="btn lightgreen" Text="Clear" /></td>
                    </tr>
                </table>
            </div>
                     </td>
        </tr>
    </table>
          </div>
</asp:Content>

