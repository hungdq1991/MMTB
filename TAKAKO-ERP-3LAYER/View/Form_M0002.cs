using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0002 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //
        public DataTable _tempTable;
        public M0002_DAO M0002_DAO;
        public const Boolean AddNew = true;
        //
        public System_DAL _systemDAL = new System_DAL();
        public Form_M0002(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        private void Form_M0002_Load(object sender, EventArgs e)
        {
            //
            _tempTable = new DataTable();
            //
            M0002_DAO = new M0002_DAO();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            GetInfo_Gridview();
        }
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0002_DAO.GetInfo_M0002();

                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = "Số record: " + _tempTable.Rows.Count;
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
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count.ToString() + " records";
        }
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0002_Detail formDetail = new Form_M0002_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                Setting_Init_Form();
            }
        }
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0002_Detail formDetail = new Form_M0002_Detail(AddNew, _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                Setting_Init_Form();
            }
        }
        private void BbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0002_Detail formDetail = new Form_M0002_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                Setting_Init_Form();
            }
        }
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0002_Detail formDetail = new Form_M0002_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                Setting_Init_Form();
            }
        }
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            Setting_Init_Form();
        }
    }
}