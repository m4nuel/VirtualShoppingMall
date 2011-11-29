using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualShoppingMall.Views.Business_Account
{
    public partial class BusinessHomePage : UserControl
    {
        public CommonPageSelectionHandler commonPageSelectionEvent;

        public BusinessHomePage()
        {
            InitializeComponent();
            this.recentActivity1.commonPageSelectionEvent = this.commonPageSelectionHandler;
        }

        public void loadSession()
        {
            this.recentActivity1.loadSession();
        }

        private void raisePageSelectionEvent(KeyValuePair<String, String> selectedPage)
        {
            if (this.commonPageSelectionEvent != null)
            {
                this.commonPageSelectionEvent(selectedPage);
            }
        }

        private void commonPageSelectionHandler(KeyValuePair<String, String> selectedPage)
        {
            this.raisePageSelectionEvent(selectedPage);
        }

        public void addActivity(KeyValuePair<String, String> item)
        {
            this.recentActivity1.addActivity(item);
        }

        private void linkReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.REPORT_PAGE);
            this.recentActivity1.addActivity(PageKeyTitles.REPORT_PAGE);
        }

        private void linkStoreFrontManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.STORE_CREATOR_PAGE);
            this.recentActivity1.addActivity(PageKeyTitles.STORE_CREATOR_PAGE);
        }

        private void linkInventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.INVENTORY_PAGE);
            this.recentActivity1.addActivity(PageKeyTitles.INVENTORY_PAGE);
        }

        private void linkBuyAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.BUY_AD_PAGE);
            this.recentActivity1.addActivity(PageKeyTitles.BUY_AD_PAGE);
        }

        private void linkPaymentProc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.PAYMENT_PAGE);
            this.recentActivity1.addActivity(PageKeyTitles.PAYMENT_PAGE);
        }
    }

    public delegate void CommonPageSelectionHandler(KeyValuePair<String, String> selectedPage);
}
