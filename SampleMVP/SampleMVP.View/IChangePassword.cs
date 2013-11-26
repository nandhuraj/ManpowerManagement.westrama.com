using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface IChangePassword
    {

       int UserId { set; get; }
       string CurrentPassword { set; get; }
       string NewPassword { set; get; }       

        /// you can also have methods to load or bind a control
        
    }
}
