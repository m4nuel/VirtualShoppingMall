namespace VirtualShoppingMall.Views.Business_Account.Charts
{
    partial class InventoryStatusChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 80D);
            this.chartInventoryStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartInventoryStatus
            // 
            this.chartInventoryStatus.BackColor = System.Drawing.Color.Transparent;
            customLabel1.Text = "Watches";
            customLabel2.Text = "Necklaces";
            customLabel3.Text = "Bracelets";
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.Name = "ChartArea1";
            this.chartInventoryStatus.ChartAreas.Add(chartArea1);
            this.chartInventoryStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartInventoryStatus.Location = new System.Drawing.Point(3, 35);
            this.chartInventoryStatus.Name = "chartInventoryStatus";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "Watches";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.IsVisibleInLegend = false;
            dataPoint1.Label = "";
            dataPoint1.LegendText = "";
            dataPoint2.AxisLabel = "Bracelets";
            dataPoint2.Label = "";
            dataPoint3.AxisLabel = "Necklaces";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.Label = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chartInventoryStatus.Series.Add(series1);
            this.chartInventoryStatus.Size = new System.Drawing.Size(641, 422);
            this.chartInventoryStatus.TabIndex = 0;
            this.chartInventoryStatus.Text = "Inventory Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartInventoryStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Status";
            // 
            // InventoryStatusChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryStatusChart";
            this.Size = new System.Drawing.Size(647, 460);
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventoryStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
