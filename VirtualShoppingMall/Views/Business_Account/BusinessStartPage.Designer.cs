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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelSwapper1 = new VirtualShoppingMall.Views.Navigation.PanelSwapper();
            this.linkHome = new System.Windows.Forms.LinkLabel();
            this.tlpStartPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStartPage
            // 
            this.tlpStartPage.ColumnCount = 3;
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStartPage.Controls.Add(this.btnPrevious, 0, 1);
            this.tlpStartPage.Controls.Add(this.btnNext, 2, 1);
            this.tlpStartPage.Controls.Add(this.panelSwapper1, 1, 0);
            this.tlpStartPage.Controls.Add(this.linkHome, 2, 2);
            this.tlpStartPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartPage.Location = new System.Drawing.Point(0, 0);
            this.tlpStartPage.Name = "tlpStartPage";
            this.tlpStartPage.RowCount = 3;
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStartPage.Size = new System.Drawing.Size(400, 400);
            this.tlpStartPage.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(3, 171);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 57);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSize = true;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(300, 171);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 57);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelSwapper1
            // 
            this.panelSwapper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSwapper1.Location = new System.Drawing.Point(84, 3);
            this.panelSwapper1.Name = "panelSwapper1";
            this.tlpStartPage.SetRowSpan(this.panelSwapper1, 3);
            this.panelSwapper1.Size = new System.Drawing.Size(210, 394);
            this.panelSwapper1.TabIndex = 2;
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
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private Navigation.PanelSwapper panelSwapper1;
        private System.Windows.Forms.LinkLabel linkHome;

    }
}
