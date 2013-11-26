using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManageWeb.Constant;
using ManpowerManageWeb.DAS;
using ManpowerManage.View;
using ManpowerManage.Presenter;
using System.Data;
using System.Drawing;
using ManpowerManageWeb.Constant;

namespace ManpowerManageWeb
{
    public partial class LeaveApplyAndStatus : System.Web.UI.Page, ILeaveApplyOrApproval
    {
       
        private string TodayDate = DateTime.Now.ToString("dd-MM-yyyy");       
        private int StaffId = 0;
        private int apprPerId=0;
        private int flagInserOrLoad = 0;
        private int cLvId = 0;
        private string StaffAdminFlag=string.Empty;
        private LeaveApplyOrApprovePresenter LeaveApplyOrAppr;
        

        public  int cStatus_StaffId 
        {
            get { return StaffId ; }
            set { StaffId = value; }
        }
        public int cLvTypeId
        {
            get { return cLvId; }
            set { cLvId = value; }
        }
        public string dFromDate 
        {
            get { return txtFromDate.Text; }
            set { txtFromDate.Text =value; }
        }
        public string dToDate 
        { 
            get { return txtToDate.Text; }
            set { txtToDate.Text = value; }
        }
        public string tTotHours 
        {
            get { return txtTotHrs.Text; }
            set { txtTotHrs.Text = value; }
        }
        public string cReason 
        {
            get { return txtRemarks.Text; }
            set { txtRemarks.Text = value; }
        }
        public int cApprPersonId 
        {
            get { return apprPerId; }
            set { apprPerId=value; }
        }
        public int flagInsertOrLoad 
        {
            get { return flagInserOrLoad; }
            set { flagInserOrLoad = value; }
        }
        public string StaffFlag
        {
            get { return StaffAdminFlag; }
            set { StaffAdminFlag = value; } 
        }

      


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //  txtFromDate.Attributes.Add("onfocus", "ShowCalendar();");
                lblError.Visible = false;
                lblError.Text = "";
                lblGridResult.Visible = false;
                lblGridResult.Text = "";
                lblGvResult.Visible = false;
                lblGvResult.Text = "";
              
                if (Session["UserId"] == null && Session["UserName"] == null && Session["UserType"] == null)
                    Response.Redirect("Login.aspx");

                StaffId = Convert.ToInt32(Session["UserId"].ToString());
                StaffFlag = Session["UserType"].ToString();
              
                if (!IsPostBack)
                {

                    if (Convert.ToString(Session["UserType"]).ToLower() == "staff")
                    {
                        pnlSatffDetails.Visible = true;
                        pnlGridStaff.Visible = true;
                        txtFromDate.Text = TodayDate;
                        txtToDate.Text = TodayDate;
                        flagInserOrLoad = 1;
                        StaffId = Convert.ToInt32(Session["UserId"]);
                        StaffAdminFlag = Convert.ToString(Session["UserType"]);
                        LeaveApplyOrAppr = new LeaveApplyOrApprovePresenter(this);
                        DataSet dsGet = LeaveApplyOrAppr.GetOrApplyOrAppr();
                        if (dsGet.Tables.Count > 0)
                        {
                            if (dsGet.Tables[0].Rows.Count > 0)
                            {
                                ListItem item = new ListItem();
                                item.Text = "--";
                                item.Value = "0";
                                ddlleaveType = ClientDetails.LoadDropDropDown(ddlleaveType, "cLeaveType", "cLeaveTypeId", dsGet.Tables[0]);
                                ddlleaveType.Items.Insert(0, item);
                               
                            }
                            else
                            {
                                return;
                            }
                            
                                GVWLeave.DataSource = dsGet.Tables[1];
                                GVWLeave.DataBind(); 
                        }
                        else
                        {
                          
                            return;
                        }

                    }
                    else if (Convert.ToString(Session["UserType"]).ToLower() == "admin")
                    {
                        pnlSatffDetails.Visible = false;
                        pnlGridStaff.Visible = false;
                        pnlAdmin.Visible = true;
                        flagInserOrLoad = 1;
                        apprPerId = Convert.ToInt32(Session["UserId"]);
                        StaffAdminFlag = Convert.ToString(Session["UserType"]);
                        LeaveApplyOrAppr = new LeaveApplyOrApprovePresenter(this);
                        DataSet dsGet = LeaveApplyOrAppr.GetOrApplyOrAppr();
                        if (dsGet.Tables.Count > 0)
                        {
                           
                                GVAdmin.DataSource = dsGet.Tables[0];
                                GVAdmin.DataBind();
                        }
                        else
                        {
                        } return;


                    }
                }
               
            }
            catch
            {

            }

        }

     


    
        protected void btnCrewPerf_Click(object sender, EventArgs e)
        {
            try
            {
                pnlStaffId.Visible = true;
                if (ddlleaveType.SelectedIndex == 0 || txtTotHrs.Text == string.Empty)
                {
                    lblError.Visible = true;
                    lblError.Text = "Fill the Required Fields";
                    lblError.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    flagInserOrLoad = 0;
                    cLvId =Convert.ToInt32(ddlleaveType.SelectedValue);
                    StaffId = Convert.ToInt32(Session["UserId"]);
                    StaffAdminFlag = Convert.ToString(Session["UserType"]);
                    apprPerId = Convert.ToInt32(Session["CreatedBy"]);
                    LeaveApplyOrAppr = new LeaveApplyOrApprovePresenter(this);
                    DataSet dsGet = LeaveApplyOrAppr.GetOrApplyOrAppr();
                    if (dsGet.Tables.Count > 0)
                    {
                          GVWLeave.DataSource = dsGet.Tables[0];
                          GVWLeave.DataBind();
                        lblGvResult.Visible = true;
                        lblGvResult.Text = "Apllied Successfully";
                        lblGvResult.ForeColor = Color.Green;

                    }
                    else
                    {
                        lblGvResult.Visible = true;
                        lblGvResult.Text = "Error in Inserted Operation";
                        lblGvResult.ForeColor = Color.Red;
                    }
                }
            }
            catch(Exception ex)
            {
                lblGvResult.Visible = true;
                lblGvResult.Text = ex.Message.ToString();
                lblGvResult.ForeColor = Color.Red;
            }


        }

        protected void lnkApprove_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)((Control)sender).Parent.Parent;
                int index = row.RowIndex;
               // string  = ((Label)GVAdmin.Rows[index].FindControl("idLvId")).Text.ToString();
                GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
                LinkButton lnkBtnAppr = sender as LinkButton;
                flagInserOrLoad = 0;
                StaffId = Convert.ToInt32(GVAdmin.DataKeys[grdrow.RowIndex].Value);
                StaffAdminFlag = Convert.ToString(Session["UserType"]);
                dFromDate = grdrow.Cells[4].Text;
                dToDate = grdrow.Cells[5].Text;
                apprPerId = Convert.ToInt32(Session["UserId"]);
                cLvTypeId=Convert.ToInt32(((Label)GVAdmin.Rows[index].FindControl("idLvId")).Text.ToString());
                LeaveApplyOrAppr = new LeaveApplyOrApprovePresenter(this);
                DataSet dsGet = LeaveApplyOrAppr.GetOrApplyOrAppr();
                if (dsGet.Tables.Count > 0)
                {
                   
                        GVAdmin.DataSource = dsGet.Tables[0];
                        GVAdmin.DataBind();
                    lblGridResult.Visible = true;
                    lblGridResult.Text = "Approved Successfully";
                    lblGridResult.ForeColor = Color.Green;

                }
                else
                {
                    lblGridResult.Visible = true;
                    lblGridResult.Text = "No Records";
                    lblGridResult.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                lblGridResult.Visible = true;
                lblGridResult.Text = ex.Message.ToString();

            }
        }


        protected void lnkCancel_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)((Control)sender).Parent.Parent;
                int index = row.RowIndex;
                GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;                              
                LinkButton lnkBtnAppr = sender as LinkButton;
                flagInserOrLoad = 2;
                StaffId = Convert.ToInt32(GVAdmin.DataKeys[grdrow.RowIndex].Value);
                StaffAdminFlag = Convert.ToString(Session["UserType"]);
                dFromDate = grdrow.Cells[4].Text;
                dToDate = grdrow.Cells[5].Text;
                apprPerId = Convert.ToInt32(Session["UserId"]);
                cLvTypeId = Convert.ToInt32(((Label)GVAdmin.Rows[index].FindControl("idLvId")).Text.ToString());
                LeaveApplyOrAppr = new LeaveApplyOrApprovePresenter(this);
                DataSet dsGet = LeaveApplyOrAppr.GetOrApplyOrAppr();
                if (dsGet.Tables.Count > 0)
                {                  
                        GVAdmin.DataSource = dsGet.Tables[0];
                        GVAdmin.DataBind();
                    lblGridResult.Visible = true;
                    lblGridResult.Text = "Cancelled Successfully";
                    lblGridResult.ForeColor = Color.Green;

                }
                else
                {
                    lblGridResult.Visible = true;
                    lblGridResult.Text = "No Records";
                    lblGridResult.ForeColor = Color.Red;
                }
              
            }
            catch(Exception ex)
            {
                lblGridResult.Visible = true;
                lblGridResult.Text = ex.Message.ToString();
                
            }

        }
    }
}