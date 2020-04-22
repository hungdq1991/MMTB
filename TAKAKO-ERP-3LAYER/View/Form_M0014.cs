using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0014 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0014_DAO M0014_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0014(System_DAL systemDAL)
        {
            InitializeComponent();

            //
            _systemDAL = systemDAL;
        }

        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0014_DAO.GetInfo_M0014();
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
        private void Form_M0014_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            M0014_DAO = new M0014_DAO();

            //
            bsiUser.Caption = _systemDAL.userName;

            GetInfo_GridView();
        }
    }
}