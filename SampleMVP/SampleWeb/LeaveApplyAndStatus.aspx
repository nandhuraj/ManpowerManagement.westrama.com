<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true"
    CodeBehind="LeaveApplyAndStatus.aspx.cs" Inherits="ManpowerManageWeb.LeaveApplyAndStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table width="100%" height="100%" border="0">
                <tr>
                    <td valign="top" class="row-fluid">
                      <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">Leave Requests</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Leave Approval</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Requests</a></li>
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
                                        <asp:Panel ID="pnlSatffDetails" runat="server" Visible="false">
                                            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td class="formtd_lt">
                                                        <asp:Label ID="Label1" runat="server">* Leave Type:</asp:Label>
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:DropDownList ID="ddlleaveType" runat="server" AutoPostBack="true" CssClass="ddlist">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                        <asp:Label ID="Label2" runat="server">* From Date:</asp:Label>
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:TextBox ID="txtFromDate" runat="server" Enabled="false">

                                                        </asp:TextBox>
                                                        <asp:ImageButton ID="imgCalenderFrom" runat="server" ImageUrl="~/Icons/calendar_select_days.png"
                                                            Width="20px" />
                                                        <ajax:CalendarExtender ID="CalContrlFrom" runat="server" TargetControlID="txtFromDate"
                                                            PopupButtonID="imgCalenderFrom" EnabledOnClient="true" EnableViewState="true"
                                                            Format="dd-MM-yyyy">
                                                        </ajax:CalendarExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                        <asp:Label ID="Label3" runat="server">* To Date:</asp:Label>
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:TextBox ID="txtToDate" runat="server" Enabled="false">
                                                        </asp:TextBox>
                                                        <asp:ImageButton ID="imgCalenderTo" runat="server" ImageUrl="~/Icons/calendar_select_days.png"
                                                            Width="20px" />
                                                        <ajax:CalendarExtender ID="CalContrlTo" runat="server" TargetControlID="txtToDate"
                                                            PopupButtonID="imgCalenderTo" EnabledOnClient="true" EnableViewState="true" Format="dd-MM-yyyy">
                                                        </ajax:CalendarExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                        <asp:Label ID="Label4" runat="server">* Total Hours:</asp:Label>
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:TextBox ID="txtTotHrs" runat="server"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                        <asp:Label ID="Label5" runat="server">  Remarks:</asp:Label>
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:TextBox ID="txtRemarks" runat="server" Width="250px" CssClass="textboxStyle"
                                                            TextMode="MultiLine"></asp:TextBox>
                                                        (*)-Required Fields
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:Button ID="btnCrewPerf" CssClass="btn green"   runat="server" Text="Submit" OnClick="btnCrewPerf_Click" />
                                                        <%--BorderStyle="None"--%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="formtd_lt">
                                                    </td>
                                                    <td class="formtd_rt">
                                                        <asp:Label ID="lblError" Text="" ForeColor="Red" Font-Bold="true" runat="server"
                                                            Visible="false"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="pnlGridStaff" runat="server" Visible="false">
                                            <div style="text-align: center;">
                                                <asp:Label ID="lblGvResult" runat="server" Visible="false" Font-Bold="true"></asp:Label></div>
                                            <!-- Leave Apply Grid View Staff & Reporting Person-->
                                            <div>
                                                <asp:GridView ID="GVWLeave" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                    AllowSorting="true" PageSize="12" Width="100%" DataKeyNames="cLvTypeId" ShowHeaderWhenEmpty="true"
                                                    RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo" HeaderStyle-CssClass="listheading"
                                                    EmptyDataText="No Records Found">
                                                    <Columns>
                                                        <asp:BoundField DataField="S_NO" HeaderText="S.No" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                                        <asp:BoundField DataField="cLeaveType" HeaderText="Leave Type" ItemStyle-Width="200px" />
                                                        <asp:BoundField DataField="dFromDate" HeaderText="From" ItemStyle-Width="130px" />
                                                        <asp:BoundField DataField="dToDate" HeaderText="To" ItemStyle-Width="130px" />
                                                        <asp:BoundField DataField="tTotHours" HeaderText="Hrs" ItemStyle-Width="60px" />
                                                        <asp:BoundField DataField="cReason" HeaderText="Reason" ItemStyle-Width="180px" />
                                                        <asp:BoundField DataField="cApprStatus" HeaderText="Status" ItemStyle-Width="120px" />
                                                        <asp:BoundField DataField="dLeaveReqDate" HeaderText="Req.Date" ItemStyle-Width="130px" />
                                                    </Columns>
                                                </asp:GridView>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="pnlAdmin" runat="server" Visible="false">
                                            <div style="text-align: center;">
                                                <asp:Label ID="lblGridResult" runat="server" Enabled="false" Font-Bold="true"></asp:Label></div>
                                            <div>
                                                <asp:GridView ID="GVAdmin" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                    AllowSorting="true" PageSize="12" Width="100%" DataKeyNames="cStatus_StaffId"
                                                    ShowHeaderWhenEmpty="true" RowStyle-CssClass="listone" AlternatingRowStyle-CssClass="listtwo"
                                                    HeaderStyle-CssClass="listheading" EmptyDataText="No Records Found">
                                                    <Columns>
                                                        <asp:BoundField DataField="S_NO" HeaderText="S.No" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                                        <asp:TemplateField HeaderText="LeaveId" Visible="false">
                                                            <ItemTemplate>
                                                                <asp:Label ID="idLvId" runat="server" Text='<%#Eval("cLvTypeId")%>' Visible="false"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="cLeaveType" HeaderText="Leave Type" ItemStyle-Width="200px" />
                                                        <asp:BoundField DataField="FirstName" HeaderText="Staff Name" ItemStyle-Width="200px" />
                                                        <asp:BoundField DataField="dFromDate" HeaderText="From" ItemStyle-Width="130px" />
                                                        <asp:BoundField DataField="dToDate" HeaderText="To" ItemStyle-Width="130px" />
                                                        <asp:BoundField DataField="tTotHours" HeaderText="Hrs" ItemStyle-Width="60px" />
                                                        <asp:BoundField DataField="cReason" HeaderText="Reason" ItemStyle-Width="180px" />
                                                        <asp:BoundField DataField="dLeaveReqDate" HeaderText="Req.Date" ItemStyle-Width="130px" />
                                                        <asp:TemplateField HeaderText="">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkApproved" runat="server" ToolTip="Click" Text="APPROVE" Font-Underline="true"
                                                                    OnClick="lnkApprove_Click"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkCancel" runat="server" ToolTip="Click" Text="CANCEL" Font-Underline="true"
                                                                    OnClick="lnkCancel_Click"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="100" />
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
            <!-- Admin Panel Gridview-->
        </ContentTemplate>
    </asp:UpdatePanel>
       </div>
</asp:Content>
