<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="frmStaffDetails.aspx.cs" Inherits="ManpowerManageWeb.frmStaffDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="../Scripts/common.js" type="text/javascript"></script>
    <script type="text/javascript">
        function validate() {
            var txtStaffId = document.getElementById("<%= txtStaffId.ClientID %>");
            var txtFirstName = document.getElementById("<%= txtFirstname.ClientID %>");
            var txtLastName = document.getElementById("<%= txtLastName.ClientID %>");
            var ddlTitle = document.getElementById("<%= ddlTitle.ClientID %>");
            var ddlStaffType = document.getElementById("<%= ddlStaffType.ClientID %>");
            var ddlUserType = document.getElementById("<%= ddlUserType.ClientID %>");
            var txtUserName = document.getElementById("<%= txtUserName.ClientID %>");
            var txtAddress1 = document.getElementById("<%= txtAddress1.ClientID %>");
            var txtCity = document.getElementById("<%= txtCity.ClientID %>");
            var txtState = document.getElementById("<%= txtState.ClientID %>");
            var txtZip = document.getElementById("<%= txtZip.ClientID %>");
            var ddlCountry = document.getElementById("<%= ddlCountry.ClientID %>");
            var txtContactNo = document.getElementById("<%= txtContactNo.ClientID %>");
            var txtEmerContactNo = document.getElementById("<%= txtEmerContactNo.ClientID %>");
            var txtEmail = document.getElementById("<%= txtEmail.ClientID %>");
            var txtQualification = document.getElementById("<%= txtQualification.ClientID %>");
            var ddlStaffTeam = document.getElementById("<%= ddlStaffTeam.ClientID %>");
            var ddlCustomerType = document.getElementById("<%= ddlCustomerType.ClientID %>");
            var txtStaffPosition = document.getElementById("<%= txtStaffPosition.ClientID %>");
            var txtStaffRate = document.getElementById("<%= txtStaffRate.ClientID %>");
            var txtCommissionRate = document.getElementById("<%= txtCommissionRate.ClientID %>");
            var txtCommissionType = document.getElementById("<%= txtCommissionType.ClientID %>");

            if (txtStaffId.value == "") {
                alert("Enter the StaffId");
                txtStaffId.focus();
                return false;
            }
            if (ddlTitle.selectedIndex == 0) {
                alert("Select Title");
                ddlTitle.focus();
                return false;
            }
            if (txtFirstName.value == "") {
                alert("Enter the First Name");
                txtFirstName.focus();
                return false;
            }
            if (txtLastName.value == "") {
                alert("Enter the Last Name");
                txtLastName.focus();
                return false;
            }

            if (ddlStaffType.selectedIndex == 0) {
                alert("Select Staff Type");
                ddlStaffType.focus();
                return false;
            }
            if (ddlUserType.selectedIndex == 0) {
                alert("Select User Type");
                ddlUserType.focus();
                return false;
            }
            if (txtUserName.value == "") {
                alert("Enter UserName");
                txtUserName.focus();
                return false;
            }
            if (txtAddress1.value == "") {
                alert("Enter Address1");
                txtAddress1.focus();
                return false;
            }
            if (txtCity.value == "") {
                alert("Enter City");
                txtCity.focus();
                return false;
            }
            if (txtState.value == "") {
                alert("Enter State");
                txtState.focus();
                return false;
            }
            if (txtZip.value == "") {
                alert("Enter Zip");
                txtZip.focus();
                return false;
            }
            if (ddlCountry.selectedIndex == 0) {
                alert("Select Country");
                ddlCountry.focus();
                return false;
            }
            if (txtContactNo.value == "") {
                alert("Enter ContactNo");
                txtContactNo.focus();
                return false;
            }
            if (txtEmerContactNo.value == "") {
                alert("Enter Emergency ContactNo");
                txtEmerContactNo.focus();
                return false;
            }
            if (txtEmail.value == "") {
                alert("Enter Email");
                txtEmail.focus();
                return false;
            }
            else {
                if (txtEmail.value != "") {
                    if (!checkEmail(document.getElementById('<%=txtEmail.ClientID%>'))) {
                        alert("Invalid Email Format");
                        return false;
                    }
                }
            }
            if (txtQualification.value == "") {
                alert("Enter Qualification");
                txtQualification.focus();
                return false;
            }
            if (ddlCustomerType.selectedIndex == 0) {
                alert("Select Customer Type");
                ddlCustomerType.focus();
                return false;
            }
            if (ddlStaffTeam.selectedIndex == 0) {
                alert("Select Staff Team");
                ddlStaffTeam.focus();
                return false;
            }
            if (txtStaffPosition.value == "") {
                alert("Enter Staff Position");
                txtStaffPosition.focus();
                return false;
            }
            if (txtStaffRate.value == "") {
                alert("Enter Staff Rate");
                txtStaffRate.focus();
                return false;
            }
            if (txtCommissionRate.value == "") {
                alert("Enter Commission Rate");
                txtCommissionRate.focus();
                return false;
            }
            if (txtCommissionType.value == "") {
                alert("Enter Commission Type");
                txtCommissionType.focus();
                return false;
            }

        }        

    </script>
    <div class="container-fluid"> 
    <table width="100%" height="100%" border="0">
         <tr>
            <td valign="top"  class="row-fluid">
                <div class="row-fluid">
                        <div class="span12">
                            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                            <h3 class="page-title">Staff Details</h3>
                            <ul class="breadcrumb">
                                <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Staff</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Staff Details</a></li>
                                <li class="pull-right no-text-shadow"></li>
                            </ul>
                            <!-- END PAGE TITLE & BREADCRUMB-->
                        </div>
                    </div>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlStaffId" runat="server">
                    <table align="center"  width="100%" border="0">
                       
                        <tr>
                            <td>
                                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label1" runat="server" Text="Staff Id"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtStaffId" runat="server" MaxLength="30" TabIndex="1"></asp:TextBox>
                                        </td>
                                        <td></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label11" runat="server" Text="Title"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList ID="ddlTitle" CssClass="ddlist" runat="server" Width="130px" 
                                                TabIndex="2">
                                                <asp:ListItem Value="0">--Select--</asp:ListItem>
                                                <asp:ListItem Value="1">Mr</asp:ListItem>
                                                <asp:ListItem Value="2">Mrs</asp:ListItem>
                                                <asp:ListItem Value="3">Miss</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="lblFirstname" runat="server" Text="First Name"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtFirstname" runat="server" MaxLength="30" TabIndex="3"></asp:TextBox>
                                        </td>
                                        <td></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label18" runat="server" Text="Middle Name"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtMiddleName" runat="server" MaxLength="30" TabIndex="4"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label13" runat="server" Text="Last Name"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="30" TabIndex="5"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label19" runat="server" Text="User Name"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtUserName" runat="server" MaxLength="30" TabIndex="6"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label4" runat="server" Text="Address1"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtAddress1" runat="server" MaxLength="30" TabIndex="7"></asp:TextBox>
                                        </td>
                                        <td></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label14" runat="server" Text="Address2"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtAddress2" runat="server" MaxLength="30" TabIndex="8"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtCity" runat="server" MaxLength="30" TabIndex="9"></asp:TextBox>
                                        </td>
                                        <td></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label15" runat="server" Text="State"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtState" runat="server" MaxLength="30" TabIndex="10"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label20" runat="server" Text="Zip"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtZip" runat="server" MaxLength="6" TabIndex="11"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label6" runat="server" Text="Country"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList ID="ddlCountry" CssClass="ddlist" runat="server" 
                                                Width="130px" TabIndex="12">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label16" runat="server" Text="Contact No"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtContactNo" runat="server" MaxLength="13" TabIndex="13"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label7" runat="server" Text="Emergency Contact No"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtEmerContactNo" runat="server" MaxLength="13" TabIndex="14"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label8" runat="server" Text="Qualification" Visible="False"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtQualification" runat="server" Visible="False" 
                                                MaxLength="10" TabIndex="15"></asp:TextBox>
                                        </td>
                                        <td></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label17" runat="server" Text="Email"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtEmail" runat="server" MaxLength="30" TabIndex="16"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label2" runat="server" Text="Staff Type"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList CssClass="ddlist" ID="ddlStaffType" runat="server" 
                                                TabIndex="17">
                                            </asp:DropDownList>
                                        </td>
                                        <td >&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label12" runat="server" Text="User Type"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList ID="ddlUserType" CssClass="ddlist" runat="server" 
                                                Width="130px" TabIndex="18">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label21" runat="server" Text="Customer Type"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList ID="ddlCustomerType" CssClass="ddlist" runat="server" 
                                                Width="130px" TabIndex="19">
                                            </asp:DropDownList>
                                        </td>
                                        <td ></td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label22" runat="server" Text="Staff Team"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:DropDownList ID="ddlStaffTeam" CssClass="ddlist" runat="server" 
                                                Width="130px" TabIndex="20">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label23" runat="server" Text="Staff Position"></asp:Label>
                                        </td>
                                        <td class="formtd_rt"">
                                            <asp:TextBox ID="txtStaffPosition" runat="server" MaxLength="30" TabIndex="21"></asp:TextBox>
                                        </td>
                                        <td >&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label24" runat="server" Text="Staff Rate"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtStaffRate" runat="server" MaxLength="30" TabIndex="22"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label25" runat="server" Text="Commission Rate"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtCommissionRate" runat="server" MaxLength="30" TabIndex="23"></asp:TextBox>
                                        </td>
                                        <td >&nbsp;</td>
                                        <td class="formtd_lt">
                                            <asp:Label ID="Label26" runat="server" Text="Commission Type"></asp:Label>
                                        </td>
                                        <td class="formtd_rt">
                                            <asp:TextBox ID="txtCommissionType" runat="server" MaxLength="30" TabIndex="24"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="5">
                                            <asp:Label ID="lblrequiredmess" CssClass="errormsg"  runat="server" Text="" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>

                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" border="0">
                                    <tr>
                                        <td align="center">
                                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" 
                                                OnClientClick="javascript:return validate();" Width="82px" ToolTip="Save" 
                                                TabIndex="25" />&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Width="88px" 
                                                ToolTip="Cancel" TabIndex="26" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" border="0">
                                    <tr>
                                        <td>
                                            <asp:GridView ID="gvStaff" runat="server" Width="100%"
                                                RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                                OnSorting="gvStaff_SortCommand" OnPageIndexChanging="gvStaff_PageIndexChanged"
                                                OnRowDataBound="gvStaff_RowDataBound" AllowSorting="True"
                                                AllowPaging="True" AutoGenerateColumns="False" PageSize="8">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S.No">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSno" runat="server" Text='<%# Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex")) + 1 %>'></asp:Label>
                                                            <input type="hidden" id="hdnWard" runat="server" value='<%# Eval("UserId")%>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Staff Id">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lblStaffId" runat="server" Text='<%# Eval("UserId")%>' OnClick="BindRowData"
                                                                ommandArgument='<%# Eval("UserId")%>'></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="FirstName" HeaderText="First Name"></asp:BoundField>
                                                    <asp:BoundField DataField="MiddleName" HeaderText="Middle Name"></asp:BoundField>
                                                    <asp:BoundField DataField="LastName" HeaderText="Last Name"></asp:BoundField>
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
        </div>
</asp:Content>
