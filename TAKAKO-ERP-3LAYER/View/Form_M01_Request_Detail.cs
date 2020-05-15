using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MMTB.DAO;
using MMTB.DAL;
using MMTB.Report;
using DevExpress.XtraReports.UI;
using System;

namespace MMTB.View
{
    public partial class Form_M01_Request_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        //
        public M01_DAO M01_DAO;
        public M0005_DAO M0005_DAO;
        //
        public System_DAL _systemDAL = new System_DAL();
        public String DocNo = "";
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo Form_M01_Request_Detail
        public Form_M01_Request_Detail()
        {
            InitializeComponent();
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M01_Request_Detail(System_DAL systemDAL)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M01_Request_Detail(String _docNo, System_DAL systemDAL)
        {
            InitializeComponent();
            DocNo = _docNo;
            //
            _systemDAL = systemDAL;
        }
        //Load form
        private void Form_M01_Request_Detail_Load(object sender, EventArgs e)
        {
            //
            M01_DAO = new M01_DAO();
            M0005_DAO = new M0005_DAO();
            _HeaderTable = new DataTable();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();
            //
            bsiUser.Caption = _systemDAL.userName;
            //Load Init
            InitValue = true;
            //Set_Enable_Control(true);

        }
        /// <summary>
        /// Điền dữ liệu cho ô Bộ phận
        /// </summary>
        private void AddValue_sLook_ControlDept()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_ControlDept();
            if (tempTable.Rows.Count > 0)
            {
                sLook_ControlDept.Properties.DataSource = tempTable;
                sLook_ControlDept.Properties.ValueMember = "SectionID";
                sLook_ControlDept.Properties.DisplayMember = "SectionID";
            }
        }
        /// <summary>
        /// Điền dữ liệu cho ô kiểm tra chương trình có hay không
        /// </summary>
        private void Add_Value_repo_sLookUp_Check()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Check", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["Check"] = "Không";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 1;
            dtRow2["Check"] = "Có";
            _ResultTable.Rows.Add(dtRow2);

            repo_sLookUp_Check.DataSource = _ResultTable;
            repo_sLookUp_Check.ValueMember = "STT";
            repo_sLookUp_Check.DisplayMember = "Check";
        }
        /// <summary>
        /// Hiển thị dữ liệu cho ô mã + tên chương trình
        /// </summary>
        private void Add_Value_repo_sLookUp_Program()
        {
            DataTable tempTable = new DataTable();
            tempTable = M01_DAO.GetInfo_M01_Program();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_Program.DataSource = tempTable;
                repo_sLookUp_Program.ValueMember = "Program";
                repo_sLookUp_Program.DisplayMember = "Program";
            }
        }
        /// <summary>
        ///Điền thông tin program
        /// </summary>
        private void repo_sLookUp_Program_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                string _program = "";
                string _programDesc = "";
                //Get index
                SearchLookUpEdit editor = sender as SearchLookUpEdit;
                int index = editor.Properties.GetIndexByKeyValue(editor.EditValue);

                //Set value to variables
                _program = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Program"));
                _programDesc = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ProgramDesc"));

                //Set value to column Program name
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "Program", _program);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "ProgramDesc", _programDesc);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "Check", 1);
            }
        }
        /// <summary>
        /// Điền dữ liệu cho ô yêu cầu
        /// </summary>
        private void AddValue_CBox_ReqType()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("ReqType", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["ReqType"] = "Chỉnh sửa";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 1;
            dtRow1["ReqType"] = "Thêm chức năng";
            _ResultTable.Rows.Add(dtRow1);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 2;
            dtRow2["ReqType"] = "Báo lỗi";
            _ResultTable.Rows.Add(dtRow2);

            DataRow dtRow3 = _ResultTable.NewRow();
            dtRow3["STT"] = 3;
            dtRow3["ReqType"] = "Thêm chương trình";
            _ResultTable.Rows.Add(dtRow3);

            repo_sLookUp_ReqType.DataSource = _ResultTable;
            repo_sLookUp_ReqType.ValueMember = "STT";
            repo_sLookUp_ReqType.DisplayMember = "ReqType";
        }
        /// <summary>
        ///Xác nhận IT
        /// </summary>
        private void Add_Value_repo_sLookUp_Confirm()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Confirm", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["Confirm"] = "Chưa nhận thông tin";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 1;
            dtRow1["Confirm"] = "Đang thực hiện";
            _ResultTable.Rows.Add(dtRow1);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 2;
            dtRow2["Confirm"] = "Đã nhận thông tin";
            _ResultTable.Rows.Add(dtRow2);

            DataRow dtRow3 = _ResultTable.NewRow();
            dtRow3["STT"] = 3;
            dtRow3["Confirm"] = "Đã hoàn thành";
            _ResultTable.Rows.Add(dtRow3);

            DataRow dtRow4 = _ResultTable.NewRow();
            dtRow4["STT"] = 4;
            dtRow4["Confirm"] = "Hủy yêu cầu";
            _ResultTable.Rows.Add(dtRow4);

            repo_sLookUp_Confirm.DataSource = _ResultTable;
            repo_sLookUp_Confirm.ValueMember = "STT";
            repo_sLookUp_Confirm.DisplayMember = "Confirm";
        }
        /// <summary>
        /// Tạo nội dung combo box cho user lựa chọn: Yes/No (trạng thái chứng từ)
        /// </summary>
        /// <param name="comboBox"></param>
        private void AddValue_CBox_Status(ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Chuẩn bị");
            Boolean.Add("Xác nhận");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        /// <summary>
        /// Điền dữ liệu cho ô Số chứng từ
        /// </summary>
        private void Add_Value_sLookUp_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M01_DAO.GetInfo_M01_DocNo();
            if (tempTable.Rows.Count > 0)
            {
                sLook_DocNo.Properties.DataSource = tempTable;
                sLook_DocNo.Properties.ValueMember = "DocNo";
                sLook_DocNo.Properties.DisplayMember = "DocNo";
            }
            else
            {
                sLook_DocNo.Properties.DataSource = "";
            }
        }
        /// <summary>
        /// Lấy số chứng từ, điền thông tin vào Form_M01_Request_Detail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SLook_DocNo_TextChanged(object sender, System.EventArgs e)
        {
            if (sLook_DocNo.EditValue != null)
            {
                DocNo = sLook_DocNo.EditValue.ToString();
            }
            try
            {
                if (!string.IsNullOrEmpty(DocNo))
                {
                    _HeaderTable.Clear();
                    _HeaderTable = M01_DAO.GetInfo_M01_Header(DocNo);

                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                    }

                    _DetailTable.Clear();
                    _DetailTable = M01_DAO.GetInfo_M01_Detail(DocNo);
                    if (_DetailTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _DetailTable;
                        bsiRecordsCount.Caption = "Records: " + _DetailTable.Rows.Count;
                    }

                    if (InitValue)
                    {
                        _InitHeaderTable = _HeaderTable.Copy();
                        _InitDetailTable = _DetailTable.Copy();
                        InitValue = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Set_Edit_Control(false);
            InitValue = true;
            Clear_Data();
        }
        
        /// <summary>
        /// Click nút Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            }
            else
            {
                SLook_DocNo_TextChanged(sender, e);
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
            dtrow["Check"] = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "Check");
            _DeleteRowTable.Rows.Add(dtrow);

            //Delete FocusedRow in advBandedGridView1
            var row = advBandedGridView1.FocusedRowHandle;
            advBandedGridView1.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }

        /// <summary>
        /// Click chuột phải chọn Add new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            advBandedGridView1.AddNewRow();
        }
        /// <summary>
        /// Click nút Add new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            advBandedGridView1.AddNewRow();
        }
        /// <summary>
        /// Click nút Delete row
        /// </summary>
        private void bbi_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Add value to datatable Delete
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["Check"] = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "Check");
            _DeleteRowTable.Rows.Add(dtrow);

            //Delete FocusedRow in advBandedGridView1
            var row = advBandedGridView1.FocusedRowHandle;
            advBandedGridView1.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        /// <summary>
        /// Click nút Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            sLook_DocNo.Focus();
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (CheckError() == true)
                {
                    try
                    {
                        string DocNo = "";
                        _DetailTable = advBandedGridView1.GridControl.DataSource as DataTable;
                        if (cbx_Status.SelectedIndex == 0)
                        {
                            DocNo = M01_DAO.Insert_Request(_DetailTable, _DeleteRowTable, GetValue_Header());
                            if (!String.IsNullOrEmpty(DocNo))
                            {
                                MessageBox.Show("Thêm mới/Cập nhật thành công DocNo: " + DocNo.PadLeft(6, '0')
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear_Data();
                            }
                            else
                            {
                                MessageBox.Show("Thêm mới/Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (cbx_Status.SelectedIndex == 1)
                        {
                            if (M01_DAO.Update_Request(_DetailTable, _DeleteRowTable, GetValue_Header()))
                            {
                                MessageBox.Show("Đã xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        Clear_Data();
                        Add_Value_sLookUp_DocNo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Click nút IT (chờ chức năng phân quyền)
        /// </summary>
        private void BbiIT_ItemClick(object sender, ItemClickEventArgs e)
        {
            sLook_DocNo.Focus();
            if (CheckError_IT() == true)
            {
                try
                {
                    sLook_DocNo.Focus();
                    _DetailTable = advBandedGridView1.GridControl.DataSource as DataTable;
                    if (M01_DAO.Update_Request_IT(_DetailTable, GetValue_Header()))
                    {
                        MessageBox.Show("Đã xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Clear_Data();
                    Add_Value_sLookUp_DocNo();
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
        private void Form_M01_Request_Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Bạn có muốn thoát khỏi chương trình? ",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        #region event advBandedGridView1 - Sự kiện liên quan gridView
        /// <summary>
        /// Show menu Pop up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var currentRow = advBandedGridView1.FocusedRowHandle;
            var focusRowView = (DataRowView)advBandedGridView1.GetFocusedRow();

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
        private void advBandedGridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //Set value to new row
            advBandedGridView1.SetRowCellValue(e.RowHandle, "Check", 0);
            advBandedGridView1.SetRowCellValue(e.RowHandle, "Urgent", 0);

            // Set focus in a specific cell
            advBandedGridView1.Focus();
            advBandedGridView1.FocusedRowHandle = e.RowHandle;
            advBandedGridView1.FocusedColumn = gridCol_Program;
        }
        #endregion
        #endregion

        #region Khởi tạo form
        //Dữ liệu trên Form_M01_Request_Detail
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName;
            //Định nghĩa datatable gán cho header
            Define_HeaderTable();
            //Định nghĩa datatable gán cho advBandedGridView1
            Define_DetailTable();
            Define_DeleteRowTable();
            //
            AddValue_CBox_Status(cbx_Status);
            Add_Value_repo_sLookUp_Check();
            Add_Value_sLookUp_DocNo();
            AddValue_sLook_ControlDept();
            Add_Value_repo_sLookUp_Program();
            AddValue_CBox_ReqType();
            Add_Value_repo_sLookUp_Confirm();
            //
        }
        private void Setting_Init_Value()
        {
            if (!String.IsNullOrEmpty(DocNo))
            {
                sLook_DocNo.EditValue = DocNo;
            }
            else
            {
                Clear_Data();
            }
        }
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbi_PopUp_AddNewRow.Enabled = IsEnable;
            bbi_PopUp_DeleteRow.Enabled = IsEnable;

            //PopUp
            bbi_PopUp_AddNewRow.Enabled = IsEnable;
            bbi_PopUp_DeleteRow.Enabled = IsEnable;

            //Header
            date_Doc.Enabled = IsEnable;
            sLook_ControlDept.Enabled = IsEnable;
            txt_ReqMemo.Enabled = IsEnable;
            cbx_Status.Enabled = IsEnable;
            
            //Collumn
            gridCol_Check.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Program.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ReqType.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ReqDesc.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Reason.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Memo.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Urgent.OptionsColumn.AllowEdit = IsEnable;
            
            //Button
            bbiSave.Enabled = IsEnable;

            //advBandedGridView1
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }
        private void Set_Edit_Control(Boolean IsEdit)
        {
            gridCol_ITConfirm.OptionsColumn.AllowEdit = IsEdit;
            gridCol_ITConfDate.OptionsColumn.AllowEdit = IsEdit;
            gridCol_ITMemo.OptionsColumn.AllowEdit = IsEdit;
            //Button
            bbiIT.Enabled = IsEdit;
        }
        //Xóa dữ liệu
        private void Clear_Data()
        {
            //Clear header
            DocNo = "";
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            sLook_ControlDept.EditValue = null;
            txt_ReqMemo.Text = "";
            cbx_Status.SelectedIndex = 0;

            //Clear detail
            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;
            advBandedGridView1.AddNewRow();

            //Refresh value for sLookUp DocNo
            Add_Value_sLookUp_DocNo();

            //Focus on the first item
            sLook_DocNo.Focus();
        }
        #endregion

        /// <summary>
        /// Hiển thị dữ liệu trên cột, ngày tháng không có
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advBandedadvBandedGridView111_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ConfDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
            if (e.Column.FieldName == "ITConfDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
        }
        /// <summary>
        /// Định nghĩa cấu trúc datatable gán cho grid control
        /// </summary>
        //Định nghĩa bảng Header
        private void Define_HeaderTable()
        {
            //Các cột theo bảng M01_Request
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ControlDept", typeof(string));
            _HeaderTable.Columns.Add("DocStatus", typeof(int));
            _HeaderTable.Columns.Add("ReqMemo", typeof(string));
            _HeaderTable.Columns.Add("UserName", typeof(string));
            _HeaderTable.Columns.Add("ConfUser", typeof(string));
            _HeaderTable.Columns.Add("ITConf", typeof(string));
        }
        //Giá trị cho Header
        private DataTable GetValue_Header()
        {
            DataTable _tempTable = new DataTable();
            _tempTable = _HeaderTable.Clone();

            DataRow dtRow = _tempTable.NewRow();
            dtRow["DocNo"] = sLook_DocNo.EditValue;
            dtRow["DocDate"] = date_Doc.EditValue;
            dtRow["ControlDept"] = sLook_ControlDept.EditValue;
            dtRow["DocStatus"] = cbx_Status.SelectedIndex;
            dtRow["ReqMemo"] = txt_ReqMemo.EditValue;
            dtRow["UserName"] = bsiUser.ToString();
            dtRow["ConfUser"] = bsiUser.ToString();
            dtRow["ITConf"] = bsiUser.ToString();
            _tempTable.Rows.Add(dtRow);

            return _tempTable;
        }
        //Điền dữ liệu cho header
        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            sLook_ControlDept.EditValue = _tempTable.Rows[0].Field<string>("ControlDept").Trim();
            if (_tempTable.Rows[0].Field<Boolean>("DocStatus"))
            {
                cbx_Status.SelectedIndex = 1;
                Set_Enable_Control(false);
                Set_Edit_Control(true);
            }
            else
            {
                cbx_Status.SelectedIndex = 0;
                Set_Enable_Control(true);
                Set_Edit_Control(false);
            }
            txt_ReqMemo.EditValue = _tempTable.Rows[0].Field<string>("ReqMemo").Trim();
            _systemDAL.userName = _tempTable.Rows[0].Field<string>("UserName").Trim();
            _systemDAL.userName = _tempTable.Rows[0].Field<string>("ConfUser").Trim();
        }
        //Detail table
        private void Define_DetailTable()
        {
            //Các cột theo bảng M01_Request
            _DetailTable.Columns.Add("DocNo", typeof(string));
            _DetailTable.Columns.Add("Check", typeof(int));
            _DetailTable.Columns.Add("Program", typeof(string));
            _DetailTable.Columns.Add("ProgramDesc", typeof(string));
            _DetailTable.Columns.Add("ReqType", typeof(string));
            _DetailTable.Columns.Add("ReqDesc", typeof(string));
            _DetailTable.Columns.Add("Reason", typeof(string));
            _DetailTable.Columns.Add("Urgent", typeof(int));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("ConfUser", typeof(string));
            _DetailTable.Columns.Add("ConfDate", typeof(DateTime));
            _DetailTable.Columns.Add("ITConfirm", typeof(string));
            _DetailTable.Columns.Add("ITConfDate", typeof(DateTime));
            _DetailTable.Columns.Add("ITMemo", typeof(string));
        }
        //Table_Xóa thông tin
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("Check", typeof(int));
        }
        
        /// <summary>
        /// Các tình huống cần kiểm tra lỗi
        /// </summary>
        private Boolean CheckError()
        {
            //Bộ phận
            string Dept = Convert.ToString(sLook_ControlDept.EditValue);
            if (String.IsNullOrEmpty(Dept))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận yêu cầu\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ControlDept.Focus();
                return false;
            }
            //Ghi chú
            if (String.IsNullOrEmpty(txt_ReqMemo.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Ghi chú\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ReqMemo.Focus();
                return false;
            }
            //Gridview
            for (int rows = 0; rows < advBandedGridView1.RowCount; rows++)
            {
                string _reqType, _reqDesc, _reason;
                //Yêu cầu
                _reqType = Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ReqType"]));
                if (String.IsNullOrEmpty(_reqType))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Yêu cầu\" chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    advBandedGridView1.Focus();
                    advBandedGridView1.FocusedRowHandle = rows;
                    advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["ReqType"];
                    return false;
                }

                //Diễn giải yêu cầu
                _reqDesc = Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ReqDesc"]));
                if (String.IsNullOrEmpty(_reqDesc))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Diễn giải yêu cầu\" chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    advBandedGridView1.Focus();
                    advBandedGridView1.FocusedRowHandle = rows;
                    advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["ReqDesc"];
                    return false;
                }

                //Lý do
                _reason = Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["Reason"]));
                if (String.IsNullOrEmpty(_reason))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Lý do\" chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    advBandedGridView1.Focus();
                    advBandedGridView1.FocusedRowHandle = rows;
                    advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["Reason"];
                    return false;
                }
            }
                return true;
        }
        //Ngày IT xác nhận
        private Boolean CheckError_IT()
        {
            for (int rows = 0; rows < advBandedGridView1.RowCount; rows++)
            {
                DateTime _ITConfDate, _confDate;
                if (!String.IsNullOrEmpty(Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ITConfDate"]))))
                {
                    _ITConfDate = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ITConfDate"]));
                    _confDate = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ConfDate"]));
                    if (_ITConfDate.Date < _confDate.Date)
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Ngày IT xác nhận < Ngày yêu cầu?\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        advBandedGridView1.Focus();
                        advBandedGridView1.FocusedRowHandle = rows;
                        advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["ITConfDate"];
                        return false;
                    }
                }
                if (String.IsNullOrEmpty(Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["ITConfDate"]))))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Ngày IT xác nhận\"chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    advBandedGridView1.Focus();
                    advBandedGridView1.FocusedRowHandle = rows;
                    advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["ITConfDate"];
                    return false;
                }
            }
            return true;
        }
    }
}

