using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MMTB.Report;
using DevExpress.XtraReports.UI;

namespace MMTB.View
{
    public partial class Form_M0013_Dau : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0002_DAO M0002_DAO;
        public M0013_DAO M0013_DAO;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0013_Dau()
        {
            InitializeComponent();
        }

        public Form_M0013_Dau(System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }
        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013_NoPrice("5");
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
        /// <summary>
        /// Hiển thị dữ liệu cho ô classify
        /// </summary>
        private void Add_Value_Classify()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M01_Classify();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_Classify.DataSource = tempTable;
                repo_sLookUp_Classify.ValueMember = "ClassifyID";
                repo_sLookUp_Classify.DisplayMember = "ClassifyDesc";
            }
        }
        //Load form 
        private void Form_M0013_Dau_Load(object sender, EventArgs e)
        {
            //_tempTable = new DataTable();
            M0002_DAO = new M0002_DAO();
            M0013_DAO = new M0013_DAO();

            //
            bsiUser.Caption = _systemDAL.userName.ToUpper().ToUpper();
            Add_Value_Classify();
            GetInfo_GridView();
        }
        //Nhấn nút Refresh
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
        }
        //Nhấn nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Nhấn nút Item
        private void BbiItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_2_ByItem formDetail = new Form_M0013_2_ByItem(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        //Nhấn nút Maker
        private void BbiMaker_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_1_ByModel formDetail = new Form_M0013_1_ByModel(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        /// <summary>
        /// Thông tin số dòng khi filter các column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }

        private void BbiLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013("5");
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
    }
}