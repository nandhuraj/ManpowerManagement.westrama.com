using System;
using System.Data;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManageWeb.BAL;

namespace ManpowerManageWeb
{
    public partial class AddOrUpdateCallRegistry : System.Web.UI.Page
    {
        #region Declarations

        CallHistory_BAL objCalBAL = new CallHistory_BAL();
        Utility objUtility = new Utility();


        #endregion

        #region Protected Methods

        protected void ImgOk_Click(object sender, EventArgs e)
        {
            Response.Redirect("CallHistoryList.aspx");
        }

        protected void BtnOpportunity_Click(object sender, EventArgs e)
        {
            int CallID = SaveCallHistory();
            Thread.Sleep(2000);
            Response.Redirect("Opportunity.aspx?CallID=" + CallID + "");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            LblMessage.Focus();
            Thread.Sleep(2000);

            Response.Redirect("CallHistoryList.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ControlTR();

                BindDropdowns();

                if (Request.QueryString["CallID"] != null)
                {
                    if (Convert.ToString(Request.QueryString["Mode"]).Equals("Edit"))
                        LoadValues(Convert.ToInt32(Request.QueryString["CallID"]), 1);
                    else
                    {
                        LoadValues(Convert.ToInt32(Request.QueryString["CallID"]), 2);
                        BtnUpdate.Visible = BtnOpportunity.Visible = false;
                    }

                }
            }
        }

        /// <summary>
        /// Save button click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            int flag = SaveCallHistory();
            if (flag > 0)
            {
                Thread.Sleep(2000);
                LblMessage.Text = "Save successfully";
                MPEMessage.Show();
            }
        }

        /// <summary>
        /// Enabling the controls based on marketing status value.
        /// </summary>
        /// <param name="mcStatus"></param>
        private void ShowMarketingStatusFields(int mcStatus)
        {
            TrCandidate.Style.Add("display", "block");
            TrActivity.Style.Add("display", "block");
            TrSendProfile.Style.Add("display", "block");
            TrFEmail.Style.Add("display", "block");
            TrReminder.Style.Add("display", "block");
            BtnUpdate.Style.Add("display", "block");

            if (mcStatus.Equals(1))
            {
                TrCandidate.Style.Add("display", "none");
            }
            else if (mcStatus.Equals(2))
            {
                TrReminder.Style.Add("display", "none");
                BtnSave.Style.Add("display", "none");
                BtnUpdate.Style.Add("display", "none");
                BtnOpportunity.Style.Add("display", "block");
            }
            else if (mcStatus.Equals(3) || mcStatus.Equals(4) || mcStatus.Equals(0))
            {
                TrCandidate.Style.Add("display", "none");
                TrActivity.Style.Add("display", "none");
                TrSendProfile.Style.Add("display", "none");
                TrFEmail.Style.Add("display", "none");
                TrReminder.Style.Add("display", "none");
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Bind all dropdown values from dataset
        /// </summary>
        private void BindDropdowns()
        {
            using (DataSet dsDD = objCalBAL.GetCADropdownValues())
            {
                if (dsDD.Tables.Count > 0)
                {
                    objUtility.LoadDropDropDown(DdlIndustry, "Title", "IndID", dsDD.Tables[0]);
                    objUtility.LoadDropDropDown(DdlMarketingCategory, "Title", "MCID", dsDD.Tables[1]);
                    objUtility.LoadDropDropDown(DdlMarketingStatus, "Title", "MSID", dsDD.Tables[2]);

                    ListItem item = new ListItem();
                    item.Text = "--";
                    item.Value = "0";
                    DdlMarketingStatus.Items.Insert(0, item);
                    DdlIndustry.Items.Insert(0, item);
                    DdlMarketingCategory.Items.Insert(0, item);
                }
            }
        }

        /// <summary>
        /// Hide / unhide controls based business logic
        /// </summary>
        private void ControlTR()
        {
            BtnOpportunity.Style.Add("display", "none");
            TrCandidate.Style.Add("display", "none");
            TrActivity.Style.Add("display", "none");
            TrSendProfile.Style.Add("display", "none");
            TrFEmail.Style.Add("display", "none");
            TrReminder.Style.Add("display", "none");
            BtnUpdate.Style.Add("display", "none");
            BtnSave.Style.Add("display", "block");

            //if (Session["Staff"] == null)          
            //    ImgAdd.Visible = false;

        }

        private int SaveCallHistory()
        {
            CallRegistry objReg = AssignValues();

            int success = objCalBAL.AddOrUpdateCallRegistry(objReg);
            ClearValues();
            return success;
        }

        /// <summary>
        /// Updating call details and refreshing the grid values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            int flag = SaveCallHistory();
            if (flag > 0)
            {
                Thread.Sleep(2000);
                LblMessage.Text = "updated successfully";
                MPEMessage.Show();
            }
        }

        /// <summary>
        /// Assign the input values to property
        /// </summary>
        /// <returns></returns>
        private CallRegistry AssignValues()
        {
            CallRegistry objReg = new CallRegistry();
            objReg.CallID = Convert.ToInt32(HdnCallID.Value);
            int zone = DdlTimeZone.SelectedIndex.Equals(0) ? 0 : 12;
            if (DdlTimeZone.SelectedIndex > 0 && DdlHour.Text.Equals("12"))
                zone = 0;

            objReg.CallDateTime = Convert.ToDateTime(TxtCallDate.Text.Trim() + " " + (Convert.ToInt32(DdlHour.Text) + zone) + ":" + DdlMinute.Text.Trim() + ":00.000");
            objReg.Industry = DdlIndustry.SelectedIndex > 0 ? Convert.ToInt32(DdlIndustry.SelectedValue.Trim()) : 0;
            objReg.CompanyName = Convert.ToString(TxtCompanyName.Text.Trim());
            objReg.Phone = Convert.ToString(TxtPhone.Text.Trim());
            objReg.AlternatePhone = Convert.ToString(TxtAlternatePhone.Text.Trim());
            objReg.Email = Convert.ToString(TxtEmail.Text.Trim());
            objReg.Reference = DdlReference.SelectedIndex > 0 ? Convert.ToInt32(DdlReference.SelectedValue.Trim()) : 0;
            objReg.MarketingCategory = DdlMarketingCategory.SelectedIndex > 0 ? Convert.ToInt32(DdlMarketingCategory.SelectedValue.Trim()) : 0;
            objReg.MarketingStatus = DdlMarketingStatus.SelectedIndex > 0 ? Convert.ToInt32(DdlMarketingStatus.SelectedValue.Trim()) : 0;
            objReg.Reminder = TxtReminder.Text != string.Empty ? (TxtReminder.Text.Trim()) : string.Empty;
            objReg.Activity = Convert.ToString(TxtActivity.Text.Trim());
            objReg.FEmail = Convert.ToString(TxtFEmail.Text.Trim());
            objReg.SendProfile = ChkSendProfile.Checked ? 1 : 0;
            objReg.NoOfCandidate = TxtNoOfCandidates.Text != string.Empty ? Convert.ToInt32(TxtNoOfCandidates.Text.Trim()) : 0;
            objReg.Opportunity = DdlMarketingStatus.SelectedValue.Equals("2") ? 1 : 0;
            objReg.StaffID = Session["Staff"] != null ? Convert.ToInt32(Session["Staff"]) : 0;

            return objReg;
        }

        /// <summary>
        /// Get the values from database and load into input controls. Used on edit/view action in call details grid
        /// </summary>
        /// <param name="callID"></param>
        /// <param name="flag"></param>
        private void LoadValues(int callID, int flag)
        {
            //Flag = 1-->Edit, Flag = 2 --> View
            string txtVisibility = "";
            string lblVisibility = "";
            DateTime callDateTime;
            using (DataTable dtCallDetails = objCalBAL.GetSpecificCallDetail(callID))
            {
                if (dtCallDetails != null)
                {
                    if (dtCallDetails.Rows.Count > 0)
                    {
                        if (flag.Equals(1))
                        {
                            callDateTime = Convert.ToDateTime(dtCallDetails.Rows[0]["CallTime"]);
                            HdnCallID.Value = Convert.ToString(dtCallDetails.Rows[0]["CallID"]);
                            TxtCallDate.Text = callDateTime.ToShortDateString();
                            DdlHour.SelectedValue = callDateTime.Hour > 12 ? (callDateTime.Hour - 12).ToString() : callDateTime.Hour.ToString();
                            DdlTimeZone.SelectedIndex = callDateTime.Hour > 12 ? 1 : 0;
                            DdlMinute.SelectedValue = callDateTime.Minute.ToString();
                            DdlIndustry.SelectedValue = Convert.ToString(dtCallDetails.Rows[0]["IndustryVal"]);
                            TxtCompanyName.Text = Convert.ToString(dtCallDetails.Rows[0]["CompanyName"]);
                            TxtPhone.Text = Convert.ToString(dtCallDetails.Rows[0]["Phone"]);
                            TxtAlternatePhone.Text = Convert.ToString(dtCallDetails.Rows[0]["AlternatePhone"]);
                            TxtEmail.Text = Convert.ToString(dtCallDetails.Rows[0]["Email"]);
                            DdlReference.SelectedValue = Convert.ToString(dtCallDetails.Rows[0]["Reference"]);
                            DdlMarketingCategory.SelectedValue = Convert.ToString(dtCallDetails.Rows[0]["MarketingCategoryVal"]);
                            DdlMarketingStatus.SelectedValue = Convert.ToString(dtCallDetails.Rows[0]["MarketingStatusVal"]);
                            TxtReminder.Text = Convert.ToString(dtCallDetails.Rows[0]["Reminder"]) != string.Empty ? Convert.ToDateTime(Convert.ToString(dtCallDetails.Rows[0]["Reminder"])).ToShortDateString() : string.Empty;
                            TxtActivity.Text = Convert.ToString(dtCallDetails.Rows[0]["Activity"]);
                            ChkSendProfile.Checked = Convert.ToBoolean(dtCallDetails.Rows[0]["SendProfile"]);
                            TxtNoOfCandidates.Text = Convert.ToString(dtCallDetails.Rows[0]["NoOfCandidates"]);
                            TxtFEmail.Text = Convert.ToString(dtCallDetails.Rows[0]["FollowupEmail"]);
                            txtVisibility = "block"; lblVisibility = "none";
                            BtnUpdate.Style.Add("display", txtVisibility); BtnSave.Style.Add("display", lblVisibility);
                        }
                        else
                        {
                            LblCallDate.Text = Convert.ToString(dtCallDetails.Rows[0]["CallTime"]);
                            LblIndustry.Text = Convert.ToString(dtCallDetails.Rows[0]["Industry"]);
                            LblCompanyName.Text = Convert.ToString(dtCallDetails.Rows[0]["CompanyName"]);
                            LblPhone.Text = Convert.ToString(dtCallDetails.Rows[0]["Phone"]);
                            LblAlternatePhone.Text = Convert.ToString(dtCallDetails.Rows[0]["AlternatePhone"]);
                            LblEmail.Text = Convert.ToString(dtCallDetails.Rows[0]["Email"]);
                            LblReference.Text = Convert.ToString(dtCallDetails.Rows[0]["Reference"]);
                            LblMarketingCategory.Text = Convert.ToString(dtCallDetails.Rows[0]["MarketingCategory"]);
                            LblMarketingStatus.Text = Convert.ToString(dtCallDetails.Rows[0]["MarketingStatus"]);
                            LblReminder.Text = Convert.ToString(dtCallDetails.Rows[0]["Reminder"]) != string.Empty ? Convert.ToDateTime(Convert.ToString(dtCallDetails.Rows[0]["Reminder"])).ToShortDateString() : string.Empty;
                            LblActivity.Text = Convert.ToString(dtCallDetails.Rows[0]["Activity"]);
                            LblSendProfile.Text = Convert.ToBoolean(dtCallDetails.Rows[0]["SendProfile"]) ? "Yes" : "No";
                            LblNoOfCandidates.Text = Convert.ToString(dtCallDetails.Rows[0]["NoOfCandidates"]);
                            LblFEmail.Text = Convert.ToString(dtCallDetails.Rows[0]["FollowupEmail"]);
                            txtVisibility = "none"; lblVisibility = "block";
                            BtnUpdate.Style.Add("display", txtVisibility); BtnSave.Style.Add("display", txtVisibility);
                        }

                        LblCallDate.Style.Add("display", lblVisibility); LblIndustry.Style.Add("display", lblVisibility); LblCompanyName.Style.Add("display", lblVisibility); LblPhone.Style.Add("display", lblVisibility); LblAlternatePhone.Style.Add("display", lblVisibility);
                        LblEmail.Style.Add("display", lblVisibility); LblReference.Style.Add("display", lblVisibility); LblMarketingCategory.Style.Add("display", lblVisibility); LblMarketingStatus.Style.Add("display", lblVisibility); LblReminder.Style.Add("display", lblVisibility);
                        LblActivity.Style.Add("display", lblVisibility); LblSendProfile.Style.Add("display", lblVisibility); LblNoOfCandidates.Style.Add("display", lblVisibility); LblFEmail.Style.Add("display", lblVisibility);

                        TxtCallDate.Style.Add("display", txtVisibility); DdlHour.Style.Add("display", txtVisibility); DdlMinute.Style.Add("display", txtVisibility); DdlTimeZone.Style.Add("display", txtVisibility); DdlIndustry.Style.Add("display", txtVisibility); TxtCompanyName.Style.Add("display", txtVisibility); TxtPhone.Style.Add("display", txtVisibility); TxtAlternatePhone.Style.Add("display", txtVisibility);
                        TxtEmail.Style.Add("display", txtVisibility); DdlReference.Style.Add("display", txtVisibility); DdlMarketingCategory.Style.Add("display", txtVisibility); DdlMarketingStatus.Style.Add("display", txtVisibility); TxtReminder.Style.Add("display", txtVisibility);
                        TxtActivity.Style.Add("display", txtVisibility); ChkSendProfile.Style.Add("display", txtVisibility); TxtNoOfCandidates.Style.Add("display", txtVisibility); TxtFEmail.Style.Add("display", txtVisibility); ;

                        ShowMarketingStatusFields(Convert.ToInt32(dtCallDetails.Rows[0]["MarketingStatusVal"]));
                        //MPEAddCall.Show();
                    }

                }
            }
        }

        /// <summary>
        /// Clear all input values once saved into database. Used this method for insert and update call details
        /// </summary>
        private void ClearValues()
        {
            TxtCallDate.Text = TxtCompanyName.Text = TxtPhone.Text = TxtAlternatePhone.Text =
            TxtEmail.Text = TxtReminder.Text =
            TxtActivity.Text = TxtNoOfCandidates.Text = TxtFEmail.Text = string.Empty;

            DdlReference.SelectedIndex = DdlMarketingCategory.SelectedIndex = DdlMarketingStatus.SelectedIndex = DdlIndustry.SelectedIndex = 0;

        }

        #endregion
       
    }
}