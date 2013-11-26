<%@ Page Language="C#" MasterPageFile="~/ManpowerManage.Master"  AutoEventWireup="true" CodeBehind="AddOrUpdateCallRegistry.aspx.cs" Inherits="ManpowerManageWeb.AddOrUpdateCallRegistry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .PopupDivMess {
            background-color: #fff;
            border: solid 1px #525252;
            padding: 3px;
            width: 250px;
            height: 100px;
        }
    </style>
    <link href="Styles/Common.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">

        //Based the marketing value, the specific controls are enabled
        function MarketingStatus(val) {
            var status = document.getElementById('<%=DdlMarketingStatus.ClientID%>');
            var val = status.options[status.selectedIndex].value;

            document.getElementById('<%=TrCandidate.ClientID%>').style.display = 'block';
            document.getElementById('<%=TrActivity.ClientID%>').style.display = 'block';
            document.getElementById('<%=TrSendProfile.ClientID%>').style.display = 'block';
            document.getElementById('<%=TrFEmail.ClientID%>').style.display = 'block';
            document.getElementById('<%=TrCandidate.ClientID%>').style.display = 'block';
            document.getElementById('<%=TrReminder.ClientID%>').style.display = 'block';
            document.getElementById('<%=BtnSave.ClientID%>').style.display = 'block';
            document.getElementById('<%=BtnOpportunity.ClientID%>').style.display = 'none';
            document.getElementById('<%=BtnUpdate.ClientID%>').style.display = 'none';


            if (document.getElementById('<%=HdnUpdate.ClientID%>').value != "") {
                document.getElementById('<%=BtnSave.ClientID%>').style.display = 'none';
                document.getElementById('<%=BtnUpdate.ClientID%>').style.display = 'block';
            }
            else {
                document.getElementById('<%=BtnSave.ClientID%>').style.display = 'block';
                document.getElementById('<%=BtnUpdate.ClientID%>').style.display = 'none';
            }


            if (val == "1") {
                document.getElementById('<%=TrCandidate.ClientID%>').style.display = 'none';
            }
            else if (val == "2") {
                document.getElementById('<%=TrReminder.ClientID%>').style.display = 'none';
                document.getElementById('<%=BtnSave.ClientID%>').style.display = 'none';
                document.getElementById('<%=BtnUpdate.ClientID%>').style.display = 'none';
                document.getElementById('<%=BtnOpportunity.ClientID%>').style.display = 'block';

            }
            else if (val == "3" || val == "4" || val == "0") {
                document.getElementById('<%=TrCandidate.ClientID%>').style.display = 'none';
                document.getElementById('<%=TrActivity.ClientID%>').style.display = 'none';
                document.getElementById('<%=TrSendProfile.ClientID%>').style.display = 'none';
                document.getElementById('<%=TrFEmail.ClientID%>').style.display = 'none';
                document.getElementById('<%=TrCandidate.ClientID%>').style.display = 'none';
                document.getElementById('<%=TrReminder.ClientID%>').style.display = 'none';
            }
}



//Validate the input values in this form. Server tag throws error in rendering. So placed moved validation script from head tag to body tag
function ValidateForm() {
    var errMsg = "";
    if (document.getElementById('<%=TxtCallDate.ClientID%>').value == "")
                errMsg += "Please enter call date\n";
            else if (document.getElementById('<%=TxtCallDate.ClientID%>').value != "") {
                if (!checkDate(document.getElementById('<%=TxtCallDate.ClientID%>'))) {
                    errMsg += "Invalid date format in call date\n";
                }
            }

        if (document.getElementById('<%=TxtCompanyName.ClientID%>').value == "")
                errMsg += "Please enter company name\n";
            if (document.getElementById('<%=TxtPhone.ClientID%>').value == "")
                errMsg += "Please enter phone\n";
            if (document.getElementById('<%=TxtEmail.ClientID%>').value != "") {
                if (!checkEmail(document.getElementById('<%=TxtEmail.ClientID%>'))) {
                    errMsg += "Invalid email format \n";
                }
            }

            if (document.getElementById('<%=TxtReminder.ClientID%>').value != "") {
                if (!checkDate(document.getElementById('<%=TxtReminder.ClientID%>'))) {
                    errMsg += "Invalid date format in reminder\n";
                }
            }

            if (document.getElementById('<%= DdlMarketingCategory.ClientID%>').selectedIndex == 0)
                errMsg += "Please select marketing category\n";

            //Validating input controls based on business logic
            var mstatus = document.getElementById('<%=DdlMarketingStatus.ClientID%>');
            var mval = mstatus.options[mstatus.selectedIndex].value;
            if (document.getElementById('<%=DdlMarketingStatus.ClientID%>').selectedIndex == 0)
                errMsg += "Please select marketing status\n";
            else if (mval == "1") {

                if (document.getElementById('<%=TxtReminder.ClientID%>').value != "") {
                    if (!checkDate(document.getElementById('<%=TxtReminder.ClientID%>'))) {
                        errMsg += "Invalid date format in reminder\n";
                    }
                }
                else
                    errMsg += "Please enter reminder\n";

                if (document.getElementById('<%=ChkSendProfile.ClientID%>').checked) {
                    if (document.getElementById('<%=TxtFEmail.ClientID%>').value == "")
                        errMsg += "Please enter follow up email\n";
                    else if (document.getElementById('<%=TxtFEmail.ClientID%>').value != "") {
                        if (!checkEmail(document.getElementById('<%=TxtFEmail.ClientID%>'))) {
                            errMsg += "Invalid email format in follow up email\n";
                        }
                    }
            }

        }
        else if (mval == "2") {
            if (document.getElementById('<%=ChkSendProfile.ClientID%>').checked) {
                if (document.getElementById('<%=TxtFEmail.ClientID%>').value == "")
                    errMsg += "Please enter follow up email\n";
                else if (document.getElementById('<%=TxtFEmail.ClientID%>').value != "") {
                    if (!checkEmail(document.getElementById('<%=TxtFEmail.ClientID%>'))) {
                        errMsg += "Invalid email format in follow up email\n";
                    }
                }
        }

        if (document.getElementById('<%=TxtNoOfCandidates.ClientID%>').value == "")
                errMsg += "Please enter no. of candidates\n";
        }


    if (errMsg != "") {
        alert(errMsg);
        return false;
    }
    else {
        return true;
    }
}
    </script>
    <div class="container-fluid"> 
    <asp:UpdatePanel ID="UPMain" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <table width="100%" height="100%" cellpadding="2" cellspacing="2">
                <tr>
                    <td colspan="2" align="center">
                        <asp:UpdateProgress ID="updProgress"
                            AssociatedUpdatePanelID="UPMain"
                            runat="server">
                            <ProgressTemplate>
                                <asp:Label ID="LblProcessing" runat="server" Text="Processing...... " Font-Bold="true"></asp:Label>
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </td>
                </tr>
                <tr>
                     <div class="row-fluid">
                        <div class="span12">
                            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                            <h3 class="page-title">Call Registry</h3>
                            <ul class="breadcrumb">
                                <li><i class="icon-home"></i><a href="frmHomePage.aspx">Home</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Call Registry</a> <span class="icon-angle-right"></span></li>
                                <li><a href="#">Add/ Edit</a></li>
                                <li class="pull-right no-text-shadow"></li>
                            </ul>
                            <!-- END PAGE TITLE & BREADCRUMB-->
                        </div>
                      </div>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td width="25%"  class="formtd_lt"><span class="SpanMandatory">*</span>Call Date & Time</td>
                                <td width="75%"  class="formtd_rt">
                                    <table>
                                        <tr>
                                            <td nowrap width="15%">
                                                <asp:TextBox ID="TxtCallDate" Width="75px" runat="server"></asp:TextBox>
                                                <ajax:CalendarExtender Format="MM/dd/yyyy" ID="AceCallDate" runat="server" TargetControlID="TxtCallDate"></ajax:CalendarExtender>
                                                <asp:Label ID="LblCallDate" runat="server"></asp:Label>
                                            </td>
                                            <td width="5%">
                                                <asp:DropDownList ID="DdlHour" runat="server" Width="45px" CssClass="ddl">
                                                    <asp:ListItem Selected="True" Text="12"></asp:ListItem>
                                                    <asp:ListItem Text="1"></asp:ListItem>
                                                    <asp:ListItem Text="2"></asp:ListItem>
                                                    <asp:ListItem Text="3"></asp:ListItem>
                                                    <asp:ListItem Text="4"></asp:ListItem>
                                                    <asp:ListItem Text="5"></asp:ListItem>
                                                    <asp:ListItem Text="6"></asp:ListItem>
                                                    <asp:ListItem Text="7"></asp:ListItem>
                                                    <asp:ListItem Text="8"></asp:ListItem>
                                                    <asp:ListItem Text="9"></asp:ListItem>
                                                    <asp:ListItem Text="10"></asp:ListItem>
                                                    <asp:ListItem Text="11"></asp:ListItem>
                                                </asp:DropDownList></td>
                                            <td width="5%">
                                                <asp:DropDownList ID="DdlMinute" runat="server" Width="45px" CssClass="ddl">
                                                    <asp:ListItem Text="00" Value="0"></asp:ListItem>
                                                    <asp:ListItem Text="05"></asp:ListItem>
                                                    <asp:ListItem Text="10"></asp:ListItem>
                                                    <asp:ListItem Text="15"></asp:ListItem>
                                                    <asp:ListItem Text="20"></asp:ListItem>
                                                    <asp:ListItem Text="25"></asp:ListItem>
                                                    <asp:ListItem Text="30"></asp:ListItem>
                                                    <asp:ListItem Text="35"></asp:ListItem>
                                                    <asp:ListItem Text="40"></asp:ListItem>
                                                    <asp:ListItem Text="45"></asp:ListItem>
                                                    <asp:ListItem Text="50"></asp:ListItem>
                                                    <asp:ListItem Text="55"></asp:ListItem>
                                                </asp:DropDownList></td>
                                            <td width="5%">
                                                <asp:DropDownList ID="DdlTimeZone" runat="server" Width="45px" CssClass="ddl">
                                                    <asp:ListItem Selected="True" Text="AM"></asp:ListItem>
                                                    <asp:ListItem Text="PM"></asp:ListItem>
                                                </asp:DropDownList></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt"><span class="SpanMandatory">*</span> Industry
                                </td>
                                <td class="formtd_rt">
                                    <asp:DropDownList ID="DdlIndustry" CssClass="ddl" Width="218px" runat="server">
                                    </asp:DropDownList>
                                    <asp:Label ID="LblIndustry" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Company Name
                                </td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtCompanyName" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblCompanyName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Phone</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblPhone" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt">Alternate Phone</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtAlternatePhone" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblAlternatePhone" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt">Email</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblEmail" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt">Reference</td>
                                <td class="formtd_rt">
                                    <asp:DropDownList ID="DdlReference" CssClass="ddl" runat="server" Width="218px">
                                        <asp:ListItem Text=" " Value="0"></asp:ListItem>
                                        <asp:ListItem Text="test" Value="1"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Label ID="LblReference" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Marketing Category
                                </td>
                                <td class="formtd_rt">
                                    <asp:DropDownList ID="DdlMarketingCategory" CssClass="ddl" runat="server" Width="218px">
                                    </asp:DropDownList>
                                    <asp:Label ID="LblMarketingCategory" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Marketing Status
                                </td>
                                <td class="formtd_rt">
                                    <asp:DropDownList ID="DdlMarketingStatus" CssClass="ddl" Width="218px" runat="server" onchange="javascript:MarketingStatus();">
                                        <asp:ListItem Text="Follow Up" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="High Win Ratio" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Not Interested" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Not in Use" Value="4"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Label ID="LblMarketingStatus" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr id="TrReminder" runat="server">
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Reminder</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtReminder" runat="server"></asp:TextBox>
                                    <ajax:CalendarExtender ID="CeReminder" runat="server" TargetControlID="TxtReminder"></ajax:CalendarExtender>
                                    <asp:Label ID="LblReminder" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr id="TrActivity" runat="server" width="100%">
                                <td class="formtd_lt">Add Activity</td>
                                <td class="formtd_rt">
                                    <table>
                                        <tr>
                                            <td></td>
                                            <asp:TextBox ID="TxtActivity" TextMode="MultiLine" Width="200px" Height="75px" runat="server"></asp:TextBox>
                                            <asp:Label ID="LblActivity" runat="server"></asp:Label>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr id="TrSendProfile" runat="server">
                                <td class="formtd_lt">Send Profile to Client</td>
                                <td class="formtd_rt">
                                    <asp:CheckBox ID="ChkSendProfile" runat="server"></asp:CheckBox>
                                    <asp:Label ID="LblSendProfile" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr id="TrFEmail" runat="server">
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>Email</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtFEmail" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblFEmail" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr id="TrCandidate" runat="server">
                                <td class="formtd_lt"><span class="SpanMandatory">*</span>No. Of Candidates</td>
                                <td class="formtd_rt">
                                    <asp:TextBox ID="TxtNoOfCandidates" runat="server"></asp:TextBox>
                                    <asp:Label ID="LblNoOfCandidates" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:HiddenField ID="HdnCallID" runat="server" Value="0" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <table align="center">
                                        <tr>
                                            <td width="15%"></td>
                                            <td>
                                                <asp:HiddenField ID="HdnUpdate" runat="server" />
                                                <asp:Button ID="BtnSave" CssClass="btn blue" OnClientClick="Javascript:return ValidateForm();" runat="server" Text="Save" OnClick="BtnSave_Click" />
                                                <asp:Button ID="BtnOpportunity" CssClass="btn blue" OnClientClick="Javascript:return ValidateForm();" runat="server" Text="Convert To Opportunity" OnClick="BtnOpportunity_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="BtnUpdate" CssClass="btn blue" OnClientClick="Javascript:return ValidateForm();" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                                            </td>
                                            <td align="left">
                                                <asp:Button ID="BtnCancel" CssClass="btn" runat="server" Text="Cancel" OnClick="BtnCancel_Click" /></td>
                                            <td width="55%"></td>
                                        </tr>
                                    </table>
                                </td>

                            </tr>
                        </table>
                    </td>
                </tr>
            </table>

            <div>
                <asp:Panel ID="PnlMessage" runat="server" CssClass="PopupDivMess">
                    <table>
                        <tr>
                            <td colspan="2" class="HeadingText">
                                <table width="100%">
                                    <tr>
                                        <td colspan="2">Message
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <asp:Label ID="LblMessage" ForeColor="Red" runat="server"></asp:Label>
                                            <td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <asp:Button ID="ImgOk" Text="OK" runat="server" OnClick="ImgOk_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <img id="ImgTemp" runat="server" src="" style="width: .1px; height: .1px" />
                <ajax:ModalPopupExtender ID="MPEMessage" runat="server"
                    TargetControlID="ImgTemp"
                    PopupControlID="PnlMessage"
                    BackgroundCssClass="ModalPopupBG"
                    OkControlID="ImgTemp">
                </ajax:ModalPopupExtender>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
        </div>
</asp:Content>
