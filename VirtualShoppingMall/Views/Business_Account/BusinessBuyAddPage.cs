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
    public partial class BusinessBuyAddPage : UserControl
    {
        public CommonPageSelectionHandler commonPageSelectionEvent;

        public BusinessBuyAddPage()
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

    }
}
