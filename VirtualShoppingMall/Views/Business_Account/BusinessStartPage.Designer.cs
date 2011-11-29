namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessStartPage
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
            this.tlpStartPage = new System.Windows.Forms.TableLayoutPanel();
            this.linkHome = new System.Windows.Forms.LinkLabel();
            this.elementHostStartWizard = new System.Windows.Forms.Integration.ElementHost();
            this.startWizard1 = new VirtualShoppingMall.Views.Business_Account.StartWizard.StartWizard();
            this.tlpStartPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStartPage
            // 
            this.tlpStartPage.ColumnCount = 2;
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStartPage.Controls.Add(this.linkHome, 1, 1);
            this.tlpStartPage.Controls.Add(this.elementHostStartWizard, 0, 0);
            this.tlpStartPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartPage.Location = new System.Drawing.Point(0, 0);
            this.tlpStartPage.Name = "tlpStartPage";
            this.tlpStartPage.RowCount = 2;
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStartPage.Size = new System.Drawing.Size(400, 400);
            this.tlpStartPage.TabIndex = 0;
            // 
            // linkHome
            // 
            this.linkHome.AutoSize = true;
            this.linkHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkHome.Location = new System.Drawing.Point(300, 383);
            this.linkHome.Name = "linkHome";
            this.linkHome.Size = new System.Drawing.Size(97, 17);
            this.linkHome.TabIndex = 3;
            this.linkHome.TabStop = true;
            this.linkHome.Text = "Skip To Home";
            this.linkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome_LinkClicked);
            // 
            // elementHostStartWizard
            // 
            this.elementHostStartWizard.AutoSize = true;
            this.tlpStartPage.SetColumnSpan(this.elementHostStartWizard, 2);
            this.elementHostStartWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostStartWizard.Location = new System.Drawing.Point(3, 3);
            this.elementHostStartWizard.Name = "elementHostStartWizard";
            this.elementHostStartWizard.Size = new System.Drawing.Size(394, 377);
            this.elementHostStartWizard.TabIndex = 4;
            this.elementHostStartWizard.Text = "Start Wizard";
            this.elementHostStartWizard.Child = this.startWizard1;
            // 
            // BusinessStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpStartPage);
            this.Name = "BusinessStartPage";
            this.Size = new System.Drawing.Size(400, 400);
            this.tlpStartPage.ResumeLayout(false);
            this.tlpStartPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStartPage;
        private System.Windows.Forms.LinkLabel linkHome;
        private System.Windows.Forms.Integration.ElementHost elementHostStartWizard;
        private StartWizard.StartWizard startWizard1;

    }
}
