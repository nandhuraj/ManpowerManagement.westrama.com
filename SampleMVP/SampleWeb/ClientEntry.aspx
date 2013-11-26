<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true"
    CodeBehind="ClientEntry.aspx.cs" Inherits="ManpowerManageWeb.ClientEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table width="100%" height="100%" border="0">
                <tr>
                    <td valign="top" class="row-fluid">
                        <!-- BREADCRUMB-->
                        <table width="100%" border="0">
                            <tr>
                                <td class="breadcrumb">
                                    <a href="frmhomepage.aspx" class="icon-home">Home</a>&nbsp;<span class="icon-angle-right"></span><a
                                        href="#" class="linkheader">Add Client</a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlStaffId" runat="server" Visible="true">
                            <table align="center" width="95%" border="0">
                                <tr>
                                    <td class="formtableheading" align="center" colspan="2">
                                        Add Client
                                    </td>
                                </tr>
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
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblOpprId" runat="server" Text="Opportunity Code"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:Label ID="lblOpprCode" runat="server" Style="font-weight: bold"></asp:Label>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblCustype" runat="server" Text="* Customer Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlCustType" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="lblCompName" runat="server" Text="* Company Name"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtCompName" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblSupplierType" runat="server" Text="* Supplier Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlSupplyType" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="lblUsrType" runat="server" Text="* User Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlUserType" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblCompSize" runat="server" Text="* Company Size"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlCompSize" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblWebSite" runat="server" Text="WebSite"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtWebSite" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblCompSource" runat="server" Text="* Company Source"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlCompSource" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblprimryPhone" runat="server" Text="Primary Phone"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtPrmryPhone" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp; &nbsp;&nbsp;
                                                    <asp:Label ID="lblGrpName" runat="server" Text="Group Name"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtGrpName" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblSecondPhone" runat="server" Text="Secondary Phone"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtSecPhone" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp; &nbsp;&nbsp;
                                                    <asp:Label ID="lblPrmyContPerson" runat="server" Text="Primary Cont.Person"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtPrmyContPerson" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp; &nbsp;&nbsp;
                                                    <asp:Label ID="lblOfficeEmail" runat="server" Text="Office Email"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtOfficeEmail" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblIndustType" runat="server" Text="* Industry Type"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlIndustType" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp; &nbsp;&nbsp;
                                                    <asp:Label ID="lblRemrks" runat="server" Text="Remarks"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" Height="100px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="formtd_lt">
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:Label ID="lblErrorOrResult" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    <asp:Label ID="lblCountry" runat="server" Text="*  Country"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:DropDownList ID="ddlCountry" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="formtd_lt">
                                                    &nbsp;&nbsp;
                                                    <asp:Label ID="lblZipCode" runat="server" Text="ZipCode"></asp:Label>
                                                </td>
                                                <td class="formtd_rt">
                                                    <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr align="right">
                    <td align="center">
                        <asp:Button ID="btnAddOrUpdate" runat="server" Text="Save" 
                            OnClick="btnAddOrUpdate_Click" />&nbsp;
                        <%--OnClick="btnUpdate_Click"--%>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                            OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
