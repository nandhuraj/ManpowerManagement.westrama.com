using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.Data;

namespace ManpowerManage.Model
{
    public class StaffTypeModel
    {
        public DataSet Insert(string StaffTypeName, int flag, int IsActive)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StaffTypeID", 0);
            parameters.Add("@StaffTypeName", StaffTypeName);
            parameters.Add("@IsActive", IsActive);
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpStaffTypeInsert", parameters.ToArray());   
        }

        public DataSet Update(int StaffTypeId, string StaffTypeName, int flag, int IsActive)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StaffTypeID", StaffTypeId);
            parameters.Add("@StaffTypeName", StaffTypeName);
            parameters.Add("@IsActive", IsActive);
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpStaffTypeInsert", parameters.ToArray());   
        }

        public DataSet Select(int flag, int StaffTypeId, string StaffTypeName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StaffTypeID", StaffTypeId);
            parameters.Add("@StaffTypeName", StaffTypeName);            
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpStaffTypeSelect", parameters.ToArray());            
        }
    }
}
