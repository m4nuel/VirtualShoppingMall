using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirtualShoppingMall.Models;
using VirtualShoppingMall.Models.User_Account;

namespace VirtualShoppingMall
{
    public partial class frmHome : Form
    {
        private static readonly String LOGIN_SCREEN = "login_screen";
        private static readonly String BUSINESS_HOME_SCREEN = "business_screen";

        private Views.Common.Login login1;
        private Views.Business_Account.BusinessHomeController busHmCtrl;

        public frmHome()
        {
            InitializeComponent();

            this.login1 = new Views.Common.Login();
            this.login1.onLoginSuccessHandler = this.onLoginSuccessfulHandler;

            this.busHmCtrl = new Views.Business_Account.BusinessHomeController();
            this.busHmCtrl.logoutUserHandler = this.onLogoutUserHandler;
            
            this.panelSwapperDesktop.PanelCollection.Add(
                LOGIN_SCREEN, login1);
            this.panelSwapperDesktop.PanelCollection.Add(
                BUSINESS_HOME_SCREEN, busHmCtrl);

            this.panelSwapperDesktop.setActivePanel(LOGIN_SCREEN);
        }

        private void onLoginSuccessfulHandler(Boolean isFirstTime)
        {
            PrototypeSession session = PrototypeSession.getInstance();

            MessageBox.Show(session.CurrentUser.User.FullName + " is logged in.");

            this.busHmCtrl.loadSession(isFirstTime);
            this.panelSwapperDesktop.setActivePanel(BUSINESS_HOME_SCREEN);
        }

        private void onLogoutUserHandler()
        {
            this.login1.clearForm();
            this.panelSwapperDesktop.setActivePanel(LOGIN_SCREEN);
            this.busHmCtrl.clearForm();
        }
    }
}
