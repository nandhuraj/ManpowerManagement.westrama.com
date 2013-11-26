using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManage.Presenter;
using System.Data;

namespace ManpowerManageWeb
{
    public partial class LeaveSummaryPage : System.Web.UI.Page
    {
        private LeaveSummaryPresenter leaveSummaryPresenter;

        protected void Page_Load(object sender, EventArgs e)
        {
              if (Session["UserId"] == null && Session["UserName"] == null && Session["UserType"] == null)
                    Response.Redirect("Login.aspx");

              lblResult.Text = "";
              lblResult.Visible = false;
            if (!IsPostBack)
            {
               
                leaveSummaryPresenter=new LeaveSummaryPresenter(Convert.ToInt32(Session["UserId"]));
                DataSet dsGetGrid=leaveSummaryPresenter.GetLeaveSummary();
                if (dsGetGrid.Tables.Count > 0)
                {
                    gvLeaveSummary.DataSource = dsGetGrid.Tables[0];
                    gvLeaveSummary.DataBind();
                }
                else
                {
                }
            }
        }
    }
}