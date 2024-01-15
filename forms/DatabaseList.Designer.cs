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
            ((System.ComponentModel.ISupportInitialize)(this.databaseListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseListBox
            // 
            this.databaseListBox.Location = new System.Drawing.Point(38, 23);
            this.databaseListBox.Name = "databaseListBox";
            this.databaseListBox.Size = new System.Drawing.Size(219, 169);
            this.databaseListBox.TabIndex = 0;
            // 
            // chooseDatabaseBtn
            // 
            this.chooseDatabaseBtn.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDatabaseBtn.Appearance.Options.UseFont = true;
            this.chooseDatabaseBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.ImageOptions.Image")));
            this.chooseDatabaseBtn.Location = new System.Drawing.Point(62, 208);
            this.chooseDatabaseBtn.Name = "chooseDatabaseBtn";
            this.chooseDatabaseBtn.Size = new System.Drawing.Size(166, 40);
            this.chooseDatabaseBtn.TabIndex = 8;
            this.chooseDatabaseBtn.Text = "Veritabanı Seç";
            this.chooseDatabaseBtn.Click += new System.EventHandler(this.chooseDatabaseBtn_Click);
            // 
            // DatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 270);
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
    }
}