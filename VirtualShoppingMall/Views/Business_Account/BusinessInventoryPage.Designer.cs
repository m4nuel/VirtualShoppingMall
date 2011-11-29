namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessInventoryPage
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.tcInventory = new System.Windows.Forms.TabControl();
            this.tpManagment = new System.Windows.Forms.TabPage();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblLowInventory = new System.Windows.Forms.Label();
            this.lblDepletionRate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcInventory.SuspendLayout();
            this.tpStatus.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblInventory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tcInventory, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventory.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(3, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(394, 33);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcInventory
            // 
            this.tcInventory.Controls.Add(this.tpManagment);
            this.tcInventory.Controls.Add(this.tpStatus);
            this.tcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInventory.Location = new System.Drawing.Point(3, 36);
            this.tcInventory.Name = "tcInventory";
            this.tcInventory.SelectedIndex = 0;
            this.tcInventory.Size = new System.Drawing.Size(394, 361);
            this.tcInventory.TabIndex = 1;
            // 
            // tpManagment
            // 
            this.tpManagment.Location = new System.Drawing.Point(4, 25);
            this.tpManagment.Name = "tpManagment";
            this.tpManagment.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagment.Size = new System.Drawing.Size(386, 332);
            this.tpManagment.TabIndex = 0;
            this.tpManagment.Text = "Management";
            this.tpManagment.UseVisualStyleBackColor = true;
            // 
            // tpStatus
            // 
            this.tpStatus.Controls.Add(this.tlpStatus);
            this.tpStatus.Location = new System.Drawing.Point(4, 25);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatus.Size = new System.Drawing.Size(386, 332);
            this.tpStatus.TabIndex = 1;
            this.tpStatus.Text = "Status";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 2;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatus.Controls.Add(this.lblLowInventory, 0, 0);
            this.tlpStatus.Controls.Add(this.lblDepletionRate, 1, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatus.Location = new System.Drawing.Point(3, 3);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowCount = 2;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Size = new System.Drawing.Size(380, 326);
            this.tlpStatus.TabIndex = 0;
            // 
            // lblLowInventory
            // 
            this.lblLowInventory.AutoSize = true;
            this.lblLowInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowInventory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowInventory.Location = new System.Drawing.Point(3, 0);
            this.lblLowInventory.Name = "lblLowInventory";
            this.lblLowInventory.Size = new System.Drawing.Size(184, 23);
            this.lblLowInventory.TabIndex = 0;
            this.lblLowInventory.Text = "Low Inventory";
            this.lblLowInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepletionRate
            // 
            this.lblDepletionRate.AutoSize = true;
            this.lblDepletionRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepletionRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepletionRate.Location = new System.Drawing.Point(193, 0);
            this.lblDepletionRate.Name = "lblDepletionRate";
            this.lblDepletionRate.Size = new System.Drawing.Size(184, 23);
            this.lblDepletionRate.TabIndex = 1;
            this.lblDepletionRate.Text = "Depletion Rate";
            // 
            // BusinessInventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusinessInventoryPage";
            this.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tcInventory.ResumeLayout(false);
            this.tpStatus.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.tlpStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TabControl tcInventory;
        private System.Windows.Forms.TabPage tpManagment;
        private System.Windows.Forms.TabPage tpStatus;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Label lblLowInventory;
        private System.Windows.Forms.Label lblDepletionRate;

    }
}
