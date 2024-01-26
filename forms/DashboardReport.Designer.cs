namespace NebimV3Reporter.forms
{
    partial class DashboardReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardReport));
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridView = new DevExpress.DashboardCommon.GridDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridView
            // 
            this.gridView.ColumnFilterOptions.UpdateTotals = true;
            this.gridView.ComponentName = "gridView";
            this.gridView.DataItemRepository.Clear();
            this.gridView.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.AutoFitToContents;
            this.gridView.GridOptions.EnableBandedRows = true;
            this.gridView.GridOptions.ShowVerticalLines = false;
            this.gridView.InteractivityOptions.IgnoreMasterFilters = false;
            resources.ApplyResources(this.gridView, "gridView");
            this.gridView.ShowCaption = true;
            // 
            // DashboardReport
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridView});
            dashboardLayoutItem1.DashboardItem = this.gridView;
            dashboardLayoutItem1.Weight = 50.101419878296149D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = resources.GetString("DashboardReport.Title.Text");
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        public DevExpress.DashboardCommon.GridDashboardItem gridView;
    }
}
