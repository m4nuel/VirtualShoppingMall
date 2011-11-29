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
    public partial class BreadCrumbItem : UserControl
    {
        private int itemIndex;
        private String itemKey;
        private String itemTitle;
        private Image itemThumbNail;

        public event BreadCrumbItemEventHandler breadCrumbItemEvent;

        public BreadCrumbItem()
        {
            InitializeComponent();
        }

        public int ItemIndex
        {
            get { return this.itemIndex; }
            set { this.itemIndex = value; }
        }

        public String ItemKey
        {
            get { return this.itemKey; }
            set { this.itemKey = value; }
        }

        public String ItemTitle
        {
            get { return this.itemTitle; }
            set { this.itemTitle = value; this.lblTitle.Text = value; }
        }

        public Image ItemThumbNail
        {
            get { return this.itemThumbNail; }
            set { this.itemThumbNail = value; this.thumbNail.Image = value; }
        }

        private void breadCrumbItemClick_Handler(object sender, EventArgs e)
        {
            if (this.breadCrumbItemEvent != null)
                this.breadCrumbItemEvent(this,
                    new BreadCrumbItemEventArgs(this.itemIndex, this.itemKey, this.itemTitle)
                    );
        }

    }

    public class BreadCrumbItemEventArgs
    {
        public int ItemIndex { get; private set; }
        public String ItemKey { get; private set; }
        public String ItemTitle { get; private set; }
        public BreadCrumbItemEventArgs(int index, String key, String title)
        {
            this.ItemIndex = index;
            this.ItemKey = key;
            this.ItemTitle = title;
        }
    }

    public delegate void BreadCrumbItemEventHandler(object sender, BreadCrumbItemEventArgs e);
}
