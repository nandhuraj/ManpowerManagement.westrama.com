using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.Data;

namespace ManpowerManage.Model
{
    public class UserModel
    {
        // model was split to entity(sampleMVP.entity), business or data access layer (current class)

        private string spUpdateNewPassword = "spUpdateNewPassword";
        private string spAddNewUser = "spAddNewUser";
        private string spDeleteUser = "spDeleteUser";

        // business logic
        public bool DoSomeLogic(string text)
        {
            /// it is not necessary that you have to write a function that talks with database
            /// we can include any business logic in the model

            return true;
        }

        // data access layer
        public int UpdateNewPassword(int userId, string newPassword)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@userid", userId);
            parameters.Add("@password", newPassword);

            return Convert.ToInt32(DataLayer.Instance.ExecuteScalarSP(spUpdateNewPassword, parameters.ToArray()));
        }


    }
}
