﻿using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0012_Stock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M0012_DAO M0012_DAO;
        public const Boolean AddNew = true;
        //
        public System_DAL _systemDAL = new System_DAL();
        public Form_M0012_Stock(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        private void Form_M0012_Stock_Load(object sender, EventArgs e)
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
            //try
            //{
            //    _tempTable = M0012_DAO.GetInfo_M0012_Stock(0);
            //    if (_tempTable.Rows.Count > 0)
            //    {
            //        gridControl.DataSource = _tempTable;
            //        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //Hiển thị dữ liệu và refresh gridview
        private void Setting_Init_Form()
        {
            GetInfo_Gridview();
            gridView.ClearFindFilter();
        }
        //Thay đổi thông tin số lượng records khi filter
        private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption =gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        //Lọc thông tin
        private void filter_List()
        {
            Boolean _inActive = bCheck_InActive.Checked;
            try
            {
                if (_inActive == true)
                {
                    DataTable _tempTable = M0012_DAO.GetInfo_M0012_Dup();
                    if (_tempTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable.AsEnumerable()
                            .Where(row => row.Field<Boolean>("InActive") == true).CopyToDataTable();
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                    }
                    if (_tempTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có mã hàng trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (_inActive == false)
                {
                    DataTable _tempTable1 = M0012_DAO.GetInfo_M0012_Dup();
                    if (_tempTable1.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable1;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable1.Rows.Count + " records";
                    }
                    if (_tempTable1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có mã hàng trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //Nhấn nút refresh
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            bCheck_InActive.Checked = false;
            GetInfo_Gridview();
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
    }
}