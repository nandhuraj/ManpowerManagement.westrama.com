using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Utilities
{
    public class Singleton<T> where T : class
    {
        static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = (T)Activator.CreateInstance(typeof(T), true);
                }
                return instance;
            }
        }
    }
}
