using System;
using System.Data;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.DAL;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0003_Process : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0003_Process_DAO M0003_Process_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0003_Process()
        {
            InitializeComponent();
        }

        public Form_M0003_Process(System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }

        private void Form_M0003_Load(object sender, System.EventArgs e)
        {

            _tempTable = new DataTable();
            //
            M0003_Process_DAO = new M0003_Process_DAO();
            //Load Init
            GetInfo_Gridview();
        }
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0003_Process_DAO.GetInfo_M0003();

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
    }
}