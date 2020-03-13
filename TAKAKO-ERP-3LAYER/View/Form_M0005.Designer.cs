namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0005
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridCol_ACCDoc_Disposal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ACCDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DocNo_Disposal = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridCol_ACCCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_NameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Maker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Group2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Series = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_OrgCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ProDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_Lifetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ConfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_StartDeprDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_EndDeprDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DocNo_Confirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InvNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_SupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_SupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_DisposalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_InstDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCol_ControlDept = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCol_ACCDoc_Disposal
            // 
            this.gridCol_ACCDoc_Disposal.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCDoc_Disposal.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ACCDoc_Disposal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ACCDoc_Disposal.Caption = "Số chứng từ thanh lý (ACC)";
            this.gridCol_ACCDoc_Disposal.FieldName = "ACCDoc_Disposal";
            this.gridCol_ACCDoc_Disposal.Name = "gridCol_ACCDoc_Disposal";
            this.gridCol_ACCDoc_Disposal.Visible = true;
            this.gridCol_ACCDoc_Disposal.VisibleIndex = 20;
            // 
            // gridCol_ACCDoc
            // 
            this.gridCol_ACCDoc.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCDoc.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ACCDoc.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ACCDoc.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCDoc.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ACCDoc.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ACCDoc.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ACCDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ACCDoc.Caption = "Số chứng từ nghiệm thu (ACC)";
            this.gridCol_ACCDoc.FieldName = "ACCDoc";
            this.gridCol_ACCDoc.Name = "gridCol_ACCDoc";
            this.gridCol_ACCDoc.OptionsColumn.AllowEdit = false;
            this.gridCol_ACCDoc.OptionsColumn.FixedWidth = true;
            this.gridCol_ACCDoc.Visible = true;
            this.gridCol_ACCDoc.VisibleIndex = 15;
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
            this.gridCol_DocNo_Disposal.Name = "gridCol_DocNo_Disposal";
            this.gridCol_DocNo_Disposal.OptionsColumn.AllowEdit = false;
            this.gridCol_DocNo_Disposal.OptionsColumn.FixedWidth = true;
            this.gridCol_DocNo_Disposal.Visible = true;
            this.gridCol_DocNo_Disposal.VisibleIndex = 19;
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
            this.bbiRefresh,
            this.barCheckItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(892, 157);
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
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
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
            this.barCheckItem1.AllowRightClickInMenu = false;
            this.barCheckItem1.Caption = "Đã thanh lý";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.barCheckItem1.CloseSubMenuOnClick = false;
            this.barCheckItem1.Id = 20;
            this.barCheckItem1.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barCheckItem1.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barCheckItem1.ItemAppearance.Pressed.BackColor = System.Drawing.Color.White;
            this.barCheckItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCheckItem1.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.White;
            this.barCheckItem1.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barCheckItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barCheckItem1.ItemAppearance.Pressed.Options.UseForeColor = true;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckItem1, true);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 485);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(892, 22);
            // 
            // gridControl
            // 
            this.gridControl.AllowDrop = true;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 157);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(892, 328);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCol_Code,
            this.gridCol_ACCCode,
            this.gridCol_NameEN,
            this.gridCol_NameVN,
            this.gridCol_NameJP,
            this.gridCol_Maker,
            this.gridCol_Model,
            this.gridCol_Group1,
            this.gridCol_Group2,
            this.gridCol_Series,
            this.gridCol_OrgCountry,
            this.gridCol_ProDate,
            this.gridCol_Lifetime,
            this.gridCol_ConfDate,
            this.gridCol_StartDeprDate,
            this.gridCol_EndDeprDate,
            this.gridCol_DocNo_Confirm,
            this.gridCol_ACCDoc,
            this.gridCol_InvNo,
            this.gridCol_SupplierID,
            this.gridCol_SupplierName,
            this.gridCol_DocNo_Disposal,
            this.gridCol_ACCDoc_Disposal,
            this.gridCol_DisposalDate,
            this.gridCol_InstDoc,
            this.gridCol_ControlDept});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gridCol_ACCDoc_Disposal;
            gridFormatRule1.ColumnApplyTo = this.gridCol_ACCDoc_Disposal;
            gridFormatRule1.Name = "Disposal";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "StartsWith([ACCDoc_Disposal], \'FA\')";
            formatConditionRuleExpression1.PredefinedName = "Disposal";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView.FormatRules.Add(gridFormatRule1);
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
            this.gridCol_Code.OptionsColumn.AllowEdit = false;
            this.gridCol_Code.OptionsColumn.FixedWidth = true;
            this.gridCol_Code.Visible = true;
            this.gridCol_Code.VisibleIndex = 0;
            // 
            // gridCol_ACCCode
            // 
            this.gridCol_ACCCode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCCode.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ACCCode.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ACCCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ACCCode.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ACCCode.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ACCCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ACCCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ACCCode.Caption = "Mã MMTB (ACC)";
            this.gridCol_ACCCode.FieldName = "ACCcode";
            this.gridCol_ACCCode.Name = "gridCol_ACCCode";
            this.gridCol_ACCCode.OptionsColumn.AllowEdit = false;
            this.gridCol_ACCCode.OptionsColumn.FixedWidth = true;
            this.gridCol_ACCCode.Visible = true;
            this.gridCol_ACCCode.VisibleIndex = 1;
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
            this.gridCol_NameEN.Caption = "Tên (t.Anh)";
            this.gridCol_NameEN.FieldName = "NameEN";
            this.gridCol_NameEN.Name = "gridCol_NameEN";
            this.gridCol_NameEN.OptionsColumn.AllowEdit = false;
            this.gridCol_NameEN.OptionsColumn.FixedWidth = true;
            this.gridCol_NameEN.Visible = true;
            this.gridCol_NameEN.VisibleIndex = 2;
            this.gridCol_NameEN.Width = 130;
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
            this.gridCol_NameVN.Caption = "Tên (t.Việt)";
            this.gridCol_NameVN.FieldName = "NameVN";
            this.gridCol_NameVN.Name = "gridCol_NameVN";
            this.gridCol_NameVN.OptionsColumn.AllowEdit = false;
            this.gridCol_NameVN.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameVN.OptionsColumn.FixedWidth = true;
            this.gridCol_NameVN.Width = 130;
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
            this.gridCol_NameJP.Caption = "Tên (t.Nhật)";
            this.gridCol_NameJP.FieldName = "NameVN";
            this.gridCol_NameJP.Name = "gridCol_NameJP";
            this.gridCol_NameJP.OptionsColumn.AllowEdit = false;
            this.gridCol_NameJP.OptionsColumn.AllowShowHide = false;
            this.gridCol_NameJP.OptionsColumn.FixedWidth = true;
            this.gridCol_NameJP.Width = 130;
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
            this.gridCol_Maker.OptionsColumn.AllowEdit = false;
            this.gridCol_Maker.OptionsColumn.FixedWidth = true;
            this.gridCol_Maker.Visible = true;
            this.gridCol_Maker.VisibleIndex = 3;
            this.gridCol_Maker.Width = 130;
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
            this.gridCol_Model.OptionsColumn.AllowEdit = false;
            this.gridCol_Model.OptionsColumn.FixedWidth = true;
            this.gridCol_Model.Visible = true;
            this.gridCol_Model.VisibleIndex = 4;
            this.gridCol_Model.Width = 130;
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
            this.gridCol_Group1.Width = 130;
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
            this.gridCol_Group2.Width = 130;
            // 
            // gridCol_Series
            // 
            this.gridCol_Series.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Series.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_Series.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_Series.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_Series.AppearanceHeader.Options.UseFont = true;
            this.gridCol_Series.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_Series.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_Series.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_Series.Caption = "Số series";
            this.gridCol_Series.FieldName = "Series";
            this.gridCol_Series.Name = "gridCol_Series";
            this.gridCol_Series.OptionsColumn.AllowEdit = false;
            this.gridCol_Series.OptionsColumn.FixedWidth = true;
            this.gridCol_Series.Visible = true;
            this.gridCol_Series.VisibleIndex = 7;
            // 
            // gridCol_OrgCountry
            // 
            this.gridCol_OrgCountry.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_OrgCountry.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_OrgCountry.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_OrgCountry.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_OrgCountry.AppearanceHeader.Options.UseFont = true;
            this.gridCol_OrgCountry.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_OrgCountry.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_OrgCountry.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_OrgCountry.Caption = "Xuất xứ";
            this.gridCol_OrgCountry.FieldName = "OrgCountry";
            this.gridCol_OrgCountry.Name = "gridCol_OrgCountry";
            this.gridCol_OrgCountry.OptionsColumn.AllowEdit = false;
            this.gridCol_OrgCountry.OptionsColumn.FixedWidth = true;
            this.gridCol_OrgCountry.Visible = true;
            this.gridCol_OrgCountry.VisibleIndex = 8;
            this.gridCol_OrgCountry.Width = 60;
            // 
            // gridCol_ProDate
            // 
            this.gridCol_ProDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProDate.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ProDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_ProDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ProDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ProDate.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ProDate.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ProDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ProDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ProDate.Caption = "Ngày SX";
            this.gridCol_ProDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridCol_ProDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridCol_ProDate.FieldName = "ProDate";
            this.gridCol_ProDate.Name = "gridCol_ProDate";
            this.gridCol_ProDate.OptionsColumn.AllowEdit = false;
            this.gridCol_ProDate.OptionsColumn.FixedWidth = true;
            this.gridCol_ProDate.Visible = true;
            this.gridCol_ProDate.VisibleIndex = 9;
            this.gridCol_ProDate.Width = 90;
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
            this.gridCol_Lifetime.Caption = "Tuổi thọ (năm)";
            this.gridCol_Lifetime.DisplayFormat.FormatString = "#";
            this.gridCol_Lifetime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCol_Lifetime.FieldName = "Lifetime";
            this.gridCol_Lifetime.Name = "gridCol_Lifetime";
            this.gridCol_Lifetime.OptionsColumn.AllowEdit = false;
            this.gridCol_Lifetime.OptionsColumn.FixedWidth = true;
            this.gridCol_Lifetime.Visible = true;
            this.gridCol_Lifetime.VisibleIndex = 10;
            this.gridCol_Lifetime.Width = 60;
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
            this.gridCol_ConfDate.OptionsColumn.AllowEdit = false;
            this.gridCol_ConfDate.OptionsColumn.FixedWidth = true;
            this.gridCol_ConfDate.Visible = true;
            this.gridCol_ConfDate.VisibleIndex = 11;
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
            this.gridCol_StartDeprDate.OptionsColumn.AllowEdit = false;
            this.gridCol_StartDeprDate.OptionsColumn.FixedWidth = true;
            this.gridCol_StartDeprDate.Visible = true;
            this.gridCol_StartDeprDate.VisibleIndex = 12;
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
            this.gridCol_EndDeprDate.OptionsColumn.AllowEdit = false;
            this.gridCol_EndDeprDate.OptionsColumn.FixedWidth = true;
            this.gridCol_EndDeprDate.Visible = true;
            this.gridCol_EndDeprDate.VisibleIndex = 13;
            this.gridCol_EndDeprDate.Width = 90;
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
            this.gridCol_DocNo_Confirm.OptionsColumn.AllowEdit = false;
            this.gridCol_DocNo_Confirm.OptionsColumn.FixedWidth = true;
            this.gridCol_DocNo_Confirm.Visible = true;
            this.gridCol_DocNo_Confirm.VisibleIndex = 14;
            // 
            // gridCol_InvNo
            // 
            this.gridCol_InvNo.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InvNo.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_InvNo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_InvNo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InvNo.AppearanceHeader.Options.UseFont = true;
            this.gridCol_InvNo.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_InvNo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_InvNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_InvNo.Caption = "Số hóa đơn";
            this.gridCol_InvNo.FieldName = "InvNo";
            this.gridCol_InvNo.Name = "gridCol_InvNo";
            this.gridCol_InvNo.OptionsColumn.AllowEdit = false;
            this.gridCol_InvNo.OptionsColumn.FixedWidth = true;
            this.gridCol_InvNo.Visible = true;
            this.gridCol_InvNo.VisibleIndex = 16;
            // 
            // gridCol_SupplierID
            // 
            this.gridCol_SupplierID.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierID.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_SupplierID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_SupplierID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseFont = true;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_SupplierID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_SupplierID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_SupplierID.Caption = "Mã số NCC";
            this.gridCol_SupplierID.FieldName = "SupplierID";
            this.gridCol_SupplierID.Name = "gridCol_SupplierID";
            this.gridCol_SupplierID.OptionsColumn.AllowEdit = false;
            this.gridCol_SupplierID.OptionsColumn.FixedWidth = true;
            this.gridCol_SupplierID.Visible = true;
            this.gridCol_SupplierID.VisibleIndex = 17;
            // 
            // gridCol_SupplierName
            // 
            this.gridCol_SupplierName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierName.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_SupplierName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_SupplierName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_SupplierName.AppearanceHeader.Options.UseFont = true;
            this.gridCol_SupplierName.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_SupplierName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_SupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_SupplierName.Caption = "Tên NCC";
            this.gridCol_SupplierName.FieldName = "SupplierName";
            this.gridCol_SupplierName.Name = "gridCol_SupplierName";
            this.gridCol_SupplierName.OptionsColumn.AllowEdit = false;
            this.gridCol_SupplierName.OptionsColumn.FixedWidth = true;
            this.gridCol_SupplierName.Visible = true;
            this.gridCol_SupplierName.VisibleIndex = 18;
            this.gridCol_SupplierName.Width = 130;
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
            this.gridCol_DisposalDate.Visible = true;
            this.gridCol_DisposalDate.VisibleIndex = 21;
            this.gridCol_DisposalDate.Width = 90;
            // 
            // gridCol_InstDoc
            // 
            this.gridCol_InstDoc.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InstDoc.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_InstDoc.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_InstDoc.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_InstDoc.AppearanceHeader.Options.UseFont = true;
            this.gridCol_InstDoc.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_InstDoc.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_InstDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_InstDoc.Caption = "Bản hướng dẫn";
            this.gridCol_InstDoc.FieldName = "InstDoc";
            this.gridCol_InstDoc.Name = "gridCol_InstDoc";
            this.gridCol_InstDoc.Visible = true;
            this.gridCol_InstDoc.VisibleIndex = 22;
            this.gridCol_InstDoc.Width = 120;
            // 
            // gridCol_ControlDept
            // 
            this.gridCol_ControlDept.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ControlDept.AppearanceCell.Options.UseForeColor = true;
            this.gridCol_ControlDept.AppearanceCell.Options.UseTextOptions = true;
            this.gridCol_ControlDept.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ControlDept.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridCol_ControlDept.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseFont = true;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseForeColor = true;
            this.gridCol_ControlDept.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCol_ControlDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCol_ControlDept.Caption = "Bộ phận quản lý";
            this.gridCol_ControlDept.FieldName = "ControlDept";
            this.gridCol_ControlDept.Name = "gridCol_ControlDept";
            this.gridCol_ControlDept.Visible = true;
            this.gridCol_ControlDept.VisibleIndex = 23;
            // 
            // Form_M0005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(892, 507);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0005";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Danh sách MMTB";
            this.Load += new System.EventHandler(this.Form_M0005_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ACCCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameVN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_NameJP;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Maker;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Model;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Series;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_OrgCountry;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ProDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Lifetime;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ConfDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_StartDeprDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_EndDeprDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DocNo_Confirm;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ACCDoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InvNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_SupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_SupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DocNo_Disposal;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ACCDoc_Disposal;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_DisposalDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_InstDoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_ControlDept;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCol_Group2;
    }
}