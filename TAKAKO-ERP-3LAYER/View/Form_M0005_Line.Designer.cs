namespace MMTB.View
{
    partial class Form_M0005_Line
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridCol_DisposalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
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
            this.gridCol_ControlDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_UsedDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_LineCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_GroupLineACC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DocNo_Confirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ConfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_StartDeprDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_EndDeprDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DocNo_Move = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_MoveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DocNo_Disposal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCol_DisposalDate
            // 
            this.gridCol_DisposalDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DisposalDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_DisposalDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_DisposalDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_DisposalDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_DisposalDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DisposalDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_DisposalDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_DisposalDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_DisposalDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_DisposalDate.Caption = "Ngày thanh lý";
            this.gridCol_DisposalDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_DisposalDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_DisposalDate.FieldName = "DisposalDate";
            this.gridCol_DisposalDate.Name = "gridCol_DisposalDate";
            this.gridCol_DisposalDate.OptionsColumn.AllowShowHide = false;
            this.gridCol_DisposalDate.OptionsColumn.FixedWidth = true;
            this.gridCol_DisposalDate.Visible = true;
            this.gridCol_DisposalDate.VisibleIndex = 19;
            this.gridCol_DisposalDate.Width = 90;
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
            this.barCheckItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(955, 159);
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
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Đã thanh lý";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.barCheckItem1.Id = 20;
            this.barCheckItem1.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barCheckItem1.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barCheckItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.barCheckItem1.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barCheckItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barCheckItem1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarCheckItem1_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckItem1);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 490);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(955, 22);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 159);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(955, 331);
            this.gridControl.TabIndex = 10;
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
            this.gridCol_ControlDept,
            this.gridCol_UsedDept,
            this.gridCol_LineCode,
            this.gridCol_GroupLineACC,
            this.gridCol_ProcessID,
            this.gridCol_DocNo_Confirm,
            this.gridCol_ConfDate,
            this.gridCol_StartDeprDate,
            this.gridCol_EndDeprDate,
            this.gridCol_DocNo_Move,
            this.gridCol_MoveDate,
            this.gridCol_DocNo_Disposal,
            this.gridCol_DisposalDate});
            gridFormatRule2.Column = this.gridCol_DisposalDate;
            gridFormatRule2.ColumnApplyTo = this.gridCol_DisposalDate;
            gridFormatRule2.Name = "ThanhLy";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "Contains([DisposalDate], \'/\')";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridView.FormatRules.Add(gridFormatRule2);
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
            this.gridCol_Code.Name = "gridCol_Code";
            this.gridCol_Code.OptionsColumn.AllowShowHide = false;
            this.gridCol_Code.OptionsColumn.FixedWidth = true;
            this.gridCol_Code.Visible = true;
            this.gridCol_Code.VisibleIndex = 0;
            this.gridCol_Code.Width = 120;
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
            this.gridCol_ACCcode.Name = "gridCol_ACCcode";
            this.gridCol_ACCcode.OptionsColumn.AllowShowHide = false;
            this.gridCol_ACCcode.OptionsColumn.FixedWidth = true;
            this.gridCol_ACCcode.Visible = true;
            this.gridCol_ACCcode.VisibleIndex = 1;
            this.gridCol_ACCcode.Width = 120;
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
            this.gridCol_NameEN.Name = "gridCol_NameEN";
            this.gridCol_NameEN.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameEN.OptionsColumn.FixedWidth = true;
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
            this.gridCol_NameVN.Name = "gridCol_NameVN";
            this.gridCol_NameVN.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameVN.OptionsColumn.FixedWidth = true;
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
            this.gridCol_NameJP.Name = "gridCol_NameJP";
            this.gridCol_NameJP.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameJP.OptionsColumn.FixedWidth = true;
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
            this.gridCol_Maker.Name = "gridCol_Maker";
            this.gridCol_Maker.OptionsColumn.AllowShowHide = false;
            this.gridCol_Maker.OptionsColumn.FixedWidth = true;
            this.gridCol_Maker.Visible = true;
            this.gridCol_Maker.VisibleIndex = 3;
            this.gridCol_Maker.Width = 120;
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
            this.gridCol_Model.Name = "gridCol_Model";
            this.gridCol_Model.OptionsColumn.AllowShowHide = false;
            this.gridCol_Model.OptionsColumn.FixedWidth = true;
            this.gridCol_Model.Visible = true;
            this.gridCol_Model.VisibleIndex = 4;
            this.gridCol_Model.Width = 120;
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
            this.gridCol_Group1.OptionsColumn.AllowShowHide = false;
            this.gridCol_Group1.OptionsColumn.FixedWidth = true;
            this.gridCol_Group1.Visible = true;
            this.gridCol_Group1.VisibleIndex = 5;
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
            this.gridCol_Group2.OptionsColumn.AllowShowHide = false;
            this.gridCol_Group2.OptionsColumn.FixedWidth = true;
            this.gridCol_Group2.Visible = true;
            this.gridCol_Group2.VisibleIndex = 6;
            this.gridCol_Group2.Width = 120;
            // 
            // gridCol_ControlDept
            // 
            this.gridCol_ControlDept.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ControlDept.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ControlDept.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ControlDept.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ControlDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ControlDept.Caption = "Bộ phận quản lý";
            this.gridCol_ControlDept.FieldName = "ControlDept";
            this.gridCol_ControlDept.Name = "gridCol_ControlDept";
            this.gridCol_ControlDept.OptionsColumn.AllowShowHide = false;
            this.gridCol_ControlDept.OptionsColumn.FixedWidth = true;
            this.gridCol_ControlDept.Visible = true;
            this.gridCol_ControlDept.VisibleIndex = 7;
            // 
            // gridCol_UsedDept
            // 
            this.gridCol_UsedDept.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_UsedDept.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_UsedDept.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_UsedDept.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_UsedDept.AppearanceHeader.Options.UseFont = true;
            this.gridCol_UsedDept.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_UsedDept.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_UsedDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_UsedDept.Caption = "Bộ phận sử dụng";
            this.gridCol_UsedDept.FieldName = "UsedDept";
            this.gridCol_UsedDept.Name = "gridCol_UsedDept";
            this.gridCol_UsedDept.OptionsColumn.AllowShowHide = false;
            this.gridCol_UsedDept.OptionsColumn.FixedWidth = true;
            this.gridCol_UsedDept.Visible = true;
            this.gridCol_UsedDept.VisibleIndex = 8;
            // 
            // gridCol_LineCode
            // 
            this.gridCol_LineCode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineCode.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_LineCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_LineCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_LineCode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_LineCode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_LineCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_LineCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_LineCode.Caption = "Mã line";
            this.gridCol_LineCode.FieldName = "LineCode";
            this.gridCol_LineCode.Name = "gridCol_LineCode";
            this.gridCol_LineCode.OptionsColumn.AllowShowHide = false;
            this.gridCol_LineCode.OptionsColumn.FixedWidth = true;
            this.gridCol_LineCode.Visible = true;
            this.gridCol_LineCode.VisibleIndex = 11;
            this.gridCol_LineCode.Width = 90;
            // 
            // gridCol_GroupLineACC
            // 
            this.gridCol_GroupLineACC.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_GroupLineACC.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_GroupLineACC.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_GroupLineACC.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseFont = true;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_GroupLineACC.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_GroupLineACC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_GroupLineACC.Caption = "Nhóm line ACC";
            this.gridCol_GroupLineACC.FieldName = "GroupLineACC";
            this.gridCol_GroupLineACC.Name = "gridCol_GroupLineACC";
            this.gridCol_GroupLineACC.OptionsColumn.AllowShowHide = false;
            this.gridCol_GroupLineACC.OptionsColumn.FixedWidth = true;
            this.gridCol_GroupLineACC.Visible = true;
            this.gridCol_GroupLineACC.VisibleIndex = 9;
            // 
            // gridCol_ProcessID
            // 
            this.gridCol_ProcessID.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessID.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ProcessID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProcessID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProcessID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProcessID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProcessID.Caption = "Công đoạn";
            this.gridCol_ProcessID.FieldName = "ProcessID";
            this.gridCol_ProcessID.Name = "gridCol_ProcessID";
            this.gridCol_ProcessID.OptionsColumn.AllowShowHide = false;
            this.gridCol_ProcessID.OptionsColumn.FixedWidth = true;
            this.gridCol_ProcessID.Visible = true;
            this.gridCol_ProcessID.VisibleIndex = 10;
            this.gridCol_ProcessID.Width = 65;
            // 
            // gridCol_DocNo_Confirm
            // 
            this.gridCol_DocNo_Confirm.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Confirm.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_DocNo_Confirm.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_DocNo_Confirm.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Confirm.AppearanceHeader.Options.UseFont = true;
            this.gridCol_DocNo_Confirm.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_DocNo_Confirm.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_DocNo_Confirm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_DocNo_Confirm.Caption = "Số chứng từ nghiệm thu";
            this.gridCol_DocNo_Confirm.FieldName = "DocNo_Confirm";
            this.gridCol_DocNo_Confirm.Name = "gridCol_DocNo_Confirm";
            this.gridCol_DocNo_Confirm.OptionsColumn.AllowShowHide = false;
            this.gridCol_DocNo_Confirm.OptionsColumn.FixedWidth = true;
            this.gridCol_DocNo_Confirm.Visible = true;
            this.gridCol_DocNo_Confirm.VisibleIndex = 12;
            this.gridCol_DocNo_Confirm.Width = 90;
            // 
            // gridCol_ConfDate
            // 
            this.gridCol_ConfDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ConfDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ConfDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_ConfDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ConfDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ConfDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ConfDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ConfDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ConfDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ConfDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ConfDate.Caption = "Ngày nghiệm thu";
            this.gridCol_ConfDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_ConfDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_ConfDate.FieldName = "ConfDate";
            this.gridCol_ConfDate.Name = "gridCol_ConfDate";
            this.gridCol_ConfDate.OptionsColumn.AllowShowHide = false;
            this.gridCol_ConfDate.OptionsColumn.FixedWidth = true;
            this.gridCol_ConfDate.Visible = true;
            this.gridCol_ConfDate.VisibleIndex = 13;
            this.gridCol_ConfDate.Width = 90;
            // 
            // gridCol_StartDeprDate
            // 
            this.gridCol_StartDeprDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_StartDeprDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_StartDeprDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_StartDeprDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_StartDeprDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_StartDeprDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_StartDeprDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_StartDeprDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_StartDeprDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_StartDeprDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_StartDeprDate.Caption = "Ngày bắt đầu khấu hao";
            this.gridCol_StartDeprDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_StartDeprDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_StartDeprDate.FieldName = "StartDeprDate";
            this.gridCol_StartDeprDate.Name = "gridCol_StartDeprDate";
            this.gridCol_StartDeprDate.OptionsColumn.AllowShowHide = false;
            this.gridCol_StartDeprDate.OptionsColumn.FixedWidth = true;
            this.gridCol_StartDeprDate.Visible = true;
            this.gridCol_StartDeprDate.VisibleIndex = 14;
            this.gridCol_StartDeprDate.Width = 90;
            // 
            // gridCol_EndDeprDate
            // 
            this.gridCol_EndDeprDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_EndDeprDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_EndDeprDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_EndDeprDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_EndDeprDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_EndDeprDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_EndDeprDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_EndDeprDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_EndDeprDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_EndDeprDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_EndDeprDate.Caption = "Ngày kết thúc khấu hao";
            this.gridCol_EndDeprDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_EndDeprDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_EndDeprDate.FieldName = "EndDeprDate";
            this.gridCol_EndDeprDate.Name = "gridCol_EndDeprDate";
            this.gridCol_EndDeprDate.OptionsColumn.AllowShowHide = false;
            this.gridCol_EndDeprDate.OptionsColumn.FixedWidth = true;
            this.gridCol_EndDeprDate.Visible = true;
            this.gridCol_EndDeprDate.VisibleIndex = 15;
            this.gridCol_EndDeprDate.Width = 90;
            // 
            // gridCol_DocNo_Move
            // 
            this.gridCol_DocNo_Move.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Move.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_DocNo_Move.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_DocNo_Move.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Move.AppearanceHeader.Options.UseFont = true;
            this.gridCol_DocNo_Move.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_DocNo_Move.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_DocNo_Move.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_DocNo_Move.Caption = "Số chứng từ di dời";
            this.gridCol_DocNo_Move.FieldName = "DocNo_Move";
            this.gridCol_DocNo_Move.Name = "gridCol_DocNo_Move";
            this.gridCol_DocNo_Move.OptionsColumn.AllowShowHide = false;
            this.gridCol_DocNo_Move.OptionsColumn.FixedWidth = true;
            this.gridCol_DocNo_Move.Visible = true;
            this.gridCol_DocNo_Move.VisibleIndex = 16;
            this.gridCol_DocNo_Move.Width = 90;
            // 
            // gridCol_MoveDate
            // 
            this.gridCol_MoveDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_MoveDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_MoveDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_MoveDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_MoveDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_MoveDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_MoveDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_MoveDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_MoveDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_MoveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_MoveDate.Caption = "Ngày di dời";
            this.gridCol_MoveDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_MoveDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_MoveDate.FieldName = "MoveDate";
            this.gridCol_MoveDate.Name = "gridCol_MoveDate";
            this.gridCol_MoveDate.OptionsColumn.AllowShowHide = false;
            this.gridCol_MoveDate.OptionsColumn.FixedWidth = true;
            this.gridCol_MoveDate.Visible = true;
            this.gridCol_MoveDate.VisibleIndex = 17;
            this.gridCol_MoveDate.Width = 90;
            // 
            // gridCol_DocNo_Disposal
            // 
            this.gridCol_DocNo_Disposal.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Disposal.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_DocNo_Disposal.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_DocNo_Disposal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_DocNo_Disposal.AppearanceHeader.Options.UseFont = true;
            this.gridCol_DocNo_Disposal.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_DocNo_Disposal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_DocNo_Disposal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_DocNo_Disposal.Caption = "Số chứng từ thanh lý";
            this.gridCol_DocNo_Disposal.FieldName = "DocNo_Disposal";
            this.gridCol_DocNo_Disposal.Name = "gridCol_DocNo_Disposal";
            this.gridCol_DocNo_Disposal.OptionsColumn.AllowShowHide = false;
            this.gridCol_DocNo_Disposal.OptionsColumn.FixedWidth = true;
            this.gridCol_DocNo_Disposal.Visible = true;
            this.gridCol_DocNo_Disposal.VisibleIndex = 18;
            this.gridCol_DocNo_Disposal.Width = 90;
            // 
            // Form_M0005_Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0005_Line";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.Form_M0009_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ControlDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_UsedDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_LineCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_GroupLineACC;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DocNo_Confirm;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ConfDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_StartDeprDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_EndDeprDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DocNo_Move;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_MoveDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DocNo_Disposal;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DisposalDate;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}