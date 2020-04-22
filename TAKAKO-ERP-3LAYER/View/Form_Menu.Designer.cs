namespace TAKAKO_ERP_3LAYER.View
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiName = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMakerModel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLine = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProcess = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPartList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPart = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDisposal = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoving = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBattery = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOil = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStock = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStop = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTech = new DevExpress.XtraBars.BarButtonItem();
            this.bbiACC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.ForeColor = System.Drawing.Color.White;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiName,
            this.bbiGroup,
            this.bbiMakerModel,
            this.bbiLine,
            this.bbiProcess,
            this.bbiClose,
            this.bbiList,
            this.bbiConfirm,
            this.bbiPartList,
            this.bbiPart,
            this.bbiDisposal,
            this.bbiMoving,
            this.bbiBattery,
            this.bbiOil,
            this.bbiStock,
            this.bbiStop,
            this.bbiTech,
            this.bbiACC,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 23;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPage1,
            this.ribbonPage2});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(831, 159);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiName
            // 
            this.bbiName.Caption = "Danh mục tên gọi";
            this.bbiName.Id = 2;
            this.bbiName.ImageOptions.ImageUri.Uri = "ListBullets";
            this.bbiName.Name = "bbiName";
            this.bbiName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiName_ItemClick);
            // 
            // bbiGroup
            // 
            this.bbiGroup.Caption = "Danh mục phân nhóm Đại-Trung-Tiểu";
            this.bbiGroup.Id = 3;
            this.bbiGroup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiGroup.ImageOptions.SvgImage")));
            this.bbiGroup.Name = "bbiGroup";
            this.bbiGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiGroup_ItemClick);
            // 
            // bbiMakerModel
            // 
            this.bbiMakerModel.Caption = "Danh mục Maker-Model MMTB";
            this.bbiMakerModel.Id = 4;
            this.bbiMakerModel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiMakerModel.ImageOptions.Image")));
            this.bbiMakerModel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiMakerModel.ImageOptions.LargeImage")));
            this.bbiMakerModel.Name = "bbiMakerModel";
            this.bbiMakerModel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiMakerModel_ItemClick);
            // 
            // bbiLine
            // 
            this.bbiLine.Caption = "Danh mục Line SX";
            this.bbiLine.Id = 5;
            this.bbiLine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiLine.ImageOptions.Image")));
            this.bbiLine.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiLine.ImageOptions.LargeImage")));
            this.bbiLine.Name = "bbiLine";
            this.bbiLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLine_ItemClick);
            // 
            // bbiProcess
            // 
            this.bbiProcess.Caption = "Danh mục Process";
            this.bbiProcess.Id = 6;
            this.bbiProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiProcess.ImageOptions.Image")));
            this.bbiProcess.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiProcess.ImageOptions.LargeImage")));
            this.bbiProcess.Name = "bbiProcess";
            this.bbiProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiProcess_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiList
            // 
            this.bbiList.Caption = "Danh sách MMTB";
            this.bbiList.Id = 10;
            this.bbiList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiList.ImageOptions.Image")));
            this.bbiList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiList.ImageOptions.LargeImage")));
            this.bbiList.Name = "bbiList";
            this.bbiList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiList_ItemClick);
            // 
            // bbiConfirm
            // 
            this.bbiConfirm.Caption = "Nghiệm thu \r\nMMTB";
            this.bbiConfirm.Id = 11;
            this.bbiConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiConfirm.ImageOptions.Image")));
            this.bbiConfirm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiConfirm.ImageOptions.LargeImage")));
            this.bbiConfirm.Name = "bbiConfirm";
            this.bbiConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiConfirm_ItemClick);
            // 
            // bbiPartList
            // 
            this.bbiPartList.Caption = "Danh mục LK, Pin, Dầu";
            this.bbiPartList.Id = 12;
            this.bbiPartList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPartList.ImageOptions.SvgImage")));
            this.bbiPartList.Name = "bbiPartList";
            this.bbiPartList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPartList_ItemClick);
            // 
            // bbiPart
            // 
            this.bbiPart.Caption = "LK";
            this.bbiPart.Id = 13;
            this.bbiPart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPart.ImageOptions.SvgImage")));
            this.bbiPart.Name = "bbiPart";
            this.bbiPart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPart_ItemClick);
            // 
            // bbiDisposal
            // 
            this.bbiDisposal.Caption = "Thanh lý \r\nMMTB";
            this.bbiDisposal.Id = 14;
            this.bbiDisposal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDisposal.ImageOptions.Image")));
            this.bbiDisposal.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDisposal.ImageOptions.LargeImage")));
            this.bbiDisposal.Name = "bbiDisposal";
            this.bbiDisposal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDisposal_ItemClick);
            // 
            // bbiMoving
            // 
            this.bbiMoving.Caption = "Di dời MMTB";
            this.bbiMoving.Id = 15;
            this.bbiMoving.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiMoving.ImageOptions.SvgImage")));
            this.bbiMoving.Name = "bbiMoving";
            this.bbiMoving.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiMoving_ItemClick);
            // 
            // bbiBattery
            // 
            this.bbiBattery.Caption = "Pin";
            this.bbiBattery.Id = 16;
            this.bbiBattery.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiBattery.ImageOptions.SvgImage")));
            this.bbiBattery.Name = "bbiBattery";
            this.bbiBattery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiBattery_ItemClick);
            // 
            // bbiOil
            // 
            this.bbiOil.Caption = "Dầu";
            this.bbiOil.Id = 17;
            this.bbiOil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiOil.ImageOptions.SvgImage")));
            this.bbiOil.Name = "bbiOil";
            this.bbiOil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiOil_ItemClick);
            // 
            // bbiStock
            // 
            this.bbiStock.Caption = "Tồn kho LK";
            this.bbiStock.Id = 18;
            this.bbiStock.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiStock.ImageOptions.SvgImage")));
            this.bbiStock.Name = "bbiStock";
            this.bbiStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStock_ItemClick);
            // 
            // bbiStop
            // 
            this.bbiStop.Caption = "Danh mục LK ngưng SX";
            this.bbiStop.Id = 19;
            this.bbiStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiStop.ImageOptions.Image")));
            this.bbiStop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiStop.ImageOptions.LargeImage")));
            this.bbiStop.Name = "bbiStop";
            this.bbiStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStop_ItemClick);
            // 
            // bbiTech
            // 
            this.bbiTech.Caption = "Thông số kỹ thuật";
            this.bbiTech.Id = 20;
            this.bbiTech.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTech.ImageOptions.SvgImage")));
            this.bbiTech.Name = "bbiTech";
            this.bbiTech.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiTech_ItemClick);
            // 
            // bbiACC
            // 
            this.bbiACC.Caption = "ACC bổ sung thông tin";
            this.bbiACC.Id = 21;
            this.bbiACC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiACC.ImageOptions.Image")));
            this.bbiACC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiACC.ImageOptions.LargeImage")));
            this.bbiACC.Name = "bbiACC";
            this.bbiACC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiACC_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "MMTB \r\nkhông sử dụng";
            this.barButtonItem1.Id = 22;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mainRibbonPage.Appearance.Options.UseFont = true;
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Master";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiName);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGroup);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiMakerModel);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiPartList);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiProcess);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiLine);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Master";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Appearance.Options.UseForeColor = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý MMTB";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiList);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTech);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiConfirm);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDisposal);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMoving);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiACC);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý MMTB";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ribbonPage2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Appearance.Options.UseForeColor = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý LK, pin, dầu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiStock);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPart);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiBattery);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiOil);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiStop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý LK, Pin, Dầu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiList);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiConfirm);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiDisposal);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiMoving);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiTech);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiACC);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý MMTB";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(831, 223);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "Form_Menu";
            this.Ribbon = this.mainRibbonControl;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiName;
        private DevExpress.XtraBars.BarButtonItem bbiGroup;
        private DevExpress.XtraBars.BarButtonItem bbiMakerModel;
        private DevExpress.XtraBars.BarButtonItem bbiLine;
        private DevExpress.XtraBars.BarButtonItem bbiProcess;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiConfirm;
        private DevExpress.XtraBars.BarButtonItem bbiPartList;
        private DevExpress.XtraBars.BarButtonItem bbiPart;
        private DevExpress.XtraBars.BarButtonItem bbiDisposal;
        private DevExpress.XtraBars.BarButtonItem bbiMoving;
        private DevExpress.XtraBars.BarButtonItem bbiBattery;
        private DevExpress.XtraBars.BarButtonItem bbiOil;
        private DevExpress.XtraBars.BarButtonItem bbiStock;
        private DevExpress.XtraBars.BarButtonItem bbiStop;
        private DevExpress.XtraBars.BarButtonItem bbiTech;
        private DevExpress.XtraBars.BarButtonItem bbiACC;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}