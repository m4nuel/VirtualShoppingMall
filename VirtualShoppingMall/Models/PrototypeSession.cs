using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Models
{
    class PrototypeSession
    {
        private static PrototypeSession instance;

        private PrototypeModel dataModel;
        private UserIDAssociation currentUser;

        private PrototypeSession()
        {
            this.dataModel = new PrototypeModel();
            this.currentUser = null;
        }

        public static PrototypeSession getInstance()
        {
            if (instance == null) instance = new PrototypeSession();
            return instance;
        }

        public PrototypeModel DataModel
        {
            get { return this.dataModel; }
        }

        /// <summary>
        /// attempts to load the current user with the provided user id
        /// </summary>
        /// <param name="userID">id of user to load</param>
        /// <returns>reference to the previous loaded user</returns>
        public UserIDAssociation loadUser(String userID)
        {
            UserIDAssociation oldUser = this.currentUser;
            UserIDAssociation user = this.dataModel.UserTable.Keys.Contains(userID) ?
                this.dataModel.UserTable[userID] : null;
            this.currentUser = user != null ? user : this.currentUser;
            return oldUser;
        }

        public Boolean checkUserPassword(String userID, String password)
        {
            UserIDAssociation user = this.dataModel.UserTable.Keys.Contains(userID) ?
                this.dataModel.UserTable[userID] : null;
            return (user != null) ? user.User.Password.Equals(password) : false;
        }

        public void addUser(UserIDAssociation user)
        {
            if (user != null)
            {
                this.dataModel.UserTable.Add(user.User.UserID, user);
            }
        }

        public UserIDAssociation CurrentUser
        {
            get { return this.currentUser; }
            set { this.currentUser = value; }
        }

        public bool isUserLoggedIn
        {
            get { return this.currentUser != null; }
        }

        public void loadTestData()
        {
            //create first test user
            User_Account.UserInfo user1 = new User_Account.UserInfo(
                "bugsbunny", "stinker", "Bugs", "", "Bunny", "");
            User_Account.BusinessAccountInfo bus1 = new User_Account.BusinessAccountInfo(
                "cartoon1", "Acme Solutions", "");
            this.addUser(new UserIDAssociation(user1, bus1));

            //create second test user
            User_Account.UserInfo user2 = new User_Account.UserInfo(
               "johndoe", "jd123", "John", "", "Doe", "");
            User_Account.BusinessAccountInfo bus2 = new User_Account.BusinessAccountInfo(
                "hunt12", "John's Hunting Apparrell", "");
            this.addUser(new UserIDAssociation(user2, bus2));

            //create third test user
            User_Account.UserInfo user3 = new User_Account.UserInfo(
               "janedoe", "ja87", "Jane", "", "Doe", "");
            User_Account.BusinessAccountInfo bus3 = new User_Account.BusinessAccountInfo(
                "rocker43", "Rockers of America", "");
            this.addUser(new UserIDAssociation(user3, bus3));
        }
    }
}
