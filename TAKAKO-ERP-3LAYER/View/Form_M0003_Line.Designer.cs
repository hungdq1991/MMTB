namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0003_Line
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLoad = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCol_TVC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LineCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LineEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LineVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LineJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_GroupLineACC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProductionDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LinePoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ItemExpenseGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ApplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bbiLoad,
            this.bbiNew});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 46;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(928, 159);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
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
            this.bsiRecordsCount.ItemAppearance.Disabled.BackColor = System.Drawing.Color.Black;
            this.bsiRecordsCount.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiRecordsCount.ItemAppearance.Disabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.bsiRecordsCount.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.Black;
            this.bsiRecordsCount.ItemAppearance.Disabled.Options.UseBackColor = true;
            this.bsiRecordsCount.ItemAppearance.Disabled.Options.UseFont = true;
            this.bsiRecordsCount.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.bsiRecordsCount.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.bsiRecordsCount.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.bsiRecordsCount.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiRecordsCount.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Chỉnh sửa";
            this.bbiEdit.Id = 38;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 40;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 41;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiRefresh_ItemClick);
            // 
            // bbiLoad
            // 
            this.bbiLoad.Id = 45;
            this.bbiLoad.Name = "bbiLoad";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm mới";
            this.bbiNew.Id = 44;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Task";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 488);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(928, 22);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 43;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 159);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(928, 329);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.GridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCol_TVC,
            this.gridCol_LineCode,
            this.gridCol_LineEN,
            this.gridCol_LineVN,
            this.gridCol_LineJP,
            this.gridCol_ProcessID,
            this.gridCol_GroupLineACC,
            this.gridCol_ProductionDept,
            this.gridCol_LinePoint,
            this.gridCol_ItemExpenseGroup,
            this.gridCol_ApplyDate,
            this.gridCol_InActive,
            this.gridCol_Memo});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(586, 308, 252, 266);
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.ColumnFilterChanged += new System.EventHandler(this.GridView_ColumnFilterChanged);
            // 
            // gridCol_TVC
            // 
            this.gridCol_TVC.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_TVC.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_TVC.AppearanceHeader.Options.UseFont = true;
            this.gridCol_TVC.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_TVC.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_TVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_TVC.Caption = "TVC";
            this.gridCol_TVC.FieldName = "TVC";
            this.gridCol_TVC.Name = "gridCol_TVC";
            this.gridCol_TVC.Visible = true;
            this.gridCol_TVC.VisibleIndex = 0;
            this.gridCol_TVC.Width = 60;
            // 
            // gridCol_LineCode
            // 
            this.gridCol_LineCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_LineCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineCode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LineCode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LineCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LineCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LineCode.Caption = "Mã line";
            this.gridCol_LineCode.FieldName = "LineID";
            this.gridCol_LineCode.Name = "gridCol_LineCode";
            this.gridCol_LineCode.OptionsColumn.FixedWidth = true;
            this.gridCol_LineCode.Visible = true;
            this.gridCol_LineCode.VisibleIndex = 1;
            this.gridCol_LineCode.Width = 90;
            // 
            // gridCol_LineEN
            // 
            this.gridCol_LineEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_LineEN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineEN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LineEN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LineEN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LineEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LineEN.Caption = "Tên line (Tiếng Anh)";
            this.gridCol_LineEN.FieldName = "LineEN";
            this.gridCol_LineEN.Name = "gridCol_LineEN";
            this.gridCol_LineEN.OptionsColumn.FixedWidth = true;
            this.gridCol_LineEN.Visible = true;
            this.gridCol_LineEN.VisibleIndex = 2;
            this.gridCol_LineEN.Width = 130;
            // 
            // gridCol_LineVN
            // 
            this.gridCol_LineVN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_LineVN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineVN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LineVN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LineVN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LineVN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LineVN.Caption = "Tên line (t.Việt)";
            this.gridCol_LineVN.FieldName = "LineVN";
            this.gridCol_LineVN.Name = "gridCol_LineVN";
            this.gridCol_LineVN.OptionsColumn.AllowShowHide = false;
            this.gridCol_LineVN.OptionsColumn.FixedWidth = true;
            this.gridCol_LineVN.Width = 130;
            // 
            // gridCol_LineJP
            // 
            this.gridCol_LineJP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_LineJP.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineJP.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LineJP.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LineJP.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LineJP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LineJP.Caption = "Tên line (t.Nhật)";
            this.gridCol_LineJP.FieldName = "LineJP";
            this.gridCol_LineJP.Name = "gridCol_LineJP";
            this.gridCol_LineJP.OptionsColumn.AllowShowHide = false;
            this.gridCol_LineJP.OptionsColumn.FixedWidth = true;
            this.gridCol_LineJP.Width = 130;
            // 
            // gridCol_ProcessID
            // 
            this.gridCol_ProcessID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_ProcessID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessID.Caption = "Công đoạn";
            this.gridCol_ProcessID.FieldName = "ProcessGroup";
            this.gridCol_ProcessID.Name = "gridCol_ProcessID";
            this.gridCol_ProcessID.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessID.Visible = true;
            this.gridCol_ProcessID.VisibleIndex = 3;
            // 
            // gridCol_GroupLineACC
            // 
            this.gridCol_GroupLineACC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_GroupLineACC.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseFont = true;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_GroupLineACC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_GroupLineACC.Caption = "Nhóm line ACC";
            this.gridCol_GroupLineACC.FieldName = "GroupLineACC";
            this.gridCol_GroupLineACC.Name = "gridCol_GroupLineACC";
            this.gridCol_GroupLineACC.OptionsColumn.FixedWidth = true;
            this.gridCol_GroupLineACC.Visible = true;
            this.gridCol_GroupLineACC.VisibleIndex = 4;
            this.gridCol_GroupLineACC.Width = 90;
            // 
            // gridCol_ProductionDept
            // 
            this.gridCol_ProductionDept.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_ProductionDept.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProductionDept.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProductionDept.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProductionDept.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProductionDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProductionDept.Caption = "Bộ phận SX";
            this.gridCol_ProductionDept.FieldName = "ProductionDept";
            this.gridCol_ProductionDept.Name = "gridCol_ProductionDept";
            this.gridCol_ProductionDept.OptionsColumn.FixedWidth = true;
            this.gridCol_ProductionDept.Visible = true;
            this.gridCol_ProductionDept.VisibleIndex = 5;
            // 
            // gridCol_LinePoint
            // 
            this.gridCol_LinePoint.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_LinePoint.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LinePoint.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LinePoint.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LinePoint.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LinePoint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LinePoint.Caption = "Điểm";
            this.gridCol_LinePoint.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_LinePoint.FieldName = "Point";
            this.gridCol_LinePoint.Name = "gridCol_LinePoint";
            this.gridCol_LinePoint.OptionsColumn.FixedWidth = true;
            this.gridCol_LinePoint.Visible = true;
            this.gridCol_LinePoint.VisibleIndex = 6;
            this.gridCol_LinePoint.Width = 65;
            // 
            // gridCol_ItemExpenseGroup
            // 
            this.gridCol_ItemExpenseGroup.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_ItemExpenseGroup.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ItemExpenseGroup.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ItemExpenseGroup.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ItemExpenseGroup.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ItemExpenseGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ItemExpenseGroup.Caption = "Nhóm chi phí";
            this.gridCol_ItemExpenseGroup.FieldName = "ExpenseGroup";
            this.gridCol_ItemExpenseGroup.Name = "gridCol_ItemExpenseGroup";
            this.gridCol_ItemExpenseGroup.OptionsColumn.FixedWidth = true;
            this.gridCol_ItemExpenseGroup.Visible = true;
            this.gridCol_ItemExpenseGroup.VisibleIndex = 7;
            this.gridCol_ItemExpenseGroup.Width = 130;
            // 
            // gridCol_ApplyDate
            // 
            this.gridCol_ApplyDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ApplyDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ApplyDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_ApplyDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ApplyDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ApplyDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ApplyDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ApplyDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ApplyDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ApplyDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ApplyDate.Caption = "Ngày hiệu lực";
            this.gridCol_ApplyDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_ApplyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_ApplyDate.FieldName = "ApplyDate";
            this.gridCol_ApplyDate.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridCol_ApplyDate.Name = "gridCol_ApplyDate";
            this.gridCol_ApplyDate.Visible = true;
            this.gridCol_ApplyDate.VisibleIndex = 8;
            this.gridCol_ApplyDate.Width = 90;
            // 
            // gridCol_InActive
            // 
            this.gridCol_InActive.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_InActive.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InActive.AppearanceHeader.Options.UseFont = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_InActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_InActive.Caption = "Ngưng sử dụng";
            this.gridCol_InActive.FieldName = "InActive";
            this.gridCol_InActive.Name = "gridCol_InActive";
            this.gridCol_InActive.OptionsColumn.FixedWidth = true;
            this.gridCol_InActive.Visible = true;
            this.gridCol_InActive.VisibleIndex = 9;
            this.gridCol_InActive.Width = 90;
            // 
            // gridCol_Memo
            // 
            this.gridCol_Memo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.gridCol_Memo.VisibleIndex = 10;
            this.gridCol_Memo.Width = 150;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Delete";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "Delete";
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // Form_M0003_Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 510);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0003_Line";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DANH MỤC LINE SẢN XUẤT";
            this.Load += new System.EventHandler(this.Form_M0003_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LineCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LineEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LineVN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LineJP;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LinePoint;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Memo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_GroupLineACC;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProductionDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ItemExpenseGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InActive;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiLoad;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ApplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_TVC;
    }
}