namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessHomeController
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
            this.lblStoreName = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.breadCrumbHistory1 = new VirtualShoppingMall.Views.Navigation.BreadCrumbHistory();
            this.panelSwapper1 = new VirtualShoppingMall.Views.Navigation.PanelSwapper();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Controls.Add(this.lblStoreName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLogout, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.breadCrumbHistory1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSwapper1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 770);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoreName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(3, 0);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(650, 48);
            this.lblStoreName.TabIndex = 4;
            this.lblStoreName.Text = "Store Name";
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLogout.Location = new System.Drawing.Point(659, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(229, 48);
            this.linkLogout.TabIndex = 5;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // breadCrumbHistory1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.breadCrumbHistory1, 2);
            this.breadCrumbHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadCrumbHistory1.Location = new System.Drawing.Point(3, 51);
            this.breadCrumbHistory1.Name = "breadCrumbHistory1";
            this.breadCrumbHistory1.Size = new System.Drawing.Size(885, 84);
            this.breadCrumbHistory1.TabIndex = 7;
            this.breadCrumbHistory1.breadCrumbItemEvent += new VirtualShoppingMall.Views.Navigation.BreadCrumbItemEventHandler(this.breadCrumbHistory1_breadCrumbItemEvent);
            // 
            // panelSwapper1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelSwapper1, 2);
            this.panelSwapper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSwapper1.Location = new System.Drawing.Point(3, 141);
            this.panelSwapper1.Name = "panelSwapper1";
            this.tableLayoutPanel1.SetRowSpan(this.panelSwapper1, 2);
            this.panelSwapper1.Size = new System.Drawing.Size(885, 626);
            this.panelSwapper1.TabIndex = 8;
            // 
            // BusinessHomeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusinessHomeController";
            this.Size = new System.Drawing.Size(891, 770);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.LinkLabel linkLogout;
        private Navigation.BreadCrumbHistory breadCrumbHistory1;
        private Navigation.PanelSwapper panelSwapper1;
    }
}
