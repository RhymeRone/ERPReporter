using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardCommon;

namespace NebimV3Reporter.forms
{
    public partial class ReportDraft : DevExpress.XtraEditors.XtraForm
    {
        public ReportDraft(string formName, DataTable dataTable, params string[] valueBases)
        {
            InitializeComponent();
            dashboardViewer1.Dashboard = CreateDashboardReport(formName,dataTable,valueBases);
            Text = formName;
        }

        public DashboardReport CreateDashboardReport(string formName, DataTable table,params string[] valueBases)
        {
            GridColumnBase[] gridColumnArray = table.GridColumnBases(valueBases).ToArray();
            DashboardReport dashboard = new DashboardReport();
            dashboard.Title.Text = formName;
            dashboard.gridView.Columns.Clear();
            dashboard.gridView.Columns.AddRange(gridColumnArray);
           /* dashboard.gridView.SparklineArgument = new Dimension(gridColumnArray[0].ToString());
            dashboard.gridView.SparklineArgument.SortOrder = DimensionSortOrder.Descending;
            dashboard.gridView.SparklineArgument.SortMode = DimensionSortMode.Value;
            dashboard.gridView.SparklineArgument.NumericFormat.FormatType = DataItemNumericFormatType.General;
            dashboard.gridView.SparklineArgument.NumericFormat.CurrencyCultureName = "tr-TR";*/
            dashboard.gridView.DataSource = new DashboardObjectDataSource(table);
            return dashboard;
        }
    }
}