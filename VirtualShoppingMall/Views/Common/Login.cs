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

namespace VirtualShoppingMall.Views.Common
{
    public partial class Login : UserControl
    {
        private static readonly String GENERAL_PANEL = "general";
        private static readonly String SHOPPER_PANEL = "shopper";
        private static readonly String BUSINESS_PANEL = "business";

        public delegate void LoginSucess(Boolean isFirstTime);
        public LoginSucess onLoginSuccessHandler;

        private Stack<String> createHistoryStack;

        public Login()
        {
            InitializeComponent();

            this.createHistoryStack = new Stack<String>();

            CreateUser_General pG = new CreateUser_General();
            pG.onRequiredFieldsFilledHandler = this.onRequiredFieldsFilledHandler_G;

            CreateUser_Business pB = new CreateUser_Business();
            pB.onRequiredFieldsFilledHandler = this.onRequiredFieldsFilledHandler_B;

            this.panelSwapperCreateUser.PanelCollection.Add(GENERAL_PANEL, pG);
            this.panelSwapperCreateUser.PanelCollection.Add(SHOPPER_PANEL,
               new CreateUser_Shopper());
            this.panelSwapperCreateUser.PanelCollection.Add(BUSINESS_PANEL, pB);
            
            this.panelSwapperCreateUser.setActivePanel(GENERAL_PANEL);
        }

        private void onRequiredFieldsFilledHandler_G(Boolean filled)
        {
            this.btnBusiness.Enabled = filled;
        }

        private void onRequiredFieldsFilledHandler_B(Boolean filled)
        {
            this.btnFinish.Enabled = filled;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.createHistoryStack.Count > 0)
            {
                String key = this.createHistoryStack.Pop();
                this.panelSwapperCreateUser.setActivePanel(key);
                this.btnPrevious.Enabled = this.createHistoryStack.Count > 0;
            }
        }

        private void btnShopper_Click(object sender, EventArgs e)
        {
            this.createHistoryStack.Push(this.panelSwapperCreateUser.ActiveKey);
            this.panelSwapperCreateUser.setActivePanel(SHOPPER_PANEL);
            this.btnPrevious.Enabled = true;
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            this.createHistoryStack.Push(this.panelSwapperCreateUser.ActiveKey);
            this.panelSwapperCreateUser.setActivePanel(BUSINESS_PANEL);
            this.btnPrevious.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            CreateUser_General pG = (CreateUser_General)this.panelSwapperCreateUser.PanelCollection[GENERAL_PANEL];
            CreateUser_Business pB = (CreateUser_Business)this.panelSwapperCreateUser.PanelCollection[BUSINESS_PANEL];

            UserInfo newUser = pG.createGeneralUser();
            BusinessAccountInfo newBus = pB.createBusinessAccount();

            PrototypeSession session = PrototypeSession.getInstance();
            session.addUser(new UserIDAssociation(newUser, newBus));
            session.loadUser(newUser.UserID);
            this.raiseLoginSuccessful(true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PrototypeSession session = PrototypeSession.getInstance();
            String userID = this.txtUserName.Text.Trim();
            String password = this.txtPassword.Text.Trim();
            if (session.checkUserPassword(userID, password))
            {
                this.lblLoginError.Text = "";
                session.loadUser(userID);
                this.raiseLoginSuccessful(false);
            }
            else
            {
                this.lblLoginError.Text = "User Name / Password combination is invalid";
            }
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            this.btnLogin.Enabled = this.txtUserName.Text.Trim().Length > 0 &&
                this.txtPassword.Text.Trim().Length > 0;
        }

        private void raiseLoginSuccessful(Boolean isFirstTime)
        {
            if (this.onLoginSuccessHandler != null)
            {
                this.onLoginSuccessHandler(isFirstTime);
            }
        }

        public void clearForm()
        {
            this.txtUserName.Text = "";
            this.txtPassword.Text = "";

            CreateUser_General pG = (CreateUser_General)this.panelSwapperCreateUser.PanelCollection[GENERAL_PANEL];
            CreateUser_Business pB = (CreateUser_Business)this.panelSwapperCreateUser.PanelCollection[BUSINESS_PANEL];

            pG.clearForm();
            pB.clearForm();

            this.btnPrevious.Enabled = false;
            this.btnShopper.Enabled = false;
            this.btnBusiness.Enabled = false;
            this.btnFinish.Enabled = false;

            this.createHistoryStack.Clear();
            this.panelSwapperCreateUser.setActivePanel(GENERAL_PANEL);

            this.tabControl1.SelectedIndex = 0;
        }
    }
}
