<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="CallHistory.aspx.cs" Inherits="ManpowerManageWeb.CallHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <asp:UpdatePanel ID="UPMain" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <div>
                    <table width="100%">
                        <tr>
                            <td colspan="2" align="center">
                                <asp:UpdateProgress ID="updProgress"
                                    AssociatedUpdatePanelID="UPMain"
                                    runat="server">
                                    <ProgressTemplate>
                                        Processing......                                                
                                    </ProgressTemplate>
                                </asp:UpdateProgress>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">Todays Call History</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Call Hisory</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Today</a></li>
                                            <li class="pull-right no-text-shadow"></li>
                                        </ul>
                                        <!-- END PAGE TITLE & BREADCRUMB-->
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="gvCallHistory" PageSize="50" Width="100%" runat="server" AutoGenerateColumns="false" GridLines="Horizontal"
                                    CssClass="mGrid" AlternatingRowStyle-CssClass="altRow" DataKeyNames="CallID" EnableSortingAndPagingCallbacks="true"
                                    AllowPaging="true" AllowSorting="true" OnSorting="gvCallHistory_Sorting" OnPageIndexChanging="gvCallHistory_PageIndexChanging">
                                    <Columns>
                                        <asp:BoundField DataField="CompanyName" HeaderText="Company" SortExpression="CompanyName" />
                                        <asp:BoundField DataField="CallTime" HeaderText="Call Date" SortExpression="CallTime" DataFormatString="{0:MM-dd-yyyy hh:mm tt}" />
                                        <asp:BoundField DataField="FollowUp" HeaderText="FollowUp" SortExpression="FollowUp" />
                                        <asp:BoundField DataField="Activity" HeaderText="Activity" SortExpression="Activity" ControlStyle-Width="200px" />
                                        <asp:BoundField DataField="StaffName" HeaderText="Staff" SortExpression="StaffName" />
                                        <asp:BoundField DataField="ModifiedOn" HeaderText="Last Updated" SortExpression="ModifiedOn" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
