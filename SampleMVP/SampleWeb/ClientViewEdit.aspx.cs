using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManage.View;
using ManpowerManage.Presenter;
using ManpowerManage.Entity;
using System.Data;
using System.Drawing;

namespace ManpowerManageWeb
{
    public partial class ClientViewEdit : System.Web.UI.Page
    {
        ClientPresenter clientPresenter;
        ClientViewClass clientViewCls;
        private string GridPage = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblresult.Text = "";
            if (Session["UserId"] == null && Session["UserName"] == null && Session["UserType"] == null)
                Response.Redirect("Login.aspx");

            GridPage = Request.QueryString["GridPage"];
            if (!IsPostBack)
            {
                if (GridPage.ToLower() == "first")
                {
                    BindGridFirstTime();
                }
                else if (GridPage.ToLower() == "second")
                {
                   // BindGridFirstTime();
                    gvdClientDetails.DataSource = ClientViewClass.dsGridClient.Tables[0];
                    gvdClientDetails.DataBind();
                }
            }

        }

        private void BindGridFirstTime()
        {
            ClientViewClass.CompanyId = 0;
            ClientViewClass.CompanyName = "";
            ClientViewClass.AdminOrStaff = Convert.ToString(Session["UserType"]).ToLower();
            ClientViewClass.SELECT = "GRID";
            ClientViewClass.StaffId = Convert.ToInt32(Session["UserId"]);
            clientPresenter = new ClientPresenter(ClientViewClass.CompanyId, ClientViewClass.CompanyName, ClientViewClass.AdminOrStaff, ClientViewClass.SELECT, ClientViewClass.StaffId);
            DataSet dtGetDetails = clientPresenter.GetClientDetails();
            gvdClientDetails.DataSource = dtGetDetails.Tables[0];
            gvdClientDetails.DataBind();
        }


        protected void imgEdit_Click(object sender, ImageClickEventArgs e)
        {

            ImageButton btn = (ImageButton)sender;

            GridViewRow grdrow = (GridViewRow)btn.NamingContainer;
            ClientViewClass.SELECT = "GRID";
            ClientViewClass.CompanyId = Convert.ToInt32(gvdClientDetails.DataKeys[grdrow.RowIndex].Value.ToString());
            Response.Redirect("ClientEntry.aspx?PageType=Update");

        }

        //private void Bind Method
        protected void imgSearch_Click(object sender, ImageClickEventArgs e)
        {

            clientPresenter = new ClientPresenter(0, txtSearch.Text, Convert.ToString(Session["UserType"]).ToLower(), "GRID", Convert.ToInt32(Session["UserId"]));
            DataSet dtGetDetails = clientPresenter.GetClientDetails();
            if (dtGetDetails.Tables[0].Rows.Count > 0)
            {
                gvdClientDetails.DataSource = dtGetDetails.Tables[0];
                gvdClientDetails.DataBind();
            }
            else
            {
                lblresult.Text = "No Search Records";
                lblresult.ForeColor = Color.Red;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCompanyNames(string prefixText)
        {
            List<string> CompanyNames = new List<string>();
            ClientPresenter clientPresenter = new ClientPresenter(0, "", "", "", 0);
            DataSet dtGetDetails = clientPresenter.GetClientNameDetails();
            for (int i = 0; i < dtGetDetails.Tables[0].Rows.Count;i++)
            {
                CompanyNames.Add(dtGetDetails.Tables[0].Rows[i]["CompanyName"].ToString());
            }         
            return CompanyNames;

        }

        
    }
   
       

   
}