using DevExpress.XtraEditors.Repository;
using System;
using System.Data;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAO;


namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public DataTable _tempTable1;
        public M0005_DAO M0005_DAO;
        public M0005_Line_DAO M0005_Line_DAO;
        public Form_M0005()
        {
            InitializeComponent();
        }
        private void Form_M0005_Load(object sender, System.EventArgs e)
        {
            _tempTable = new DataTable();
            //
            M0005_DAO = new M0005_DAO();
            //Load Init
            GetInfo_Gridview();
        }
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0005_DAO.GetInfo_M0005();
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

        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }

        private void BarCheckItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tempTable1 = new DataTable();
            //
            M0005_Line_DAO = new M0005_Line_DAO();
            //Load Init
            GetInfo_Gridview1();
        }
        private void GetInfo_Gridview1()
            {
                try
                {
                    _tempTable1 = M0005_Line_DAO.GetInfo_M0005_Line();
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
