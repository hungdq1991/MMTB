using System;
using System.Data;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAO;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0001 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0001_DAO M0001_DAO;
        public const Boolean AddNew = true;

        public Form_M0001()
        {
            InitializeComponent();
        }
        //Khởi tạo dữ liệu
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable.Clear();
                _tempTable = M0001_DAO.GetInfo_M0001();

                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = "Records: " + _tempTable.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Refresh gridview
        private void Setting_Init_Form()
        {
            GetInfo_Gridview();
            gridView.ClearFindFilter();
        }
        //Load form
        private void Form_M0001_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            M0001_DAO = new M0001_DAO();
            //Load Init
            GetInfo_Gridview();
        }
        //Số thứ tự các dòng dữ liệu
        private void gridName_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        //Hiển thị số lượng records khi filter cột
        private void GridName_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count.ToString() + " records";
        }
        //Double click tại dòng cần chỉnh sửa/delete
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0001_Detail formDetail = new Form_M0001_Detail(gridView.GetFocusedDataRow()))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        //Thêm dữ liệu
        private void barBtn_AddNewRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0001_Detail formDetail = new Form_M0001_Detail(AddNew))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        //Chọn nút Edit
        private void BbiEdit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0001_Detail formDetail = new Form_M0001_Detail(gridView.GetFocusedDataRow()))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }        
        //Chọn nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0001_Detail formDetail = new Form_M0001_Detail(gridView.GetFocusedDataRow()))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        //Chọn nút Refresh
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            Setting_Init_Form();
        }
    }
}