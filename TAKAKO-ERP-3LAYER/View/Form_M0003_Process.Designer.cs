namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0003_Process
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCol_ProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProcessNameEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProcessNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProcessNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_isOutsource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridCol_ProcessGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 159);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl.Size = new System.Drawing.Size(1198, 440);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCol_ProcessID,
            this.gridCol_ProcessNameEN,
            this.gridCol_ProcessNameVN,
            this.gridCol_ProcessNameJP,
            this.gridCol_Point,
            this.gridCol_Memo,
            this.gridCol_isOutsource,
            this.gridCol_ProcessGroup,
            this.gridCol_InActive});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // gridCol_ProcessID
            // 
            this.gridCol_ProcessID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessID.Caption = "Công đoạn";
            this.gridCol_ProcessID.FieldName = "ProcessID";
            this.gridCol_ProcessID.Name = "gridCol_ProcessID";
            this.gridCol_ProcessID.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessID.Visible = true;
            this.gridCol_ProcessID.VisibleIndex = 0;
            this.gridCol_ProcessID.Width = 65;
            // 
            // gridCol_ProcessNameEN
            // 
            this.gridCol_ProcessNameEN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessNameEN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessNameEN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessNameEN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessNameEN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessNameEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessNameEN.Caption = "Tên (Tiếng Anh)";
            this.gridCol_ProcessNameEN.FieldName = "ProcessNameEN";
            this.gridCol_ProcessNameEN.Name = "gridCol_ProcessNameEN";
            this.gridCol_ProcessNameEN.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessNameEN.Visible = true;
            this.gridCol_ProcessNameEN.VisibleIndex = 1;
            this.gridCol_ProcessNameEN.Width = 130;
            // 
            // gridCol_ProcessNameVN
            // 
            this.gridCol_ProcessNameVN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessNameVN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessNameVN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessNameVN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessNameVN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessNameVN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessNameVN.Caption = "Tên (Tiếng Việt)";
            this.gridCol_ProcessNameVN.FieldName = "ProcessNameEN";
            this.gridCol_ProcessNameVN.Name = "gridCol_ProcessNameVN";
            this.gridCol_ProcessNameVN.OptionsColumn.AllowShowHide = false;
            this.gridCol_ProcessNameVN.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessNameVN.Width = 130;
            // 
            // gridCol_ProcessNameJP
            // 
            this.gridCol_ProcessNameJP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessNameJP.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessNameJP.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessNameJP.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessNameJP.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessNameJP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessNameJP.Caption = "Tên (Tiếng Nhật)";
            this.gridCol_ProcessNameJP.FieldName = "ProcessNameJP";
            this.gridCol_ProcessNameJP.Name = "gridCol_ProcessNameJP";
            this.gridCol_ProcessNameJP.OptionsColumn.AllowShowHide = false;
            this.gridCol_ProcessNameJP.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessNameJP.Width = 130;
            // 
            // gridCol_Point
            // 
            this.gridCol_Point.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Point.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Point.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Point.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Point.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Point.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Point.Caption = "Điểm";
            this.gridCol_Point.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_Point.FieldName = "Point";
            this.gridCol_Point.Name = "gridCol_Point";
            this.gridCol_Point.OptionsColumn.FixedWidth = true;
            this.gridCol_Point.Visible = true;
            this.gridCol_Point.VisibleIndex = 3;
            this.gridCol_Point.Width = 65;
            // 
            // gridCol_Memo
            // 
            this.gridCol_Memo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Memo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Memo.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Memo.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Memo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Memo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Memo.Caption = "Ghi chú";
            this.gridCol_Memo.FieldName = "Memo";
            this.gridCol_Memo.Name = "gridCol_Memo";
            this.gridCol_Memo.OptionsColumn.FixedWidth = true;
            this.gridCol_Memo.Visible = true;
            this.gridCol_Memo.VisibleIndex = 4;
            this.gridCol_Memo.Width = 150;
            // 
            // gridCol_isOutsource
            // 
            this.gridCol_isOutsource.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_isOutsource.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_isOutsource.AppearanceHeader.Options.UseFont = true;
            this.gridCol_isOutsource.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_isOutsource.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_isOutsource.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_isOutsource.Caption = "Gia công ngoài";
            this.gridCol_isOutsource.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridCol_isOutsource.FieldName = "isOutsource";
            this.gridCol_isOutsource.Name = "gridCol_isOutsource";
            this.gridCol_isOutsource.OptionsColumn.FixedWidth = true;
            this.gridCol_isOutsource.Visible = true;
            this.gridCol_isOutsource.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridCol_ProcessGroup
            // 
            this.gridCol_ProcessGroup.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessGroup.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessGroup.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessGroup.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessGroup.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessGroup.Caption = "Nhóm công đoạn";
            this.gridCol_ProcessGroup.FieldName = "ProcessGroup";
            this.gridCol_ProcessGroup.Name = "gridCol_ProcessGroup";
            this.gridCol_ProcessGroup.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessGroup.Visible = true;
            this.gridCol_ProcessGroup.VisibleIndex = 2;
            this.gridCol_ProcessGroup.Width = 130;
            // 
            // gridCol_InActive
            // 
            this.gridCol_InActive.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_InActive.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InActive.AppearanceHeader.Options.UseFont = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_InActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_InActive.Caption = "Ngưng sử dụng";
            this.gridCol_InActive.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridCol_InActive.FieldName = "InActive";
            this.gridCol_InActive.Name = "gridCol_InActive";
            this.gridCol_InActive.OptionsColumn.FixedWidth = true;
            this.gridCol_InActive.Visible = true;
            this.gridCol_InActive.VisibleIndex = 6;
            this.gridCol_InActive.Width = 90;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1198, 159);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm mới";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 577);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1198, 22);
            // 
            // Form_M0003_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0003_Process";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CÔNG ĐOẠN CHI TIẾT";
            this.Load += new System.EventHandler(this.Form_M0003_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessNameEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Point;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Memo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_isOutsource;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}