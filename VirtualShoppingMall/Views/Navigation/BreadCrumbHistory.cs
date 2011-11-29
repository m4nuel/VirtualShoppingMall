using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualShoppingMall.Views.Navigation
{
    public partial class BreadCrumbHistory : UserControl
    {
        private List<BreadCrumbItem> listHistory;

        public event BreadCrumbItemEventHandler breadCrumbItemEvent;

        public BreadCrumbHistory()
        {
            InitializeComponent();
            this.listHistory = new List<BreadCrumbItem>();
        }

        public void clearHistory()
        {
            for (int i = this.listHistory.Count - 1; i >= 0; i--)
            {
                //remove all items after selected bread crumb
                BreadCrumbItem item = this.listHistory[i];
                this.listHistory.RemoveAt(i);
                this.tlpHistory.Controls.RemoveAt(i);
                item.breadCrumbItemEvent -= this.breadCrumbItemClick_Handler;
                item = null;
            }
        }

        private void breadCrumbItemClick_Handler(object sender, BreadCrumbItemEventArgs e)
        {
            for (int i = this.listHistory.Count - 1; i > e.ItemIndex; i--)
            {
                //remove all items after selected bread crumb
                BreadCrumbItem item = this.listHistory[i];
                this.listHistory.RemoveAt(i);
                this.tlpHistory.Controls.RemoveAt(i);
                item.breadCrumbItemEvent -= this.breadCrumbItemClick_Handler;
                item = null;
            }
            if (this.breadCrumbItemEvent != null)
                this.breadCrumbItemEvent(this, e);
        }

        public void addBreadCrumbItem(String itemKey, String itemTitle, Image itemThumbNail = null)
        {
            BreadCrumbItem item = new BreadCrumbItem();
            item.ItemIndex = this.listHistory.Count;
            item.ItemKey = itemKey;
            item.ItemTitle = itemTitle;
            item.ItemThumbNail = itemThumbNail;
            item.breadCrumbItemEvent += this.breadCrumbItemClick_Handler;

            this.listHistory.Add(item);
            this.tlpHistory.Controls.Add(item);
            if (item.ItemIndex > (this.tlpHistory.ColumnStyles.Count - 1))
            {
                this.tlpHistory.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            }
            else
            {
                ColumnStyle cs = this.tlpHistory.ColumnStyles[item.ItemIndex];
                cs.SizeType = SizeType.Absolute;
                cs.Width = 100;
            }
        }
    }
}
