<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true"
    CodeBehind="LeaveType.aspx.cs" Inherits="ManpowerManageWeb.LeaveType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
     <asp:UpdatePanel ID="updatepanel_login" runat="server">
        <ContentTemplate>
            <table width="100%" height="100%" border="0">
                <tr>
                    <td valign="top" class="row-fluid">
                       <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">Leave Policy</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Leave Policy</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">2013</a></li>
                                            <li class="pull-right no-text-shadow"></li>
                                        </ul>
                                        <!-- END PAGE TITLE & BREADCRUMB-->
                                    </div>
                                </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlStaffId" runat="server" Visible="true">
                            <table align="center" width="95%" border="0">
                               
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="Label1" runat="server" Text="Leave Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                <asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="lbl_LeaveType" runat="server" Text="Leave Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txt_LeaveType" runat="server" MaxLength="20"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Leave Type"
                                                        ControlToValidate="txt_LeaveType" ValidationGroup="g1"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="lblDays" runat="server" Text="No.of.Days"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtNoOfDay" runat="server"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter No.of Days"
                                                        ValidationGroup="g1" ControlToValidate="txtNoOfDay"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                                            ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNoOfDay"
                                                            ErrorMessage="Only Numbers" Display="None" ValidationExpression="^\d+$" ValidationGroup="g1"></asp:RegularExpressionValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                </td>
                                                <td style="text-align: Left; font-weight: bold;">
                                                    <asp:Label ID="lblError" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:Button ID="btn_SaveOrUpdate" runat="server" Text="Save" OnClick="btn_SaveOrUpdate_Click1"
                                                        ValidationGroup="g1" />&nbsp;
                                                    <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold;">
                                        <br />
                                        <asp:Label ID="lblGridResult" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="formtd_lt">
                                        <asp:GridView ID="gvLeaveType" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                            AllowSorting="true" PageSize="12" Width="100%" DataKeyNames="cLeaveTypeId" ShowHeaderWhenEmpty="true"
                                            RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                            EmptyDataText="No Records Found">
                                            <Columns>
                                                <asp:TemplateField HeaderText="SNo">
                                                    <ItemTemplate>
                                                        <%# Container.DataItemIndex + 1 %>
                                                    </ItemTemplate>
                                                    <ItemStyle Width="2%" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="cLeaveType" HeaderText="Leave Type" />
                                                <asp:BoundField DataField="cDays" HeaderText="Days" />
                                                <asp:BoundField DataField="cYear" HeaderText="Year" />
                                                <asp:TemplateField HeaderText="Edit">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imgEdit" ImageUrl="~/Images/edit.jpg" runat="server" Width="25"
                                                            Height="25" OnClick="imgbtn_Click" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="4%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Del">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imgDel" ImageUrl="~/Images/delete.jpg" runat="server" Width="25"
                                                            Height="25" OnClick="imgDel_Click" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="4%" />
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
       </div>
</asp:Content>
