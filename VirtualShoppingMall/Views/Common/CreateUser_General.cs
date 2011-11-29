using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirtualShoppingMall.Models.User_Account;

namespace VirtualShoppingMall.Views.Common
{
    public partial class CreateUser_General : UserControl
    {
        public delegate void onRequiredFieldsFilled(Boolean filled);

        public onRequiredFieldsFilled onRequiredFieldsFilledHandler;

        public CreateUser_General()
        {
            InitializeComponent();
        }

        public Boolean areRequiredFieldsFilled()
        {
            return this.txtNewUserName.Text.Trim().Length > 0 &&
                this.txtNewPassword.Text.Trim().Length > 0 &&
                this.txtNewConfirm.Text.Trim().Length > 0 &&
                this.txtNewFirstName.Text.Trim().Length > 0 &&
                this.txtNewLastName.Text.Trim().Length > 0;
        }

        public Boolean doesPasswordMatchConfirm()
        {
            return this.txtNewPassword.Text.Trim().Equals(
                this.txtNewConfirm.Text.Trim());
        }

        public UserInfo createGeneralUser()
        {
            return new UserInfo(
                this.txtNewUserName.Text.Trim(),
                this.txtNewPassword.Text.Trim(),
                this.txtNewFirstName.Text.Trim(),
                this.txtNewMiddleName.Text.Trim(),
                this.txtNewLastName.Text.Trim(),
                this.txtNewSuffix.Text.Trim()
                );
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            if (this.onRequiredFieldsFilledHandler != null)
            {
                this.onRequiredFieldsFilledHandler(this.areRequiredFieldsFilled());
            }
        }

        public void clearForm()
        {
            this.txtNewUserName.Text = "";
            this.txtNewPassword.Text = "";
            this.txtNewConfirm.Text = "";
            this.txtNewFirstName.Text = "";
            this.txtNewMiddleName.Text = "";
            this.txtNewLastName.Text = "";
            this.txtNewSuffix.Text = "";
        }
    }
}
