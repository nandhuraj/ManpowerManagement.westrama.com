using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
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
    public partial class frmStaffType : System.Web.UI.Page,IStaffType
    {
        #region "Declaration"
        int StaffTypeId = 1;        
        BusinessStaffType objStaffType = new BusinessStaffType();
        int result = Constants.NullInt;
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";
        int flag = 0;
        int Isactive = 1;
        #endregion

        private StaffTypePresenter  Presenter;

        # region " Members value assigning with Properties Staff Type Presenter"

        public int StaffTypeID
        {
            get { return StaffTypeId; }
            set { StaffTypeId = value; }
        }

        public string StaffType
        {
            get { return txtStaffType.Text; }
            set { txtStaffType.Text = value; }
        }

        public int IsActive
        {
            get { return Isactive; }
            set { Isactive = value; }
        }

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
            Control_Attributes();  
        }

        #region "ControlAttributes"

        public void Control_Attributes()
        {
            txtStaffType.Attributes.Add("onkeypress", "javascript:return THIS_FALLOWCHAR(event,null,this,'" + btnSave.ClientID + "')");
        }

        public void ClearData()
        {
            txtStaffType.Text = "";            
           
        }

        #endregion

        #region "Button Events"

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    Flag = 2;
                    StaffTypeId = 0;
                    Presenter = new StaffTypePresenter(this);
                    DataTable dt = Presenter.Select().Tables[0];                    
                    if (dt.Rows.Count == 0)
                    {
                        Flag = 0;
                        IsActive = 1;
                        dt = Presenter.Insert().Tables[0];
                        if (dt.Rows.Count == 0)
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
                        lblrequiredmess.Text = "Staff Type Already Exist!";
                        lblrequiredmess.Visible = true;
                        lblrequiredmess.Style.Add("color", "red");
                    }
                }
                else
                {
                    Flag = 1;
                    IsActive = 1;
                    Presenter = new StaffTypePresenter(this);
                    StaffTypeID = Convert.ToInt32(Convert.ToString(ViewState["StaffId"]));                    
                    DataTable dt = Presenter.Update().Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        lblrequiredmess.Text = "Updated Successfully.";
                        lblrequiredmess.Visible = true;
                        lblrequiredmess.Style.Add("color", "green");
                        BindGrid();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                lblrequiredmess.Text = ex.Message.ToString();
                lblrequiredmess.Visible = true;
                lblrequiredmess.Style.Add("color", "red");
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
                Flag = 0;
                StaffTypeID = 0;
                Presenter = new StaffTypePresenter(this);
                DataTable dt = Presenter.Select().Tables[0];
                gvStaffType.DataSource = dt;
                gvStaffType.DataBind();
                ViewState["StaffDetails"] = dt;            
        }

        protected void gvStaffType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvStaffType.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (ViewState["StaffDetails"] != null)
            {
                dt = (DataTable)ViewState["StaffDetails"];//Filter the data in view state
            }
            else
            {
                Flag = 0;
                StaffTypeID = 0;
                StaffType = "";
                Presenter = new StaffTypePresenter(this);
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
            gvStaffType.DataSource = dv;
            gvStaffType.DataBind();  //Bind the data 
        }        

        protected void gvStaffType_SortCommand(object sender, GridViewSortEventArgs e)
        {
            if (ViewState["StaffDetails"] != null)//Filter the data in view state
            {
                DataTable dtsort = (DataTable)ViewState["StaffDetails"];
                SortGrid(e.SortExpression, dtsort);
            }
            else
            {
                Flag = 0;
                StaffTypeID = 0;
                StaffType = "";
                Presenter = new StaffTypePresenter(this);                
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
            gvStaffType.DataSource = dv;
            gvStaffType.DataBind();
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

        protected void BindRowData(object sender, EventArgs e)
        {
            LinkButton lbtn = (LinkButton)sender;
            TableRow trow = (TableRow)lbtn.Parent.Parent;
            HtmlInputHidden hdnvalue = (HtmlInputHidden)trow.FindControl("hdnStaffTypeID");
            Flag = 1;
            StaffTypeID = Convert.ToInt32(hdnvalue.Value.ToString().Trim());
            Presenter = new StaffTypePresenter(this);
            DataTable dt = Presenter.Select().Tables[0];
            if (dt.Rows.Count > 0)
            {
                txtStaffType.Text = Convert.ToString(dt.Rows[0]["StaffTypeName"]);                
                btnSave.Text = "Update";
                btnSave.ToolTip = "Update";
            }
            ViewState["StaffId"] = hdnvalue.Value.ToString().Trim();
        }

        #endregion
    }
}