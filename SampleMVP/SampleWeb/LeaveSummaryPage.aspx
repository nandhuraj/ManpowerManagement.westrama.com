<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true"
    CodeBehind="LeaveSummaryPage.aspx.cs" Inherits="ManpowerManageWeb.LeaveSummaryPage" %>

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
                                        <h3 class="page-title">Leave Balance</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Leave</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Leave Balance</a></li>
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
                            <table align="center" width="100%" border="0">
                                
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div style="text-align:center;">
                                            <asp:Label ID="lblResult" runat="server" Font-Bold="true" Visible="false"></asp:Label></div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="formtd_lt">
                                        <asp:GridView ID="gvLeaveSummary" runat="server" AutoGenerateColumns="false" AllowPaging="True"
                                            AllowSorting="true" PageSize="12" Width="100%" DataKeyNames="LvId" ShowHeaderWhenEmpty="true"
                                            RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                            EmptyDataText="No Records Found">
                                           
                                            <Columns>
                                               
                                                <asp:TemplateField HeaderText="LeaveId" Visible="false">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idLvId" runat="server" Text='<%#Eval("LvId")%>' Visible="false"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Leave Type">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idLvType" runat="server" Text='<%#Eval("LvType")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Leave Entitled (days)">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idLveTot" runat="server" Text='<%#Eval("sDay")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Leave Taken (days)">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idLvTaken" runat="server" Text='<%#Eval("LeaveTaken")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Leave Balance (days)">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idLvBal" runat="server" Text='<%#Eval("LvBal")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Year">
                                                    <ItemTemplate>
                                                        <asp:Label ID="idYear" runat="server" Text='<%#Eval("yearc")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
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
