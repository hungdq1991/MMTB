using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0012 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0012_DAO M0012_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0012(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }

        private void Form_M0012_Load(object sender, EventArgs e)
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
                _tempTable = M0012_DAO.GetInfo_M0012(0);
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
        //Thêm mới
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012_Detail formDetail = new Form_M0012_Detail())
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //Lọc thông tin
        private void filter_List()
        {
            Boolean _inActive = bCheck_InActive.Checked;
            Boolean _Duplicate = bCheck_Duplicate.Checked;
            try
            {
                if (_Duplicate == true && _inActive == true)
                {
                    DataTable _tempTable = M0012_DAO.GetInfo_M0012_Dup();
                    if (_tempTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable.AsEnumerable()
                            .Where(row => row.Field<Boolean>("InActive") == true).CopyToDataTable();
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                    }
                }
                if (_Duplicate == true && _inActive == false)
                {
                    DataTable _tempTable1 = M0012_DAO.GetInfo_M0012_Dup();
                    if (_tempTable1.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable1;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable1.Rows.Count + " records";
                    }
                }
                if (_Duplicate == false && _inActive == true)
                {
                    DataTable _tempTable2 = M0012_DAO.GetInfo_M0012(1);
                    if (_tempTable2.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable2;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable2.Rows.Count + " records";
                    }
                }
                if (_Duplicate == false && _inActive == false)
                {
                    DataTable _tempTable3 = M0012_DAO.GetInfo_M0012(0);
                    if (_tempTable3.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable3.Rows.Count + " records";
                    }
                }
            }
            catch
            {
                gridControl.DataSource = "";
            }
        }

        private void BCheck_InActive_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }

        private void BCheck_Duplicate_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }
    }
}