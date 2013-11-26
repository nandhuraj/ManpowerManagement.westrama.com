using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.View;
using ManpowerManage.Model;

namespace ManpowerManage.Presenter
{
    public class ChangePasswordPresenter
    {
        private IChangePassword iChangePassword;
        private UserModel userModel;

        public ChangePasswordPresenter(IChangePassword view)
        {
            iChangePassword = view;
        }

        public int SaveNewPassword()
        {
            userModel = new UserModel();
            userModel.UpdateNewPassword(iChangePassword.UserId, iChangePassword.NewPassword);

            return 1;
        }
    }
}
