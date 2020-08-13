using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.SpreadsheetSource;

namespace MMTB.View
{
    public partial class Form_M0013_All : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0002_DAO M0002_DAO;
        public M0013_DAO M0013_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0013_All()
        {
            InitializeComponent();
        }

        public Form_M0013_All(System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }
        private void GetInfo_advBandedGridView1()
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013_NoPrice("%");
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Hiển thị dữ liệu cho ô classify
        /// </summary>
        private void Add_Value_Classify()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M01_Classify();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_Classify.DataSource = tempTable;
                repo_sLookUp_Classify.ValueMember = "ClassifyID";
                repo_sLookUp_Classify.DisplayMember = "ClassifyDesc";
            }
        }
        //Load form 
        private void Form_M0013_Load(object sender, EventArgs e)
        {
            //_tempTable = new DataTable();
            M0002_DAO = new M0002_DAO();
            M0013_DAO = new M0013_DAO();

            //
            bsiUser.Caption = _systemDAL.userName.ToUpper().ToUpper();
            Add_Value_Classify();
            GetInfo_advBandedGridView1();
        }
        //Nhấn nút Refresh
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Set_Enable_Control(false);
            GetInfo_advBandedGridView1();
            advBandedGridView1.ClearColumnsFilter();
        }
        //Nhấn nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Nhấn nút Item
        private void BbiItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_2_ByItem formDetail = new Form_M0013_2_ByItem(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        //Nhấn nút Maker
        private void BbiMaker_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_1_ByModel formDetail = new Form_M0013_1_ByModel(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        /// <summary>
        /// Thông tin số dòng khi filter các column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }

        private void BbiLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013("%");
                if (_tempTable.Rows.Count > 0)
                {
                    Set_Enable_Control(true);
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Set_Enable_Control(Boolean IsEnable)
        {
            gridCol_PurCode.Visible = IsEnable;
            gridCol_VendID.Visible = IsEnable;
            gridCol_VendName.Visible = IsEnable;
            gridCol_Cury.Visible = IsEnable;
            gridCol_PriceRef.Visible = IsEnable;
            gridCol_EffDate.Visible = IsEnable;
            gridCol_PurCodeRe.Visible = IsEnable;
            gridCol_VendIDRe.Visible = IsEnable;
            gridCol_VendNameRe.Visible = IsEnable;
            gridCol_CuryRe.Visible = IsEnable;
            gridCol_PriceRefRe.Visible = IsEnable;
            gridCol_EffDateRe.Visible = IsEnable;
        }
        //Xuất file excel
        private void BbiExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportExcel("");
        }
        //Xuất excel
        private void ExportExcel(string fileName)
        {
            try
            {
                if (advBandedGridView1.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = fileName;
                    dialog.Filter = @"Microsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        advBandedGridView1.ColumnPanelRowHeight = 40;
                        advBandedGridView1.OptionsPrint.AutoWidth = AutoSize;
                        advBandedGridView1.OptionsPrint.ShowPrintExportProgress = true;
                        advBandedGridView1.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"List";
                        ExportSettings.DefaultExportType = ExportType.Default;
                        advBandedGridView1.ExportToXlsx(dialog.FileName, options);
                        MessageBox.Show("Xuất dũ liệu thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi" + e, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}