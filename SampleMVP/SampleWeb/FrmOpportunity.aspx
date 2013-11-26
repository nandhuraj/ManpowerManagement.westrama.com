<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="FrmOpportunity.aspx.cs" Inherits="ManpowerManageWeb.FrmOpportunity" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="../Scripts/common.js" type="text/javascript"></script>
<script type="text/javascript">

    function validate() {

        var txtCompanyName = document.getElementById("<%= txtCompanyName.ClientID %>");
        var ddlCompany = document.getElementById("<%= ddlCompanyName.ClientID %>");
        var ddlIndustry = document.getElementById("<%= ddlIndustry.ClientID %>");
        var ddlCategory = document.getElementById("<%= ddlCategory.ClientID %>");
        var ddlJobPosition = document.getElementById("<%= ddlJobPosition.ClientID %>");
        var ddlCountry = document.getElementById("<%= ddlCountry.ClientID %>");
        var txtSalary = document.getElementById("<%= txtSalary.ClientID %>");
        var ddlHours = document.getElementById("<%= ddlHours.ClientID %>");
        var ddlMonth = document.getElementById("<%= ddlMonth.ClientID %>");
        var ddlExperience = document.getElementById("<%= ddlExperience.ClientID %>");
        var ddlPassType = document.getElementById("<%= ddlPassType.ClientID %>");
                       
            if (txtCompanyName.value == "") {
                alert("Enter Company Name");
                txtCompanyName.focus();
                return false;
            }           

        if (ddlIndustry.selectedIndex == 0) {
            alert("Select Industry");
            ddlIndustry.focus();
            return false;
        }

        if (ddlCategory.selectedIndex == 0) {
            alert("Select Category");
            ddlCategory.focus();
            return false;
        }

        if (ddlJobPosition.selectedIndex == 0) {
            alert("Select Job Position");
            ddlJobPosition.focus();
            return false;
        }

        if (ddlCountry.selectedIndex == 0) {
            alert("Select Country");
            ddlCountry.focus();
            return false;
        }

        if (ddlPassType.selectedIndex == 0) {
            alert("Select Pass Type");
            ddlPassType.focus();
            return false;
        }

        if (txtSalary.value == "") {
            alert("Enter the Salary");
            txtSalary.focus();
            return false;
        }

        if (ddlHours.selectedIndex == 0) {
            alert("Select Working Hours");
            ddlHours.focus();
            return false;
        }

        if (ddlMonth.selectedIndex == 0) {
            alert("Select Leave/Month");
            ddlMonth.focus();
            return false;
        }

        if (ddlExperience.selectedIndex == 0) {
            alert("Select Experience");
            ddlExperience.focus();
            return false;
        }        
    }
        
</script>
    <div class="container-fluid"> 
    <table width="100%" height="100%" border="0">
        <tr>
            <td valign="top" class="row-fluid">
                 <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">Opportunity</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Manage Clients</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Opportunity</a></li>
                                            <li class="pull-right no-text-shadow"></li>
                                        </ul>
                                        <!-- END PAGE TITLE & BREADCRUMB-->
                                    </div>
                                </div>

            </td>
        </tr>
        <tr>
            <td>
                <table align="center" width="100%" border="0">

                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td width="40%">
                            <table width="100%" height="100%" border="0">
                                <tr>
                                    <td class="formtd_lt">
                                        <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:TextBox ID="txtCompanyName" CssClass="textbox" runat="server" 
                                            Visible="False" MaxLength="30" TabIndex="1"></asp:TextBox>
                                        <asp:DropDownList ID="ddlCompanyName" runat="server"  Width="130px" Visible="False">
                                        </asp:DropDownList>
                                    </td>
                                    <td></td>
                                    <td class="formtd_lt">
                                        <asp:Label ID="Label11" runat="server" Text="Industry"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlIndustry" runat="server" Width="130px" TabIndex="2">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlCategory" runat="server"  Width="130px" TabIndex="3">
                                        </asp:DropDownList>
                                    </td>
                                    <td></td>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label12" runat="server" Text="Required Job Position"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlJobPosition" runat="server" Width="130px" TabIndex="4">

                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label6" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlCountry" runat="server" Width="130px" TabIndex="5">
                                        </asp:DropDownList>
                                    </td>
                                    <td>&nbsp;</td>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label22" runat="server" Text="Pass Type"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlPassType" runat="server" Width="130px" TabIndex="6">

                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="lblFirstname" runat="server" Text="Salary"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:TextBox ID="txtSalary" runat="server" MaxLength="30" TabIndex="7"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label23" runat="server" Text="Working Hours"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlHours" runat="server" Width="130px" TabIndex="8">

                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label24" runat="server" Text="Leave/Month"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlMonth" runat="server" Width="130px" TabIndex="9">

                                        </asp:DropDownList>
                                    </td>
                                    <td></td>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label21" runat="server" Text="Required Experience"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="ddlExperience" runat="server" Width="130px" TabIndex="10">

                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label25" runat="server" Text="Accomodation"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:CheckBox ID="chkaccomodation" runat="server" TabIndex="11" />
                                    </td>
                                    <td ></td>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label26" runat="server" Text="Over Time"></asp:Label>
                                    </td>
                                    <td class="formtd_rt">
                                        <asp:CheckBox ID="chkovertime" runat="server" TabIndex="12" />
                                    </td>
                                </tr>
                                <tr>
                                    <td  class="formtd_lt">
                                        <asp:Label ID="Label8" runat="server" Text="Food"></asp:Label>
                                    </td>
                                    <td  class="formtd_rt">
                                        <asp:CheckBox ID="chkFood" runat="server" TabIndex="13" />
                                    </td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <asp:Label ID="lblrequiredmess" runat="server" Text="Label" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" 
                                CssClass="btn green" OnClientClick="javascript:return validate();" Width="82px" 
                                ToolTip="Save" TabIndex="14" />&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" 
                                CssClass="btn lightgreeen" Width="88px" ToolTip="Cancel" TabIndex="15" /></td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td>
                                        <asp:GridView ID="gvInsert" runat="server" Width="100%"
                                            RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"                                                                                       
                                            AutoGenerateColumns="False" PageSize="8" Visible="False">
                                            <Columns>
                                                <asp:TemplateField HeaderText="S.No">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblSno" runat="server" Text='<%# Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex")) + 1 %>'></asp:Label>                                                        
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="CompanyName" HeaderText="Company Name"></asp:BoundField>
                                                <asp:BoundField DataField="salary" HeaderText="Salary"></asp:BoundField>                                                
                                                <%--<asp:TemplateField HeaderText="Delete">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lblOppId" runat="server" Text="Delete" OnClick="BindDeleteData" CommandArgument='<%# Eval("CompanyName")%>'></asp:LinkButton>
                                                        <input type="hidden" id="hdnopp" runat="server" value='<%# Eval("CompanyName")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>--%>
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                   <td align="center">
                                        <asp:Button ID="btnSubmit" Visible="False" runat="server" Text="Submit"  
                                            CssClass="btn green" Width="82px" ToolTip="Submit" onclick="btnSubmit_Click1" />&nbsp;
                                        <asp:Button ID="btnClear" Visible="False" runat="server" Text="Cancel"  
                                            CssClass="btn lightgreeen" Width="88px" ToolTip="Clear" 
                                            onclick="btnClear_Click1" />
                                   </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <table width="100%" height="100%">
                                <tr>
                                    <td>
                                        <asp:GridView ID="gvOpportunity" runat="server" Width="100%"
                                            RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                            OnSorting="gvStaff_SortCommand" OnPageIndexChanging="gvStaff_PageIndexChanged"
                                            OnRowDataBound="gvStaff_RowDataBound" AllowSorting="True"
                                            AllowPaging="True" AutoGenerateColumns="False" PageSize="8">
                                            <Columns>
                                                <asp:TemplateField HeaderText="S.No">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblSno" runat="server" Text='<%# Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex")) + 1 %>'></asp:Label>
                                                        <input type="hidden" id="hdnWard" runat="server" value='<%# Eval("OppotunityId")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Staff Id">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lblStaffId" runat="server" Text='<%# Eval("OppotunityId")%>' OnClick="BindRowData"
                                                            CommandArgument='<%# Eval("OppotunityId")%>'></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="CompanyName" HeaderText="Company Name"></asp:BoundField>
                                                <asp:BoundField DataField="RequiredJobPostion" HeaderText="Required Job Postion"></asp:BoundField>
                                                <asp:BoundField DataField="PassType" HeaderText="Pass Type"></asp:BoundField>
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                </table>
            </td>
        </tr>


    </table>
        </div>
</asp:Content>
