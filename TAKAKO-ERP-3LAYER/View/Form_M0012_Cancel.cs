using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MMTB.DAO;
using MMTB.DAL;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace MMTB.View
{
    public partial class Form_M0012_Cancel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public M0012_DAO M0012_DAO;
        public System_DAL _systemDAL = new System_DAL();
        #region Tạo biến
        public DataTable _tempTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        //
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo Form_M0012_Cancel
        public Form_M0012_Cancel()
        {
            InitializeComponent();
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M0012_Cancel(System_DAL systemDAL)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
        }

        //Load dữ liệu của Form_M0012_Cancel
        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0012_DAO.GetInfo_M0012_Cancel();
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
        //Các trạng thái nhập liệu/xem dữ liệu
        private void AddValue_CBox_Status(ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Xem thông tin");
            Boolean.Add("Thêm mới");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Load form
        private void Form_M0012_Cancel_Load(object sender, EventArgs e)
        {
            //
            M0012_DAO = new M0012_DAO();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();
            //
            GetInfo_GridView();
            //
            Setting_Init_Control();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            InitValue = true;
            Set_Enable_Control(false);
            AddValue_CBox_Status(cbx_Status);
            cbx_Status.SelectedIndex = 0;
        }
        //Chuyển đổi vị trí thao tác
        private void Cbx_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Status.SelectedIndex == 0)
            {
                GetInfo_GridView();
                Set_Enable_Control(false);
                gridCol_ItemCode.ColumnEdit = None;
            }
            if (cbx_Status.SelectedIndex == 1)
            {
                Clear_Data();
                gridControl.DataSource = _DetailTable;
                Set_Enable_Control(true);
                gridCol_ItemCode.ColumnEdit = repo_sLookUp_ItemCode;
            }
         }
        /// <summary>
        ///Lấy thông tin mã hàng
        /// </summary>
        private void Add_Value_sLook_ItemCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_M0012_ItemCode_Cancel();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_ItemCode.DataSource = tempTable;
                repo_sLookUp_ItemCode.ValueMember = "ItemCode";
                repo_sLookUp_ItemCode.DisplayMember = "ItemCode";
            }
        }
        /// <summary>
        ///Điền thông tin mã hàng
        /// </summary>
        private void SLook_ItemCode_CloseUp(object sender, CloseUpEventArgs e)
        {
            try
            {
                if (e.CloseMode == PopupCloseMode.Normal)
                {
                    string _classifyID = "";
                    string _itemCode = "";
                    string _nameEN = "";
                    string _nameVN = "";
                    string _nameJP = "";
                    string _maker = null;
                    string _unit = "";

                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _classifyID = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ClassifyID"));
                    _itemCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ItemCode"));
                    _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
                    _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
                    _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
                    if (String.IsNullOrEmpty(Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"))))
                    {
                        _maker = null;
                    }
                    else
                    {
                        _maker = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"));
                    }
                    _unit = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Unit"));

                    //Set value to column
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "ClassifyID", _classifyID);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "ItemCode", _itemCode);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameEN", _nameEN);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameVN", _nameVN);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameJP", _nameJP);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Maker", _maker);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Unit", _unit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Chức năng
        /// <summary>
        /// Click nút Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonControl.Focus();
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    if (CheckError() == true)
                    {
                        _DetailTable = gridControl.DataSource as DataTable;
                        if (cbx_Status.SelectedIndex == 1)
                        {
                            if (M0012_DAO.Insert_Item_Cancel(_DetailTable))
                            {
                                MessageBox.Show("Thêm mới/Cập nhật thành công!"
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear_Data();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới/Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.FocusedColumn = gridCol_ItemCode;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Click nút Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Form Closing
        /// </summary>
        private void Form_M0012_Cancel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Bạn có muốn thoát khỏi chương trình? ",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }
        #region event gridView - Sự kiện liên quan gridView
        /// <summary>
        /// Khởi tạo thêm dòng mới gridView
        /// </summary>
        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //Set value to new row
            gridView.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName.ToUpper());
            gridView.SetRowCellValue(e.RowHandle, "ApplyDate", DateTime.Today.Date);

            // Set focus in a specific cell
            gridView.Focus();
            gridView.FocusedRowHandle = e.RowHandle;
            gridView.FocusedColumn = gridCol_ItemCode;
        }
        #endregion
        #endregion

        #region Khởi tạo form
        //Dữ liệu trên Form_M0012_Cancel
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Định nghĩa datatable gán cho gridView
            Define_DetailTable();
            //
            Add_Value_sLook_ItemCode();
        }
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Collumn
            gridCol_ItemCode.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Maker.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Memo.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ApplyDate.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ClassifyDesc.Visible = !IsEnable;

            //Button
            bbiSave.Enabled = IsEnable;

            //gridView
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }

        //Xóa dữ liệu
        private void Clear_Data()
        {
            //Clear detail
            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;

            //Set focus in a specific cell
            gridView.FocusedColumn = gridCol_ItemCode;
            Add_Value_sLook_ItemCode();
            gridView.AddNewRow();
        }
        #endregion
        /// <summary>
        /// Định nghĩa cấu trúc datatable gán cho grid control
        /// </summary>
        //Định nghĩa bảng Detail table
        private void Define_DetailTable()
        {
            //Các cột theo bảng M0013_Master_Supply_Replace
            _DetailTable.Columns.Add("ClassifyID", typeof(string));
            _DetailTable.Columns.Add("ItemCode", typeof(string));
            _DetailTable.Columns.Add("NameEN", typeof(string));
            _DetailTable.Columns.Add("NameVN", typeof(string));
            _DetailTable.Columns.Add("NameJP", typeof(string));
            _DetailTable.Columns.Add("Maker", typeof(string));
            _DetailTable.Columns.Add("Unit", typeof(string));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InputUser", typeof(string));
        }
        /// <summary>
        /// Các tình huống cần kiểm tra lỗi
        /// </summary>
        private Boolean CheckError()
        {
            try
            {
                for (int rows = 0; rows < gridView.RowCount; rows++)
                {
                    //Ghi chú
                    string _memo = "";
                    _memo = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Memo"]));
                    if (String.IsNullOrEmpty(_memo))
                    {
                        MessageBox.Show("Cột \"Ghi chú\" chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["Memo"];
                        return false;
                    }
                    //Ngày hiệu lực
                    DateTime _applyDate = Convert.ToDateTime(gridView.GetRowCellValue(rows, gridView.Columns["ApplyDate"]));
                    if (_applyDate.Date < DateTime.Today.Date)
                    {
                        MessageBox.Show("Cột \"Ngày hiệu lực\" phải lớn hơn hoặc bằng ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["ApplyDate"];
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        /// <summary>
        /// Hiển thị số dòng khi filter column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
        }
    }
}