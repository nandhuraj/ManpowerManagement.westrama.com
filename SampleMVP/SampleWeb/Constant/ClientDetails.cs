using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;

namespace ManpowerManageWeb.Constant
{
    public class ClientDetails
    {
        public static DropDownList LoadDropDropDown(DropDownList ddl, string textField, string valueField, DataTable dtSource)
        {
            ddl.DataSource = dtSource;
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
            return ddl;
        }
    }
}