<%@ Page Title="" Language="C#" MasterPageFile="~/ManpowerManage.Master" AutoEventWireup="true" CodeBehind="frmHomePage.aspx.cs" Inherits="ManpowerManageWeb.frmHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
    <table width="100%" height="100%" border="0">
        <tr>
            <td valign="top" align="left">
                <!-- BEGIN PAGE -->
                <div class="">
                   
                    <!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->
                    <!-- BEGIN PAGE CONTAINER-->
                    <div class="container-fluid">
                        <!-- BEGIN PAGE HEADER-->
                        <div class="row-fluid">
                            <div class="span12">
                                <!-- BEGIN PAGE TITLE & BREADCRUMB-->
                               <!-- <h3 class="page-title">Dashboard </h3>-->
                                <ul class="breadcrumb">
                                    <li><i class="icon-home"></i><a href="index.html">Home</a> <span class="icon-angle-right"></span></li>
                                    <li><a href="#">Dashboard</a></li>
                                    <li class="pull-right no-text-shadow">
                                        <div id="dashboard-report-range" class="dashboard-date-range tooltips no-tooltip-on-touch-device responsive" data-tablet="" data-desktop="tooltips" data-placement="top" data-original-title="Change dashboard date range"><i class="icon-calendar"></i><span></span><i class="icon-angle-down"></i></div>
                                    </li>
                                </ul>
                                <!-- END PAGE TITLE & BREADCRUMB-->
                            </div>
                        </div>
                        <!-- END PAGE HEADER-->
                        <div id="dashboard">
                            <!-- BEGIN DASHBOARD STATS -->
                            <div class="row-fluid">
                                <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                                    <div class="dashboard-stat blue">
                                        <div class="visual"><i class="icon-group"></i></div>
                                        <div class="details">
                                            <div class="number">349 </div>
                                            <div class="desc">Total Requirements </div>
                                        </div>
                                        <a class="more" href="#">View all <i class="m-icon-swapright m-icon-white"></i></a>
                                    </div>
                                </div>
                                <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                                    <div class="dashboard-stat green">
                                        <div class="visual"><i class="icon-check"></i></div>
                                        <div class="details">
                                            <div class="number">45</div>
                                            <div class="desc">Position Closed</div>
                                        </div>
                                        <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i></a>
                                    </div>
                                </div>
                                <div class="span3 responsive" data-tablet="span6  fix-offset" data-desktop="span3">
                                    <div class="dashboard-stat purple">
                                        <div class="visual"><i class="icon-globe"></i></div>
                                        <div class="details">
                                            <div class="number">+89%</div>
                                            <div class="desc">Performance</div>
                                        </div>
                                        <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i></a>
                                    </div>
                                </div>
                                <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                                    <div class="dashboard-stat yellow">
                                        <div class="visual"><i class="icon-bar-chart"></i></div>
                                        <div class="details">
                                            <div class="number">512</div>
                                            <div class="desc">Interview State</div>
                                        </div>
                                        <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i></a>
                                    </div>
                                </div>
                            </div>
                            <!-- END DASHBOARD STATS -->
                            <div class="clearfix"></div>
                            <div class="row-fluid">
                                <div class="span6">
                                    <!-- BEGIN PORTLET-->
                                    <div class="portlet paddingless">
                                        <div class="portlet-title line">
                                            <h4><i class="icon-phone"></i>Call History</h4>
                                            <div class="tools"><a href="javascript:;" class="collapse"></a><a href="#portlet-config" data-toggle="modal" class="config"></a><a href="javascript:;" class="reload"></a><a href="javascript:;" class="remove"></a></div>
                                        </div>
                                        <div class="portlet-body">
                                            <!--BEGIN TABS-->
                                            <div class="tabbable tabbable-custom">
                                                <ul class="nav nav-tabs">
                                                    <li class="active"><a href="#tab_1_1" data-toggle="tab">Today</a></li>
                                                    <li><a href="#tab_1_2" data-toggle="tab">Call Registry</a></li>
                                                    <li><a href="#tab_1_3" data-toggle="tab">Add New Call</a></li>
                                                </ul>
                                                <div class="tab-content">
                                                    <div class="tab-pane active" id="tab_1_1">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <div class="portlet">
                                                                <div class="portlet-body">
                                                                    <table class="table table-striped table-bordered table-advance table-hover">
                                                                        <thead>
                                                                            <tr>
                                                                                <th><i class="icon-briefcase"></i>Company</th>
                                                                                <th class="hidden-phone"><i class="icon-user"></i>Name</th>
                                                                                <th><i class="icon-phone"></i>Contact N0.</th>
                                                                                <th></th>
                                                                            </tr>
                                                                        </thead>
                                                                        <tbody>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">RedBull</a></td>
                                                                                <td class="hidden-phone">Mike Nilson</td>
                                                                                <td>8748757845</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Google</a></td>
                                                                                <td class="hidden-phone">Adam Larson</td>
                                                                                <td>12457889</td>
                                                                                <td><a href="#" class="btn mini black"><i class="icon-trash"></i>Delete</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Apple</a></td>
                                                                                <td class="hidden-phone">Daniel Kim</td>
                                                                                <td>658458855</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Microsoft</a></td>
                                                                                <td class="hidden-phone">Nick </td>
                                                                                <td>57489652</td>
                                                                                <td><a href="#" class="btn mini blue"><i class="icon-share"></i>Share</a></td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="tab-pane" id="tab_1_2">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <div class="portlet">
                                                                <div class="portlet-body">
                                                                    <table class="table table-striped table-bordered table-advance table-hover">
                                                                        <thead>
                                                                            <tr>
                                                                                <th><i class="icon-briefcase"></i>Company</th>
                                                                                <th class="hidden-phone"><i class="icon-user"></i>Name</th>
                                                                                <th><i class="icon-phone"></i>Contact N0.</th>
                                                                                <th></th>
                                                                            </tr>
                                                                        </thead>
                                                                        <tbody>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">RedBull</a></td>
                                                                                <td class="hidden-phone">Mike Nilson</td>
                                                                                <td>8748757845</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Google</a></td>
                                                                                <td class="hidden-phone">Adam Larson</td>
                                                                                <td>12457889</td>
                                                                                <td><a href="#" class="btn mini black"><i class="icon-trash"></i>Delete</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Apple</a></td>
                                                                                <td class="hidden-phone">Daniel Kim</td>
                                                                                <td>658458855</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Microsoft</a></td>
                                                                                <td class="hidden-phone">Nick </td>
                                                                                <td>57489652</td>
                                                                                <td><a href="#" class="btn mini blue"><i class="icon-share"></i>Share</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">RedBull</a></td>
                                                                                <td class="hidden-phone">Mike Nilson</td>
                                                                                <td>8748757845</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Google</a></td>
                                                                                <td class="hidden-phone">Adam Larson</td>
                                                                                <td>12457889</td>
                                                                                <td><a href="#" class="btn mini black"><i class="icon-trash"></i>Delete</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Apple</a></td>
                                                                                <td class="hidden-phone">Daniel Kim</td>
                                                                                <td>658458855</td>
                                                                                <td><a href="#" class="btn mini purple"><i class="icon-edit"></i>Edit</a></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="highlight"><a href="#">Microsoft</a></td>
                                                                                <td class="hidden-phone">Nick </td>
                                                                                <td>57489652</td>
                                                                                <td><a href="#" class="btn mini blue"><i class="icon-share"></i>Share</a></td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="tab-pane" id="tab_1_3">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <form class="form-horizontal" action="#">
                                                                <div class="control-group">
                                                                    <label class="control-label">Company Name</label>
                                                                    <div class="controls">
                                                                        <select tabindex="1" class="medium m-wrap">
                                                                            <option value="Category 1">Google </option>
                                                                            <option value="Category 2">TCS </option>
                                                                            <option value="Category 3">Wipro </option>
                                                                            <option value="Category 4">Cognizant </option>
                                                                        </select>
                                                                    </div>
                                                                </div>
                                                                <div class="control-group">
                                                                    <label class="control-label">Name</label>
                                                                    <div class="controls">
                                                                        <input type="text" class="m-wrap medium" placeholder="First Name">
                                                                    </div>
                                                                </div>
                                                                <div class="control-group">
                                                                    <label class="control-label">Contact Number</label>
                                                                    <div class="controls">
                                                                        <input type="text" class="m-wrap medium" placeholder="">
                                                                    </div>
                                                                </div>
                                                                <div class="control-group">
                                                                    <label class="control-label">Status</label>
                                                                    <div class="controls">
                                                                        <label class="radio">
                                                                            <div class="radio" id="uniform-undefined">
                                                                                <span>
                                                                                    <input type="radio" value="option1" name="optionsRadios1" style="opacity: 0;"></span>
                                                                            </div>
                                                                            Active
                                                                        </label>
                                                                        <label class="radio">
                                                                            <div class="radio" id="Div1">
                                                                                <span class="checked">
                                                                                    <input type="radio" checked="" value="option2" name="optionsRadios1" style="opacity: 0;"></span>
                                                                            </div>
                                                                            In-active
                                                                        </label>
                                                                        <label class="radio">
                                                                            <div class="radio" id="Div2">
                                                                                <span>
                                                                                    <input type="radio" value="option2" name="optionsRadios1" style="opacity: 0;"></span>
                                                                            </div>
                                                                            On Hold
                                                                        </label>
                                                                    </div>
                                                                </div>
                                                                <div class="form-actions">
                                                                    <button class="btn blue" type="submit"><i class="icon-ok"></i>Save</button>
                                                                    <button class="btn" type="button">Cancel</button>
                                                                </div>
                                                            </form>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!--END TABS-->
                                        </div>
                                    </div>
                                    <!-- END PORTLET-->
                                </div>
                                <div class="span6">
                                    <div class="portlet paddingless">
                                        <div class="portlet-title line">
                                            <h4><i class="icon-suitcase"></i>Opportunity</h4>
                                            <div class="tools"><a href="javascript:;" class="collapse"></a><a href="#portlet-config" data-toggle="modal" class="config"></a><a href="javascript:;" class="reload"></a><a href="javascript:;" class="remove"></a></div>
                                        </div>
                                        <div class="portlet-body">
                                            <!--BEGIN TABS-->
                                            <div class="tabbable tabbable-custom">
                                                <ul class="nav nav-tabs">
                                                    <li class="active"><a href="#tab_2_1" data-toggle="tab">Open Opportunity</a></li>
                                                    <li><a href="#tab_2_2" data-toggle="tab">Closed Opportunity</a></li>
                                                </ul>
                                                <div class="tab-content">
                                                    <div class="tab-pane active" id="tab_2_1">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <ul class="feeds">
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Technical Recruiter (US IT Staffing) Multiple Positions </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">20 days </div>
                                                                    </div>
                                                                </a></li>
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Project Manager For Industrial Projects For Chennai </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">2 days </div>
                                                                    </div>
                                                                </a>
                                                                </li>
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Sales Executive - Air Cargo </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 days </div>
                                                                    </div>
                                                                </a>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Hiring for Application Security @ Altimetrik India Pvt ltd, Chennai </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 days </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Clinical Research Associate </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="tab-pane" id="tab_2_2">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <ul class="feeds">
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Design Engineer Unigraphics NX on Fixed time Contract </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">120 days </div>
                                                                    </div>
                                                                </a></li>
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Sr.manager / Dy.manager - Logistics Safety </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">10 weeks </div>
                                                                    </div>
                                                                </a></li>
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-suitcase"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Facets Application Developer </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">6 Months </div>
                                                                    </div>
                                                                </a></li>
                                                            </ul>
                                                        </div>
                                                    </div>

                                                </div>
                                            </div>
                                            <!--END TABS-->
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="row-fluid">
                                <div class="span6">
                                    <!-- BEGIN PORTLET-->
                                    <div class="portlet box blue calendar">
                                        <div class="portlet-title">
                                            <h4 class=""><i class="icon-calendar"></i>Calendar</h4>
                                        </div>
                                        <div class="portlet-body light-grey">
                                            <div id="calendar"></div>
                                        </div>
                                    </div>
                                    <!-- END PORTLET-->
                                </div>
                                <div class="span6">
                                    <!-- BEGIN PORTLET-->
                                    <div class="portlet paddingless">
                                        <div class="portlet-title line">
                                            <h4><i class="icon-bell"></i>Reminders</h4>
                                            <div class="tools"><a href="javascript:;" class="collapse"></a><a href="#portlet-config" data-toggle="modal" class="config"></a><a href="javascript:;" class="reload"></a><a href="javascript:;" class="remove"></a></div>
                                        </div>
                                        <div class="portlet-body">
                                            <!--BEGIN TABS-->
                                            <div class="tabbable tabbable-custom">
                                                <ul class="nav nav-tabs">
                                                    <li class="active"><a href="#tab_3_1" data-toggle="tab">Today's Reminder</a></li>
                                                    <li><a href="#tab_3_2" data-toggle="tab">Reminder List</a></li>
                                                    <li><a href="#tab_3_3" data-toggle="tab">Closed Reminder</a></li>
                                                </ul>
                                                <div class="tab-content">
                                                    <div class="tab-pane active" id="tab_3_1">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <ul class="feeds">
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-bell"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Complete Timesheet by EOD </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">20 mins </div>
                                                                    </div>
                                                                </a></li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Call Candidated for Interview </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Update data sheet and report </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Submit resume for review </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">New order received. Please take care of it. </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="tab-pane" id="tab_3_2">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <ul class="feeds">
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-bell"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Complete Timesheet by EOD </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">20 mins </div>
                                                                    </div>
                                                                </a></li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Call Candidated for Interview </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Update data sheet and report </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Submit resume for review </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">New order received. Please take care of it. </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-bell"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Complete Timesheet by EOD </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">20 mins </div>
                                                                    </div>
                                                                </a></li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Call Candidated for Interview </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Update data sheet and report </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Submit resume for review </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">New order received. Please take care of it. </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="tab-pane" id="tab_3_3">
                                                        <div class="scroller" data-height="290px" data-always-visible="1" data-rail-visible1="1">
                                                            <ul class="feeds">
                                                                <li><a href="#">
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-success"><i class="icon-bell"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Complete Timesheet by EOD </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">20 mins </div>
                                                                    </div>
                                                                </a></li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Call Candidated for Interview </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Update data sheet and report </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-important"><i class="icon-bolt"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">Submit resume for review </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">24 mins </div>
                                                                    </div>
                                                                </li>
                                                                <li>
                                                                    <div class="col1">
                                                                        <div class="cont">
                                                                            <div class="cont-col1">
                                                                                <div class="label label-info"><i class="icon-bullhorn"></i></div>
                                                                            </div>
                                                                            <div class="cont-col2">
                                                                                <div class="desc">New order received. Please take care of it. </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col2">
                                                                        <div class="date">22 hours </div>
                                                                    </div>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!--END TABS-->
                                        </div>
                                    </div>
                                    <!-- END PORTLET-->
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- END PAGE CONTAINER-->
                </div>
                <!-- END PAGE -->
            </td>
        </tr>
    </table>
         </div>
</asp:Content>
