namespace VirtualShoppingMall.Views.Common
{
    partial class Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExisting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.tabPageNew = new System.Windows.Forms.TabPage();
            this.tlpCreate = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelSwapperCreateUser = new VirtualShoppingMall.Views.Navigation.PanelSwapper();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnShopper = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageExisting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageNew.SuspendLayout();
            this.tlpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageExisting);
            this.tabControl1.Controls.Add(this.tabPageNew);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageExisting
            // 
            this.tabPageExisting.Controls.Add(this.tableLayoutPanel1);
            this.tabPageExisting.Location = new System.Drawing.Point(4, 4);
            this.tabPageExisting.Name = "tabPageExisting";
            this.tabPageExisting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExisting.Size = new System.Drawing.Size(724, 299);
            this.tabPageExisting.TabIndex = 0;
            this.tabPageExisting.Text = "Login";
            this.tabPageExisting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLoginError, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.92066F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.41587F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.84498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 96);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(174, 39);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(174, 37);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(183, 102);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(431, 26);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(183, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(431, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoSize = true;
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(539, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(183, 79);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(431, 17);
            this.lblLoginError.TabIndex = 3;
            // 
            // tabPageNew
            // 
            this.tabPageNew.Controls.Add(this.tlpCreate);
            this.tabPageNew.Location = new System.Drawing.Point(4, 4);
            this.tabPageNew.Name = "tabPageNew";
            this.tabPageNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNew.Size = new System.Drawing.Size(724, 299);
            this.tabPageNew.TabIndex = 1;
            this.tabPageNew.Text = "Create Account";
            this.tabPageNew.UseVisualStyleBackColor = true;
            // 
            // tlpCreate
            // 
            this.tlpCreate.ColumnCount = 4;
            this.tlpCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCreate.Controls.Add(this.btnPrevious, 0, 2);
            this.tlpCreate.Controls.Add(this.panelSwapperCreateUser, 0, 0);
            this.tlpCreate.Controls.Add(this.label1, 1, 1);
            this.tlpCreate.Controls.Add(this.btnFinish, 3, 2);
            this.tlpCreate.Controls.Add(this.btnShopper, 1, 2);
            this.tlpCreate.Controls.Add(this.btnBusiness, 2, 2);
            this.tlpCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCreate.Location = new System.Drawing.Point(3, 3);
            this.tlpCreate.Name = "tlpCreate";
            this.tlpCreate.RowCount = 3;
            this.tlpCreate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCreate.Size = new System.Drawing.Size(718, 293);
            this.tlpCreate.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(3, 263);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(174, 27);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelSwapperCreateUser
            // 
            this.tlpCreate.SetColumnSpan(this.panelSwapperCreateUser, 4);
            this.panelSwapperCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSwapperCreateUser.Location = new System.Drawing.Point(3, 3);
            this.panelSwapperCreateUser.Name = "panelSwapperCreateUser";
            this.panelSwapperCreateUser.Size = new System.Drawing.Size(712, 237);
            this.panelSwapperCreateUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "* = Required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.AutoSize = true;
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(474, 263);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(241, 27);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnShopper
            // 
            this.btnShopper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShopper.AutoSize = true;
            this.btnShopper.Enabled = false;
            this.btnShopper.Location = new System.Drawing.Point(183, 263);
            this.btnShopper.Name = "btnShopper";
            this.btnShopper.Size = new System.Drawing.Size(141, 27);
            this.btnShopper.TabIndex = 2;
            this.btnShopper.Text = "Shopper Account";
            this.btnShopper.UseVisualStyleBackColor = true;
            this.btnShopper.Click += new System.EventHandler(this.btnShopper_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusiness.AutoSize = true;
            this.btnBusiness.Enabled = false;
            this.btnBusiness.Location = new System.Drawing.Point(330, 263);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(138, 27);
            this.btnBusiness.TabIndex = 1;
            this.btnBusiness.Text = "Business Account";
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(732, 328);
            this.tabControl1.ResumeLayout(false);
            this.tabPageExisting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageNew.ResumeLayout(false);
            this.tlpCreate.ResumeLayout(false);
            this.tlpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageExisting;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tlpCreate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnShopper;
        private System.Windows.Forms.Button btnFinish;
        private Navigation.PanelSwapper panelSwapperCreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginError;
    }
}
