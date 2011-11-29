using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Models
{
    class PrototypeModel
    {
        //Key: userID
        //Value: UserIDAssociation
        private Dictionary<String, UserIDAssociation> userTable;
        
        public PrototypeModel()
        {
            this.userTable = new Dictionary<string, UserIDAssociation>();
        }

        public Dictionary<String, UserIDAssociation> UserTable
        {
            get { return this.userTable; }
        }
    }

    class UserIDAssociation
    {
        private User_Account.UserInfo user;
        private User_Account.BusinessAccountInfo business;
        private User_Account.ShopperAccountInfo shopper;

        public UserIDAssociation(User_Account.UserInfo user = null, 
            User_Account.BusinessAccountInfo business = null,
            User_Account.ShopperAccountInfo shopper = null)
        {
            this.user = user != null ? user : new User_Account.UserInfo();
            this.business = business;
            this.shopper = shopper;
        }

        public User_Account.UserInfo User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }

        public User_Account.BusinessAccountInfo Business
        {
            get
            {
                return this.business;
            }
            set
            {
                this.business = value;
            }
        }

        public User_Account.ShopperAccountInfo Shopper
        {
            get
            {
                return this.shopper;
            }
            set
            {
                this.shopper = value;
            }
        }
    }
}
