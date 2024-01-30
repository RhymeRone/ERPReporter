using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using System.Runtime.InteropServices;

namespace NebimV3Reporter.forms
{
    public partial class UpdateCheck : DevExpress.XtraEditors.XtraForm
    {
        public UpdateCheck()
        {
            InitializeComponent();
            CheckControl.Checked = Program.properties.UpdateAutomatically;
            Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CheckControl.CheckedChanged += (sender, args) =>
            {
                Program.properties.UpdateAutomatically = CheckControl.Checked;
                Program.properties.Save();
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Program.CheckUpdate();
        }
    }
}