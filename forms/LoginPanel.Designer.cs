namespace NebimV3Reporter.forms
{
    partial class LoginPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.usernameBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.passwordBox = new DevExpress.XtraEditors.TextEdit();
            this.versionLabel = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.databaseListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rememberCheck = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Location = new System.Drawing.Point(29, 12);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(239, 232);
            this.xtraUserControl1.TabIndex = 0;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(137, 18);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.usernameBox.Properties.Appearance.Options.UseFont = true;
            this.usernameBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usernameBox.Properties.ContextImageOptions.Image")));
            this.usernameBox.Properties.MaxLength = 15;
            this.usernameBox.Size = new System.Drawing.Size(131, 26);
            this.usernameBox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adı : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Şifre : ";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(137, 54);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.passwordBox.Properties.Appearance.Options.UseFont = true;
            this.passwordBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("passwordBox.Properties.ContextImageOptions.Image")));
            this.passwordBox.Properties.MaxLength = 15;
            this.passwordBox.Properties.UseSystemPasswordChar = true;
            this.passwordBox.Size = new System.Drawing.Size(131, 26);
            this.passwordBox.TabIndex = 2;
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(260, 183);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "v1.0.0.0";
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.ImageOptions.Image")));
            this.loginButton.Location = new System.Drawing.Point(101, 126);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(131, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rememberCheck
            // 
            this.rememberCheck.Location = new System.Drawing.Point(137, 90);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 14F);
            this.rememberCheck.Properties.Appearance.Options.UseFont = true;
            this.rememberCheck.Properties.Caption = "";
            this.rememberCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rememberCheck.Size = new System.Drawing.Size(20, 20);
            this.rememberCheck.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Beni Hatırla : ";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 208);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.rememberCheck);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.xtraUserControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "LoginPanel";
            this.Text = "TX Raporlayıcı";
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.TextEdit usernameBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal DevExpress.XtraEditors.TextEdit passwordBox;
        private DevExpress.XtraEditors.LabelControl versionLabel;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private System.Windows.Forms.BindingSource databaseListBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.CheckEdit rememberCheck;
    }
}