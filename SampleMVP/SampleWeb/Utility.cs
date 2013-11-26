using System.Data;
using System.Web.UI.WebControls;

namespace ManpowerManageWeb
{
    public class Utility
    {
        public void LoadDropDropDown(DropDownList ddl,string textField,string valueField, DataTable dtSource)
        {
            ddl.DataSource = dtSource;
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }
    }
}