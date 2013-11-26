using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ManpowerManageWeb.DAS;

namespace ManpowerManageWeb
{
   
        public partial class Login : System.Web.UI.Page
        {
            // DataLogin objlogin = new DataLogin();
            DataTable dtuser = null;
            protected void Page_Load(object sender, EventArgs e)
            {
               // Session.Abandon();
            }

            //protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
            //{
            //    try
            //    {
            //        LoginLogics();
            //    }
            //    catch (Exception ex)
            //    {
            //        //Login1.FailureText = ex.Message.ToString();
            //    }
            //}

            public void LoginLogics()
            {
                try
                {
                    dtuser = DataLogin.GetLoginDetail();
                    if (dtuser.Rows.Count > 0)
                    {
                        DataRow[] drow = dtuser.Select("username='" + Convert.ToString(UserName.Text).Trim() + "' and userpassword = '" + Convert.ToString(Password.Text).Trim() + "' ");
                        if (drow.Count() > 0)
                        {
                            Session["UserName"] = UserName.Text;
                            Session["UserId"] = drow[0]["userid"];
                            if (drow[0]["usertype"].ToString() == "admin" || drow[0]["usertype"].ToString() == "superadmin")
                            {
                                Session["UserType"] = "admin";
                            }
                            else
                            {
                                Session["UserType"] = drow[0]["usertype"];
                            }
                            Response.Redirect("frmHomePage.aspx", false);
                        }
                        else
                        {
                            FailureText.Text = " Invalid Username or Password!";
                        }
                    }
                    else
                    {
                        FailureText.Text = " Invalid Username or Password!";
                    }
                }
                catch (Exception ex)
                {
                    FailureText.Text = ex.Message.ToString();
                }
            }


            protected void BtnLogin_Click(object sender, EventArgs e)
            {
                LoginLogics();
            }
        }
   
}