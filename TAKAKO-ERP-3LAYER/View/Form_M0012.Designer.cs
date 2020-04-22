namespace MMTB.View
{
    partial class Form_M0012
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
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bCheck_InActive = new DevExpress.XtraBars.BarCheckItem();
            this.bCheck_Duplicate = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCol_SessionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Maker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_MinimumQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Lifetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_PurUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_UnitMulDiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_CnvtQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_PriceRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Cury = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_EffDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_SupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_PurCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_WH1Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_WH2Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ApplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsiUser = new DevExpress.XtraBars.BarStaticItem();
            this.bbiCheckDup = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bCheck_InActive,
            this.bCheck_Duplicate});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 24;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(987, 159);
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
            this.bbiNew.Caption = "Thêm mới/Chỉnh sửa";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Chỉnh sửa";
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
            // bCheck_InActive
            // 
            this.bCheck_InActive.Caption = "Ngưng sử dụng";
            this.bCheck_InActive.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.bCheck_InActive.Id = 20;
            this.bCheck_InActive.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bCheck_InActive.ItemAppearance.Normal.Options.UseBackColor = true;
            this.bCheck_InActive.Name = "bCheck_InActive";
            this.bCheck_InActive.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.BCheck_InActive_CheckedChanged);
            // 
            // bCheck_Duplicate
            // 
            this.bCheck_Duplicate.Caption = "Mã trùng          ";
            this.bCheck_Duplicate.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.bCheck_Duplicate.Id = 23;
            this.bCheck_Duplicate.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bCheck_Duplicate.ItemAppearance.Normal.Options.UseBackColor = true;
            this.bCheck_Duplicate.Name = "bCheck_Duplicate";
            this.bCheck_Duplicate.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.BCheck_Duplicate_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bCheck_InActive);
            this.ribbonPageGroup2.ItemLinks.Add(this.bCheck_Duplicate);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lọc thông tin";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiUser);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 577);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(987, 22);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 159);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(987, 418);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCol_SessionID,
            this.gridCol_ItemCode,
            this.gridCol_NameEN,
            this.gridCol_NameVN,
            this.gridCol_NameJP,
            this.gridCol_Group1,
            this.gridCol_Group2,
            this.gridCol_Maker,
            this.gridCol_MinimumQty,
            this.gridCol_Lifetime,
            this.gridCol_Unit,
            this.gridCol_PurUnit,
            this.gridCol_UnitMulDiv,
            this.gridCol_CnvtQty,
            this.gridCol_PriceRef,
            this.gridCol_Cury,
            this.gridCol_EffDate,
            this.gridCol_SupplierID,
            this.gridCol_Supplier,
            this.gridCol_PurCode,
            this.gridCol_WH1Code,
            this.gridCol_WH2Code,
            this.gridCol_ApplyDate,
            this.gridCol_InActive,
            this.gridCol_Memo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridCol_SessionID
            // 
            this.gridCol_SessionID.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SessionID.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_SessionID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_SessionID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SessionID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_SessionID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_SessionID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_SessionID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_SessionID.Caption = "Nhóm hàng";
            this.gridCol_SessionID.FieldName = "SessionID";
            this.gridCol_SessionID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_SessionID.Name = "gridCol_SessionID";
            this.gridCol_SessionID.Visible = true;
            this.gridCol_SessionID.VisibleIndex = 0;
            this.gridCol_SessionID.Width = 60;
            // 
            // gridCol_ItemCode
            // 
            this.gridCol_ItemCode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ItemCode.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ItemCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ItemCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ItemCode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ItemCode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ItemCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ItemCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ItemCode.Caption = "Mã hàng";
            this.gridCol_ItemCode.FieldName = "ItemCode";
            this.gridCol_ItemCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_ItemCode.Name = "gridCol_ItemCode";
            this.gridCol_ItemCode.Visible = true;
            this.gridCol_ItemCode.VisibleIndex = 1;
            this.gridCol_ItemCode.Width = 120;
            // 
            // gridCol_NameEN
            // 
            this.gridCol_NameEN.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameEN.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_NameEN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_NameEN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameEN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_NameEN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_NameEN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_NameEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_NameEN.Caption = "Tên (Tiếng Anh)";
            this.gridCol_NameEN.FieldName = "NameEN";
            this.gridCol_NameEN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_NameEN.Name = "gridCol_NameEN";
            this.gridCol_NameEN.Visible = true;
            this.gridCol_NameEN.VisibleIndex = 2;
            this.gridCol_NameEN.Width = 120;
            // 
            // gridCol_NameVN
            // 
            this.gridCol_NameVN.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameVN.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_NameVN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_NameVN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameVN.AppearanceHeader.Options.UseFont = true;
            this.gridCol_NameVN.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_NameVN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_NameVN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_NameVN.Caption = "Tên (Tiếng Việt)";
            this.gridCol_NameVN.FieldName = "NameVN";
            this.gridCol_NameVN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_NameVN.Name = "gridCol_NameVN";
            this.gridCol_NameVN.Visible = true;
            this.gridCol_NameVN.VisibleIndex = 3;
            this.gridCol_NameVN.Width = 120;
            // 
            // gridCol_NameJP
            // 
            this.gridCol_NameJP.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameJP.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_NameJP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_NameJP.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameJP.AppearanceHeader.Options.UseFont = true;
            this.gridCol_NameJP.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_NameJP.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_NameJP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_NameJP.Caption = "Tên (Tiếng Nhật)";
            this.gridCol_NameJP.FieldName = "NameJP";
            this.gridCol_NameJP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_NameJP.Name = "gridCol_NameJP";
            this.gridCol_NameJP.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameJP.Width = 120;
            // 
            // gridCol_Group1
            // 
            this.gridCol_Group1.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Group1.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Group1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Group1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Group1.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Group1.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Group1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Group1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Group1.Caption = "Nhóm trung";
            this.gridCol_Group1.FieldName = "Group1";
            this.gridCol_Group1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_Group1.Name = "gridCol_Group1";
            this.gridCol_Group1.Visible = true;
            this.gridCol_Group1.VisibleIndex = 4;
            this.gridCol_Group1.Width = 120;
            // 
            // gridCol_Group2
            // 
            this.gridCol_Group2.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Group2.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Group2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Group2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Group2.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Group2.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Group2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Group2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Group2.Caption = "Nhóm đại";
            this.gridCol_Group2.FieldName = "Group2";
            this.gridCol_Group2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_Group2.Name = "gridCol_Group2";
            this.gridCol_Group2.Visible = true;
            this.gridCol_Group2.VisibleIndex = 5;
            this.gridCol_Group2.Width = 120;
            // 
            // gridCol_Maker
            // 
            this.gridCol_Maker.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Maker.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Maker.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Maker.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Maker.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Maker.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Maker.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Maker.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Maker.Caption = "Maker";
            this.gridCol_Maker.FieldName = "Maker";
            this.gridCol_Maker.Name = "gridCol_Maker";
            this.gridCol_Maker.Visible = true;
            this.gridCol_Maker.VisibleIndex = 6;
            this.gridCol_Maker.Width = 120;
            // 
            // gridCol_MinimumQty
            // 
            this.gridCol_MinimumQty.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_MinimumQty.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_MinimumQty.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_MinimumQty.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_MinimumQty.AppearanceHeader.Options.UseFont = true;
            this.gridCol_MinimumQty.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_MinimumQty.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_MinimumQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_MinimumQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridCol_MinimumQty.Caption = "Tồn kho tối thiểu";
            this.gridCol_MinimumQty.DisplayFormat.FormatString = "#,###";
            this.gridCol_MinimumQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_MinimumQty.FieldName = "MinimumQty";
            this.gridCol_MinimumQty.Name = "gridCol_MinimumQty";
            this.gridCol_MinimumQty.Visible = true;
            this.gridCol_MinimumQty.VisibleIndex = 8;
            // 
            // gridCol_Lifetime
            // 
            this.gridCol_Lifetime.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Lifetime.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Lifetime.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Lifetime.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Lifetime.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Lifetime.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Lifetime.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Lifetime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Lifetime.Caption = "Tuổi thọ (tháng)";
            this.gridCol_Lifetime.DisplayFormat.FormatString = "#,###";
            this.gridCol_Lifetime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_Lifetime.FieldName = "Lifetime";
            this.gridCol_Lifetime.Name = "gridCol_Lifetime";
            this.gridCol_Lifetime.Visible = true;
            this.gridCol_Lifetime.VisibleIndex = 7;
            // 
            // gridCol_Unit
            // 
            this.gridCol_Unit.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Unit.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Unit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Unit.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Unit.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Unit.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Unit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Unit.Caption = "Đvt";
            this.gridCol_Unit.FieldName = "Unit";
            this.gridCol_Unit.Name = "gridCol_Unit";
            this.gridCol_Unit.Visible = true;
            this.gridCol_Unit.VisibleIndex = 9;
            this.gridCol_Unit.Width = 60;
            // 
            // gridCol_PurUnit
            // 
            this.gridCol_PurUnit.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PurUnit.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_PurUnit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_PurUnit.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PurUnit.AppearanceHeader.Options.UseFont = true;
            this.gridCol_PurUnit.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_PurUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_PurUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_PurUnit.Caption = "Đvt (mua)";
            this.gridCol_PurUnit.FieldName = "EF_PurUnit";
            this.gridCol_PurUnit.Name = "gridCol_PurUnit";
            this.gridCol_PurUnit.Visible = true;
            this.gridCol_PurUnit.VisibleIndex = 10;
            this.gridCol_PurUnit.Width = 60;
            // 
            // gridCol_UnitMulDiv
            // 
            this.gridCol_UnitMulDiv.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_UnitMulDiv.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_UnitMulDiv.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_UnitMulDiv.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_UnitMulDiv.AppearanceHeader.Options.UseFont = true;
            this.gridCol_UnitMulDiv.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_UnitMulDiv.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_UnitMulDiv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_UnitMulDiv.Caption = "Quy đổi";
            this.gridCol_UnitMulDiv.FieldName = "UnitMultDiv";
            this.gridCol_UnitMulDiv.Name = "gridCol_UnitMulDiv";
            this.gridCol_UnitMulDiv.Visible = true;
            this.gridCol_UnitMulDiv.VisibleIndex = 11;
            this.gridCol_UnitMulDiv.Width = 60;
            // 
            // gridCol_CnvtQty
            // 
            this.gridCol_CnvtQty.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_CnvtQty.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_CnvtQty.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_CnvtQty.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_CnvtQty.AppearanceHeader.Options.UseFont = true;
            this.gridCol_CnvtQty.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_CnvtQty.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_CnvtQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_CnvtQty.Caption = "Hệ số quy đổi (M:Multi/D:Div)";
            this.gridCol_CnvtQty.DisplayFormat.FormatString = "#,0";
            this.gridCol_CnvtQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_CnvtQty.FieldName = "CnvFact";
            this.gridCol_CnvtQty.Name = "gridCol_CnvtQty";
            this.gridCol_CnvtQty.Visible = true;
            this.gridCol_CnvtQty.VisibleIndex = 12;
            this.gridCol_CnvtQty.Width = 60;
            // 
            // gridCol_PriceRef
            // 
            this.gridCol_PriceRef.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PriceRef.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_PriceRef.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_PriceRef.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PriceRef.AppearanceHeader.Options.UseFont = true;
            this.gridCol_PriceRef.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_PriceRef.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_PriceRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_PriceRef.Caption = "Giá tham khảo";
            this.gridCol_PriceRef.DisplayFormat.FormatString = "#,###.##";
            this.gridCol_PriceRef.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_PriceRef.FieldName = "Price";
            this.gridCol_PriceRef.Name = "gridCol_PriceRef";
            this.gridCol_PriceRef.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridCol_PriceRef.Visible = true;
            this.gridCol_PriceRef.VisibleIndex = 13;
            // 
            // gridCol_Cury
            // 
            this.gridCol_Cury.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Cury.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Cury.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_Cury.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Cury.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_Cury.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Cury.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Cury.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Cury.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Cury.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Cury.Caption = "Loại tiền";
            this.gridCol_Cury.FieldName = "Cury";
            this.gridCol_Cury.Name = "gridCol_Cury";
            this.gridCol_Cury.Visible = true;
            this.gridCol_Cury.VisibleIndex = 14;
            // 
            // gridCol_EffDate
            // 
            this.gridCol_EffDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_EffDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_EffDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_EffDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_EffDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_EffDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_EffDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_EffDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_EffDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_EffDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_EffDate.Caption = "Ngày hiệu lực giá";
            this.gridCol_EffDate.FieldName = "EffDate";
            this.gridCol_EffDate.Name = "gridCol_EffDate";
            this.gridCol_EffDate.Visible = true;
            this.gridCol_EffDate.VisibleIndex = 15;
            // 
            // gridCol_SupplierID
            // 
            this.gridCol_SupplierID.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierID.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_SupplierID.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_SupplierID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_SupplierID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_SupplierID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_SupplierID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_SupplierID.Caption = "Mã số NCC";
            this.gridCol_SupplierID.FieldName = "EF_VendID";
            this.gridCol_SupplierID.Name = "gridCol_SupplierID";
            this.gridCol_SupplierID.Visible = true;
            this.gridCol_SupplierID.VisibleIndex = 16;
            // 
            // gridCol_Supplier
            // 
            this.gridCol_Supplier.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Supplier.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Supplier.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridCol_Supplier.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Supplier.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Supplier.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Supplier.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Supplier.Caption = "Nhà cung cấp";
            this.gridCol_Supplier.FieldName = "EF_VendName";
            this.gridCol_Supplier.Name = "gridCol_Supplier";
            this.gridCol_Supplier.Visible = true;
            this.gridCol_Supplier.VisibleIndex = 17;
            // 
            // gridCol_PurCode
            // 
            this.gridCol_PurCode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PurCode.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_PurCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_PurCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_PurCode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_PurCode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_PurCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_PurCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_PurCode.Caption = "Mã mua hàng";
            this.gridCol_PurCode.FieldName = "PurCode";
            this.gridCol_PurCode.Name = "gridCol_PurCode";
            this.gridCol_PurCode.Visible = true;
            this.gridCol_PurCode.VisibleIndex = 18;
            this.gridCol_PurCode.Width = 120;
            // 
            // gridCol_WH1Code
            // 
            this.gridCol_WH1Code.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_WH1Code.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_WH1Code.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_WH1Code.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_WH1Code.AppearanceHeader.Options.UseFont = true;
            this.gridCol_WH1Code.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_WH1Code.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_WH1Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_WH1Code.Caption = "Mã nhập kho TVC1";
            this.gridCol_WH1Code.FieldName = "WH1Code";
            this.gridCol_WH1Code.Name = "gridCol_WH1Code";
            this.gridCol_WH1Code.Visible = true;
            this.gridCol_WH1Code.VisibleIndex = 19;
            this.gridCol_WH1Code.Width = 120;
            // 
            // gridCol_WH2Code
            // 
            this.gridCol_WH2Code.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_WH2Code.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_WH2Code.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_WH2Code.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_WH2Code.AppearanceHeader.Options.UseFont = true;
            this.gridCol_WH2Code.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_WH2Code.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_WH2Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_WH2Code.Caption = "Mã nhập kho TVC2";
            this.gridCol_WH2Code.FieldName = "WH2Code";
            this.gridCol_WH2Code.Name = "gridCol_WH2Code";
            this.gridCol_WH2Code.Visible = true;
            this.gridCol_WH2Code.VisibleIndex = 20;
            this.gridCol_WH2Code.Width = 120;
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
            this.gridCol_ApplyDate.FieldName = "ApplyDate";
            this.gridCol_ApplyDate.Name = "gridCol_ApplyDate";
            this.gridCol_ApplyDate.Visible = true;
            this.gridCol_ApplyDate.VisibleIndex = 21;
            this.gridCol_ApplyDate.Width = 90;
            // 
            // gridCol_InActive
            // 
            this.gridCol_InActive.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InActive.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_InActive.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_InActive.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InActive.AppearanceHeader.Options.UseFont = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_InActive.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_InActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_InActive.Caption = "Ngưng sử dụng";
            this.gridCol_InActive.FieldName = "InActive";
            this.gridCol_InActive.Name = "gridCol_InActive";
            this.gridCol_InActive.Visible = true;
            this.gridCol_InActive.VisibleIndex = 22;
            this.gridCol_InActive.Width = 90;
            // 
            // gridCol_Memo
            // 
            this.gridCol_Memo.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Memo.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Memo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Memo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Memo.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Memo.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Memo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Memo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Memo.Caption = "Ghi chú";
            this.gridCol_Memo.FieldName = "Memo";
            this.gridCol_Memo.Name = "gridCol_Memo";
            this.gridCol_Memo.Visible = true;
            this.gridCol_Memo.VisibleIndex = 23;
            this.gridCol_Memo.Width = 150;
            // 
            // bsiUser
            // 
            this.bsiUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiUser.Caption = "barStaticItem1";
            this.bsiUser.Id = 21;
            this.bsiUser.Name = "bsiUser";
            // 
            // bbiCheckDup
            // 
            this.bbiCheckDup.Caption = "Mã trùng          ";
            this.bbiCheckDup.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.bbiCheckDup.Id = 21;
            this.bbiCheckDup.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bbiCheckDup.ItemAppearance.Normal.Options.UseBackColor = true;
            this.bbiCheckDup.Name = "bbiCheckDup";
            // 
            // Form_M0012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 599);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0012";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DANH MỤC DẦU, PIN, LINH KIỆN MMTB";
            this.Load += new System.EventHandler(this.Form_M0012_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameVN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameJP;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_SessionID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Maker;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_PurUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_UnitMulDiv;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_CnvtQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_PriceRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_MinimumQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Lifetime;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_PurCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_WH1Code;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_WH2Code;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ApplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Memo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Cury;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_EffDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_SupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Supplier;
        private DevExpress.XtraBars.BarCheckItem bCheck_InActive;
        private DevExpress.XtraBars.BarCheckItem bCheck_Duplicate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarCheckItem bbiCheckDup;
        private DevExpress.XtraBars.BarStaticItem bsiUser;
    }
}