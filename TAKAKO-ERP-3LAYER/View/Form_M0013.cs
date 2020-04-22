using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0013 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0013_DAO M0013_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0013()
        {
            InitializeComponent();
        }

        public Form_M0013(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
            //
            bsiUser.Caption = _systemDAL.userName;
        }

        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013();
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
        private void Form_M0013_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            M0013_DAO = new M0013_DAO();

            GetInfo_GridView();
        }
    }
}