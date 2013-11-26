using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ManpowerManageWeb.BAL;
using ManpowerManage.Utilities;
using System.Threading;

namespace ManpowerManageWeb
{
    public partial class CallHistoryList : System.Web.UI.Page
    {        

        #region Declarations

        CallHistory_BAL objCalBAL = new CallHistory_BAL();
        Utility objUtility = new Utility();
         
        
        #endregion
    
        #region Protected Methods

        /// <summary>
        /// Binding dropdowns and call detail grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            if (Session["usertype"].ToString() == "admin")           
                TrSearch.Visible = true;           
            else
                TrSearch.Visible = false;

           

                if (!Page.IsPostBack)
                {                  
                    BindCallDetails();

                    using (DataTable dtStaff = objCalBAL.GetStaffDetails())
                    {
                        if (dtStaff != null)
                        {
                            DdlStaff.DataSource = dtStaff;
                            DdlStaff.DataTextField = "FirstName";
                            DdlStaff.DataValueField = "Employeerid";
                            DdlStaff.DataBind();
                        }

                        ListItem item = new ListItem();
                        item.Text = "--";
                        item.Value = "0";
                        DdlStaff.Items.Insert(0, item);
                    }
                }
            //}
            //catch (Exception ex)
            //{

            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvdata_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //ImageButton ImgDelete = (ImageButton)e.Row.FindControl("ImgDelete");
                //if (Session["Admin"] != null)
                //    ImgDelete.Visible = true;
                //else
                //    ImgDelete.Visible = false;
                
            }
        }

        /// <summary>
        /// Call edit click action. Loading values fromm DB to input controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImgEdit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow gvRow = (GridViewRow)btn.NamingContainer;
           // HdnUpdate.Value = Convert.ToString(gvdata.DataKeys[gvRow.DataItemIndex].Value);
           // LoadValues(Convert.ToInt32(gvdata.DataKeys[gvRow.DataItemIndex].Value), 1);
            Thread.Sleep(2000);
            Response.Redirect("AddOrUpdateCallRegistry.aspx?Mode=Edit&CallID=" + Convert.ToInt32(gvCallRegistry.DataKeys[gvRow.DataItemIndex].Value));
        }
        
        /// <summary>
        /// Call view click action. Loading values fromm DB to label controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImgView_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow gvRow = (GridViewRow)btn.NamingContainer;

            //LoadValues(Convert.ToInt32(gvdata.DataKeys[gvRow.DataItemIndex].Value), 2);
            //BtnUpdate.Visible = BtnOpportunity.Visible = false;
            Thread.Sleep(2000);
            Response.Redirect("AddOrUpdateCallRegistry.aspx?Mode=View&CallID=" + Convert.ToInt32(gvCallRegistry.DataKeys[gvRow.DataItemIndex].Value));
        }

        protected void ImgDelete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow gvRow = (GridViewRow)btn.NamingContainer;

            int deleteFlag = objCalBAL.DeleteCallDetail(Convert.ToInt32(gvCallRegistry.DataKeys[gvRow.DataItemIndex].Value));

           //if (deleteFlag.Equals(1))
                BindCallDetails();

            Thread.Sleep(2000);

        }
                   
        #endregion
        
        #region Private Methods    

        /// <summary>
        /// Get the call details from database and bind details in grid based on staffID
        /// </summary>
        /// <param name="callID"></param>
        /// <param name="staffID"></param>
        private DataTable BindCallDetails()
        {
            DataTable dtCallDetails;
            int callID = 0;
            int staffID = 0;
            if(Session["Staff"] != null)
                staffID = Convert.ToInt32(Session["Staff"]);           
            else if(DdlStaff.SelectedIndex > 0)           
                staffID=Convert.ToInt32((DdlStaff.SelectedValue));
          
            string today = string.Empty;
            if (Request.QueryString["CallDate"] != null)
                today = DateTime.Now.ToShortDateString();
            using (DataSet dsCallDetails = objCalBAL.GetCallDetails(callID, staffID, today))
            {
                gvCallRegistry.DataSource = dsCallDetails;
                gvCallRegistry.DataBind();
                dtCallDetails = dsCallDetails.Tables[0];
                ViewState["CallDetails"] = dtCallDetails;
            }
            return dtCallDetails;
        }
        #endregion

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            BindCallDetails();  
        }

        protected void gvCallRegistry_Sorting(object sender, GridViewSortEventArgs e)
        {
            Thread.Sleep(2000);
            if (ViewState["CallDetails"] != null)
            {
                DataTable dtCallDetails = (DataTable)ViewState["CallDetails"];
                SortGrid(e.SortExpression, dtCallDetails);
            }
            else
            {
                DataTable dtCallDetails = BindCallDetails();
                SortGrid(e.SortExpression, dtCallDetails);
            }
        }

        /// <summary>
        /// Set the data in order through sorting
        /// </summary>
        /// <param name="sortExpres"></param>
        /// <param name="dtCallRegistryDetails"></param>
        private void SortGrid(string sortExpres, DataTable dtCallRegistryDetails)
        {
            string sortExpression = sortExpres;
            ViewState["SortExpression"] = sortExpression;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortDataGrid(sortExpression, "ASC", dtCallRegistryDetails);
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortDataGrid(sortExpression, "DESC", dtCallRegistryDetails);
            }
        }

        /// <summary>
        /// Sorting in grid
        /// </summary>
        /// <param name="sortExpression"></param>
        /// <param name="direction"></param>
        private void SortDataGrid(string sortExpression, string direction, DataTable dt)
        {
            DataTable dtCallDetails = dt;
            DataView dv = new DataView(dtCallDetails);
            dv.Sort = (sortExpression + " ") + direction;
            gvCallRegistry.DataSource = dv;
            gvCallRegistry.DataBind();
        }

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


        protected void gvCallRegistry_PageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            Thread.Sleep(2000);
            gvCallRegistry.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (ViewState["CallDetails"] != null)
            {
                dt = (DataTable)ViewState["CallDetails"];//Filter the data in view state
            }
            else
            {
                dt = BindCallDetails();
            }

            DataView dv = new DataView(dt);

            if (Convert.ToString(ViewState["SortExpression"]) != "")
            {
                string direction;
                if ((SortDirection)ViewState["sortDirection"] == SortDirection.Ascending)
                {
                    direction = "ASC";
                }
                else
                {
                    direction = "DESC";
                }
                dv.Sort = (ViewState["SortExpression"] + " ") + direction;
            }
            gvCallRegistry.DataSource = dv;
            gvCallRegistry.DataBind(); 
        }
      
               
    }
}