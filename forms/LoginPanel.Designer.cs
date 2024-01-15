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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.usernameBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.passwordBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Location = new System.Drawing.Point(29, 12);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(239, 232);
            this.xtraUserControl1.TabIndex = 0;
            this.xtraUserControl1.Load += new System.EventHandler(this.xtraUserControl1_Load);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(137, 18);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.usernameBox.Properties.Appearance.Options.UseFont = true;
            this.usernameBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usernameBox.Properties.ContextImageOptions.Image")));
            this.usernameBox.Properties.MaxLength = 10;
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
            this.passwordBox.Properties.MaxLength = 10;
            this.passwordBox.Properties.UseSystemPasswordChar = true;
            this.passwordBox.Size = new System.Drawing.Size(131, 26);
            this.passwordBox.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "v1.0";
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.loginButton.Location = new System.Drawing.Point(85, 103);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(131, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.xtraUserControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "LoginPanel";
            this.Text = "TX Raporlayıcı";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.TextEdit usernameBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal DevExpress.XtraEditors.TextEdit passwordBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton loginButton;
    }
}