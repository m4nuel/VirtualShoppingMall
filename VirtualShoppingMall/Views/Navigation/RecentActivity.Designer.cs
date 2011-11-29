namespace VirtualShoppingMall.Views.Navigation
{
    partial class RecentActivity
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwRecentActivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwRecentActivity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 599);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Activity";
            // 
            // lvwRecentActivity
            // 
            this.lvwRecentActivity.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwRecentActivity.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvwRecentActivity.AutoArrange = false;
            this.lvwRecentActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRecentActivity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwRecentActivity.LargeImageList = this.imageList1;
            this.lvwRecentActivity.Location = new System.Drawing.Point(3, 35);
            this.lvwRecentActivity.MultiSelect = false;
            this.lvwRecentActivity.Name = "lvwRecentActivity";
            this.lvwRecentActivity.Size = new System.Drawing.Size(230, 561);
            this.lvwRecentActivity.SmallImageList = this.imageList1;
            this.lvwRecentActivity.TabIndex = 0;
            this.lvwRecentActivity.TileSize = new System.Drawing.Size(150, 64);
            this.lvwRecentActivity.UseCompatibleStateImageBehavior = false;
            this.lvwRecentActivity.View = System.Windows.Forms.View.Tile;
            this.lvwRecentActivity.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwRecentActivity_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RecentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RecentActivity";
            this.Size = new System.Drawing.Size(236, 599);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwRecentActivity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
