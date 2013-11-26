using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ManpowerManage.View;
using ManpowerManage.Presenter;

namespace ManpowerManageWeb
{
    public partial class LeaveType : System.Web.UI.Page,ILeaveType
    {

        private int nLTypeId = 0;
        private int UserId = 0;
        public int flag = 0;
        public int days = 0;
        public int year = 0;
        private string Leavetype = string.Empty;
        private LeavePresenter presenter;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string cLeaveType
        {
            get { return txt_LeaveType.Text; }
            set { txt_LeaveType.Text = value; }
        }
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
        public int nLeaveTypeId
        {
            get { return nLTypeId; }
            set { nLTypeId = value; }
        }
        public int CreatedBy
        {
            get { return UserId; }
            set { UserId = value; }
        }

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            #region "Satrt PostBack"
            if (Session["UserId"] == null && Session["UserName"] == null && Session["UserType"] == null)
                Response.Redirect("Login.aspx");

            UserId = Convert.ToInt32(Session["UserId"].ToString());

            if (!IsPostBack)
            {
                presenter = new LeavePresenter(this);
                DataSet dsGetLeave = presenter.GetLeaveTypePresent();
                BindMethod(dsGetLeave);
                ddlYear = LeaveTypeClass.TempYearMethod(ddlYear);
                LeaveTypeClass. flagForLeaveType = 1;
            }
            #endregion

        }
        protected void BindMethod(DataSet dsGetLeave)
        {
            gvLeaveType.DataSource = dsGetLeave.Tables[0];
            gvLeaveType.DataBind();
        }
        protected void imgbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //GridViewRow row = (GridViewRow)((Control)sender).Parent.Parent;
                //int index = row.RowIndex;
                //string ETMNO = ((Label)gvLeaveType.Rows[index].FindControl("imgEdit")).Text.ToString();
                GridViewRow grdrow = (GridViewRow)((ImageButton)sender).NamingContainer;
                //ddlYear.SelectedIndex = 
                ddlYear.SelectedItem.Text = grdrow.Cells[3].Text;             
                txtNoOfDay.Text = grdrow.Cells[2].Text;
                txt_LeaveType.Text = grdrow.Cells[1].Text;
                LeaveTypeClass.nLTypeId = Convert.ToInt32(gvLeaveType.DataKeys[grdrow.RowIndex].Value);
                LeaveTypeClass.flagForLeaveType = 2;
            }
            catch (Exception Ex)
            {
                lblError.Visible = true;
                lblError.Text = Ex.Message.ToString();
            }

        }
        protected void imgDel_Click(object sender, EventArgs e)
        {
            try
            {               
                flag= 3;               
                GridViewRow grdrow = (GridViewRow)((ImageButton)sender).NamingContainer;               
                year = Convert.ToInt32(grdrow.Cells[3].Text);
                days = Convert.ToInt32(grdrow.Cells[2].Text);              
                nLTypeId = Convert.ToInt32(gvLeaveType.DataKeys[grdrow.RowIndex].Value);
                presenter = new LeavePresenter(this);
                DataSet dsGetLeave = presenter.UpdateDeleteLeaveType();
                BindMethod(dsGetLeave);
                lblGridResult.Visible = true;
                lblGridResult.Text = "Deleted Successfully";
                LeaveTypeClass.flagForLeaveType = 1;
               
            }
            catch 
            {
                lblGridResult.Visible = true;
                lblGridResult.Text = "Error";
            }
        }
        private void clearFields()
        {
            ddlYear.SelectedIndex = 0;
            txtNoOfDay.Text = string.Empty;
            txt_LeaveType.Text = string.Empty;
        }

        protected void btn_SaveOrUpdate_Click1(object sender, EventArgs e)
        {
            days = Convert.ToInt32(txtNoOfDay.Text);
            year = Convert.ToInt32(ddlYear.SelectedItem.Text.ToString());

            try
            {
                if (ddlYear.SelectedIndex > 0 && !string.IsNullOrEmpty(txt_LeaveType.Text) && !string.IsNullOrEmpty(txtNoOfDay.Text))
                {
                    //common = new CommonClass(this);
                    if (LeaveTypeClass.flagForLeaveType == 1)// Add New Function
                    {
                        flag = LeaveTypeClass.flagForLeaveType;
                        presenter = new LeavePresenter(this);
                        DataSet dsGetLeave = presenter.SaveNewLeaveType();
                        BindMethod(dsGetLeave);
                        lblGridResult.Visible = true;
                        lblGridResult.Text = "Inserted Successfully";
                        
                    }
                    else if (LeaveTypeClass.flagForLeaveType == 2) // update Function
                    {
                        flag = LeaveTypeClass.flagForLeaveType;
                        nLTypeId = LeaveTypeClass.nLTypeId;
                        presenter = new LeavePresenter(this);
                        DataSet dsGetLeave = presenter.UpdateDeleteLeaveType();
                        BindMethod(dsGetLeave);
                        lblGridResult.Visible = true;
                        lblGridResult.Text = "Updated Successfully";
                       
                    }
                    clearFields(); // Clear the field
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message.ToString();
            }
        }
    }

    public class LeaveTypeClass
    {
        public static int flagForLeaveType { get; set; }
        public static int nLTypeId { get; set; }
        public static DropDownList TempYearMethod(DropDownList dropDownYear)
        {
            List<string> temp = new List<string>();
            for (int i = 2013; i < 2050; i++)
            {
                temp.Add(i.ToString());
            }
            temp.Insert(0, "--");
            dropDownYear.DataSource = temp;
            dropDownYear.DataBind();


            return dropDownYear;
        }
    }
}