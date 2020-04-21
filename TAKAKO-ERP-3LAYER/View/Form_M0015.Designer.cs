namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0015
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCol_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ACCcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Maker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameVN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_PriceRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_QtyNeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Lifetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_PurCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ApplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Memo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(790, 159);
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
            this.bbiNew.Caption = "New";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
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
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 22);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 159);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(790, 418);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCol_Code,
            this.gridCol_ACCcode,
            this.gridCol_NameEN,
            this.gridCol_NameVN,
            this.gridCol_NameJP,
            this.gridCol_Maker,
            this.gridCol_Model,
            this.gridCol_Group1,
            this.gridCol_Group2,
            this.gridCol_ItemCode,
            this.gridCol_NameEN1,
            this.gridCol_NameVN1,
            this.gridCol_Unit,
            this.gridCol_PriceRef,
            this.gridCol_QtyNeed,
            this.gridCol_Lifetime,
            this.gridCol_Location,
            this.gridCol_PurCode,
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
            // gridCol_Code
            // 
            this.gridCol_Code.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Code.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Code.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Code.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Code.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Code.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Code.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Code.Caption = "Mã MMTB";
            this.gridCol_Code.FieldName = "Code";
            this.gridCol_Code.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_Code.Name = "gridCol_Code";
            this.gridCol_Code.Visible = true;
            this.gridCol_Code.VisibleIndex = 0;
            // 
            // gridCol_ACCcode
            // 
            this.gridCol_ACCcode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCcode.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ACCcode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ACCcode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCcode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ACCcode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ACCcode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ACCcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ACCcode.Caption = "Mã MMTB (ACC)";
            this.gridCol_ACCcode.FieldName = "ACCcode";
            this.gridCol_ACCcode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_ACCcode.Name = "gridCol_ACCcode";
            this.gridCol_ACCcode.Visible = true;
            this.gridCol_ACCcode.VisibleIndex = 1;
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
            this.gridCol_NameEN.Width = 95;
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
            this.gridCol_NameVN.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameVN.Visible = true;
            this.gridCol_NameVN.VisibleIndex = 3;
            this.gridCol_NameVN.Width = 98;
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
            this.gridCol_Maker.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_Maker.Name = "gridCol_Maker";
            this.gridCol_Maker.Visible = true;
            this.gridCol_Maker.VisibleIndex = 4;
            this.gridCol_Maker.Width = 92;
            // 
            // gridCol_Model
            // 
            this.gridCol_Model.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Model.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Model.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Model.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Model.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Model.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Model.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Model.Caption = "Model";
            this.gridCol_Model.FieldName = "Model";
            this.gridCol_Model.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_Model.Name = "gridCol_Model";
            this.gridCol_Model.Visible = true;
            this.gridCol_Model.VisibleIndex = 5;
            this.gridCol_Model.Width = 89;
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
            this.gridCol_Group1.Name = "gridCol_Group1";
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
            this.gridCol_Group2.Name = "gridCol_Group2";
            this.gridCol_Group2.Width = 120;
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
            this.gridCol_ItemCode.VisibleIndex = 6;
            this.gridCol_ItemCode.Width = 120;
            // 
            // gridCol_NameEN1
            // 
            this.gridCol_NameEN1.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameEN1.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_NameEN1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_NameEN1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameEN1.AppearanceHeader.Options.UseFont = true;
            this.gridCol_NameEN1.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_NameEN1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_NameEN1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_NameEN1.Caption = "Tên (t.Anh)";
            this.gridCol_NameEN1.FieldName = "NameEN1";
            this.gridCol_NameEN1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_NameEN1.Name = "gridCol_NameEN1";
            this.gridCol_NameEN1.Visible = true;
            this.gridCol_NameEN1.VisibleIndex = 7;
            this.gridCol_NameEN1.Width = 96;
            // 
            // gridCol_NameVN1
            // 
            this.gridCol_NameVN1.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameVN1.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_NameVN1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_NameVN1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_NameVN1.AppearanceHeader.Options.UseFont = true;
            this.gridCol_NameVN1.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_NameVN1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_NameVN1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_NameVN1.Caption = "Tên (t.Việt)";
            this.gridCol_NameVN1.FieldName = "NameVN1";
            this.gridCol_NameVN1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridCol_NameVN1.Name = "gridCol_NameVN1";
            this.gridCol_NameVN1.Visible = true;
            this.gridCol_NameVN1.VisibleIndex = 8;
            this.gridCol_NameVN1.Width = 99;
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
            this.gridCol_PriceRef.FieldName = "PriceRef";
            this.gridCol_PriceRef.Name = "gridCol_PriceRef";
            this.gridCol_PriceRef.Visible = true;
            this.gridCol_PriceRef.VisibleIndex = 17;
            this.gridCol_PriceRef.Width = 90;
            // 
            // gridCol_QtyNeed
            // 
            this.gridCol_QtyNeed.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_QtyNeed.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_QtyNeed.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_QtyNeed.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_QtyNeed.AppearanceHeader.Options.UseFont = true;
            this.gridCol_QtyNeed.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_QtyNeed.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_QtyNeed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_QtyNeed.Caption = "Số lượng sử dụng";
            this.gridCol_QtyNeed.FieldName = "QtyNeed";
            this.gridCol_QtyNeed.Name = "gridCol_QtyNeed";
            this.gridCol_QtyNeed.Visible = true;
            this.gridCol_QtyNeed.VisibleIndex = 10;
            this.gridCol_QtyNeed.Width = 90;
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
            this.gridCol_Lifetime.FieldName = "Lifetime";
            this.gridCol_Lifetime.Name = "gridCol_Lifetime";
            this.gridCol_Lifetime.Visible = true;
            this.gridCol_Lifetime.VisibleIndex = 11;
            this.gridCol_Lifetime.Width = 90;
            // 
            // gridCol_Location
            // 
            this.gridCol_Location.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Location.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Location.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Location.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Location.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Location.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Location.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Location.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Location.Caption = "Vị trí";
            this.gridCol_Location.FieldName = "Location";
            this.gridCol_Location.Name = "gridCol_Location";
            this.gridCol_Location.Visible = true;
            this.gridCol_Location.VisibleIndex = 12;
            this.gridCol_Location.Width = 90;
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
            this.gridCol_PurCode.VisibleIndex = 16;
            this.gridCol_PurCode.Width = 120;
            // 
            // gridCol_ApplyDate
            // 
            this.gridCol_ApplyDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ApplyDate.AppearanceCell.Options.UseForeColor = true;
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
            this.gridCol_ApplyDate.VisibleIndex = 13;
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
            this.gridCol_InActive.VisibleIndex = 14;
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
            this.gridCol_Memo.VisibleIndex = 15;
            this.gridCol_Memo.Width = 150;
            // 
            // Form_M0015
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0015";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_M0015_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Code;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ACCcode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameVN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameJP;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Maker;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Model;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_PriceRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_QtyNeed;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Lifetime;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Location;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_PurCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ApplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Memo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameEN1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameVN1;
    }
}