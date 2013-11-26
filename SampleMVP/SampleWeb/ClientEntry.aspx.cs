using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using ManpowerManage.View;
using ManpowerManage.Presenter;
using ManpowerManage.Entity;
using ManpowerManageWeb.Constant;
using System.Data;

namespace ManpowerManageWeb
{
    public partial class ClientEntry : System.Web.UI.Page,IClient
    {
        private int CompId = 0;
        private int createdBy = 0;
        private int modifiedBy = 0;
        private DateTime creationTime = DateTime.Now;
        private DateTime modifiedTime = DateTime.Now;
        private int isActive = 1;
        private string flagQuery = string.Empty;
        private string CompName = string.Empty;
        private string PageType = string.Empty;
        private string uSrTypes=string.Empty;
        // For dropdown assign and pass to interface , avoid null
        //private int DdlUserId = 0;
        //private int DdlCompSizeId = 0;
        //private int DdlCustTypeId = 0;
        //private int DdlCompSrceId = 0;
        //private int DdlIndusTypeId = 0;
        //private int DdlSuppId = 0;
        //private int DdlCntyId = 0;
        

        private ClientPresenter presenter;

        # region " Members value assigning with Properties Client Presenter
        public int CompanyID
        {
            get { return CompId; }
            set { CompId = value; }
        }

        public string CompanyName
        {
            get { return txtCompName.Text; }
            set { txtCompName.Text = value; }
        }

        public int UserTypeID
        {
            get { return Convert.ToInt32(ddlUserType.SelectedValue); }
            set { ddlUserType.SelectedValue = Convert.ToString(value); }
        }
        public string GroupName
        {
            get { return txtGrpName.Text; }
            set { txtGrpName.Text = value; }
        }

        public string Website
        {
            get { return txtWebSite.Text; }
            set { txtWebSite.Text = value; }
        }

        public string PrimaryPhone
        {
            get { return txtPrmryPhone.Text; }
            set { txtPrmryPhone.Text = value; }
        }
        public string SecondaryPhone
        {
            get { return txtSecPhone.Text; }
            set { txtSecPhone.Text = value; }
        }
        public string Fax
         {
             get { return txtFax.Text; }
             set { txtFax.Text = value; }
         }
        public string Address
         {
             get { return txtAddress.Text; }
             set { txtAddress.Text = value; }
         }
        public string Address2
         {
             get { return txtAddress.Text; }
             set { txtAddress.Text = value; }
         }
        public string City
         {
             get { return txtCity.Text; }
             set { txtCity.Text = value; }
         }
        public string State
         {
             get { return txtState.Text; }
             set { txtState.Text = value; }
         }
        public string Zip
         {
             get { return txtZipCode.Text; }
             set { txtZipCode.Text = value; }
         }
        public int CountryID
         {
             get { return Convert.ToInt32(ddlCountry.SelectedValue); }
             set { ddlCountry.SelectedValue = Convert.ToString(value); }
         }
        public int CustomerTypeID
        {
            get { return Convert.ToInt32(ddlCustType.SelectedValue); }
            set { ddlCustType.SelectedValue =Convert.ToString(value); }
        }
        public int SupplierTypeID
        {
            get { return Convert.ToInt32(ddlSupplyType.SelectedValue); }
            set { ddlSupplyType.SelectedValue =Convert.ToString(value); }
        }
        public int CompanySizeID
        {
            get { return Convert.ToInt32(ddlCompSize.SelectedValue); }
            set { ddlCompSize.SelectedValue =Convert.ToString(value); }
        }
        public int CompanySourceID
        {
            get { return Convert.ToInt32(ddlCompSource.SelectedValue); }
            set { ddlCompSource.SelectedValue =Convert.ToString(value); }
        }
        public string PrimaryContactPerson
        {
            get { return txtPrmyContPerson.Text; }
            set { txtPrmyContPerson.Text = value; }
        }
        public string OfficialEmailID
        {
            get { return txtOfficeEmail.Text; }
            set { txtOfficeEmail.Text = value; }
        }
        public int IndustryTypeID
        {
            get { return Convert.ToInt32(ddlIndustType.SelectedValue); }
            set { ddlIndustType.SelectedValue =Convert.ToString(value); }
        }
        public int CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }
        public int ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public DateTime ModifiedTime
        {
            get { return modifiedTime; }
            set { modifiedTime = value; }
        }

        public int IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string Remarks
        {
            get { return txtRemarks.Text; }
            set { txtRemarks.Text = value; }
        }

        public string FLAG
        {
            get { return flagQuery; }
            set { flagQuery = value; }
        }
        public string COMPNAME
        {
            get { return CompName; }
            set { CompName = value; }
        }

        public string Usertypes
        {
            get { return uSrTypes; }
            set { uSrTypes = value; }
        }

      #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            lblErrorOrResult.Text = "";           
            if (Session["UserId"] == null && Session["UserName"] == null && Session["UserType"] == null)
                Response.Redirect("Login.aspx");

            createdBy = Convert.ToInt32(Session["UserId"]);
            modifiedBy = Convert.ToInt32(Session["UserId"]);
            uSrTypes=Convert.ToString(Session["UserType"]).ToString().Trim().ToLower();
            PageType = Request.QueryString["PageType"];

            lblOpprCode.Visible = false;
            lblOpprId.Visible = false;
            if (!IsPostBack)
            {
                if (PageType.ToLower() == "add")
                {
                    lblOpprCode.Visible = false;
                    lblOpprId.Visible = false;                   
                    flagQuery = "DROPDOWN";
                    CompId = 0;
                    COMPNAME = string.Empty;
                    presenter = new ClientPresenter(CompId, CompName, Convert.ToString(Session["UserType"]).ToLower().Trim(), flagQuery, createdBy);
                    BindDropDown(presenter.GetClientDetails());
                }
                else if (PageType.ToLower() == "update")
                {
                    lblOpprCode.Visible = true;
                    lblOpprId.Visible = true;                    
                    presenter = new ClientPresenter(ClientViewClass.CompanyId, "", Convert.ToString(Session["UserType"]).ToLower().Trim(), ClientViewClass.SELECT, createdBy);
                    BindDropDown(presenter.GetClientDetails());
                }
            }
            
            

        }
        // Bind the DropDown list
        private void BindDropDown(DataSet dsDD)
        {
           ListItem item = new ListItem();
           item.Text = "--";
           item.Value = "0";
           if (dsDD.Tables.Count > 0) // Check All the DropDown data in Dataset
           {
               ddlCompSize = ClientDetails.LoadDropDropDown(ddlCompSize, "Size", "CompanySizeID", dsDD.Tables[0]);
               ddlCompSize.Items.Insert(0, item);

               ddlCompSource = ClientDetails.LoadDropDropDown(ddlCompSource, "CompanySource", "CompanySourceID", dsDD.Tables[1]);
               ddlCompSource.Items.Insert(0, item);

               ddlCountry = ClientDetails.LoadDropDropDown(ddlCountry, "CountryName", "CountryID", dsDD.Tables[2]);
               ddlCountry.Items.Insert(0, item);

               ddlCustType = ClientDetails.LoadDropDropDown(ddlCustType, "CustomerTypeDesc", "CustomerTypeID", dsDD.Tables[3]);
               ddlCustType.Items.Insert(0, item);

               ddlIndustType = ClientDetails.LoadDropDropDown(ddlIndustType, "IndustryType", "IndustryTypeID", dsDD.Tables[4]);
               ddlIndustType.Items.Insert(0, item);

               ddlSupplyType = ClientDetails.LoadDropDropDown(ddlSupplyType, "SupplierType", "SupplierTypeID", dsDD.Tables[5]);
               ddlSupplyType.Items.Insert(0, item);

               ddlUserType = ClientDetails.LoadDropDropDown(ddlUserType, "UserType", "UserTypeID", dsDD.Tables[6]);
               ddlUserType.Items.Insert(0, item);

               if (PageType.ToLower() == "update" )
               {
                   txtCompName.Text =   Convert.ToString(dsDD.Tables[7].Rows[0]["CompanyName"]);
                   ddlUserType.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["UserTypeId"]);
                   txtWebSite.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["Website"]);
                   txtGrpName.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["GroupName"]);
                   txtSecPhone.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["SecondaryPhone"]);
                   txtPrmryPhone.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["PrimaryPhone"]);
                   txtFax.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["Fax"]);
                   txtAddress.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["Address1"]);
                   txtCity.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["City"]);
                   txtState.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["StateVal"]);
                   ddlCountry.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["CountryID"]);
                   txtZipCode.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["Zip"]);
                   ddlCustType.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["CustomerTypeID"]);
                   ddlCompSize.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["CompanySizeID"]);
                   ddlCompSource.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["CompanySourceID"]);
                   ddlIndustType.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["IndustryTypeID"]);
                   ddlSupplyType.SelectedValue = Convert.ToString(dsDD.Tables[7].Rows[0]["SupplierTypeID"]);
                   txtPrmyContPerson.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["PrimaryContactPerson"]);
                   txtOfficeEmail.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["OfficialEmailID"]);
                   txtRemarks.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["Remarks"]);
                   lblOpprCode.Text = Convert.ToString(dsDD.Tables[7].Rows[0]["OppotunityId"]);
               }
            
           }
        }

        private void ClearFields()
        {
            txtCompName.Text = "";
            ddlUserType.SelectedValue = "0";
            txtWebSite.Text = "";
            txtGrpName.Text = "";
            txtSecPhone.Text = "";
            txtPrmryPhone.Text = "";
            txtFax.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            ddlCountry.SelectedValue ="0";
            txtZipCode.Text = "";
            ddlCustType.SelectedValue = "0";
            ddlCompSize.SelectedValue = "0";
            ddlCompSource.SelectedValue = "0";
            ddlIndustType.SelectedValue = "0";
            ddlSupplyType.SelectedValue = "0";
            txtPrmyContPerson.Text = "";
            txtOfficeEmail.Text = "";
            txtRemarks.Text = "";
            lblOpprCode.Text = "";
        }

       

        // Create Or Update Client function 
        protected void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            int Result = 0;
            if (ValidateRequireField())
            {
                if (PageType.ToLower() == "add")
                {
                    
                    try
                    {
                        presenter = new ClientPresenter(this);
                        Result = presenter.SaveNewClient();
                        if (Result !=0)
                        {
                            lblErrorOrResult.Text = "Sucessfully Created";
                            lblErrorOrResult.ForeColor = Color.Green;
                            ClearFields();
                        }
                        else
                        {
                            lblErrorOrResult.Text = "Not Saved";
                            lblErrorOrResult.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblErrorOrResult.Text = ex.Message.ToString();
                        lblErrorOrResult.ForeColor = Color.Red;

                    }
                }
                else if (PageType.ToLower() == "update")
                {
                    CompId = ClientViewClass.CompanyId;
                    
                    presenter = new ClientPresenter(this);
                    ClientViewClass.dsGridClient = presenter.UpdateClient();                   
                    if (ClientViewClass.dsGridClient.Tables.Count>0)
                    {
                    
                        lblErrorOrResult.Text = "Sucessfully Saved";
                        lblErrorOrResult.ForeColor = Color.Green;                    
                        Response.Redirect("ClientViewEdit.aspx?GridPage=Second");
                    }
                    else
                    {
                        lblErrorOrResult.Text = "Not Saved";
                        lblErrorOrResult.ForeColor = Color.Red;
                    }
                    
                }
            }
            else
            {
                lblErrorOrResult.Text = "* Fill Required Fields";
                lblErrorOrResult.ForeColor = Color.Red;
            }
                
        }
       
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //this.ModalPopupExtender1.Hide();
            lblErrorOrResult.Text = "";
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {

            //presenter = new ClientPresenter(this);
           // this.ModalPopupExtender1.Show();
        }
        

       

        // Validation Check for the Required field in place
        private bool ValidateRequireField()
        {
            if (string.IsNullOrEmpty(txtCompName.Text) || ddlUserType.SelectedIndex == 0 || ddlCountry.SelectedIndex == 0 || ddlCustType.SelectedIndex == 0 || ddlCompSource.SelectedIndex == 0 ||
                     ddlCompSize.SelectedIndex == 0 || ddlIndustType.SelectedIndex == 0 || ddlSupplyType.SelectedIndex == 0)

                return false;
            else
                return true;
        }
    }
}