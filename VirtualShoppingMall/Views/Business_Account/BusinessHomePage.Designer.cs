namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessHomePage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkReports = new System.Windows.Forms.LinkLabel();
            this.linkStoreFrontManagement = new System.Windows.Forms.LinkLabel();
            this.linkInventory = new System.Windows.Forms.LinkLabel();
            this.linkBuyAd = new System.Windows.Forms.LinkLabel();
            this.linkPaymentProc = new System.Windows.Forms.LinkLabel();
            this.salesTimeChart1 = new VirtualShoppingMall.Views.Business_Account.Charts.SalesTimeChart();
            this.inventoryStatusChart1 = new VirtualShoppingMall.Views.Business_Account.Charts.InventoryStatusChart();
            this.recentActivity1 = new VirtualShoppingMall.Views.Navigation.RecentActivity();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.93805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.salesTimeChart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inventoryStatusChart1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.recentActivity1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(627, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(231, 655);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common Tasks";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.linkReports, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkStoreFrontManagement, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.linkInventory, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.linkBuyAd, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.linkPaymentProc, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 617);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // linkReports
            // 
            this.linkReports.AutoSize = true;
            this.linkReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkReports.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReports.Location = new System.Drawing.Point(3, 0);
            this.linkReports.Name = "linkReports";
            this.linkReports.Padding = new System.Windows.Forms.Padding(10);
            this.linkReports.Size = new System.Drawing.Size(219, 48);
            this.linkReports.TabIndex = 0;
            this.linkReports.TabStop = true;
            this.linkReports.Text = "Reports";
            this.linkReports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReports_LinkClicked);
            // 
            // linkStoreFrontManagement
            // 
            this.linkStoreFrontManagement.AutoSize = true;
            this.linkStoreFrontManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkStoreFrontManagement.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStoreFrontManagement.Location = new System.Drawing.Point(3, 48);
            this.linkStoreFrontManagement.Name = "linkStoreFrontManagement";
            this.linkStoreFrontManagement.Padding = new System.Windows.Forms.Padding(10);
            this.linkStoreFrontManagement.Size = new System.Drawing.Size(219, 76);
            this.linkStoreFrontManagement.TabIndex = 1;
            this.linkStoreFrontManagement.TabStop = true;
            this.linkStoreFrontManagement.Text = "Storefront Management";
            this.linkStoreFrontManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStoreFrontManagement_LinkClicked);
            // 
            // linkInventory
            // 
            this.linkInventory.AutoSize = true;
            this.linkInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkInventory.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkInventory.Location = new System.Drawing.Point(3, 124);
            this.linkInventory.Name = "linkInventory";
            this.linkInventory.Padding = new System.Windows.Forms.Padding(10);
            this.linkInventory.Size = new System.Drawing.Size(219, 48);
            this.linkInventory.TabIndex = 2;
            this.linkInventory.TabStop = true;
            this.linkInventory.Text = "Inventory";
            this.linkInventory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInventory_LinkClicked);
            // 
            // linkBuyAd
            // 
            this.linkBuyAd.AutoSize = true;
            this.linkBuyAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkBuyAd.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBuyAd.Location = new System.Drawing.Point(3, 172);
            this.linkBuyAd.Name = "linkBuyAd";
            this.linkBuyAd.Padding = new System.Windows.Forms.Padding(10);
            this.linkBuyAd.Size = new System.Drawing.Size(219, 76);
            this.linkBuyAd.TabIndex = 3;
            this.linkBuyAd.TabStop = true;
            this.linkBuyAd.Text = "Buy Ad Placement";
            this.linkBuyAd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuyAd_LinkClicked);
            // 
            // linkPaymentProc
            // 
            this.linkPaymentProc.AutoSize = true;
            this.linkPaymentProc.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkPaymentProc.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPaymentProc.Location = new System.Drawing.Point(3, 248);
            this.linkPaymentProc.Name = "linkPaymentProc";
            this.linkPaymentProc.Padding = new System.Windows.Forms.Padding(10);
            this.linkPaymentProc.Size = new System.Drawing.Size(219, 76);
            this.linkPaymentProc.TabIndex = 4;
            this.linkPaymentProc.TabStop = true;
            this.linkPaymentProc.Text = "Payment Processing";
            this.linkPaymentProc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPaymentProc_LinkClicked);
            // 
            // salesTimeChart1
            // 
            this.salesTimeChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesTimeChart1.Location = new System.Drawing.Point(259, 3);
            this.salesTimeChart1.Name = "salesTimeChart1";
            this.salesTimeChart1.Size = new System.Drawing.Size(362, 324);
            this.salesTimeChart1.TabIndex = 1;
            // 
            // inventoryStatusChart1
            // 
            this.inventoryStatusChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryStatusChart1.Location = new System.Drawing.Point(259, 333);
            this.inventoryStatusChart1.Name = "inventoryStatusChart1";
            this.inventoryStatusChart1.Size = new System.Drawing.Size(362, 325);
            this.inventoryStatusChart1.TabIndex = 2;
            // 
            // recentActivity1
            // 
            this.recentActivity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentActivity1.Location = new System.Drawing.Point(3, 3);
            this.recentActivity1.Name = "recentActivity1";
            this.tableLayoutPanel1.SetRowSpan(this.recentActivity1, 2);
            this.recentActivity1.Size = new System.Drawing.Size(250, 655);
            this.recentActivity1.TabIndex = 3;
            // 
            // BusinessHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusinessHomePage";
            this.Size = new System.Drawing.Size(861, 661);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkReports;
        private System.Windows.Forms.LinkLabel linkStoreFrontManagement;
        private System.Windows.Forms.LinkLabel linkInventory;
        private System.Windows.Forms.LinkLabel linkBuyAd;
        private System.Windows.Forms.LinkLabel linkPaymentProc;
        private Charts.SalesTimeChart salesTimeChart1;
        private Charts.InventoryStatusChart inventoryStatusChart1;
        private Navigation.RecentActivity recentActivity1;
    }
}
