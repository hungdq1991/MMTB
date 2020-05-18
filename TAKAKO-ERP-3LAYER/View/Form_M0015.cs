using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0015 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0015_DAO M0015_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0015()
        {
            InitializeComponent();
        }

        public Form_M0015(System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }

        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0015_DAO.GetInfo_M0015();
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
        private void Form_M0015_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            M0015_DAO = new M0015_DAO();

            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();

            GetInfo_GridView();
        }
    }
}