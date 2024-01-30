namespace NebimV3Reporter.forms
{
    partial class DatabaseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseList));
            this.databaseListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.chooseDatabaseBtn = new DevExpress.XtraEditors.SimpleButton();
            this.settingsdbBTN = new DevExpress.XtraEditors.SimpleButton();
            this.getdbListBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.databaseListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseListBox
            // 
            this.databaseListBox.Location = new System.Drawing.Point(21, 59);
            this.databaseListBox.Name = "databaseListBox";
            this.databaseListBox.Size = new System.Drawing.Size(214, 169);
            this.databaseListBox.TabIndex = 3;
            // 
            // chooseDatabaseBtn
            // 
            this.chooseDatabaseBtn.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDatabaseBtn.Appearance.Options.UseFont = true;
            this.chooseDatabaseBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chooseDatabaseBtn.ImageOptions.Image")));
            this.chooseDatabaseBtn.Location = new System.Drawing.Point(21, 234);
            this.chooseDatabaseBtn.Name = "chooseDatabaseBtn";
            this.chooseDatabaseBtn.Size = new System.Drawing.Size(214, 40);
            this.chooseDatabaseBtn.TabIndex = 4;
            this.chooseDatabaseBtn.Text = "Veritabanı Seç";
            this.chooseDatabaseBtn.Click += new System.EventHandler(this.chooseDatabaseBtn_Click);
            // 
            // settingsdbBTN
            // 
            this.settingsdbBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settingsdbBTN.ImageOptions.Image")));
            this.settingsdbBTN.Location = new System.Drawing.Point(21, 13);
            this.settingsdbBTN.Name = "settingsdbBTN";
            this.settingsdbBTN.Size = new System.Drawing.Size(42, 40);
            this.settingsdbBTN.TabIndex = 1;
            this.settingsdbBTN.Click += new System.EventHandler(this.settingsdbBTN_Click);
            // 
            // getdbListBTN
            // 
            this.getdbListBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("getdbListBTN.ImageOptions.Image")));
            this.getdbListBTN.Location = new System.Drawing.Point(69, 13);
            this.getdbListBTN.Name = "getdbListBTN";
            this.getdbListBTN.Size = new System.Drawing.Size(166, 40);
            this.getdbListBTN.TabIndex = 2;
            this.getdbListBTN.Text = "Veritabanlarını Getir";
            this.getdbListBTN.Click += new System.EventHandler(this.getdbListBTN_Click);
            // 
            // DatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 286);
            this.Controls.Add(this.getdbListBTN);
            this.Controls.Add(this.settingsdbBTN);
            this.Controls.Add(this.chooseDatabaseBtn);
            this.Controls.Add(this.databaseListBox);
            this.Name = "DatabaseList";
            this.Text = "Veritabanları";
            ((System.ComponentModel.ISupportInitialize)(this.databaseListBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl databaseListBox;
        private DevExpress.XtraEditors.SimpleButton chooseDatabaseBtn;
        private DevExpress.XtraEditors.SimpleButton settingsdbBTN;
        private DevExpress.XtraEditors.SimpleButton getdbListBTN;
    }
}