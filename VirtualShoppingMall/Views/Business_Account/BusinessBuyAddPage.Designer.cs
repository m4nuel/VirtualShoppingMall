namespace VirtualShoppingMall.Views.Business_Account
{
    partial class BusinessBuyAddPage
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
            this.lblPlaceHolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlaceHolder
            // 
            this.lblPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceHolder.Location = new System.Drawing.Point(0, 0);
            this.lblPlaceHolder.Name = "lblPlaceHolder";
            this.lblPlaceHolder.Size = new System.Drawing.Size(300, 300);
            this.lblPlaceHolder.TabIndex = 1;
            this.lblPlaceHolder.Text = "Buy AD Placement Page";
            this.lblPlaceHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusinessBuyAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlaceHolder);
            this.Name = "BusinessBuyAddPage";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlaceHolder;
    }
}
