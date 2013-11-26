<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true"
    CodeBehind="ClientViewEdit.aspx.cs" Inherits="ManpowerManageWeb.ClientViewEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid"> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table width="100%" height="100%" border="0">
                <tr>
                    <td valign="top" >
                        <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">View My Clients</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Manage Clients</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">My Clients</a></li>
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
                                    <td class="formtd_rt">&nbsp;
                                        <asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label>
                                        &nbsp;
                                        <asp:TextBox ID="txtSearch" runat="server" Width="300px"></asp:TextBox>&nbsp;
                                        <ajax:TextBoxWatermarkExtender ID="txtAutoCompleteforCompany_waterMark" runat="server"
                                            TargetControlID="txtSearch" WatermarkText="Search Company Name..." Enabled="true">
                                        </ajax:TextBoxWatermarkExtender>
                                        <ajax:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" DelimiterCharacters=""
                                            Enabled="True" ServiceMethod="GetCompanyNames" MinimumPrefixLength="1" EnableCaching="true"
                                            ServicePath="" TargetControlID="txtSearch" CompletionInterval="10" CompletionSetCount="20">
                                        </ajax:AutoCompleteExtender>
                                        <asp:ImageButton ID="imgSearch" ImageUrl="~/Images/img/search-icon.png" runat="server"
                                            Width="25" Height="25" OnClick="imgSearch_Click" />&nbsp;
                                        <%-- <asp:ImageButton ID="imgAdd" ImageUrl="~/Images/AddNew.jpg" runat="server" Width="25"
                    Height="25" OnClick="imgAdd_Click" />--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <div style="text-align: center">
                                            <asp:Label ID="lblresult" runat="server" Font-Bold="true" Font-Size="Medium" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView runat="server" ID="gvdClientDetails" AutoGenerateColumns="false" DataKeyNames="CompanyID"
                                            AllowPaging="True" AllowSorting="true" PageSize="12" Width="100%" ShowHeaderWhenEmpty="true"
                                            RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                            EmptyDataText="No Records Found" >
                                        <columns>
                                                <asp:TemplateField HeaderText="Sno">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblSno" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="CompanyName" HeaderText="Comp.Name" />
                                                <asp:BoundField DataField="GroupName" HeaderText="Group" />
                                                <asp:BoundField DataField="PrimaryPhone" HeaderText="Contact No" />
                                                <asp:BoundField DataField="City" HeaderText="City" />
                                                <asp:BoundField DataField="CountryName" HeaderText="Country" />
                                                <asp:BoundField DataField="PrimaryContactPerson" HeaderText="Contact Person" />
                                                <asp:BoundField DataField="CustomerTypeDesc" HeaderText="Cust.Type" />
                                                <asp:BoundField DataField="OfficialEmailID" HeaderText="Mail-Id" />
                                                <asp:BoundField DataField="OppotunityId" HeaderText="Oppr-Id" />
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imgEdit" ImageUrl="~/Images/Edit.jpg" runat="server" Height="25"
                                                            ToolTip="Edit" OnClick="imgEdit_Click" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <%-- <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ID="imgDel" CommandName="Delete" ImageUrl="~/Images/delete.jpg"
                                    runat="server" Height="25" ToolTip="Delete" />
                                <!--OnClick="imgDelete_Click"-->
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                                            </columns>
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
