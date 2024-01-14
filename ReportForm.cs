using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NebimV3Reporter
{
    public partial class ReportForm : RibbonForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ConnectionTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var loginInfo = new SqlHelper.SqlLoginInfo("reportadmin", "19339a20", "V3_EVKURAN");
            var connection = new SqlHelper.Connection(loginInfo);
            XtraMessageBox.Show(connection.Connect());
            connection.Disconnect();
        }
    }
}
