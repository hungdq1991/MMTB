using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MMTB.DAO;
using MMTB.DAL;
using System.Collections.Generic;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace MMTB.View
{
    public partial class Form_M01_GroupEmail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public M01_DAO M01_DAO;
        public System_DAL _systemDAL = new System_DAL();
        #region Tạo biến
        public DataTable _tempTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        //
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo Form_M01_GroupEmail
        public Form_M01_GroupEmail()
        {
            InitializeComponent();
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M01_GroupEmail(System_DAL systemDAL)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
        }

        //Load dữ liệu của Form_M01_GroupEmail
        private void GetInfo_gridView()
        {
            try
            {
                _tempTable = M01_DAO.GetInfo_M01_GroupEmail();
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
            //Boolean.Add("Thêm mới");
            //Boolean.Add("InActive");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Load form
        private void Form_M01_GroupEmail_Load(object sender, EventArgs e)
        {
            //
            M01_DAO = new M01_DAO();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();
            //
            GetInfo_gridView();
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
                GetInfo_gridView();
                Set_Enable_Control(false);
                gridCol_MSNV.ColumnEdit = None;
            }
            if (cbx_Status.SelectedIndex == 1)
            {
                Clear_Data();
                gridControl.DataSource = _DetailTable;
                Set_Enable_Control(true);
                gridCol_MSNV.ColumnEdit = repo_sLookUp_MSNV;
            }
            if (cbx_Status.SelectedIndex == 2)
            {
                Clear_Data();
                gridControl.DataSource = _DetailTable;
                Set_Enable_Control(true);
                gridCol_Dept.OptionsColumn.AllowEdit = false;
                gridCol_Memo.OptionsColumn.AllowEdit = false;
                gridCol_ApplyDate.OptionsColumn.AllowEdit = false;
                gridCol_MSNV.ColumnEdit = repo_sLookUp_MSNV_Stop;
            }
        }
        /// <summary>
        ///Lấy thông tin NV
        /// </summary>
        private void Add_Value_sLook_MSNV()
        {
            DataTable tempTable = new DataTable();
            tempTable = M01_DAO.GetInfo_M01_MSNV();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_MSNV.DataSource = tempTable;
                repo_sLookUp_MSNV.ValueMember = "MSNV";
                repo_sLookUp_MSNV.DisplayMember = "MSNV";
            }
        }
        /// <summary>
        ///Lấy thông tin NV cần InActive
        /// </summary>
        private void Add_Value_sLook_MSNV_Stop()
        {
            DataTable tempTable = new DataTable();
            tempTable = M01_DAO.GetInfo_M01_MSNV_Stop();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_MSNV_Stop.DataSource = tempTable;
                repo_sLookUp_MSNV_Stop.ValueMember = "MSNV";
                repo_sLookUp_MSNV_Stop.DisplayMember = "MSNV";
            }
            else if (tempTable.Rows.Count == 0)
            {
                repo_sLookUp_MSNV_Stop.DataSource = "";
            }
        }
        /// <summary>
        ///Điền thông tin NV
        /// </summary>
        private void SLook_MSNV_CloseUp(object sender, CloseUpEventArgs e)
        {
            try
            {
                if (e.CloseMode == PopupCloseMode.Normal)
                {
                    string _MSNV = "";
                    string _name = "";
                    string _dept = "";
                    string _position = "";

                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _MSNV = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("MSNV"));
                    _name = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Name"));
                    _dept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DepartID"));
                    _position = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("PositionID"));

                    //Set value to column
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "MSNV", _MSNV);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Name", _name);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "DepartID", _dept);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "PositionID", _position);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Điền thông tin NV thôi việc
        private void sLook_MSNV_Stop_CloseUp(object sender, CloseUpEventArgs e)
        {
            try
            {
                if (e.CloseMode == PopupCloseMode.Normal)
                {
                    string _MSNV = "";
                    string _name = "";
                    string _dept = "";
                    string _position = "";
                    string _phone = "";
                    string _intPhone = "";
                    string _handPhone = "";
                    string _email = "";

                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _MSNV = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("MSNV"));
                    _name = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Name"));
                    _dept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DepartID"));
                    _position = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("PositionID"));
                    _phone = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Phone"));
                    _intPhone = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("IntPhone"));
                    _handPhone = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("HandPhone"));
                    _email = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Email"));

                    //Set value to column
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "MSNV", _MSNV);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Name", _name);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "DepartID", _dept);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "PositionID", _position);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Phone", _phone);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "IntPhone", _intPhone);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "HandPhone", _handPhone);
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "Email", _email);
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
                    _DetailTable = gridControl.DataSource as DataTable;
                    if (cbx_Status.SelectedIndex == 1)
                    {
                        if (CheckError() == true)
                        {
                            if (M01_DAO.Insert_TelEmail(_DetailTable))
                            {
                                MessageBox.Show("Thêm mới/Cập nhật thành công!"
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear_Data();
                            }
                            else
                            {
                                MessageBox.Show("Thêm mới/Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                gridView.FocusedColumn = gridCol_MSNV;
                            }
                        }
                    }
                    if (cbx_Status.SelectedIndex == 2)
                    {
                        if (M01_DAO.InActive_TelEmail(_DetailTable))
                        {
                            MessageBox.Show("Cập nhật 'MSNV thôi việc' thành công!"
                                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear_Data();
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới/Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gridView.FocusedColumn = gridCol_MSNV;
                        }
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
        private void Form_M01_GroupEmail_FormClosing(object sender, FormClosingEventArgs e)
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
            gridView.SetRowCellValue(e.RowHandle, "InActiveIntPhone", 0);
            gridView.SetRowCellValue(e.RowHandle, "InActiveEmail", 0);
            gridView.SetRowCellValue(e.RowHandle, "InActiveIntPhoneUser", _systemDAL.userName.ToUpper());
            gridView.SetRowCellValue(e.RowHandle, "InActiveEmailUser", _systemDAL.userName.ToUpper());
            gridView.SetRowCellValue(e.RowHandle, "ApplyDate", DateTime.Today.Date);

            // Set focus in a specific cell
            gridView.Focus();
            gridView.FocusedRowHandle = e.RowHandle;
            gridView.FocusedColumn = gridCol_MSNV;
        }
        #endregion
        #endregion

        #region Khởi tạo form
        //Dữ liệu trên Form_M01_GroupEmail
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Định nghĩa datatable gán cho gridView
            Define_DetailTable();
            //
            Add_Value_sLook_MSNV();
        }
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Collumn
            gridCol_MSNV.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Dept.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Memo.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ApplyDate.OptionsColumn.AllowEdit = IsEnable;
            gridCol_InActiveEmail.OptionsColumn.AllowEdit = IsEnable;

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
            gridView.FocusedColumn = gridCol_MSNV;
            Add_Value_sLook_MSNV();
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
            _DetailTable.Columns.Add("GroupEmail", typeof(string));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("MSNV", typeof(string));
            _DetailTable.Columns.Add("Name", typeof(string));
            _DetailTable.Columns.Add("DepartID", typeof(string));
            _DetailTable.Columns.Add("PositionID", typeof(string));
            _DetailTable.Columns.Add("Email", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActive", typeof(int));
            _DetailTable.Columns.Add("InputUser", typeof(string));
            _DetailTable.Columns.Add("InActiveUser", typeof(string));
            _DetailTable.Columns.Add("PwEmail", typeof(string));
            _DetailTable.Columns.Add("Status", typeof(string));
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
        private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        //Xuất file excel
        private void BbiExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportExcel("");
        }
        //Xuất excel
        private void ExportExcel(string fileName)
        {
            try
            {
                if (gridView.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = fileName;
                    dialog.Filter = @"Microsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView.ColumnPanelRowHeight = 40;
                        gridView.OptionsPrint.AutoWidth = AutoSize;
                        gridView.OptionsPrint.ShowPrintExportProgress = true;
                        gridView.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"List";
                        gridView.OptionsPrint.PrintHorzLines = false;
                        gridView.OptionsPrint.PrintVertLines = false;
                        ExportSettings.DefaultExportType = ExportType.Default;
                        gridView.ExportToXlsx(dialog.FileName, options);
                        MessageBox.Show("Xuất dũ liệu thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi" + e, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}