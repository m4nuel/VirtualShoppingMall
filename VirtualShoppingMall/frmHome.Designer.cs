namespace VirtualShoppingMall
{
    partial class frmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDesktop = new System.Windows.Forms.TabPage();
            this.tabPageMobile = new System.Windows.Forms.TabPage();
            this.tlpMobilePictures = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventory = new System.Windows.Forms.PictureBox();
            this.pictureBoxRecentSales = new System.Windows.Forms.PictureBox();
            this.panelSwapperDesktop = new VirtualShoppingMall.Views.Navigation.PanelSwapper();
            this.tabControl1.SuspendLayout();
            this.tabPageDesktop.SuspendLayout();
            this.tabPageMobile.SuspendLayout();
            this.tlpMobilePictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecentSales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDesktop);
            this.tabControl1.Controls.Add(this.tabPageMobile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDesktop
            // 
            this.tabPageDesktop.Controls.Add(this.panelSwapperDesktop);
            this.tabPageDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDesktop.Location = new System.Drawing.Point(4, 25);
            this.tabPageDesktop.Name = "tabPageDesktop";
            this.tabPageDesktop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesktop.Size = new System.Drawing.Size(899, 551);
            this.tabPageDesktop.TabIndex = 0;
            this.tabPageDesktop.Text = "Desktop Prototype";
            this.tabPageDesktop.UseVisualStyleBackColor = true;
            // 
            // tabPageMobile
            // 
            this.tabPageMobile.Controls.Add(this.tlpMobilePictures);
            this.tabPageMobile.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMobile.Location = new System.Drawing.Point(4, 25);
            this.tabPageMobile.Name = "tabPageMobile";
            this.tabPageMobile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMobile.Size = new System.Drawing.Size(899, 551);
            this.tabPageMobile.TabIndex = 1;
            this.tabPageMobile.Text = "Mobile Prototype";
            this.tabPageMobile.UseVisualStyleBackColor = true;
            // 
            // tlpMobilePictures
            // 
            this.tlpMobilePictures.ColumnCount = 5;
            this.tlpMobilePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMobilePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMobilePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMobilePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMobilePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMobilePictures.Controls.Add(this.pictureBoxHome, 1, 0);
            this.tlpMobilePictures.Controls.Add(this.pictureBoxInventory, 2, 0);
            this.tlpMobilePictures.Controls.Add(this.pictureBoxRecentSales, 3, 0);
            this.tlpMobilePictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMobilePictures.Location = new System.Drawing.Point(3, 3);
            this.tlpMobilePictures.Name = "tlpMobilePictures";
            this.tlpMobilePictures.RowCount = 1;
            this.tlpMobilePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMobilePictures.Size = new System.Drawing.Size(893, 545);
            this.tlpMobilePictures.TabIndex = 0;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.InitialImage = null;
            this.pictureBoxHome.Location = new System.Drawing.Point(140, 77);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(200, 391);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            // 
            // pictureBoxInventory
            // 
            this.pictureBoxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory.Image")));
            this.pictureBoxInventory.InitialImage = null;
            this.pictureBoxInventory.Location = new System.Drawing.Point(346, 77);
            this.pictureBoxInventory.Name = "pictureBoxInventory";
            this.pictureBoxInventory.Size = new System.Drawing.Size(200, 391);
            this.pictureBoxInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxInventory.TabIndex = 0;
            this.pictureBoxInventory.TabStop = false;
            // 
            // pictureBoxRecentSales
            // 
            this.pictureBoxRecentSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRecentSales.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecentSales.Image")));
            this.pictureBoxRecentSales.InitialImage = null;
            this.pictureBoxRecentSales.Location = new System.Drawing.Point(552, 77);
            this.pictureBoxRecentSales.Name = "pictureBoxRecentSales";
            this.pictureBoxRecentSales.Size = new System.Drawing.Size(200, 391);
            this.pictureBoxRecentSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRecentSales.TabIndex = 0;
            this.pictureBoxRecentSales.TabStop = false;
            // 
            // panelSwapperDesktop
            // 
            this.panelSwapperDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSwapperDesktop.Location = new System.Drawing.Point(3, 3);
            this.panelSwapperDesktop.Name = "panelSwapperDesktop";
            this.panelSwapperDesktop.Size = new System.Drawing.Size(893, 545);
            this.panelSwapperDesktop.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHome";
            this.Text = "Virtual Shopping Mall (Prototype)";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDesktop.ResumeLayout(false);
            this.tabPageMobile.ResumeLayout(false);
            this.tlpMobilePictures.ResumeLayout(false);
            this.tlpMobilePictures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecentSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDesktop;
        private System.Windows.Forms.TabPage tabPageMobile;
        private Views.Navigation.PanelSwapper panelSwapperDesktop;
        private System.Windows.Forms.TableLayoutPanel tlpMobilePictures;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxInventory;
        private System.Windows.Forms.PictureBox pictureBoxRecentSales;
    }
}

