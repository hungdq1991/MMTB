namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0001_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_M0001_Detail));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel_Detail = new DevExpress.XtraEditors.PanelControl();
            this.cbx_Group1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label_Group1 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_Name = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.cbx_InActive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_Line = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_Group2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_NameJP = new DevExpress.XtraEditors.TextEdit();
            this.txt_NameVN = new DevExpress.XtraEditors.TextEdit();
            this.txt_NameEN = new DevExpress.XtraEditors.TextEdit();
            this.label_InActive = new DevExpress.XtraEditors.LabelControl();
            this.label_NameVN = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label_NameJP = new DevExpress.XtraEditors.LabelControl();
            this.label_Group2 = new DevExpress.XtraEditors.LabelControl();
            this.label_NameEN = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Detail)).BeginInit();
            this.panel_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Group1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Line.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Group2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameEN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiSave,
            this.bbiReset,
            this.bbiDelete,
            this.bbiNew,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 14;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(415, 157);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSave_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R));
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 10;
            this.bbiDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelete.ImageOptions.SvgImage")));
            this.bbiDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDelete_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm mới";
            this.bbiNew.Id = 11;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 12;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiClose_ItemClick_1);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // panel_Detail
            // 
            this.panel_Detail.Controls.Add(this.cbx_Group1);
            this.panel_Detail.Controls.Add(this.label_Group1);
            this.panel_Detail.Controls.Add(this.cbx_Name);
            this.panel_Detail.Controls.Add(this.label_Name);
            this.panel_Detail.Controls.Add(this.cbx_InActive);
            this.panel_Detail.Controls.Add(this.cbx_Line);
            this.panel_Detail.Controls.Add(this.cbx_Group2);
            this.panel_Detail.Controls.Add(this.txt_NameJP);
            this.panel_Detail.Controls.Add(this.txt_NameVN);
            this.panel_Detail.Controls.Add(this.txt_NameEN);
            this.panel_Detail.Controls.Add(this.label_InActive);
            this.panel_Detail.Controls.Add(this.label_NameVN);
            this.panel_Detail.Controls.Add(this.labelControl1);
            this.panel_Detail.Controls.Add(this.label_NameJP);
            this.panel_Detail.Controls.Add(this.label_Group2);
            this.panel_Detail.Controls.Add(this.label_NameEN);
            this.panel_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Detail.Location = new System.Drawing.Point(0, 157);
            this.panel_Detail.Name = "panel_Detail";
            this.panel_Detail.Size = new System.Drawing.Size(415, 348);
            this.panel_Detail.TabIndex = 2;
            // 
            // cbx_Group1
            // 
            this.cbx_Group1.Location = new System.Drawing.Point(103, 172);
            this.cbx_Group1.MenuManager = this.mainRibbonControl;
            this.cbx_Group1.Name = "cbx_Group1";
            this.cbx_Group1.Properties.AutoComplete = false;
            this.cbx_Group1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Group1.Size = new System.Drawing.Size(121, 20);
            this.cbx_Group1.TabIndex = 8;
            // 
            // label_Group1
            // 
            this.label_Group1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group1.Appearance.Options.UseFont = true;
            this.label_Group1.Appearance.Options.UseTextOptions = true;
            this.label_Group1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.label_Group1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_Group1.Location = new System.Drawing.Point(10, 155);
            this.label_Group1.Name = "label_Group1";
            this.label_Group1.Size = new System.Drawing.Size(97, 50);
            this.label_Group1.TabIndex = 7;
            this.label_Group1.Text = "Sử dụng cho Nhóm trung";
            // 
            // cbx_Name
            // 
            this.cbx_Name.Location = new System.Drawing.Point(103, 131);
            this.cbx_Name.MenuManager = this.mainRibbonControl;
            this.cbx_Name.Name = "cbx_Name";
            this.cbx_Name.Properties.AutoComplete = false;
            this.cbx_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Name.Size = new System.Drawing.Size(121, 20);
            this.cbx_Name.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Appearance.Options.UseTextOptions = true;
            this.label_Name.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.label_Name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_Name.Location = new System.Drawing.Point(10, 124);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(87, 31);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Sử dụng cho Tên";
            // 
            // cbx_InActive
            // 
            this.cbx_InActive.Location = new System.Drawing.Point(102, 301);
            this.cbx_InActive.Name = "cbx_InActive";
            this.cbx_InActive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_InActive.Size = new System.Drawing.Size(121, 20);
            this.cbx_InActive.TabIndex = 4;
            // 
            // cbx_Line
            // 
            this.cbx_Line.Location = new System.Drawing.Point(102, 260);
            this.cbx_Line.Name = "cbx_Line";
            this.cbx_Line.Properties.AutoComplete = false;
            this.cbx_Line.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Line.Size = new System.Drawing.Size(121, 20);
            this.cbx_Line.TabIndex = 3;
            // 
            // cbx_Group2
            // 
            this.cbx_Group2.Location = new System.Drawing.Point(103, 215);
            this.cbx_Group2.MenuManager = this.mainRibbonControl;
            this.cbx_Group2.Name = "cbx_Group2";
            this.cbx_Group2.Properties.AutoComplete = false;
            this.cbx_Group2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Group2.Size = new System.Drawing.Size(121, 20);
            this.cbx_Group2.TabIndex = 3;
            // 
            // txt_NameJP
            // 
            this.txt_NameJP.Location = new System.Drawing.Point(102, 90);
            this.txt_NameJP.Name = "txt_NameJP";
            this.txt_NameJP.Size = new System.Drawing.Size(300, 20);
            this.txt_NameJP.TabIndex = 2;
            // 
            // txt_NameVN
            // 
            this.txt_NameVN.Location = new System.Drawing.Point(102, 50);
            this.txt_NameVN.MenuManager = this.mainRibbonControl;
            this.txt_NameVN.Name = "txt_NameVN";
            this.txt_NameVN.Size = new System.Drawing.Size(300, 20);
            this.txt_NameVN.TabIndex = 1;
            // 
            // txt_NameEN
            // 
            this.txt_NameEN.Location = new System.Drawing.Point(102, 8);
            this.txt_NameEN.MenuManager = this.mainRibbonControl;
            this.txt_NameEN.Name = "txt_NameEN";
            this.txt_NameEN.Size = new System.Drawing.Size(300, 20);
            this.txt_NameEN.TabIndex = 0;
            // 
            // label_InActive
            // 
            this.label_InActive.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InActive.Appearance.Options.UseFont = true;
            this.label_InActive.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_InActive.Location = new System.Drawing.Point(9, 299);
            this.label_InActive.Name = "label_InActive";
            this.label_InActive.Size = new System.Drawing.Size(120, 22);
            this.label_InActive.TabIndex = 4;
            this.label_InActive.Text = "Ngưng sử dụng";
            // 
            // label_NameVN
            // 
            this.label_NameVN.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameVN.Appearance.Options.UseFont = true;
            this.label_NameVN.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_NameVN.Location = new System.Drawing.Point(10, 48);
            this.label_NameVN.Name = "label_NameVN";
            this.label_NameVN.Size = new System.Drawing.Size(120, 22);
            this.label_NameVN.TabIndex = 3;
            this.label_NameVN.Text = "Tên (t.Việt)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(9, 253);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 34);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sử dụng cho Line";
            // 
            // label_NameJP
            // 
            this.label_NameJP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameJP.Appearance.Options.UseFont = true;
            this.label_NameJP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_NameJP.Location = new System.Drawing.Point(10, 88);
            this.label_NameJP.Name = "label_NameJP";
            this.label_NameJP.Size = new System.Drawing.Size(120, 22);
            this.label_NameJP.TabIndex = 2;
            this.label_NameJP.Text = "Tên (t.Nhật)";
            // 
            // label_Group2
            // 
            this.label_Group2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group2.Appearance.Options.UseFont = true;
            this.label_Group2.Appearance.Options.UseTextOptions = true;
            this.label_Group2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.label_Group2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_Group2.Location = new System.Drawing.Point(10, 208);
            this.label_Group2.Name = "label_Group2";
            this.label_Group2.Size = new System.Drawing.Size(86, 34);
            this.label_Group2.TabIndex = 1;
            this.label_Group2.Text = "Sử dụng cho Nhóm đại";
            // 
            // label_NameEN
            // 
            this.label_NameEN.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameEN.Appearance.Options.UseFont = true;
            this.label_NameEN.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_NameEN.Location = new System.Drawing.Point(10, 6);
            this.label_NameEN.Name = "label_NameEN";
            this.label_NameEN.Size = new System.Drawing.Size(120, 22);
            this.label_NameEN.TabIndex = 0;
            this.label_NameEN.Text = "Tên (t.Anh)";
            // 
            // Form_M0001_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(415, 505);
            this.Controls.Add(this.panel_Detail);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "Form_M0001_Detail";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "CẬP NHẬT DANH MỤC TÊN GỌI";
            this.Load += new System.EventHandler(this.Form_M0001_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Detail)).EndInit();
            this.panel_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Group1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Line.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Group2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameEN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraEditors.PanelControl panel_Detail;
        private DevExpress.XtraEditors.TextEdit txt_NameJP;
        private DevExpress.XtraEditors.TextEdit txt_NameVN;
        private DevExpress.XtraEditors.TextEdit txt_NameEN;
        private DevExpress.XtraEditors.LabelControl label_InActive;
        private DevExpress.XtraEditors.LabelControl label_NameVN;
        private DevExpress.XtraEditors.LabelControl label_NameJP;
        private DevExpress.XtraEditors.LabelControl label_Group2;
        private DevExpress.XtraEditors.LabelControl label_NameEN;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_InActive;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Group2;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Group1;
        private DevExpress.XtraEditors.LabelControl label_Group1;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Name;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Line;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}