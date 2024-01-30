namespace NebimV3Reporter.forms
{
    partial class DatabaseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettings));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.passwordBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usernameBox = new DevExpress.XtraEditors.TextEdit();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sqlConnectBox = new DevExpress.XtraEditors.TextEdit();
            this.connectTestBTN = new DevExpress.XtraEditors.SimpleButton();
            this.saveSettingsBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlConnectBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Şifre : ";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(154, 99);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.passwordBox.Properties.Appearance.Options.UseFont = true;
            this.passwordBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("passwordBox.Properties.ContextImageOptions.Image")));
            this.passwordBox.Properties.MaxLength = 20;
            this.passwordBox.Properties.UseSystemPasswordChar = true;
            this.passwordBox.Size = new System.Drawing.Size(173, 26);
            this.passwordBox.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Kullanıcı Adı : ";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(154, 63);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.usernameBox.Properties.Appearance.Options.UseFont = true;
            this.usernameBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usernameBox.Properties.ContextImageOptions.Image")));
            this.usernameBox.Properties.MaxLength = 20;
            this.usernameBox.Size = new System.Drawing.Size(173, 26);
            this.usernameBox.TabIndex = 2;
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Location = new System.Drawing.Point(31, 57);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(239, 83);
            this.xtraUserControl1.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 19);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Sunucu Adresi : ";
            // 
            // sqlConnectBox
            // 
            this.sqlConnectBox.Location = new System.Drawing.Point(154, 25);
            this.sqlConnectBox.Name = "sqlConnectBox";
            this.sqlConnectBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.sqlConnectBox.Properties.Appearance.Options.UseFont = true;
            this.sqlConnectBox.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("textEdit1.Properties.ContextImageOptions.Image")));
            this.sqlConnectBox.Properties.MaxLength = 20;
            this.sqlConnectBox.Size = new System.Drawing.Size(173, 26);
            this.sqlConnectBox.TabIndex = 1;
            // 
            // connectTestBTN
            // 
            this.connectTestBTN.Appearance.Font = new System.Drawing.Font("Calibri", 13F);
            this.connectTestBTN.Appearance.Options.UseFont = true;
            this.connectTestBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.ImageOptions.Image")));
            this.connectTestBTN.Location = new System.Drawing.Point(30, 137);
            this.connectTestBTN.Name = "connectTestBTN";
            this.connectTestBTN.Size = new System.Drawing.Size(147, 40);
            this.connectTestBTN.TabIndex = 4;
            this.connectTestBTN.Text = "Bağlantı Testi";
            this.connectTestBTN.Click += new System.EventHandler(this.connectTestBTN_Click);
            // 
            // saveSettingsBTN
            // 
            this.saveSettingsBTN.Appearance.Font = new System.Drawing.Font("Calibri", 13F);
            this.saveSettingsBTN.Appearance.Options.UseFont = true;
            this.saveSettingsBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.saveSettingsBTN.Location = new System.Drawing.Point(184, 137);
            this.saveSettingsBTN.Name = "saveSettingsBTN";
            this.saveSettingsBTN.Size = new System.Drawing.Size(143, 40);
            this.saveSettingsBTN.TabIndex = 5;
            this.saveSettingsBTN.Text = "Kaydet";
            this.saveSettingsBTN.Click += new System.EventHandler(this.saveSettingsBTN_Click);
            // 
            // DatabaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 204);
            this.Controls.Add(this.saveSettingsBTN);
            this.Controls.Add(this.connectTestBTN);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.sqlConnectBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.xtraUserControl1);
            this.Name = "DatabaseSettings";
            this.Text = "Sunucu Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlConnectBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton connectTestBTN;
        private DevExpress.XtraEditors.SimpleButton saveSettingsBTN;
        public DevExpress.XtraEditors.TextEdit passwordBox;
        public DevExpress.XtraEditors.TextEdit usernameBox;
        public DevExpress.XtraEditors.TextEdit sqlConnectBox;
    }
}