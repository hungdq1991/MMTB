using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;

namespace MMTB.View
{
    public partial class Form_M0005_Line : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0009_DAO M0009_DAO;
        public DataTable _tempTable1;
        public M00091_DAO M00091_DAO;
        public Form_M0005_Line()
        {
            InitializeComponent();
        }

        private void Form_M0009_Load(object sender, EventArgs e)
        {
            _tempTable = new DataTable();
            //
            M0009_DAO = new M0009_DAO();
            //Load Init
            GetInfo_Gridview();
        }
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0009_DAO.GetInfo_M0009();
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

        private void BarCheckItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tempTable1 = new DataTable();
            //
            M00091_DAO = new M00091_DAO();
            //Load Init
            GetInfo_Gridview1();
        }
        private void GetInfo_Gridview1()
        {
            try
            {
                _tempTable1 = M00091_DAO.GetInfo_M00091();
                if (barCheckItem1.Checked == true)
                {
                    gridControl.DataSource = _tempTable1;
                    gridView.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
                if (barCheckItem1.Checked == false)
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
    }
}