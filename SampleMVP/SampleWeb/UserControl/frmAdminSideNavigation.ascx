<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="frmAdminSideNavigation.ascx.cs" Inherits="ManpowerManageWeb.UserControl.frmAdminSideNavigation" %>

<ul>
    <li><a href="index.html"><i class="icon-home"></i>Dashboard <span class="selected"></span></a></li>
    <li class="has-sub active"><a href="javascript:;" class=""><i class="icon-bookmark-empty"></i>Manage Staffs <span class="arrow"></span></a>
        <ul class="sub">           
            <li class=""><a class="" href="callhistory.aspx">Todays Call History</a></li>
            <li><a class="" href="callhistorylist.aspx">Call History</a></li>
            <li><a class="" href="frmopportunity.aspx">Opportunity List</a></li>
            <li><a class="" href="frmStaffType.aspx">Staff Types</a></li>
            <li><a class="" href="frmStaffDetails.aspx">WestRama Staffs</a></li>            
        </ul>
    </li>
    <li class="has-sub"><a href="javascript:;" class=""><i class="icon-table"></i>Manage Clients <span class="arrow"></span></a>
        <ul class="sub">
            <li><a class="" href="ClientEntry.aspx?PageType=Add">Add Clients</a></li>
            <li><a class="" href="ClientViewEdit.aspx?GridPage=First">View all Clients</a></li>
        </ul>
    </li>
    <li class="has-sub"><a href="javascript:;" class=""><i class="icon-th-list"></i>Manage Leaves <span class="arrow"></span></a>
        <ul class="sub">
            <li><a class="" href="leavetype.aspx">Leave Policy</a></li>
            <li><a class="" href="leaveapplyandstatus.aspx">Leave Requests</a></li>
        </ul>
    </li>
     <li class="has-sub"><a href="javascript:;" class=""><i class="icon-th-list"></i>My Profile <span class="arrow"></span></a>
        <ul class="sub">
            <li><a class="" href="changepassword.aspx">Change Password</a></li>
            <li><a class="" href="Login.aspx">Log Out</a></li>
        </ul>
    </li>
   <!-- <li><a class="" href="grids.html"><i class="icon-bar-chart"></i>Reports</a></li>
    <li class="has-sub"><a href="javascript:;" class=""><i class="icon-wrench"></i>Admin <span class="arrow"></span></a>
        <ul class="sub">
            <li><a class="" href="javascript:;">Agent</a></li>
            <li><a class="" href="javascript:;">Staff</a></li>
            <li><a class="" href="javascript:;">User Group</a></li>
            <li><a class="" href="javascript:;">Setting</a></li>
            <li><a class="" href="javascript:;">Value List</a></li>
            <li><a class="" href="javascript:;">Translation</a></li>
            <li><a class="" href="javascript:;">Staff Attendance</a></li>
        </ul>
    </li>-->
</ul>
