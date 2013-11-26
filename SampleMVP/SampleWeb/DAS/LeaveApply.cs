using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ManpowerManageWeb;
using System.Data;
using System.Data.SqlClient;
using ManpowerManageWeb.DB;
using ManpowerManageWeb.Constant;

namespace ManpowerManageWeb.DAS
{
    public class LeaveApply
    {

        # region "DropDown Bind" 19-10-2013-Thiru
        public static LeaveApplyProperty ReturnLeaveTypeControl(LeaveApplyProperty ReturnDdlControl)
        {

            try
            {

                DataSet DataSetRecd = GetLeaveTypeMaster(ReturnDdlControl);

                if (DataSetRecd.Tables[0].Rows.Count > 0)
                {

                        StaticProperty.dTableDDLLvType = DataSetRecd.Tables[0]; //StaticProperty.CreateTableLeaveType();
                        DataRow rowFirstselect = StaticProperty.dTableDDLLvType.NewRow();
                        rowFirstselect["cLeaveTypeId"] = 0;
                        rowFirstselect["cLeaveType"] = "--Select--";
                        StaticProperty.dTableDDLLvType.Rows.InsertAt(rowFirstselect, 0);
                        ReturnDdlControl.dropDown.DataSource = StaticProperty.dTableDDLLvType;
                        ReturnDdlControl.dropDown.DataTextField = "cLeaveType";
                        ReturnDdlControl.dropDown.DataValueField = "cLeaveTypeId";
                        ReturnDdlControl.dropDown.DataBind();
                    
                }
                ReturnDdlControl.BindGrid = DataSetRecd.Tables[1];
                return ReturnDdlControl;
            }
            catch
            {
                return ReturnDdlControl;
            }

        }

        #endregion

        #region "SP Methods" 19-10-2013
        public static DataSet GetLeaveTypeMaster(LeaveApplyProperty listInput)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            //DataSet dataSet = new DataSet();
            try
            {
                connection = DatabaseConnection.GetConnection();
                command = new SqlCommand();
                string sqlQuery = "SP_LeaveApplyandType";

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sqlQuery;
                // Add Date Parameter            

                command.Parameters.Add("@staffRoleCode", SqlDbType.Text).Value =listInput.StaffRoleCode;     
                command.Parameters.Add("@LeavTypeId", SqlDbType.Text).Value = listInput.LvTypeId;     
                command.Parameters.Add("@FromDate", SqlDbType.Text).Value = listInput.fromDate;     
                command.Parameters.Add("@ToDate", SqlDbType.Text).Value = listInput.toDate;     
                command.Parameters.Add("@TotHours", SqlDbType.Int).Value = listInput.TotHrs;     
                command.Parameters.Add("@Reason", SqlDbType.Text).Value = listInput.Reason;   
                command.Parameters.Add("@ApprStatus",SqlDbType.Text).Value=listInput.ApprStatus;
                command.Parameters.Add("@ApprPersonId", SqlDbType.Text).Value = listInput.ApprPerid;     
                command.Parameters.Add("@LeaveReqDate", SqlDbType.Text).Value = listInput.LeaveReqDate;
                command.Parameters.Add("@LeaveResDate", SqlDbType.Text).Value = listInput.LeaveResDate;
                command.Parameters.Add("@FLAG", SqlDbType.TinyInt).Value = listInput.flagInsertOrLoad;
                command.Parameters.Add("@STAFF_FLAG", SqlDbType.Text).Value = listInput.StaffFlag;
                command.CommandTimeout = 3600;
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (DataSet busDetails = new DataSet())
                {
                    adapter.Fill(busDetails);
                    return busDetails;
                }
            }
            catch
            {
                return new DataSet();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
                if (command != null)
                    command.Dispose();
            }
        }
        #endregion




    }


    public class LeaveApplyProperty
    {

        public DropDownList dropDown { get; set; }
        public DataTable BindGrid { get; set; }
        public string StaffRoleCode { get; set; }
        public string LvTypeId { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string ApprStatus { get; set; }
        public int TotHrs { get; set; }
        public string Reason { get; set; }
        public string ApprPerid { get; set; }
        public string LeaveReqDate { get; set; }
        public string LeaveResDate { get; set; }
        public int flagInsertOrLoad { get; set; }
        public string StaffFlag { get; set; }
        



    }
}