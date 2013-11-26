using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.Model;
using ManpowerManage.View;

namespace ManpowerManage.Presenter
{
    public class StaffTypePresenter
    {
        private  IStaffType iStaffTypeEntry;
        private StaffTypeModel StaffTypeModel;

        public StaffTypePresenter(IStaffType StaffTypeview)
        {
            iStaffTypeEntry = StaffTypeview;
        }

        public DataSet Insert()
        {
            using (DataSet ds = new DataSet())
            {
                StaffTypeModel = new StaffTypeModel();
                return StaffTypeModel.Insert(iStaffTypeEntry.StaffType, iStaffTypeEntry.Flag, iStaffTypeEntry.IsActive);
            }            
        }

        public DataSet Update()
        {
            using (DataSet ds = new DataSet())
            {
                StaffTypeModel = new StaffTypeModel();
                return StaffTypeModel.Update(iStaffTypeEntry.StaffTypeID, iStaffTypeEntry.StaffType, iStaffTypeEntry.Flag,iStaffTypeEntry.IsActive);
            }
        }

        public DataSet Select()
        {
            using (DataSet ds = new DataSet())
            {
                DataSet ds1 = new DataSet();
                StaffTypeModel = new StaffTypeModel();
                ds1 = StaffTypeModel.Select(iStaffTypeEntry.Flag, iStaffTypeEntry.StaffTypeID, iStaffTypeEntry.StaffType);
                return ds1;
            }
        }
    }
}
