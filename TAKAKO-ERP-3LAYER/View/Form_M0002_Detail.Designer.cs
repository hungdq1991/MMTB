namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0002_Detail
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label_NameEN = new DevExpress.XtraEditors.LabelControl();
            this.label_NameVN = new DevExpress.XtraEditors.LabelControl();
            this.txt_NameVN = new DevExpress.XtraEditors.TextEdit();
            this.label_NameJP = new DevExpress.XtraEditors.LabelControl();
            this.txt_NameJP = new DevExpress.XtraEditors.TextEdit();
            this.label_Group1 = new DevExpress.XtraEditors.LabelControl();
            this.label_Group2 = new DevExpress.XtraEditors.LabelControl();
            this.label_ClassifyID = new DevExpress.XtraEditors.LabelControl();
            this.label_ApplyDate = new DevExpress.XtraEditors.LabelControl();
            this.txt_ClassifyDesc = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.date_ApplyDate = new DevExpress.XtraEditors.DateEdit();
            this.look_ClassifyID = new DevExpress.XtraEditors.LookUpEdit();
            this.sLook_NameEN = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sLook_Group1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sLook_Group2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_InActive = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassifyDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.look_ClassifyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_NameEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_Group1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_Group2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).BeginInit();
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
            this.bbiSave,
            this.bbiReset,
            this.bbiNew,
            this.bbiClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 26;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(462, 157);
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
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Save";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.Image = global::TAKAKO_ERP_3LAYER.Properties.Resources.save_32x32;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.ImageOptions.LargeImage = global::TAKAKO_ERP_3LAYER.Properties.Resources.save_32x32;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.Image = global::TAKAKO_ERP_3LAYER.Properties.Resources.reset_16x16;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.ImageOptions.LargeImage = global::TAKAKO_ERP_3LAYER.Properties.Resources.reset_32x32;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.Id = 22;
            this.bbiSave.ImageOptions.Image = global::TAKAKO_ERP_3LAYER.Properties.Resources.save_16x161;
            this.bbiSave.ImageOptions.LargeImage = global::TAKAKO_ERP_3LAYER.Properties.Resources.save_32x321;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSave_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 23;
            this.bbiReset.ImageOptions.Image = global::TAKAKO_ERP_3LAYER.Properties.Resources.reset_16x161;
            this.bbiReset.ImageOptions.LargeImage = global::TAKAKO_ERP_3LAYER.Properties.Resources.reset_32x321;
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm mới";
            this.bbiNew.Id = 24;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 25;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 464);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(462, 22);
            // 
            // label_NameEN
            // 
            this.label_NameEN.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_NameEN.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_NameEN.Appearance.Options.UseFont = true;
            this.label_NameEN.Appearance.Options.UseForeColor = true;
            this.label_NameEN.Location = new System.Drawing.Point(11, 166);
            this.label_NameEN.Name = "label_NameEN";
            this.label_NameEN.Size = new System.Drawing.Size(90, 13);
            this.label_NameEN.TabIndex = 4;
            this.label_NameEN.Text = "Tên (Tiếng Anh)";
            // 
            // label_NameVN
            // 
            this.label_NameVN.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_NameVN.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_NameVN.Appearance.Options.UseFont = true;
            this.label_NameVN.Appearance.Options.UseForeColor = true;
            this.label_NameVN.Location = new System.Drawing.Point(11, 204);
            this.label_NameVN.Name = "label_NameVN";
            this.label_NameVN.Size = new System.Drawing.Size(90, 13);
            this.label_NameVN.TabIndex = 4;
            this.label_NameVN.Text = "Tên (Tiếng Việt)";
            // 
            // txt_NameVN
            // 
            this.txt_NameVN.Enabled = false;
            this.txt_NameVN.EnterMoveNextControl = true;
            this.txt_NameVN.Location = new System.Drawing.Point(119, 203);
            this.txt_NameVN.Name = "txt_NameVN";
            this.txt_NameVN.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_NameVN.Properties.Appearance.Options.UseForeColor = true;
            this.txt_NameVN.Size = new System.Drawing.Size(300, 20);
            this.txt_NameVN.TabIndex = 1;
            // 
            // label_NameJP
            // 
            this.label_NameJP.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_NameJP.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_NameJP.Appearance.Options.UseFont = true;
            this.label_NameJP.Appearance.Options.UseForeColor = true;
            this.label_NameJP.Location = new System.Drawing.Point(11, 242);
            this.label_NameJP.Name = "label_NameJP";
            this.label_NameJP.Size = new System.Drawing.Size(94, 13);
            this.label_NameJP.TabIndex = 4;
            this.label_NameJP.Text = "Tên (Tiếng Nhật)";
            // 
            // txt_NameJP
            // 
            this.txt_NameJP.Enabled = false;
            this.txt_NameJP.EnterMoveNextControl = true;
            this.txt_NameJP.Location = new System.Drawing.Point(119, 241);
            this.txt_NameJP.Name = "txt_NameJP";
            this.txt_NameJP.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_NameJP.Properties.Appearance.Options.UseForeColor = true;
            this.txt_NameJP.Size = new System.Drawing.Size(300, 20);
            this.txt_NameJP.TabIndex = 2;
            // 
            // label_Group1
            // 
            this.label_Group1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_Group1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_Group1.Appearance.Options.UseFont = true;
            this.label_Group1.Appearance.Options.UseForeColor = true;
            this.label_Group1.Location = new System.Drawing.Point(11, 280);
            this.label_Group1.Name = "label_Group1";
            this.label_Group1.Size = new System.Drawing.Size(66, 13);
            this.label_Group1.TabIndex = 4;
            this.label_Group1.Text = "Nhóm trung";
            // 
            // label_Group2
            // 
            this.label_Group2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_Group2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_Group2.Appearance.Options.UseFont = true;
            this.label_Group2.Appearance.Options.UseForeColor = true;
            this.label_Group2.Location = new System.Drawing.Point(11, 318);
            this.label_Group2.Name = "label_Group2";
            this.label_Group2.Size = new System.Drawing.Size(52, 13);
            this.label_Group2.TabIndex = 4;
            this.label_Group2.Text = "Nhóm đại";
            // 
            // label_ClassifyID
            // 
            this.label_ClassifyID.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_ClassifyID.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_ClassifyID.Appearance.Options.UseFont = true;
            this.label_ClassifyID.Appearance.Options.UseForeColor = true;
            this.label_ClassifyID.Location = new System.Drawing.Point(11, 356);
            this.label_ClassifyID.Name = "label_ClassifyID";
            this.label_ClassifyID.Size = new System.Drawing.Size(51, 13);
            this.label_ClassifyID.TabIndex = 4;
            this.label_ClassifyID.Text = "Phân loại";
            // 
            // label_ApplyDate
            // 
            this.label_ApplyDate.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_ApplyDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label_ApplyDate.Appearance.Options.UseFont = true;
            this.label_ApplyDate.Appearance.Options.UseForeColor = true;
            this.label_ApplyDate.Location = new System.Drawing.Point(11, 394);
            this.label_ApplyDate.Name = "label_ApplyDate";
            this.label_ApplyDate.Size = new System.Drawing.Size(75, 13);
            this.label_ApplyDate.TabIndex = 4;
            this.label_ApplyDate.Text = "Ngày hiệu lực";
            // 
            // txt_ClassifyDesc
            // 
            this.txt_ClassifyDesc.Enabled = false;
            this.txt_ClassifyDesc.Location = new System.Drawing.Point(182, 355);
            this.txt_ClassifyDesc.Name = "txt_ClassifyDesc";
            this.txt_ClassifyDesc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_ClassifyDesc.Properties.Appearance.Options.UseForeColor = true;
            this.txt_ClassifyDesc.Size = new System.Drawing.Size(237, 20);
            this.txt_ClassifyDesc.TabIndex = 5;
            this.txt_ClassifyDesc.TabStop = false;
            // 
            // date_ApplyDate
            // 
            this.date_ApplyDate.EditValue = null;
            this.date_ApplyDate.Location = new System.Drawing.Point(119, 393);
            this.date_ApplyDate.MenuManager = this.ribbonControl;
            this.date_ApplyDate.Name = "date_ApplyDate";
            this.date_ApplyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ApplyDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ApplyDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_ApplyDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ApplyDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_ApplyDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ApplyDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_ApplyDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ApplyDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_ApplyDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ApplyDate.Size = new System.Drawing.Size(300, 20);
            this.date_ApplyDate.TabIndex = 6;
            // 
            // look_ClassifyID
            // 
            this.look_ClassifyID.Location = new System.Drawing.Point(119, 355);
            this.look_ClassifyID.MenuManager = this.ribbonControl;
            this.look_ClassifyID.Name = "look_ClassifyID";
            this.look_ClassifyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.look_ClassifyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.look_ClassifyID.Size = new System.Drawing.Size(57, 20);
            this.look_ClassifyID.TabIndex = 5;
            this.look_ClassifyID.Validated += new System.EventHandler(this.Look_ClassifyID_Validated);
            // 
            // sLook_NameEN
            // 
            this.sLook_NameEN.Location = new System.Drawing.Point(119, 165);
            this.sLook_NameEN.MenuManager = this.ribbonControl;
            this.sLook_NameEN.Name = "sLook_NameEN";
            this.sLook_NameEN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLook_NameEN.Properties.PopupView = this.searchLookUpEdit1View;
            this.sLook_NameEN.Size = new System.Drawing.Size(300, 20);
            this.sLook_NameEN.TabIndex = 12;
            this.sLook_NameEN.Validated += new System.EventHandler(this.sLook_NameEN_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // sLook_Group1
            // 
            this.sLook_Group1.Location = new System.Drawing.Point(119, 279);
            this.sLook_Group1.MenuManager = this.ribbonControl;
            this.sLook_Group1.Name = "sLook_Group1";
            this.sLook_Group1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLook_Group1.Properties.PopupView = this.gridView1;
            this.sLook_Group1.Size = new System.Drawing.Size(300, 20);
            this.sLook_Group1.TabIndex = 13;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // sLook_Group2
            // 
            this.sLook_Group2.Location = new System.Drawing.Point(119, 317);
            this.sLook_Group2.MenuManager = this.ribbonControl;
            this.sLook_Group2.Name = "sLook_Group2";
            this.sLook_Group2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLook_Group2.Properties.PopupView = this.searchLookUpEdit2View;
            this.sLook_Group2.Size = new System.Drawing.Size(300, 20);
            this.sLook_Group2.TabIndex = 14;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 432);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ngưng sử dụng";
            // 
            // cbx_InActive
            // 
            this.cbx_InActive.Location = new System.Drawing.Point(119, 431);
            this.cbx_InActive.MenuManager = this.ribbonControl;
            this.cbx_InActive.Name = "cbx_InActive";
            this.cbx_InActive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_InActive.Size = new System.Drawing.Size(100, 20);
            this.cbx_InActive.TabIndex = 17;
            // 
            // Form_M0002_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 486);
            this.Controls.Add(this.cbx_InActive);
            this.Controls.Add(this.sLook_Group2);
            this.Controls.Add(this.sLook_Group1);
            this.Controls.Add(this.sLook_NameEN);
            this.Controls.Add(this.look_ClassifyID);
            this.Controls.Add(this.date_ApplyDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_ApplyDate);
            this.Controls.Add(this.txt_ClassifyDesc);
            this.Controls.Add(this.label_ClassifyID);
            this.Controls.Add(this.label_Group2);
            this.Controls.Add(this.label_Group1);
            this.Controls.Add(this.txt_NameJP);
            this.Controls.Add(this.label_NameJP);
            this.Controls.Add(this.txt_NameVN);
            this.Controls.Add(this.label_NameVN);
            this.Controls.Add(this.label_NameEN);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0002_Detail";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PHÂN NHÓM";
            this.Load += new System.EventHandler(this.Form_M0002_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClassifyDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.look_ClassifyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_NameEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_Group1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_Group2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.LabelControl label_NameEN;
        private DevExpress.XtraEditors.LabelControl label_NameVN;
        private DevExpress.XtraEditors.TextEdit txt_NameVN;
        private DevExpress.XtraEditors.LabelControl label_NameJP;
        private DevExpress.XtraEditors.TextEdit txt_NameJP;
        private DevExpress.XtraEditors.LabelControl label_Group1;
        private DevExpress.XtraEditors.LabelControl label_Group2;
        private DevExpress.XtraEditors.LabelControl label_ClassifyID;
        private DevExpress.XtraEditors.LabelControl label_ApplyDate;
        private DevExpress.XtraEditors.TextEdit txt_ClassifyDesc;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.DateEdit date_ApplyDate;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.LookUpEdit look_ClassifyID;
        private DevExpress.XtraEditors.SearchLookUpEdit sLook_NameEN;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit sLook_Group1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit sLook_Group2;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_InActive;
    }
}