using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0003_Line : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string _username = "";
        public DataTable _tempTable;
        public M0003_Line_DAO M0003_Line_DAO;
        public const Boolean AddNew = true;
        //
        public System_DAL _systemDAL = new System_DAL();

        //Khởi tạo form M0003
        public Form_M0003_Line(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }

        //Load form M0003
        private void Form_M0003_Load(object sender, System.EventArgs e)
        {
            //Tạo table sử dụng cho form M0003
            _tempTable = new DataTable();
            //Sử dụng DAO của M0003
            M0003_Line_DAO = new M0003_Line_DAO();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            GetInfo_Gridview();
        }
        //Dữ liệu của tempTable
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0003_Line_DAO.GetInfo_M0003();

                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = "Số records: " + _tempTable.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hiển thị dữ liệu và refresh gridview
        private void Setting_Init_Form()
        {
            GetInfo_Gridview();
            gridView.ClearFindFilter();
        }
        //Nội dung hiển thị khi thay đổi chọn filter các column
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count.ToString() + " records";
        }
        //Nội dung hiển thị khi double click trên lưới
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0003_Line_Detail formDetail = new Form_M0003_Line_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Thêm mới"
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line_Detail formDetail = new Form_M0003_Line_Detail(AddNew, _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Sửa"
        private void BbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line_Detail formDetail = new Form_M0003_Line_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Xóa"
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line_Detail formDetail = new Form_M0003_Line_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Refresh"
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            Setting_Init_Form();
        }
    }
}


