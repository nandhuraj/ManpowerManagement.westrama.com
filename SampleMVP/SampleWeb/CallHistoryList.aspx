<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="CallHistoryList.aspx.cs" Inherits="ManpowerManageWeb.CallHistoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">

        //hide and enable input controls based on mode. View mode - label enabled. Edit mode - textbox,dropdowns enabled
        function Redirect() {
            window.location = 'AddOrUpdateCallRegistry.aspx';

        }       

    </script>
     <div class="container-fluid">
    <asp:UpdatePanel ID="UPMain" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <div class="row-fluid">
                                    <div class="span12">
                                        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                                        <h3 class="page-title">All Call History</h3>
                                        <ul class="breadcrumb">
                                            <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">Call History</a> <span class="icon-angle-right"></span></li>
                                            <li><a href="#">View All</a></li>
                                            <li class="pull-right no-text-shadow"></li>
                                        </ul>
                                        <!-- END PAGE TITLE & BREADCRUMB-->
                                    </div>
                                </div>
            <div id="Main">
                <table width="100%" height="100%" border="0">
                    <tr id="TrSearch" runat="server" visible="false">
                        <td colspan="2">
                            <table width="100%" border="0">
                              
                                <tr> <td colspan="3">&nbsp;</td></tr>
                                <tr>
                                    <td class="formtd_lt" >Staff</td>
                                    <td class="formtd_rt">
                                        <asp:DropDownList ID="DdlStaff" CssClass="textbox" runat="server"></asp:DropDownList>
                                    </td>
                                    <td class="formtd_lt" width="70%">
                                         &nbsp;<asp:Button ID="BtnSearch" CssClass="btn blue" Text="Search" OnClick="BtnSearch_Click" runat="server" />
                                    </td>
                                </tr>
                                 <tr> <td colspan="3">&nbsp;</td></tr>
                                
                            </table>
                        </td>
                    </tr>
                    <tr>                      
                        <td colspan="2" align="center">
                            <asp:UpdateProgress ID="updProgress"
                                AssociatedUpdatePanelID="UPMain"
                                runat="server">
                                <ProgressTemplate>
                                    <%--<img alt="progress" style="width:100px;height:50px;border:none;" src="Images/progress.gif" />--%>
                                    Processing......                                                
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                   
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="gvCallRegistry" Width="100%"
                                 OnRowDataBound="gvdata_RowDataBound" runat="server" AutoGenerateColumns="false" GridLines="Horizontal"
                                CssClass="mGrid" AlternatingRowStyle-CssClass="altRow" DataKeyNames="CallID" AllowPaging="true" AllowSorting="true"
                                OnSorting="gvCallRegistry_Sorting" OnPageIndexChanging="gvCallRegistry_PageIndexChanged" PageSize="3">
                                <Columns>
                                    <asp:BoundField DataField="CompanyName" HeaderText="Company" SortExpression="CompanyName" />
                                    <asp:BoundField DataField="CallTime" HeaderText="Call Date"  SortExpression="CallTime" DataFormatString="{0:MM-dd-yyyy hh:mm tt}" />
                                    <asp:BoundField DataField="Phone" HeaderText="Contact Number"  SortExpression="Phone" />
                                    <asp:BoundField DataField="MarketingStatus" HeaderText="Status"  SortExpression="MarketingStatus" />
                                     <asp:BoundField DataField="StaffName" HeaderText="Staff"  SortExpression="StaffName" />
                                    <asp:TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:ImageButton runat="server" ID="ImgEdit" ImageUrl="~/Images/edit.jpg" OnClick="ImgEdit_Click" Width="20px" Height="20px" />
                                            <asp:ImageButton runat="server" ID="ImgView" ImageUrl="~/Images/view.jpg" OnClick="ImgView_Click" Width="20px" Height="20px" />                                        
                                            <asp:ImageButton runat="server" BorderColor="White" ID="ImgDelete" ImageUrl="~/Images/delete.jpg" OnClick="ImgDelete_Click" Width="20px" Height="20px" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td height="20" colspan="2">&nbsp;</td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
         </div>
</asp:Content>

