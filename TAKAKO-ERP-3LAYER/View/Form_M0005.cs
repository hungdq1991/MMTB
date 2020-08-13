 using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace MMTB.View
{
    public partial class Form_M0005 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0005_DAO M0005_DAO;
        public M0005_Line_DAO M0005_Line_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        //Khởi tạo Form_M0005
        public Form_M0005(System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }

        //Load form
        private void Form_M0005_Load(object sender, System.EventArgs e)
        {
            //
            _tempTable = new DataTable();
            //
            M0005_DAO = new M0005_DAO();
            //
            M0005_Line_DAO = new M0005_Line_DAO();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper().ToUpper();
            //Load Init
            GetInfo_advBandedGridView1();
        }
        //Load dữ liệu
        private void GetInfo_advBandedGridView1()
        {
            try
            {
                _tempTable = M0005_DAO.GetInfo_M0005();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    advBandedGridView1.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thay đổi thông tin số lượng records khi filter
        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        //Lọc lại danh sách MMTB đã thanh lý/ngưng sử dụng
        private void filter_List()
        {
            Boolean _disposal = bCheck_Disposal.Checked;
            Boolean _noUsed = bCheck_NoUsed.Checked;
            try
            {
                _tempTable = M0005_DAO.GetInfo_M0005_Filter();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    advBandedGridView1.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                    try
                    {

                        if (_disposal == true && _noUsed == true)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable()
                                .Where(row => row.Field<string>("DocNo_Disposal") != null && row.Field<string>("DesLineCode") == "NoUsed").CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_disposal == true && _noUsed == false)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable()
                                    .Where(row => row.Field<string>("DocNo_Disposal") != null).CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_disposal == false && _noUsed == true)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable()
                                .Where(row => row.Field<string>("DesLineCode") == "NoUsed").CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_disposal == false && _noUsed == false)
                        {
                            _tempTable = M0005_DAO.GetInfo_M0005();
                            if (_tempTable.Rows.Count > 0)
                            {
                                gridControl.DataSource = _tempTable;
                                advBandedGridView1.FormatRules[0].ApplyToRow = true;
                                bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                            }
                        }
                    }
                    catch
                    {
                        gridControl.DataSource = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Disposal check changed
        private void BCheck_Disposal_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }
        //NoUsed check changed
        private void BCheck_NoUsed_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }
        //Xem chứng từ nghiệm thu MMTB
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            //String param_DocNo = advBandedGridView1.GetFocusedDataRow()["DocNo_Confirm"].ToString();
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT(advBandedGridView1.GetFocusedDataRow()["DocNo"].ToString(), _systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.ShowDialog();
            }
        }
        //Tạo chứng từ nghiệm thu
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT(_systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //Tạo chứng từ thanh lý 
        private void BbiDisposal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_TL formDetail = new Form_M0005_Detail_TL(_systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //Tạo chứng từ di dời
        private void BbiMoving_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_DD formDetail = new Form_M0005_Detail_DD(_systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //Click nút Refresh 
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bCheck_Disposal.Checked = false;
            bCheck_NoUsed.Checked = false;
            filter_List();
        }
        //Tạo chứng từ không sử dụng
        private void BbiNoUsed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NoUsed formDetail = new Form_M0005_Detail_NoUsed())
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }

        //Hiển thị dữ liệu trên cột, ngày tháng không có
        private void AdvBandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ProDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
            if (e.Column.FieldName == "DisposalDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
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
                if (advBandedGridView1.FocusedRowHandle <0)
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
