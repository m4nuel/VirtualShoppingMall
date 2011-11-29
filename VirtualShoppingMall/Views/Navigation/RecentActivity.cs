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

namespace VirtualShoppingMall.Views.Navigation
{
    public partial class RecentActivity : UserControl
    {
        public VirtualShoppingMall.Views.Business_Account.CommonPageSelectionHandler commonPageSelectionEvent;
        
        public RecentActivity()
        {
            InitializeComponent();

            this.loadSession();
        }

        private void raisePageSelectionEvent(KeyValuePair<String, String> selectedPage)
        {
            if (this.commonPageSelectionEvent != null)
            {
                this.commonPageSelectionEvent(selectedPage);
            }
        }

        public void loadSession()
        {
            PrototypeSession session = PrototypeSession.getInstance();
            if (session.isUserLoggedIn)
            {
                this.loadRecentActivity(session.CurrentUser.Business.ListRecentActivity);
            }
        }

        private void loadRecentActivity(List<KeyValuePair<String, String>> recent)
        {
            this.lvwRecentActivity.Items.Clear();
            for (int i = recent.Count - 1; i >= 0; i--)
            {
                ListViewItem lvItem = new ListViewItem(recent[i].Value);
                lvItem.Tag = recent[i];

                this.lvwRecentActivity.Items.Add(lvItem);
            }
        }

        public void addActivity(KeyValuePair<String, String> item)
        {
            PrototypeSession session = PrototypeSession.getInstance();
            if (session.isUserLoggedIn)
            {
                session.CurrentUser.Business.ListRecentActivity.Add(item);
                /*
                ListViewItem lvItem = new ListViewItem(item.Value);
                lvItem.Tag = item;

                this.lvwRecentActivity.Items.Insert(0, lvItem);
                */
                this.loadRecentActivity(session.CurrentUser.Business.ListRecentActivity);
            }
        }

        private void lvwRecentActivity_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.raisePageSelectionEvent((KeyValuePair<String, String>)e.Item.Tag);
        }
    }
}
