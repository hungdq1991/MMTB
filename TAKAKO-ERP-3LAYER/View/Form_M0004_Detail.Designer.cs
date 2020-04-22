namespace MMTB.View
{
    partial class Form_M0004_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_M0004_Detail));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sLook_NameEN = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NameVN = new DevExpress.XtraEditors.TextEdit();
            this.txt_NameJP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Maker = new DevExpress.XtraEditors.TextEdit();
            this.txt_Model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_InActive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Memo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_NameEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).BeginInit();
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
            this.bbiReset,
            this.bbiClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(452, 159);
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
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Lưu";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Save";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSave_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDelete_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 19;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReset.ImageOptions.SvgImage")));
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiReset_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 20;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 177);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên (Tiếng Anh)";
            // 
            // sLook_NameEN
            // 
            this.sLook_NameEN.Location = new System.Drawing.Point(104, 173);
            this.sLook_NameEN.MenuManager = this.ribbonControl;
            this.sLook_NameEN.Name = "sLook_NameEN";
            this.sLook_NameEN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLook_NameEN.Properties.PopupView = this.searchLookUpEdit1View;
            this.sLook_NameEN.Size = new System.Drawing.Size(324, 20);
            this.sLook_NameEN.TabIndex = 1;
            this.sLook_NameEN.TextChanged += new System.EventHandler(this.SLook_NameEN_Validated);
            this.sLook_NameEN.Validated += new System.EventHandler(this.SLook_NameEN_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 213);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên (Tiếng Việt)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 249);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên (Tiếng Nhật)";
            // 
            // txt_NameVN
            // 
            this.txt_NameVN.Enabled = false;
            this.txt_NameVN.Location = new System.Drawing.Point(104, 209);
            this.txt_NameVN.MenuManager = this.ribbonControl;
            this.txt_NameVN.Name = "txt_NameVN";
            this.txt_NameVN.Size = new System.Drawing.Size(324, 20);
            this.txt_NameVN.TabIndex = 6;
            // 
            // txt_NameJP
            // 
            this.txt_NameJP.Enabled = false;
            this.txt_NameJP.Location = new System.Drawing.Point(104, 245);
            this.txt_NameJP.Name = "txt_NameJP";
            this.txt_NameJP.Size = new System.Drawing.Size(324, 20);
            this.txt_NameJP.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 285);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Maker";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 321);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Model";
            // 
            // txt_Maker
            // 
            this.txt_Maker.Location = new System.Drawing.Point(104, 281);
            this.txt_Maker.Name = "txt_Maker";
            this.txt_Maker.Size = new System.Drawing.Size(324, 20);
            this.txt_Maker.TabIndex = 2;
            this.txt_Maker.Leave += new System.EventHandler(this.Txt_Maker_Leave);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(104, 317);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(324, 20);
            this.txt_Model.TabIndex = 3;
            this.txt_Model.Leave += new System.EventHandler(this.Txt_Model_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 357);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Ngưng sử dụng";
            // 
            // cbx_InActive
            // 
            this.cbx_InActive.Location = new System.Drawing.Point(104, 353);
            this.cbx_InActive.MenuManager = this.ribbonControl;
            this.cbx_InActive.Name = "cbx_InActive";
            this.cbx_InActive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_InActive.Size = new System.Drawing.Size(100, 20);
            this.cbx_InActive.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 393);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Ghi chú";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(104, 389);
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(324, 20);
            this.txt_Memo.TabIndex = 5;
            // 
            // Form_M0004_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 424);
            this.Controls.Add(this.cbx_InActive);
            this.Controls.Add(this.txt_Memo);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Maker);
            this.Controls.Add(this.txt_NameJP);
            this.Controls.Add(this.txt_NameVN);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sLook_NameEN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0004_Detail";
            this.Ribbon = this.ribbonControl;
            this.Text = "TÊN, MAKER & MODEL";
            this.Load += new System.EventHandler(this.Form_M0004_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_NameEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Maker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit sLook_NameEN;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_NameVN;
        private DevExpress.XtraEditors.TextEdit txt_NameJP;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Maker;
        private DevExpress.XtraEditors.TextEdit txt_Model;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_InActive;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Memo;
    }
}