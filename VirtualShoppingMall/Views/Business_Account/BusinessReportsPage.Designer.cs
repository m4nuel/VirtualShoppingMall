namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessReportsPage
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
            this.grbProfitMargin = new System.Windows.Forms.GroupBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.grbSalesTrend = new System.Windows.Forms.GroupBox();
            this.grbProductPerform = new System.Windows.Forms.GroupBox();
            this.grbSalesMap = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbProfitMargin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReports, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbSalesTrend, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbProductPerform, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbSalesMap, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbProfitMargin
            // 
            this.grbProfitMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProfitMargin.Location = new System.Drawing.Point(3, 31);
            this.grbProfitMargin.Name = "grbProfitMargin";
            this.grbProfitMargin.Size = new System.Drawing.Size(194, 180);
            this.grbProfitMargin.TabIndex = 0;
            this.grbProfitMargin.TabStop = false;
            this.grbProfitMargin.Text = "Profit Margin";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblReports, 2);
            this.lblReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReports.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(3, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(394, 28);
            this.lblReports.TabIndex = 1;
            this.lblReports.Text = "Reports";
            this.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbSalesTrend
            // 
            this.grbSalesTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSalesTrend.Location = new System.Drawing.Point(203, 31);
            this.grbSalesTrend.Name = "grbSalesTrend";
            this.grbSalesTrend.Size = new System.Drawing.Size(194, 180);
            this.grbSalesTrend.TabIndex = 2;
            this.grbSalesTrend.TabStop = false;
            this.grbSalesTrend.Text = "Sales Trend";
            // 
            // grbProductPerform
            // 
            this.grbProductPerform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProductPerform.Location = new System.Drawing.Point(3, 217);
            this.grbProductPerform.Name = "grbProductPerform";
            this.grbProductPerform.Size = new System.Drawing.Size(194, 180);
            this.grbProductPerform.TabIndex = 3;
            this.grbProductPerform.TabStop = false;
            this.grbProductPerform.Text = "Product Performance";
            // 
            // grbSalesMap
            // 
            this.grbSalesMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSalesMap.Location = new System.Drawing.Point(203, 217);
            this.grbSalesMap.Name = "grbSalesMap";
            this.grbSalesMap.Size = new System.Drawing.Size(194, 180);
            this.grbSalesMap.TabIndex = 4;
            this.grbSalesMap.TabStop = false;
            this.grbSalesMap.Text = "Sales Map";
            // 
            // BusinessReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusinessReportsPage";
            this.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbProfitMargin;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.GroupBox grbSalesTrend;
        private System.Windows.Forms.GroupBox grbProductPerform;
        private System.Windows.Forms.GroupBox grbSalesMap;

    }
}
