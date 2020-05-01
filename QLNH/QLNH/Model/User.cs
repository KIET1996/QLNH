using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    class User
    {
        private String userName;
        private String passWord;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public User(string userName, string passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }
    }
}
