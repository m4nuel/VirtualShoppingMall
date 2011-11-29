using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Models.User_Account
{
    public class UserInfo
    {
        private String userID;
        private String password;

        private String userFirstName;
        private String userMiddleName;
        private String userLastName;
        private String userSuffix;

        public UserInfo()
        {
            this.userID = "johnDoe@morgereality.com";
            this.password = "123abc";

            this.userFirstName = "John";
            this.userMiddleName = "Jacob";
            this.userLastName = "Doe";
            this.userSuffix = "";
        }

        public UserInfo(String id, String password, 
            String first, String middle, String last, String suffix)
        {
            this.userID = id;
            this.password = password;
            
            this.userFirstName = first;
            this.userMiddleName = middle;
            this.userLastName = last;
            this.userSuffix = suffix;
        }

        public String UserID
        {
            get
            {
                return this.userID;
            }
            set
            {
                this.userID = value;
            }
        }

        public String Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public String UserFirstName
        {
            get
            {
                return this.userFirstName;
            }
            set
            {
                this.userFirstName = value;
            }
        }

        public String UserMiddleName
        {
            get
            {
                return this.userMiddleName;
            }
            set
            {
                this.userMiddleName = value;
            }
        }

        public String UserLastName
        {
            get
            {
                return this.userLastName;
            }
            set
            {
                this.userLastName = value;
            }
        }

        public String UserSuffix
        {
            get
            {
                return this.userSuffix;
            }
            set
            {
                this.userSuffix = value;
            }
        }

        public String FullName
        {
            get
            {
                return this.userFirstName + " "
                    + this.userMiddleName + " "
                    + this.userLastName + " "
                    + this.userSuffix;
            }

        }
    }
}
