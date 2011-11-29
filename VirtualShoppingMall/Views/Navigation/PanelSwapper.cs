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
    public partial class PanelSwapper : UserControl
    {
        private IDictionary<String, UserControl> panelCollection;
        private String activeKey;
        private UserControl activeControl;


        public PanelSwapper()
        {
            this.panelCollection = new Dictionary<String, UserControl>();
            InitializeComponent();
        }

        public IDictionary<String, UserControl> PanelCollection
        {
            get { return this.panelCollection; }
        }

        public UserControl setActivePanel(String key)
        {
            UserControl panel = this.panelCollection[key];
            if (panel != null)
            {
                if (this.activeControl != null)
                {
                    this.Controls.Remove(this.activeControl);
                }
                this.activeKey = key;
                this.activeControl = panel;
                this.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
            return panel;
        }

        public String ActiveKey
        {
            get { return this.activeKey; }
        }

        public UserControl ActivePanel
        {
            get { return this.activeControl; }
        }
    }
}
