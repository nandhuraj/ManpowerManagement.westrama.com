<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="frmStaffType.aspx.cs" Inherits="ManpowerManageWeb.frmStaffType" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../Scripts/common.js" type="text/javascript"></script>
    <script type="text/javascript">
        function validate() {
            var txtStaffType = document.getElementById("<%= txtStaffType.ClientID %>");

            if (txtStaffType.value == "") {
                alert("Enter Staff Type");
                txtStaffType.focus();
                return false;
            }
        }

        /*This Function allow only Number Character */
        function ALLOWNUMBER(eventobj, previousObj, txtObj, objcid) {
            var objcid1 = document.getElementById(objcid);
            var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
            if (previousObj != null && previousObj != '') {
                if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
                    previousObj.focus();
                    return false;
                }
            }
            if (EnterCode == 13) {
                objcid1.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
                return;
            }
            if (EnterCode >= 48 && EnterCode <= 57) {
                return true;
            }
            else {
                return false;
            }
        }

        /*This Function allow only Character */
        function ALLOWCHAR(eventobj, previousObj, txtObj, objcid) {
            //alert(txtObj.value.indexOf((txtObj.value.length)));
            var objcid1 = document.getElementById(objcid);
            var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;

            if (previousObj != null && previousObj != '') {
                if (previousObj.value == "" && txtObj.value == "") {
                    previousObj.focus();
                    return false;
                }
            }

            if (EnterCode == 13) {
                objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
                return;
            }

            if (EnterCode == 64) {
                return false;
            }


            if ((EnterCode >= 65 && EnterCode <= 90) || EnterCode == 32) {

                return true;
            }
            else {
                if (EnterCode >= 97 && EnterCode <= 122) {
                    return true;
                }
                else {
                    return false;
                }
            }

        }

    </script>
    <div class="container-fluid">
        <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="top" class="row-fluid">
                    <div class="row-fluid">
                        <div class="span12">
                            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                            <h3 class="page-title">Staff Types</h3>
                            <ul class="breadcrumb">
                                <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Staff</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Staff Types</a></li>
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
                        <table align="center" width="100%" border="0" cellpadding="0" cellspacing="0">
                           
                            <tr>
                                <td class="formtd_lt">
                                    <asp:Label ID="Label1" runat="server" Text="Staff Type"></asp:Label>
                                </td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="txtStaffType" runat="server" MaxLength="30" TabIndex="1"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="2" align="center">
                                    <asp:Label ID="lblrequiredmess" CssClass="errormsg" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"
                                        OnClientClick="javascript:return validate();" Width="82px" ToolTip="Save"
                                        TabIndex="2" />&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"
                            Width="88px" ToolTip="Cancel" TabIndex="3" /></td>
                            </tr>
                            <tr>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:GridView ID="gvStaffType" runat="server" Width="100%"
                                        RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                        OnSorting="gvStaffType_SortCommand" OnPageIndexChanging="gvStaffType_PageIndexChanging" AllowSorting="True"
                                        AllowPaging="True" AutoGenerateColumns="False" PageSize="8">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S.No">
                                                <HeaderStyle Wrap="false" />
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSno" Text=' <%# Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex")) + 1 %>' runat="server"></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Staff Type">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lblStaffType" runat="server" Text='<%# Eval("StaffTypeName")%>' OnClick="BindRowData"
                                                        CommandArgument='<%# Eval("StaffTypeName")%>'></asp:LinkButton>
                                                    <input type="hidden" id="hdnStaffTypeID" runat="server" value='<%# Eval("StaffTypeID")%>' />
                                                </ItemTemplate>
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
    </div>
</asp:Content>
