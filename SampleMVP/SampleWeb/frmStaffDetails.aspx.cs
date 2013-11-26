using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using TestApps.BAL;
using ManpowerManage.View;
using ManpowerManage.Presenter;
using ManpowerManage.Utilities;
using ManpowerManageWeb.Constant;
namespace ManpowerManageWeb
{
    public partial class frmStaffDetails : System.Web.UI.Page,IStaffDetails
    {
        #region "Declaration"

        BusinessStaffDetails objStaff = new BusinessStaffDetails();
        int result=Constants.NullInt;
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";
        int Flag = 0;
        int StaffID = 1;

        #endregion

        private StaffDetailsPresenter Presenter;

        # region " Members value assigning with Properties Staff Type Presenter"

        public int StaffId
        {
            get { return Convert.ToInt32(txtStaffId.Text); }
            set { txtStaffId.Text = Convert.ToString(value); }
        }

        public string title
        {
            get { return ddlTitle.SelectedValue; }
            set { ddlTitle.SelectedValue = value; }
        }

        public int StaffType
        {
            get { return Convert.ToInt32(ddlStaffType.SelectedValue == "" || ddlStaffType.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlStaffType.SelectedValue)); }
            set { ddlStaffType.SelectedValue = Convert.ToString(value); }
        }
        public int UserType
        {
            get { return Convert.ToInt32(ddlUserType.SelectedValue == "" || ddlUserType.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlUserType.SelectedValue)); }
            set { ddlUserType.SelectedValue = Convert.ToString(value); }
        }

        public string Firstname
        {
            get { return Convert.ToString(txtFirstname.Text); }
            set { txtFirstname.Text = value; }
        }

        public string middlename
        {
            get { return txtMiddleName.Text; }
            set { txtMiddleName.Text = Convert.ToString(value); }
        }
        public string Lastname
        {
            get { return txtLastName.Text.Trim(); }
            set { txtLastName.Text = value; }
        }

        public string UserName
        {
            get { return Convert.ToString(txtUserName.Text); }
            set { txtUserName.Text = value; }
        }
        public string Address1
        {
            get { return Convert.ToString(txtAddress1.Text); }
            set { txtAddress1.Text = value; }
        }
        public string Address2
        {
            get { return Convert.ToString(txtAddress2.Text); }
            set { txtAddress2.Text = Convert.ToString(value); }
        }
        public string City
        {
            get { return Convert.ToString(txtCity.Text); }
            set { txtCity.Text = Convert.ToString(value); }
        }
        public string State
        {
            get { return Convert.ToString(txtState.Text); }
            set { txtState.Text = Convert.ToString(value); }
        }
        public string zip
        {
            get { return Convert.ToString(txtZip.Text); }
            set { txtZip.Text = Convert.ToString(value); }
        }

        public int Country
        {
            get { return Convert.ToInt32(ddlCountry.SelectedValue == "" || ddlCountry.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlCountry.SelectedValue)); }
            set { ddlCountry.SelectedValue = Convert.ToString(value); }
        }
        public string ContactNo
        {
            get { return txtContactNo.Text.Trim(); }
            set { txtContactNo.Text = value; }
        }

        public string EmergencyContactNo
        {
            get { return Convert.ToString(txtEmerContactNo.Text); }
            set { txtEmerContactNo.Text = value; }
        }
        public string Email
        {
            get { return Convert.ToString(txtEmail.Text); }
            set { txtEmail.Text = value; }
        }
        public string Qualification
        {
            get { return Convert.ToString(txtQualification.Text); }
            set { txtQualification.Text = Convert.ToString(value); }
        }
        public int StaffTeamID
        {
            get { return Convert.ToInt32(ddlStaffTeam.SelectedValue == "" || ddlStaffTeam.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlStaffTeam.SelectedValue)); }
            set { ddlStaffTeam.SelectedValue = Convert.ToString(value); }
        }
        public int CustomerTypeID
        {
            get { return Convert.ToInt32(ddlCustomerType.SelectedValue == "" || ddlCustomerType.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlCustomerType.SelectedValue)); }
            set { ddlCustomerType.SelectedValue = Convert.ToString(value); }
        }
        public string StaffPosition
        {
            get { return Convert.ToString(txtStaffPosition.Text); }
            set { txtStaffPosition.Text = value; }
        }

        public string StaffRate
        {
            get { return Convert.ToString(txtStaffRate.Text); }
            set { txtStaffRate.Text = value; }
        }
        public string CommissionRate
        {
            get { return Convert.ToString(txtCommissionRate.Text); }
            set { txtCommissionRate.Text = value; }
        }

        public string CommissionType
        {
            get { return Convert.ToString(txtCommissionType.Text); }
            set { txtCommissionType.Text = value; }
        }
        public int CreatedBy
        {
            get { return Convert.ToInt32(Convert.ToString(Session["UserId"]) == ""  ? 0 : Convert.ToInt32(Session["UserId"])); }
            set { Session["UserId"] = value; }
        }

        public int flag
        {
            get { return Flag; }
            set { Flag = value; }
        }

        #endregion

         protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                BindStaffType();
                BindStaffTeam();
                BindUserType();
                BindCustomerType();
                BindCountry();               
            }
            Control_Attributes();            
        }

        #region "ControlAttributes"

        public void Control_Attributes()
        {
            txtFirstname.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtMiddleName.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtLastName.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtCity.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtState.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtStaffPosition.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtCommissionType.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtQualification.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtState.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtStaffId.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWNUMANDCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtUserName.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWNUMANDCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtAddress1.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWNUMANDCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtAddress2.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWNUMANDCHAR(event,null,this,'" + btnSave.ClientID + "')");

            txtZip.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
            txtContactNo.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
            txtEmerContactNo.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
            txtStaffRate.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
            txtCommissionRate.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
        }

        #endregion

        #region "Button Events"

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                Presenter = new StaffDetailsPresenter(this);
                Flag = 1;
                StaffId = Convert.ToInt32(txtStaffId.Text.Trim());
                DataTable dt = Presenter.Select().Tables[0];
                if (dt.Rows.Count == 0)
                {
                    Flag = 0;
                    DataTable dti = Presenter.Insert().Tables[0];
                    if (dti.Rows.Count > 0)
                    {                        
                        lblrequiredmess.Text = "Inserted Successfully.";
                        lblrequiredmess.Visible = true;
                        lblrequiredmess.Style.Add("color", "green");
                        BindGrid();
                        ClearData();
                    }
                }
                else
                {
                    lblrequiredmess.Text = "Already Staff Id Available";
                    lblrequiredmess.Visible = true;
                    lblrequiredmess.Style.Add("color", "red");
                }
            }
            else
            {
                Presenter = new StaffDetailsPresenter(this);
                Flag = 1;
                StaffId = Convert.ToInt32(txtStaffId.Text);
                DataTable dt = Presenter.Update().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    lblrequiredmess.Text = "Updated Successfully.";
                    lblrequiredmess.Visible = true;
                    lblrequiredmess.Style.Add("color", "green");
                    BindGrid();
                    ClearData();
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            lblrequiredmess.Text = "";
        }

        #endregion

        #region "Grid Events"

        public void BindGrid()
        {
            Presenter = new StaffDetailsPresenter(this);
            Flag = 0;
            StaffId = 0;
            DataTable dt = Presenter.Select().Tables[0];
                gvStaff.DataSource = dt;
                gvStaff.DataBind();
                ViewState["StaffDetails"] = dt;            
        }

        protected void gvStaff_PageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gvStaff.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (ViewState["StaffDetails"] != null)
            {
                dt = (DataTable)ViewState["StaffDetails"];//Filter the data in view state
            }
            else
            {
                Flag = 0;
                StaffId = 0;
                Presenter = new StaffDetailsPresenter(this);
                dt = Presenter.Select().Tables[0];
            }

            DataView dv = new DataView(dt);
            
            if (Convert.ToString(ViewState["SortExpression"]) != "")
            {
                string direction;
                if ((SortDirection)ViewState["sortDirection"] == SortDirection.Ascending)
                {
                    direction = DESCENDING;//Set the data in Deascending order
                }
                else
                {
                    direction = ASCENDING;//Set the data in Ascending order
                }
                dv.Sort = (ViewState["SortExpression"] + " ") + direction;
            }
            gvStaff.DataSource = dv;
            gvStaff.DataBind();  //Bind the data 
        }

        protected void gvStaff_SortCommand(object sender, GridViewSortEventArgs e)
        {
            if (ViewState["StaffDetails"] != null)//Filter the data in view state
            {
                DataTable dtsort = (DataTable)ViewState["StaffDetails"];
                SortGrid(e.SortExpression, dtsort);
            }
            else
            {
                Presenter = new StaffDetailsPresenter(this);
                Flag = 0;
                StaffId = 0;
                DataTable dtsort = Presenter.Select().Tables[0];
                SortGrid(e.SortExpression, dtsort);
            }
        }

        /// <summary>
        /// Set the data in order through sorting
        /// </summary>
        /// <param name="sortExpres"></param>
        /// <param name="dt"></param>
        private void SortGrid(string sortExpres, DataTable dt)
        {
            string sortExpression = sortExpres;
            ViewState["SortExpression"] = sortExpression;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortDataGrid(sortExpression, ASCENDING, dt);
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortDataGrid(sortExpression, DESCENDING, dt);
            }
        }
        /// <summary>
        /// Sorting in grid
        /// </summary>
        /// <param name="sortExpression"></param>
        /// <param name="direction"></param>
        private void SortDataGrid(string sortExpression, string direction, DataTable dt)
        {
            DataTable dtsort = dt;
            DataView dv = new DataView(dtsort);
            dv.Sort = (sortExpression + " ") + direction;
            gvStaff.DataSource = dv;
            gvStaff.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private SortDirection GridViewSortDirection
        {
            get
            {
                if (Convert.ToString(ViewState["sortDirection"]) == "")
                {
                    ViewState["sortDirection"] = SortDirection.Ascending;
                }
                return (SortDirection)ViewState["sortDirection"];
            }
            set
            {
                ViewState["sortDirection"] = value;
            }
        }

        protected void gvStaff_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lbl = (Label)e.Row.FindControl("lblSno");
                lbl.Text = Convert.ToString(((gvStaff.PageSize * gvStaff.PageIndex) + e.Row.RowIndex) + 1);
            }   
        }

        protected void BindRowData(object sender, EventArgs e)
        {
            lblrequiredmess.Text = "";
            LinkButton lbtn = (LinkButton)sender;
            Presenter = new StaffDetailsPresenter(this);
            Flag = 1;
            StaffId = Convert.ToInt32(lbtn.Text.Trim());
            DataTable dt = Presenter.Select().Tables[0];
            if (dt.Rows.Count > 0)
            {
                BindStaffType();
                BindStaffTeam();
                BindUserType();
                BindCustomerType();
                BindCountry();                
                txtStaffId.Text = Convert.ToString(lbtn.Text);
                txtStaffId.Enabled = false;
                txtFirstname.Text = Convert.ToString(dt.Rows[0]["FirstName"]);
                txtMiddleName.Text = Convert.ToString(dt.Rows[0]["MiddleName"]);
                txtLastName.Text = Convert.ToString(dt.Rows[0]["LastName"]);
                txtUserName.Text = Convert.ToString(dt.Rows[0]["UserName"]);
                txtAddress1.Text = Convert.ToString(dt.Rows[0]["Address1"]);
                txtAddress2.Text = Convert.ToString(dt.Rows[0]["Address2"]);
                txtContactNo.Text = Convert.ToString(dt.Rows[0]["PrimaryPhone"]);
                txtEmerContactNo.Text = Convert.ToString(dt.Rows[0]["SecondaryPhone"]);
                txtEmail.Text = Convert.ToString(dt.Rows[0]["EmailId"]);
                //txtQualification.Text = Convert.ToString(dt.Rows[0]["Qualification"]);
                ddlStaffType.SelectedValue = Convert.ToString(dt.Rows[0]["StaffTypeID"]);
                //ddlTitle.SelectedValue =  Convert.ToString(dt.Rows[0]["Title"]);
                ddlUserType.SelectedValue = Convert.ToString(dt.Rows[0]["UserTypeId"]);
                ddlCountry.SelectedValue = Convert.ToString(dt.Rows[0]["CountryID"]);
                txtCommissionRate.Text = Convert.ToString(dt.Rows[0]["CommissionRate"]);
                txtCommissionType.Text = Convert.ToString(dt.Rows[0]["CommssionType"]);
                txtStaffRate.Text = Convert.ToString(dt.Rows[0]["StaffRate"]);
                txtStaffPosition.Text = Convert.ToString(dt.Rows[0]["StaffPosition"]);
                ddlStaffTeam.SelectedValue = Convert.ToString(dt.Rows[0]["StaffTeamID"]);
                ddlCustomerType.SelectedValue = Convert.ToString(dt.Rows[0]["CustomerTypeID"]);
                txtState.Text = Convert.ToString(dt.Rows[0]["State"]);
                txtCity.Text = Convert.ToString(dt.Rows[0]["City"]);
                txtZip.Text = Convert.ToString(dt.Rows[0]["Zip"]);
                btnSave.Text = "Update";
                btnSave.ToolTip = "Update";
            }
            ViewState["StaffId"] = lbtn.Text;
        }

        #endregion

        #region "Binding Dropdown List"

        protected void BindStaffType()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new StaffDetailsPresenter(this);
            Flag = 0;
            //StaffType = 0;
            oDataTable = Presenter.SelectStaffType().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlStaffType.DataSource = oDataTable;
                ddlStaffType.DataTextField = "StaffTypeName";
                ddlStaffType.DataValueField = "StaffTypeID";
                ddlStaffType.DataBind();
                ddlStaffType.Items.Insert(0, "--Select--");
            }
        }

        protected void BindUserType()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new StaffDetailsPresenter(this);
            Flag = 1;
            //UserType = 0;
            oDataTable = Presenter.SelectUserType().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlUserType.DataSource = oDataTable;
                ddlUserType.DataTextField = "UserType";
                ddlUserType.DataValueField = "UserTypeId";
                ddlUserType.DataBind();
                ddlUserType.Items.Insert(0, "--Select--");
            }
        }

        protected void BindStaffTeam()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new StaffDetailsPresenter(this);
            Flag = 1;
            //StaffTeamID = 0;
            oDataTable = Presenter.SelectStaffTeam().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlStaffTeam.DataSource = oDataTable;
                ddlStaffTeam.DataTextField = "TeamName";
                ddlStaffTeam.DataValueField = "StaffTeamID";
                ddlStaffTeam.DataBind();
                ddlStaffTeam.Items.Insert(0, "--Select--");
            }
        }

        protected void BindCustomerType()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new StaffDetailsPresenter(this);
            Flag = 1;
            //CustomerTypeID = 0;
            oDataTable = Presenter.SelectCustomerType().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlCustomerType.DataSource = oDataTable;
                ddlCustomerType.DataTextField = "CustomerTypeDesc";
                ddlCustomerType.DataValueField = "CustomerTypeID";
                ddlCustomerType.DataBind();
                ddlCustomerType.Items.Insert(0, "--Select--");
            }
        }

        protected void BindCountry()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new StaffDetailsPresenter(this);
            Flag = 1;
            //Country = 0;
            oDataTable = Presenter.SelectCountry().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlCountry.DataSource = oDataTable;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "--Select--");
            }
        }

        #endregion

        public void ClearData()
        {
            txtStaffId.Text = "";
            txtFirstname.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtContactNo.Text = "";
            txtEmerContactNo.Text = "";
            txtEmail.Text = "";
            txtQualification.Text = "";
            ddlStaffType.SelectedIndex = 0;
            ddlTitle.SelectedIndex = 0;
            ddlUserType.SelectedIndex = 0;            
            ddlCountry.SelectedIndex = 0;
            ddlCustomerType.SelectedIndex = 0;
            ddlStaffTeam.SelectedIndex = 0;
            txtStaffRate.Text = "";
            txtCommissionRate.Text = "";
            txtCommissionType.Text = "";
            txtState.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";            
            btnSave.Text = "Save";
            btnSave.ToolTip = "Save";
            txtStaffId.Enabled = true;
        }                 
    }
}