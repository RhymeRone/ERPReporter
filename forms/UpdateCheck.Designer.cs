namespace NebimV3Reporter.forms
{
    partial class UpdateCheck
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Version = new DevExpress.XtraEditors.LabelControl();
            this.CheckControl = new DevExpress.XtraEditors.CheckEdit();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CheckControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sürümünüz :";
            // 
            // Version
            // 
            this.Version.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Version.Appearance.Options.UseFont = true;
            this.Version.Location = new System.Drawing.Point(143, 37);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(45, 19);
            this.Version.TabIndex = 1;
            this.Version.Text = "v1.0.0";
            // 
            // CheckControl
            // 
            this.CheckControl.Location = new System.Drawing.Point(45, 79);
            this.CheckControl.Name = "CheckControl";
            this.CheckControl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.CheckControl.Properties.Appearance.Options.UseFont = true;
            this.CheckControl.Properties.Appearance.Options.UseTextOptions = true;
            this.CheckControl.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CheckControl.Properties.Caption = "Program Başlatılırken Güncelleme Kontrolü Yap";
            this.CheckControl.Size = new System.Drawing.Size(273, 20);
            this.CheckControl.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Appearance.Options.UseFont = true;
            this.updateButton.Location = new System.Drawing.Point(123, 119);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 44);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Güncelle";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 191);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.CheckControl);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.labelControl1);
            this.Name = "UpdateCheck";
            this.Text = "Güncelleme Kontrolü";
            ((System.ComponentModel.ISupportInitialize)(this.CheckControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckControl;
        public DevExpress.XtraEditors.LabelControl Version;
        private DevExpress.XtraEditors.SimpleButton updateButton;
    }
}