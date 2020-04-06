using DevExpress.XtraEditors.Repository;
using System;
using System.Data;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAO;


namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0005_DAO M0005_DAO;
        public M0005_Line_DAO M0005_Line_DAO;
        public Form_M0005()
        {
            InitializeComponent();
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
            //Load Init
            GetInfo_Gridview();
        }
        //Load dữ liệu
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0005_DAO.GetInfo_M0005();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    gridView.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thay đổi thông tin số lượng records khi filter
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        //Lọc lại danh sách MMTB đã thanh lý
        private void BarCheckItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked)
            { 
                gridControl.DataSource = _tempTable.AsEnumerable()
                    .Where(row => row.Field<DateTime?>("DisposalDate") != null).CopyToDataTable();
            } else
            {
                gridControl.DataSource = _tempTable;
            }
        }
        //Xem chứng từ nghiệm thu MMTB
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            //String param_DocNo = gridView.GetFocusedDataRow()["DocNo_Confirm"].ToString();
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT(gridView.GetFocusedDataRow()["DocNo"].ToString()))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
            }
        }
        //Tạo chứng từ nghiệm thu
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
            }
        }
        //Tạo chứng từ thanh lý 
        private void BbiDisposal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_TL formDetail = new Form_M0005_Detail_TL())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
            }
        }

    }
}
