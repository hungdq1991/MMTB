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

namespace MMTB.View
{
    public partial class Form_M0013_3_Replace : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public M0002_DAO M0002_DAO;
        public M0004_DAO M0004_DAO;
        public M0012_DAO M0012_DAO;
        public M0013_DAO M0013_DAO;
        public System_DAL _systemDAL = new System_DAL();
        #region Tạo biến
        public DataTable _tempTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        //
        public string DocNo = "";
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo Form_M0013_3_Replace
        public Form_M0013_3_Replace()
        {
            InitializeComponent();
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M0013_3_Replace(System_DAL systemDAL)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
        }
        //Khởi tạo form,  kèm systemDAL + DocNo
        public Form_M0013_3_Replace(System_DAL systemDAL, string _docNo)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
            DocNo = _docNo;
        }
        //Load dữ liệu của Form_M0013_3_Replace
        private void GetInfo_GridView()
        {
            try
            {
                _tempTable = M0013_DAO.GetInfo_M0013_Replace();
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
        //Load form
        private void Form_M0013_3_Replace_Load(object sender, EventArgs e)
        {
            //
            M0002_DAO = new M0002_DAO();
            M0004_DAO = new M0004_DAO();
            M0012_DAO = new M0012_DAO();
            M0013_DAO = new M0013_DAO();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            cbx_View.Checked = true;
            GetInfo_GridView();
            Setting_Init_Control();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            InitValue = true;
            Set_Enable_Control(false);
        }
        /// <summary>
        ///Lấy thông tin mã hàng
        /// </summary>
        private void Add_Value_sLook_ItemCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_M0012_Update();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_ItemCode.DataSource = tempTable;
                repo_sLookUp_ItemCode.ValueMember = "ItemCode";
                repo_sLookUp_ItemCode.DisplayMember = "ItemCode";
            }
        }
        //Lấy thông tin mã hàng thay thế
        private void Add_Value_sLook_ItemCodeRe()
        {
            DataTable tempTable = new DataTable();
            string _nameEN = "";
            int[] selectedRows = gridView.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    _nameEN = Convert.ToString(gridView.GetRowCellValue(rowHandle, gridCol_NameEN));
                    if (!String.IsNullOrEmpty(_nameEN))
                    {
                        tempTable = M0012_DAO.GetInfo_M0012_ItemCodeRe(_nameEN);
                        if (tempTable.Rows.Count > 0)
                        {
                            repo_sLookUp_ItemCodeRe.DataSource = tempTable;
                            repo_sLookUp_ItemCodeRe.ValueMember = "ItemCode";
                            repo_sLookUp_ItemCodeRe.DisplayMember = "ItemCode";
                        }
                    }
                    else
                    {
                        tempTable = M0012_DAO.GetInfo_M0012_Update();
                        if (tempTable.Rows.Count > 0)
                        {
                            repo_sLookUp_ItemCodeRe.DataSource = tempTable;
                            repo_sLookUp_ItemCodeRe.ValueMember = "ItemCode";
                            repo_sLookUp_ItemCodeRe.DisplayMember = "ItemCode";
                        }
                    }
                }
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
                    string _nameEN = "";
                    string _nameVN = "";
                    string _nameJP = "";
                    string _maker = null;
                    string _unit = "";

                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _classifyID = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ClassifyID"));
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
        /// <summary>
        /// Tùy chọn thông tin cột ItemCode (TextEdit / Repo_sLookUp_ItemCode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == gridCol_ItemCode)
            {
                e.RepositoryItem = repo_sLookUp_ItemCode;
            }
            if (e.Column == gridCol_ItemCodeRe)
            {
                e.RepositoryItem = repo_sLookUp_ItemCodeRe;
                Add_Value_sLook_ItemCodeRe();
            }
        }
        #region Chức năng
        /// <summary>
        /// Click nút thêm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Set_Enable_Control(true);
            InitValue = true;
            Clear_Data();
        }
        /// <summary>
        /// Click nút Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbx_View.Checked == true)
            {
                GetInfo_GridView();
            }
            else
            {
                gridControl.DataSource = _DetailTable;
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
        /// Click chuột phải chọn Delete row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_PopUp_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Add value to datatable Delete
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["ItemCode"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemCode");
            _DeleteRowTable.Rows.Add(dtrow);

            //Delete FocusedRow in gridView
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        /// <summary>
        /// Click chuột phải chọn Add new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        /// <summary>
        /// Click nút Add new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        /// <summary>
        /// Click nút Delete row
        /// </summary>
        private void bbi_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Add value to datatable Delete
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["ItemCode"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemCode");
            _DeleteRowTable.Rows.Add(dtrow);

            //Delete FocusedRow in gridView
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        /// <summary>
        /// Click nút Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    _DetailTable = gridView.GridControl.DataSource as DataTable;
                        if (CheckError() == true)
                    {
                        //DocNo = M0013_DAO.Insert_Summary_ByModel(_DetailTable);
                        if (!String.IsNullOrEmpty(DocNo))
                        {
                            MessageBox.Show("Thêm mới/Cập nhật thành công DocNo: " + DocNo.PadLeft(6, '0')
                                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear_Data();
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
        /// Form Closing
        /// </summary>
        private void Form_M0013_3_Replace_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Bạn có muốn thoát khỏi chương trình? ",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        #region event gridView - Sự kiện liên quan gridView
        /// <summary>
        /// Show menu Pop up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var currentRow = gridView.FocusedRowHandle;
            var focusRowView = (DataRowView)gridView.GetFocusedRow();

            if (focusRowView == null || focusRowView.IsNew) return;

            if (currentRow >= 0)
            {
                popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
            }
            else
            {
                popupMenu1.HidePopup();
            }
        }
        /// <summary>
        /// Khởi tạo thêm dòng mới gridView
        /// </summary>
        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //Set value to new row
            gridView.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName.ToUpper());
            gridView.SetRowCellValue(e.RowHandle, "ConfUser", _systemDAL.userName.ToUpper());
            gridView.SetRowCellValue(e.RowHandle, "InActive", 0);
            gridView.SetRowCellValue(e.RowHandle, "ApplyDate", DateTime.Today.Date);

            // Set focus in a specific cell
            gridView.Focus();
            gridView.FocusedRowHandle = e.RowHandle;
            gridView.FocusedColumn = gridCol_ItemCode;
        }
        #endregion
        #endregion

        #region Khởi tạo form
        //Dữ liệu trên Form_M0013_3_Replace
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Định nghĩa datatable gán cho gridView
            Define_DetailTable();
            Define_DeleteRowTable();
            //
            Add_Value_sLook_ItemCode();
            //
        }
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbi_AddNewRow.Enabled = IsEnable;
            bbi_DeleteRow.Enabled = IsEnable;

            //PopUp
            //bbi_PopUp_AddNewRow.Enabled = IsEnable;
            //bbi_PopUp_DeleteRow.Enabled = IsEnable;

            //Collumn
            gridCol_InActive.OptionsColumn.AllowEdit = !IsEnable;

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
            gridView.AddNewRow();

            //Set focus in a specific cell
            gridView.FocusedColumn = gridCol_ItemCode;
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
            _DetailTable.Columns.Add("ItemCodeRe", typeof(string));
            _DetailTable.Columns.Add("NameENRe", typeof(string));
            _DetailTable.Columns.Add("NameVNRe", typeof(string));
            _DetailTable.Columns.Add("NameJPRe", typeof(string));
            _DetailTable.Columns.Add("MakerRe", typeof(string));
            _DetailTable.Columns.Add("UnitRe", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActive", typeof(int));
            _DetailTable.Columns.Add("InActiveDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActiveUser", typeof(string));
        }
        //Table_Xóa thông tin
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("ItemCode", typeof(string));
        }

        /// <summary>
        /// Các tình huống cần kiểm tra lỗi
        /// </summary>
        private Boolean CheckError()
        {
            //Kiểm tra trùng trên lưới
            //Trùng thông tin ItemCode, Maker
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _itemCode;
                string _maker;
                string _itemCodeRe;
                string _makerRe;

                _itemCode = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["ItemCode"]));
                _maker = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Maker"]));
                _itemCodeRe = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["ItemCodeRe"]));
                _makerRe = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["MakerRe"]));

                try
                {
                    DataTable _tempTable = M0013_DAO.GetInfo_M0013_CheckReplace(_itemCode, _maker, _itemCodeRe, _makerRe);
                    if (_tempTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", Master đã có (trùng Mã LK/Dầu/Pin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridControl.DataSource = _DetailTable;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void Cbx_Add_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            cbx_View.Checked = false;
            gridControl.DataSource = _DetailTable;
            Set_Enable_Control(true);
        }
    }
}