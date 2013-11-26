using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestApps.BAL;
using ManpowerManage.View;
using ManpowerManage.Presenter;
using ManpowerManage.Utilities;
using ManpowerManageWeb.Constant;

namespace ManpowerManageWeb
{
    public partial class FrmOpportunity : System.Web.UI.Page,IOpportunity
    {
        DataTable dttemp = new DataTable();
        public FrmOpportunity()
        {
            dttemp.Columns.Add("CompanyName");
            dttemp.Columns.Add("Industry");
            dttemp.Columns.Add("category");
            dttemp.Columns.Add("requiredjobposition");
            dttemp.Columns.Add("CountryID");
            dttemp.Columns.Add("salary");
            dttemp.Columns.Add("workinghours");
            dttemp.Columns.Add("leavermonth");
            dttemp.Columns.Add("requiredexperience");
            dttemp.Columns.Add("passtype");
            dttemp.Columns.Add("accomodation");
            dttemp.Columns.Add("overtime");
            dttemp.Columns.Add("food");
            ViewState["Data"] = dttemp;
        }

        #region "Declaration"
        int OpportunityID = 1;        
        BusinessOpportunity objStaff = new BusinessOpportunity();
        int result = Constants.NullInt;
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";
        int Flag = 0;
        int Companyinsert;
        int companyId = 0;
        #endregion

        private OpportunityPresenter Presenter;

        # region " Members value assigning with Properties Staff Type Presenter"

        public int OpportunityId
        {
            get { return OpportunityID; }
            set { OpportunityID = value; }
        }

        public string CompanyName
        {
            get { return txtCompanyName.Text; }
            set { txtCompanyName.Text = value; }
        }

        public int Industry
        {
            get { return Convert.ToInt32(ddlIndustry.SelectedValue == "" || ddlIndustry.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlIndustry.SelectedValue)); }
            set { ddlIndustry.SelectedValue = Convert.ToString(value); }
        }
        public int category
        {
            get { return Convert.ToInt32(ddlCategory.SelectedValue == "" || ddlCategory.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlCategory.SelectedValue)); }
            set { ddlCategory.SelectedValue = Convert.ToString(value); }
        }

        public int requiredjobposition
        {
            get { return Convert.ToInt32(ddlJobPosition.SelectedValue == "" || ddlJobPosition.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlJobPosition.SelectedValue)); }
            set { ddlJobPosition.SelectedValue = Convert.ToString(value); }
        }

        public int CountryID
        {
            get { return Convert.ToInt32(ddlCountry.SelectedValue == "" || ddlCountry.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlCountry.SelectedValue)); }
            set { ddlCountry.SelectedValue = Convert.ToString(value); }
        }
        public string salary
        {
            get { return txtSalary.Text.Trim(); }
            set { txtSalary.Text = value; }
        }
        
        public int workinghours
        {
            get { return Convert.ToInt32(ddlHours.SelectedValue == "" || ddlHours.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlHours.SelectedValue)); }
            set { ddlMonth.SelectedValue = Convert.ToString(value); }
        }
        public int leavermonth
        {
            get { return Convert.ToInt32(ddlMonth.SelectedValue == "" || ddlMonth.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlMonth.SelectedValue)); }
            set { ddlMonth.SelectedValue = Convert.ToString(value); }
        }
        public int requiredexperience
        {
            get { return Convert.ToInt32(ddlExperience.SelectedValue == "" || ddlExperience.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlExperience.SelectedValue)); }
            set { ddlExperience.SelectedValue = Convert.ToString(value); }
        }
        public int passtype
        {
            get { return Convert.ToInt32(ddlPassType.SelectedValue == "" || ddlPassType.SelectedValue == "--Select--" ? 0 : Convert.ToInt32(ddlPassType.SelectedValue)); }
            set { ddlPassType.SelectedValue = Convert.ToString(value); }
        }
        public string accomodation
        {
            get { return Convert.ToString(chkaccomodation.Checked); }
            set { chkaccomodation.Checked = Convert.ToBoolean(value); }
        }
        public string overtime
        {
            get { return Convert.ToString(chkovertime.Checked); }
            set { chkovertime.Checked = Convert.ToBoolean(value); }
        }       
        public string food
        {
            get { return Convert.ToString(chkFood.Checked); }
            set { chkFood.Checked = Convert.ToBoolean(value); }
        }

        public int CompanyInsert
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public int CompanyID
        {
            get { return Companyinsert; }
            set { Companyinsert = value; }
        }

        public int flag
        {
            get { return Flag; }
            set { Flag = value; }
        }

        public int CreatedBy
        {
            get { return Convert.ToInt32(Convert.ToString(Session["UserId"]) == "" ? 0 : Convert.ToInt32(Session["UserId"])); }
            set { Session["UserId"] = value; }
        }

        public int UserTypeID
        {
            get { return Convert.ToInt32(Convert.ToString(Session["UserType"]) == "" || Convert.ToString(Session["UserType"]) == "admin" ? 0 : Convert.ToInt32(Session["UserType"])); }
            set { Session["UserType"] = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Convert.ToString(Request.QueryString["CallID"]) == "" || Convert.ToString(Request.QueryString["CallID"]) == null)                
                {
                    ViewState["Type"] = "Insert";
                    txtCompanyName.Visible = false;
                    ddlCompanyName.Visible = true;
                    BindCompany();
                    CompanyInsert = 0;
                }
                else
                {
                    ViewState["Type"] = "Temp";
                    txtCompanyName.Visible = true;
                    ddlCompanyName.Visible = false;
                    CompanyInsert = 1;
                }
                BindIndustry();
                BindCategory();
                BindJobPosition();
                BindCountry();
                BindPassType();
                BindHours();
                BindExperience();
                BindLeaveMonth();
                BindGrid();
            }
            Control_Attributes();
        }

        #region "ControlAttributes"

        public void Control_Attributes()
        {
            txtCompanyName.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
            txtSalary.Attributes.Add("onkeypress", "javascript:return THIS_ALLOWNUMERIC(event,null,this,'" + btnSave.ClientID + "')");
        }

        #endregion

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string accomodation = "";
            string food = "";
            string overtime = "";
            if (chkaccomodation.Checked == true)
                accomodation = "true";
            else accomodation = "false";
            if (chkovertime.Checked == true)
                overtime = "true";
            else overtime = "false";
            if (chkFood.Checked == true)
                food = "true";
            else food = "false";

            if (btnSave.Text == "Save")
            {
                if (Convert.ToString(ViewState["Type"]) == "Insert")
                {
                    Presenter = new OpportunityPresenter(this);
                    Flag = 0;
                    Companyinsert = 0;
                    DataTable dt = new DataTable();
                    dt = Presenter.Insert().Tables[0];
                    if (dt.Rows.Count > 0)
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
                    DataTable dttemp = new DataTable();
                    if (ViewState["Data"] == null)
                    {
                        dttemp.Columns.Add("CompanyName");
                        dttemp.Columns.Add("Industry");
                        dttemp.Columns.Add("category");
                        dttemp.Columns.Add("requiredjobposition");
                        dttemp.Columns.Add("CountryID");
                        dttemp.Columns.Add("salary");
                        dttemp.Columns.Add("workinghours");
                        dttemp.Columns.Add("leavermonth");
                        dttemp.Columns.Add("requiredexperience");
                        dttemp.Columns.Add("passtype");
                        dttemp.Columns.Add("accomodation");
                        dttemp.Columns.Add("overtime");
                        dttemp.Columns.Add("food");
                        ViewState["Data"] = dttemp;
                    }
                    else
                    {
                        dttemp = ViewState["Data"] as DataTable;
                    }
                    DataRow dr = dttemp.NewRow();
                    dr["CompanyName"] = txtCompanyName.Text;
                    dr["Industry"] = ddlIndustry.SelectedValue;
                    dr["category"] = ddlCategory.SelectedValue;
                    dr["requiredjobposition"] = ddlExperience.SelectedValue;
                    dr["CountryID"] = ddlCountry.SelectedValue;
                    dr["salary"] = txtSalary.Text;
                    dr["workinghours"] = ddlHours.SelectedValue;
                    dr["leavermonth"] = ddlMonth.SelectedValue;
                    dr["requiredexperience"] = ddlExperience.SelectedValue;
                    dr["passtype"] = ddlPassType.SelectedValue;
                    dr["accomodation"] = chkaccomodation.Checked ? true : false;
                    dr["overtime"] = chkovertime.Checked ? true : false;
                    dr["food"] = chkFood.Checked ? true : false;
                    dttemp.Rows.Add(dr);
                    ViewState["Data"] = dttemp;
                    gvInsert.Visible = true;
                    btnSubmit.Visible = true;
                    btnClear.Visible = true;
                    gvInsert.DataSource = dttemp;
                    gvInsert.DataBind();
                    ClearData();
                }
            }
            else
            {
                Companyinsert = 0;
                Presenter = new OpportunityPresenter(this);
                OpportunityId = Convert.ToInt32(ViewState["OpportunityId"]);
                Flag = 1;
                DataTable dt = new DataTable();
                dt = Presenter.Update().Tables[0];
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
            gvInsert.DataSource = "";
            gvInsert.Visible = false;
            btnSubmit.Visible = false;
            btnClear.Visible = false;
            ViewState["Data"] = null;
        }

        #region "Grid Events"

        public void BindGrid()
        {
                Presenter = new OpportunityPresenter(this);
                Flag = 1;
                DataTable dt = Presenter.Select().Tables[0];
                gvOpportunity.DataSource = dt;
                gvOpportunity.DataBind();
                ViewState["OpportunityDetails"] = dt;
        }

        protected void gvStaff_PageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gvOpportunity.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (ViewState["OpportunityDetails"] != null)
            {
                dt = (DataTable)ViewState["OpportunityDetails"];//Filter the data in view state
            }
            else
            {
                Flag = 0;
                OpportunityId = 0;
                Presenter = new OpportunityPresenter(this);
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
            gvOpportunity.DataSource = dv;
            gvOpportunity.DataBind();  //Bind the data 
        }

        protected void gvStaff_SortCommand(object sender, GridViewSortEventArgs e)
        {
            if (ViewState["OpportunityDetails"] != null)//Filter the data in view state
            {
                DataTable dtsort = (DataTable)ViewState["OpportunityDetails"];
                SortGrid(e.SortExpression, dtsort);
            }
            else
            {
                Flag = 0;
                OpportunityId = 0;
                Presenter = new OpportunityPresenter(this);
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
            gvOpportunity.DataSource = dv;
            gvOpportunity.DataBind();
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
                lbl.Text = Convert.ToString(((gvOpportunity.PageSize * gvOpportunity.PageIndex) + e.Row.RowIndex) + 1);
            }   
        }

        protected void BindRowData(object sender, EventArgs e)
        {
            lblrequiredmess.Text = "";
            LinkButton lbtn = (LinkButton)sender;
            Presenter = new OpportunityPresenter(this);
            Flag = 0;
            OpportunityId = Convert.ToInt32(lbtn.Text.Trim());
            DataTable dt = Presenter.Select().Tables[0];            
            if (dt.Rows.Count > 0)
            {
                BindIndustry();
                BindCategory();
                BindJobPosition();
                BindCountry();
                BindPassType();
                BindHours();
                BindExperience();
                BindLeaveMonth();
                txtCompanyName.Text = Convert.ToString(lbtn.Text);               
                txtSalary.Text = Convert.ToString(dt.Rows[0]["Salary"]);
                ddlCategory.SelectedValue = Convert.ToString(dt.Rows[0]["CategoryId"]);
                ddlExperience.SelectedValue = Convert.ToString(dt.Rows[0]["RequiredExperience"]);
                ddlHours.SelectedValue = Convert.ToString(dt.Rows[0]["WorkingHours"]);
                ddlIndustry.SelectedValue = Convert.ToString(dt.Rows[0]["IndustryId"]);
                ddlJobPosition.SelectedValue = Convert.ToString(dt.Rows[0]["RequiredJobPostion"]);
                ddlMonth.SelectedValue = Convert.ToString(dt.Rows[0]["LeaveMonth"]);
                ddlPassType.SelectedValue = Convert.ToString(dt.Rows[0]["PassType"]);
                ddlCountry.SelectedValue = Convert.ToString(dt.Rows[0]["CountryId"]);
                ddlMonth.SelectedValue = Convert.ToString(dt.Rows[0]["LeaveMonth"]);
                chkaccomodation.Checked = Convert.ToBoolean(Convert.ToString(dt.Rows[0]["Accomodation"]));
                chkovertime.Checked = Convert.ToBoolean(Convert.ToString(dt.Rows[0]["OverTime"]));
                chkFood.Checked = Convert.ToBoolean(Convert.ToString(dt.Rows[0]["Food"]));
                btnSave.Text = "Update";
                btnSave.ToolTip = "Update";
            }
            ViewState["OpportunityId"] = lbtn.Text;
        }

        #endregion

        #region "Binding Dropdown List"

        protected void BindCompany()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new OpportunityPresenter(this);
            Flag = 1;
            //Industry = 0;
            oDataTable = Presenter.SelectCompany().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlCompanyName.DataSource = oDataTable;
                ddlCompanyName.DataTextField = "CompanyName";
                ddlCompanyName.DataValueField = "CompanyID";
                ddlCompanyName.DataBind();
                ddlCompanyName.Items.Insert(0, "--Select--");
            }
        }

        protected void BindIndustry()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new OpportunityPresenter(this);
            Flag = 1;
            //Industry = 0;            
            oDataTable = Presenter.SelectIndustry().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlIndustry.DataSource = oDataTable;
                ddlIndustry.DataTextField = "Title";
                ddlIndustry.DataValueField = "RefID";
                ddlIndustry.DataBind();
                ddlIndustry.Items.Insert(0, "--Select--");
            }
        }

        protected void BindCategory()
        {
            DataTable oDataTable = new DataTable();//Create type drop down
            Presenter = new OpportunityPresenter(this);
            Flag = 1;
            //category = 0;
            oDataTable = Presenter.SelectCategory().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlCategory.DataSource = oDataTable;
                ddlCategory.DataTextField = "CategoryType";
                ddlCategory.DataValueField = "CategoryTypeID";
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, "--Select--");
            }
        }

        protected void BindJobPosition()
        {
            DataTable oDataTable = new DataTable();//Create type drop down            
            Flag = 1;
            oDataTable = Presenter.SelectJobPosition().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlJobPosition.DataSource = oDataTable;
                ddlJobPosition.DataTextField = "JobPostion";
                ddlJobPosition.DataValueField = "JobPositionID";
                ddlJobPosition.DataBind();
                ddlJobPosition.Items.Insert(0, "--Select--");
            }
        }

        protected void BindCountry()
        {
            DataTable oDataTable = new DataTable();//Create type drop down            
            Presenter = new OpportunityPresenter(this);
            Flag = 1;
            //CountryID = 0;
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

        protected void BindPassType()
        {
            DataTable oDataTable = new DataTable();//Create type drop down   
            Flag = 1;
            oDataTable = Presenter.SelectPassType().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlPassType.DataSource = oDataTable;
                ddlPassType.DataTextField = "PassType";
                ddlPassType.DataValueField = "PassTypeID";
                ddlPassType.DataBind();
                ddlPassType.Items.Insert(0, "--Select--");
            }
        }

        protected void BindHours()
        {
            DataTable oDataTable = new DataTable();//Create type drop down     
            Flag = 1;
            oDataTable = Presenter.SelectHours().Tables[0];            
            if (oDataTable.Rows.Count > 0)
            {
                ddlHours.DataSource = oDataTable;
                ddlHours.DataTextField = "Hour";
                ddlHours.DataValueField = "HourID";
                ddlHours.DataBind();
                ddlHours.Items.Insert(0, "--Select--");
            }
        }

        protected void BindExperience()
        {
            DataTable oDataTable = new DataTable();//Create type drop down    
            Flag = 1;
            oDataTable = Presenter.SelectExperience().Tables[0];             
            if (oDataTable.Rows.Count > 0)
            {
                ddlExperience.DataSource = oDataTable;
                ddlExperience.DataTextField = "Experience";
                ddlExperience.DataValueField = "ExperienceID";
                ddlExperience.DataBind();
                ddlExperience.Items.Insert(0, "--Select--");
            }
        }

        protected void BindLeaveMonth()
        {
            DataTable oDataTable = new DataTable();//Create type drop down     
            Flag = 1;
            oDataTable = Presenter.SelectLeavemonth().Tables[0];
            if (oDataTable.Rows.Count > 0)
            {
                ddlMonth.DataSource = oDataTable;
                ddlMonth.DataTextField = "LeaveMonth";
                ddlMonth.DataValueField = "LeaveMonthID";
                ddlMonth.DataBind();
                ddlMonth.Items.Insert(0, "--Select--");
            }
        }

        #endregion

        public void ClearData()
        {
            txtCompanyName.Text = "";
            txtSalary.Text = "";
            ddlCategory.SelectedIndex = 0;
            ddlExperience.SelectedIndex = 0;
            ddlHours.SelectedIndex = 0;
            ddlIndustry.SelectedIndex = 0;
            ddlJobPosition.SelectedIndex = 0;
            ddlMonth.SelectedIndex = 0;
            ddlPassType.SelectedIndex = 0;
            ddlCountry.SelectedIndex = 0;
            chkaccomodation.Checked = false;
            chkFood.Checked = false;
            chkovertime.Checked = false;
            btnSave.Text = "Save";
            btnSave.ToolTip = "Save";
        }

        protected void BindDeleteData(object sender, EventArgs e)
        {            
            LinkButton lbtn = (LinkButton)sender;
            Presenter = new OpportunityPresenter(this);
            Flag = 1;            
            DataTable dttemp = ViewState["Data"] as DataTable;
            DataRow[] dr = dttemp.Select("CompanyName = '" + lbtn.Text.Trim() + "'");
            if (dr.Length > 0)
            {
                dttemp.Rows.Remove(dr[0]);
            }
            ViewState["Data"] = dttemp;
            gvInsert.DataSource = dttemp;
            gvInsert.DataBind();
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            if (ViewState["Type"] != "Insert")
            {
                if (Convert.ToString(ViewState["Data"]) != "")
                {
                    DataTable dttemp = ViewState["Data"] as DataTable;
                    for (int i = 0; i < dttemp.Rows.Count; i++)
                    {
                        OpportunityId = 0;
                        CompanyName = Convert.ToString(dttemp.Rows[i]["CompanyName"]);
                        Industry = Convert.ToInt32(dttemp.Rows[i]["Industry"]);
                        category = Convert.ToInt32(dttemp.Rows[i]["category"]);
                        requiredjobposition = Convert.ToInt32(dttemp.Rows[i]["requiredjobposition"]);
                        CountryID = Convert.ToInt32(dttemp.Rows[i]["CountryID"]);
                        salary = Convert.ToString(dttemp.Rows[i]["salary"]);
                        workinghours = Convert.ToInt32(dttemp.Rows[i]["workinghours"]);
                        leavermonth = Convert.ToInt32(dttemp.Rows[i]["leavermonth"]);
                        requiredexperience = Convert.ToInt32(dttemp.Rows[i]["requiredexperience"]);
                        passtype = Convert.ToInt32(dttemp.Rows[i]["passtype"]);
                        accomodation = Convert.ToString(dttemp.Rows[i]["accomodation"]);
                        overtime = Convert.ToString(dttemp.Rows[i]["overtime"]);
                        food = Convert.ToString(dttemp.Rows[i]["food"]);
                        CompanyInsert = 1;
                        CompanyID = 1; //Convert.ToInt32(Request.QueryString["CallID"]);
                        flag = 0;
                        Presenter = new OpportunityPresenter(this);
                        DataTable dt = Presenter.Insert().Tables[0];
                    }
                    gvInsert.Visible = false;
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;
                    ViewState["Data"] = null;
                    lblrequiredmess.Text = "Inserted Successfully.";
                    lblrequiredmess.Visible = true;
                    lblrequiredmess.Style.Add("color", "green");
                    BindGrid();
                    ClearData();
                }
            }
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            gvInsert.Visible = false;
            btnSubmit.Visible = false;
            btnClear.Visible = false;
            ViewState["Data"] = null;
        }        
    }
}