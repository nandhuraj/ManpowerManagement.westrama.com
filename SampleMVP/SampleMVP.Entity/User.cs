using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Entity
{
    public class User
    {
        public int UserId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}
