using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    class UserController
    {
        private static UserController instance;

        public static UserController Instance
        {
            get { if (instance == null) instance = new UserController(); return UserController.instance; }
            private set { UserController.instance = value; }
        }
        // Create 1 contructor for Usercontroller
        private UserController() { }

        public bool Login(string userName, string passWord)
        {
            String Query = "QLNH_Login @usernname , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(Query, new object[] { userName, passWord });

            return result.Rows.Count > 0;

        }
    }
}
