using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirtualShoppingMall.Models;
using VirtualShoppingMall.Models.User_Account;

namespace VirtualShoppingMall.Views.Business_Account
{
    public partial class BusinessHomeController : UserControl
    {
        public delegate void LogoutUser();
        public LogoutUser logoutUserHandler;

        private static readonly KeyValuePair<String, String> EMPTY_PAGE = new KeyValuePair<string, string>(null, null);

        private KeyValuePair<String, String> currentPageKeyTitle;

        private BusinessStartPage startPage;
        private BusinessHomePage homePage;
        private BusinessReportsPage reportPage;
        private BusinessStoreFrontCreatorPage storeFrontCreatorPage;
        private BusinessInventoryPage inventoryPage;
        private BusinessBuyAddPage buyAddPage;
        private BusinessPaymentPage paymentPage;

        public BusinessHomeController()
        {
            InitializeComponent();

            this.currentPageKeyTitle = EMPTY_PAGE;

            this.startPage = new BusinessStartPage();
            this.homePage = new BusinessHomePage();
            this.reportPage = new BusinessReportsPage();
            this.storeFrontCreatorPage = new BusinessStoreFrontCreatorPage();
            this.inventoryPage = new BusinessInventoryPage();
            this.buyAddPage = new BusinessBuyAddPage();
            this.paymentPage = new BusinessPaymentPage();

            this.startPage.commonPageSelectionEvent = this.commonPageSelectionHandler;
            this.homePage.commonPageSelectionEvent = this.commonPageSelectionHandler;

            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.START_PAGE.Key, this.startPage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.HOME_PAGE.Key, this.homePage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.REPORT_PAGE.Key, this.reportPage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.STORE_CREATOR_PAGE.Key, this.storeFrontCreatorPage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.INVENTORY_PAGE.Key, this.inventoryPage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.BUY_AD_PAGE.Key, this.buyAddPage);
            this.panelSwapper1.PanelCollection.Add(
                PageKeyTitles.PAYMENT_PAGE.Key, this.paymentPage);

            this.panelSwapper1.setActivePanel(PageKeyTitles.HOME_PAGE.Key);
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.logoutUserHandler != null)
                this.logoutUserHandler();
        }

        public void loadSession(Boolean isFirstTime = false)
        {
            PrototypeSession session = PrototypeSession.getInstance();
            if (session.isUserLoggedIn)
            {
                this.lblStoreName.Text = session.CurrentUser.Business.CompanyName;
                this.homePage.loadSession();

                this.panelSwapper1.setActivePanel(isFirstTime ? PageKeyTitles.START_PAGE.Key : PageKeyTitles.HOME_PAGE.Key);
                if (isFirstTime)
                {
                    this.currentPageKeyTitle = PageKeyTitles.START_PAGE;
                }
                else
                {
                    this.currentPageKeyTitle = PageKeyTitles.HOME_PAGE;
                }
            }
        }

        public void clearForm()
        {
            this.breadCrumbHistory1.clearHistory();
            this.lblStoreName.Text = "Store Name";
        }

        public void commonPageSelectionHandler(KeyValuePair<String, String> selectedPage)
        {
            this.panelSwapper1.setActivePanel(selectedPage.Key);
            //add recent activity
            //if (!selectedPage.Equals(PageKeyTitles.START_PAGE) &&
            //    !selectedPage.Equals(PageKeyTitles.HOME_PAGE) &&
            //    !selectedPage.Equals(EMPTY_PAGE))
            //{
            //    this.homePage.addActivity(selectedPage);
            //}
            //add bread crumb
            if(!this.currentPageKeyTitle.Equals(EMPTY_PAGE))
                this.breadCrumbHistory1.addBreadCrumbItem(this.currentPageKeyTitle.Key, this.currentPageKeyTitle.Value);
            //set current page key/title
            this.currentPageKeyTitle = selectedPage;
        }

        private void breadCrumbHistory1_breadCrumbItemEvent(object sender, Navigation.BreadCrumbItemEventArgs e)
        {
            this.panelSwapper1.setActivePanel(e.ItemKey);
            this.currentPageKeyTitle = EMPTY_PAGE;
        }
    }

    public class PageKeyTitles
    {
        public static readonly KeyValuePair<String, String> START_PAGE = new KeyValuePair<string, string>("start_page", "Start Page");
        public static readonly KeyValuePair<String, String> HOME_PAGE = new KeyValuePair<string, string>("home_page", "Home Page");
        public static readonly KeyValuePair<String, String> REPORT_PAGE = new KeyValuePair<string, string>("report_page", "Report Page");
        public static readonly KeyValuePair<String, String> STORE_CREATOR_PAGE = new KeyValuePair<string, string>("store_create_page", "Store Management Page");
        public static readonly KeyValuePair<String, String> INVENTORY_PAGE = new KeyValuePair<string, string>("inventory_page", "Inventory Page");
        public static readonly KeyValuePair<String, String> BUY_AD_PAGE = new KeyValuePair<string, string>("buy_add_page", "Buy Ad Placement Page");
        public static readonly KeyValuePair<String, String> PAYMENT_PAGE = new KeyValuePair<string, string>("payment_page", "Payment Processing Page");
    }
}
