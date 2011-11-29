using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirtualShoppingMall.Models.User_Account;

namespace VirtualShoppingMall.Views.Common
{
    public partial class CreateUser_Business : UserControl
    {
        public delegate void onRequiredFieldsFilled(Boolean filled);
        public onRequiredFieldsFilled onRequiredFieldsFilledHandler;

        public CreateUser_Business()
        {
            InitializeComponent();
        }

        public Boolean areRequiredFieldsFilled()
        {
            return this.txtNewCompanyID.Text.Trim().Length > 0 &&
                this.txtNewCompanyName.Text.Trim().Length > 0;
        }


        public BusinessAccountInfo createBusinessAccount()
        {
            return new BusinessAccountInfo(
                this.txtNewCompanyID.Text.Trim(),
                this.txtNewCompanyName.Text.Trim(),
                this.txtNewCompanyURL.Text.Trim()
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
            this.txtNewCompanyID.Text = "";
            this.txtNewCompanyName.Text = "";
            this.txtNewCompanyURL.Text = "";
        }
    }
}
