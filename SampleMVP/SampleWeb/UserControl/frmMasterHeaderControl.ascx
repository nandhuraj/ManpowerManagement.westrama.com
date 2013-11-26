<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="frmMasterHeaderControl.ascx.cs" Inherits="ManpowerManageWeb.frmMasterHeaderControl" %>
<table width="100%" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td >
             <a class="" href="index.html">
                <img src="images/img/logo.png" height="60" width="180" alt="manpower Management System" />
            </a>
        </td>
        <td align="right">
             <!-- BEGIN USER LOGIN DROPDOWN -->
                <li ><a href="#" class="dropdown-toggle" data-toggle="dropdown">
                    <img alt="" src="assets/img/avatar1_small.jpg" />
                  
                    <asp:Label ID="lblUserName" runat="server" Text="Admin" class="username" ></asp:Label> 
                    
                </li>
        </td>
    </tr>
</table>