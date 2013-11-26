using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManageWeb.BAL;
using ManpowerManage.Utilities;
using System.Threading;

namespace ManpowerManageWeb
{
    public partial class CallHistory : System.Web.UI.Page
    {
        CallHistory_BAL objCalBAL = new CallHistory_BAL();
        Utility objUtility = new Utility();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCallHistory();
            }
        }

        private DataTable BindCallHistory()
        {
            DataTable dtCallDetails;
            int staffID = Session["Staff"] != null ? Convert.ToInt32(Session["Staff"]) : 0;
            using (DataSet dsCallDetails = objCalBAL.GetCallHistoryDetails(staffID))
            {
                gvCallHistory.DataSource = dsCallDetails;
                gvCallHistory.DataBind();
                dtCallDetails = dsCallDetails.Tables[0];
                ViewState["CallDetails"] = dtCallDetails;
            }
            return dtCallDetails;
        }

        protected void gvCallHistory_Sorting(object sender, GridViewSortEventArgs e)
        {
            Thread.Sleep(2000);
            if (ViewState["CallDetails"] != null)
            {
                DataTable dtCallDetails = (DataTable)ViewState["CallDetails"];
                SortGrid(e.SortExpression, dtCallDetails);
            }
            else
            {
                DataTable dtCallDetails = BindCallHistory();
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
            gvCallHistory.DataSource = dv;
            gvCallHistory.DataBind();
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

        protected void gvCallHistory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Thread.Sleep(2000);
            gvCallHistory.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (ViewState["CallDetails"] != null)
            {
                dt = (DataTable)ViewState["CallDetails"];//Filter the data in view state
            }
            else
            {
                dt = BindCallHistory();
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
            gvCallHistory.DataSource = dv;
            gvCallHistory.DataBind(); 
        }
    }
}