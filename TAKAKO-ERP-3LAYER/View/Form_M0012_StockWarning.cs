using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0012_StockWarning : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0012_DAO M0012_DAO;
        public const Boolean AddNew = true;
        //
        public System_DAL _systemDAL = new System_DAL();
        public Form_M0012_StockWarning(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        private void Form_M0012_StockWarning_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            //
            M0012_DAO = new M0012_DAO();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            GetInfo_Gridview();
        }
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0012_DAO.GetInfo_M0012_StockWarning();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
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
        //Thay đổi thông tin số lượng records khi filter
        private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption =gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }      
        //Nhấn nút refresh
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            bCheck_InActive.Checked = false;
            GetInfo_Gridview();
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
    }
}