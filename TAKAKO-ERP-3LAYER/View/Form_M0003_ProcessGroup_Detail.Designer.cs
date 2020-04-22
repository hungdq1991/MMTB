namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_M0003_ProcessCode_Detail
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
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProcessEN = new DevExpress.XtraEditors.TextEdit();
            this.txt_ProcessVN = new DevExpress.XtraEditors.TextEdit();
            this.txt_ProcessJP = new DevExpress.XtraEditors.TextEdit();
            this.txt_Point = new DevExpress.XtraEditors.TextEdit();
            this.date_ApplyDate = new DevExpress.XtraEditors.DateEdit();
            this.txt_Memo = new DevExpress.XtraEditors.TextEdit();
            this.cbx_InActive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sLook_ProcessCode = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Point.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_ProcessCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.bbiDelete,
            this.bbiSave,
            this.bbiReset,
            this.bbiClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 24;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(540, 157);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Id = 21;
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
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDelete_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.Id = 20;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSave_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 22;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiReset_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 23;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm công đoạn";
            // 
            // txt_ProcessEN
            // 
            this.txt_ProcessEN.Enabled = false;
            this.txt_ProcessEN.Location = new System.Drawing.Point(125, 214);
            this.txt_ProcessEN.MenuManager = this.ribbonControl;
            this.txt_ProcessEN.Name = "txt_ProcessEN";
            this.txt_ProcessEN.Size = new System.Drawing.Size(385, 20);
            this.txt_ProcessEN.TabIndex = 2;
            // 
            // txt_ProcessVN
            // 
            this.txt_ProcessVN.Enabled = false;
            this.txt_ProcessVN.Location = new System.Drawing.Point(125, 256);
            this.txt_ProcessVN.Name = "txt_ProcessVN";
            this.txt_ProcessVN.Size = new System.Drawing.Size(385, 20);
            this.txt_ProcessVN.TabIndex = 7;
            // 
            // txt_ProcessJP
            // 
            this.txt_ProcessJP.Enabled = false;
            this.txt_ProcessJP.Location = new System.Drawing.Point(125, 298);
            this.txt_ProcessJP.Name = "txt_ProcessJP";
            this.txt_ProcessJP.Size = new System.Drawing.Size(385, 20);
            this.txt_ProcessJP.TabIndex = 8;
            // 
            // txt_Point
            // 
            this.txt_Point.Location = new System.Drawing.Point(125, 340);
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.Size = new System.Drawing.Size(115, 20);
            this.txt_Point.TabIndex = 3;
            // 
            // date_ApplyDate
            // 
            this.date_ApplyDate.EditValue = null;
            this.date_ApplyDate.Location = new System.Drawing.Point(361, 340);
            this.date_ApplyDate.MenuManager = this.ribbonControl;
            this.date_ApplyDate.Name = "date_ApplyDate";
            this.date_ApplyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ApplyDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_ApplyDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_ApplyDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_ApplyDate.Size = new System.Drawing.Size(149, 20);
            this.date_ApplyDate.TabIndex = 4;
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(125, 424);
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(385, 20);
            this.txt_Memo.TabIndex = 6;
            // 
            // cbx_InActive
            // 
            this.cbx_InActive.Location = new System.Drawing.Point(125, 382);
            this.cbx_InActive.MenuManager = this.ribbonControl;
            this.cbx_InActive.Name = "cbx_InActive";
            this.cbx_InActive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_InActive.Size = new System.Drawing.Size(115, 20);
            this.cbx_InActive.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên (t.Anh)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên (t.Việt)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên (t.Nhật)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngưng sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(261, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày hiệu lực";
            // 
            // sLook_ProcessCode
            // 
            this.sLook_ProcessCode.EnterMoveNextControl = true;
            this.sLook_ProcessCode.Location = new System.Drawing.Point(125, 172);
            this.sLook_ProcessCode.MenuManager = this.ribbonControl;
            this.sLook_ProcessCode.Name = "sLook_ProcessCode";
            this.sLook_ProcessCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLook_ProcessCode.Properties.PopupView = this.searchLookUpEdit1View;
            this.sLook_ProcessCode.Size = new System.Drawing.Size(115, 20);
            this.sLook_ProcessCode.TabIndex = 10;
            this.sLook_ProcessCode.TextChanged += new System.EventHandler(this.SLook_ProcessCode_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Form_M0003_ProcessCode_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 463);
            this.Controls.Add(this.sLook_ProcessCode);
            this.Controls.Add(this.cbx_InActive);
            this.Controls.Add(this.date_ApplyDate);
            this.Controls.Add(this.txt_Memo);
            this.Controls.Add(this.txt_Point);
            this.Controls.Add(this.txt_ProcessJP);
            this.Controls.Add(this.txt_ProcessVN);
            this.Controls.Add(this.txt_ProcessEN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form_M0003_ProcessCode_Detail";
            this.Ribbon = this.ribbonControl;
            this.Text = "CÔNG ĐOẠN";
            this.Load += new System.EventHandler(this.Form_M0003_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProcessJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Point.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_ApplyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_InActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLook_ProcessCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_ProcessEN;
        private DevExpress.XtraEditors.TextEdit txt_ProcessVN;
        private DevExpress.XtraEditors.TextEdit txt_ProcessJP;
        private DevExpress.XtraEditors.TextEdit txt_Point;
        private DevExpress.XtraEditors.DateEdit date_ApplyDate;
        private DevExpress.XtraEditors.TextEdit txt_Memo;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_InActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraEditors.SearchLookUpEdit sLook_ProcessCode;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
    }
}