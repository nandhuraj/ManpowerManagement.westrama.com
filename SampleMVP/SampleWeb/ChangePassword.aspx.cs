using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManpowerManage.View;
using ManpowerManage.Presenter;
//using SampleMVP.Utilities;

namespace ManpowerManageWeb
{
    public partial class ChangePassword : System.Web.UI.Page,IChangePassword
    {
        int userid = 1;// get the userid from session
        private ChangePasswordPresenter presenter;

        public int UserId
        {
            get { return userid; }
            set { userid = value; }
        }

        public string CurrentPassword
        {
            get { return txtConfirmNewPassword.Text; }
            set { txtConfirmNewPassword.Text = value; }
        }

        public string NewPassword
        {
            get { return txtNewPassword.Text; }
            set { txtNewPassword.Text = value; }
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Logging.LogMessage("UserId: 123" + " -- Page: changepassword.aspx");
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            presenter = new ChangePasswordPresenter(this);
            presenter.SaveNewPassword();

        }
    }
}