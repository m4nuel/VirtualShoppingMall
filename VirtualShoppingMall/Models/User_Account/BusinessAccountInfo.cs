using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Models.User_Account
{
    public class BusinessAccountInfo
    {
        private String companyID;
        private String companyName;
        private String companyHomePageURL;

        private List<KeyValuePair<String, String>> listRecentActivity;

        public BusinessAccountInfo(String id, String companyName, String url)
        {
            this.companyID = id;
            this.companyName = companyName;
            this.companyHomePageURL = url;
            this.listRecentActivity = new List<KeyValuePair<string, string>>();
        }

        public String CompanyID
        {
            get
            {
                return this.companyID;
            }
            set
            {
                this.companyID = value;

            }
        }

        public String CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }


        public String CompanyHomePageURL
        {
            get
            {
                return this.companyHomePageURL;
            }
            set
            {
                this.companyHomePageURL = value;
            }
        }

        public List<KeyValuePair<String, String>> ListRecentActivity
        {
            get { return this.listRecentActivity; }
        }
    }
}
