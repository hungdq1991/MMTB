﻿using System;
using System.Data;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.DAL;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0004 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0004_DAO M0004_DAO;
        public const Boolean AddNew = true;

        //
        public System_DAL _systemDAL = new System_DAL();

        //Khởi tạo form
        public Form_M0004()
        {
            InitializeComponent();
        }

        //Khởi tạo form M0004
        public Form_M0004(System_DAL System_DAL)
        {
            InitializeComponent();

            _systemDAL = System_DAL;
        }

        //Load dữ liệu
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0004_DAO.GetInfo_M0004();

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
        //Load form
        private void Form_M0004_Load(object sender, System.EventArgs e)
        {

            _tempTable = new DataTable();
            //
            M0004_DAO = new M0004_DAO();
            //Load Init
            GetInfo_Gridview();
        }
        //Hiển thị dữ liệu và refresh gridview
        private void Setting_Init_Form()
        {
            GetInfo_Gridview();
            gridView.ClearFindFilter();
        }
        //Nội dung hiển thị khi thay đổi chọn filter các column
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count.ToString() + " records";
        }
        //Nội dung hiển thị khi double click trên lưới
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0004_Detail formDetail = new Form_M0004_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Thêm mới"
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004_Detail formDetail = new Form_M0004_Detail(AddNew))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Chỉnh sửa"
        private void BbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004_Detail formDetail = new Form_M0004_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Xóa"
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004_Detail formDetail = new Form_M0004_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Refresh"
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            Setting_Init_Form();
        }
    }
}