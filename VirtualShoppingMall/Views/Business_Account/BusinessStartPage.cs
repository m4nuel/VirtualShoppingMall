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
    public partial class BusinessStartPage : UserControl
    {

        public CommonPageSelectionHandler commonPageSelectionEvent;

        public BusinessStartPage()
        {
            InitializeComponent();
        }

        private void raisePageSelectionEvent(KeyValuePair<String, String> selectedPage)
        {
            if (this.commonPageSelectionEvent != null)
            {
                this.commonPageSelectionEvent(selectedPage);
            }
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.raisePageSelectionEvent(PageKeyTitles.HOME_PAGE);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
