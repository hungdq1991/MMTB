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
    public partial class Form_M0013_2_ByItem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public M0002_DAO M0002_DAO;
        public M0004_DAO M0004_DAO;
        public M0005_DAO M0005_DAO;
        public M0012_DAO M0012_DAO;
        public M0013_DAO M0013_DAO;
        public System_DAL _systemDAL = new System_DAL();
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        //
        public string DocNo = "";
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo Form_M0013_2_ByItem
        public Form_M0013_2_ByItem()
        {
            InitializeComponent();
        }
        //Khởi tạo form,  kèm systemDAL
        public Form_M0013_2_ByItem(System_DAL systemDAL)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
        }
        //Khởi tạo form,  kèm systemDAL + DocNo
        public Form_M0013_2_ByItem(System_DAL systemDAL, string _docNo)
        {
            InitializeComponent();
            //
            _systemDAL = systemDAL;
            DocNo = _docNo;
        }
        //Load form
        private void Form_M0013_2_ByItem_Load(object sender, EventArgs e)
        {
            //
            M0002_DAO = new M0002_DAO();
            M0004_DAO = new M0004_DAO();
            M0005_DAO = new M0005_DAO();
            M0012_DAO = new M0012_DAO();
            M0013_DAO = new M0013_DAO();
            _HeaderTable = new DataTable();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Load Init
            InitValue = true;

            Set_Enable_Control(true);
        }
        /// <summary>
        /// Lấy số chứng từ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Value_sLookUp_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0013_DAO.GetInfo_M0013_DocNo("M0013_2");
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
        /// Điền thông tin vào Form_M0013_2_ByItem theo số chứng từ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SLook_DocNo_TextChanged(object sender, EventArgs e)
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
                    _HeaderTable = M0013_DAO.GetInfo_M0013_Header_Item(DocNo);

                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                    }

                    _DetailTable.Clear();
                    _DetailTable = M0013_DAO.GetInfo_M0013_Detail(DocNo);
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
        /// <summary>
        ///Điền thông tin NameVN, NameJP, Maker, Model
        /// </summary>
        private void SLook_ItemCode_CloseUp(object sender, CloseUpEventArgs e)
        {
            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
            try
            {
                if (e.CloseMode == PopupCloseMode.Normal)
                {
                    string _itemCode = "";
                    string _nameEN = "";
                    string _nameVN = "";
                    string _nameJP = "";
                    string _maker = "";
                    string _unit = "";
                    string _classifyID = "";
                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _itemCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ItemCode"));
                    _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
                    _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
                    _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
                    _maker = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"));
                    _unit = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Unit"));
                    _classifyID = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ClassifyID"));

                    try
                    {
                        DataTable _tempTable = new DataTable();
                        _tempTable = M0013_DAO.GetInfo_M0013_Item(_itemCode);
                        if (_tempTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Mã LK/Pin/Dầu " + _itemCode + " đang có chứng từ cập nhật master chưa xác nhận!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sLookUp_ItemCode.Focus();
                        }
                        else
                        {   //Set value to Text edit
                            sLookUp_ItemCode.Text = _itemCode;
                            txt_NameEN.Text = _nameEN;
                            txt_NameVN.Text = _nameVN;
                            txt_NameJP.Text = _nameJP;
                            txt_Maker.Text = _maker;
                            txt_Unit.Text = _unit;
                            txt_Classify.Text = _classifyID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        ///Lấy thông tin mã hàng
        /// </summary>
        private void Add_Value_sLook_ItemCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_M0012_Update();
            if (tempTable.Rows.Count > 0)
            {
                sLookUp_ItemCode.Properties.DataSource = tempTable;
                sLookUp_ItemCode.Properties.ValueMember = "ItemCode";
                sLookUp_ItemCode.Properties.DisplayMember = "ItemCode";
            }
        }
        /// <summary>
        /// Hiển thị dữ liệu cho ô tên MMTB + maker + model
        /// </summary>
        private void Add_Value_sLook_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_M0004();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_NameEN.DataSource = tempTable;
                repo_sLookUp_NameEN.ValueMember = "NameEN";
                repo_sLookUp_NameEN.DisplayMember = "NameEN";
            }
        }
        private void SLook_NameEN_CloseUp(object sender, CloseUpEventArgs e)
        {
            try
            {
                if (e.CloseMode == PopupCloseMode.Normal)
                {
                    string _nameEN = "";
                    string _nameVN = "";
                    string _nameJP = "";
                    string _maker = "";
                    string _model = "";
                    //Get index
                    SearchLookUpEdit editor = sender as SearchLookUpEdit;

                    //Set value variables
                    _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
                    _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
                    _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
                    _maker = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"));
                    _model = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Model"));
                    for (int rows = 0; rows <= gridView.DataRowCount; rows++)
                        if (rows != gridView.FocusedRowHandle)
                        {
                            string _nameEN1 = _nameEN + _maker + _model;
                            if (IsDublicatedRowFound(_nameEN1, "NameEN", "Maker", "Model") == true)
                            {
                                MessageBox.Show("MMTB đã tồn tại trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {   //Set value to column
                                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameEN", _nameEN);
                                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameVN", _nameVN);
                                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameJP", _nameJP);
                                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Maker", _maker);
                                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Model", _model);
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Tùy chọn thông tin cột Code (TextEdit / sLookUp_ItemCode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == gridCol_NameEN)
            {
                e.RepositoryItem = repo_sLookUp_NameEN;
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
            dtrow["DocNo"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DocNo");
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
            dtrow["DocNo"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DocNo");
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
            sLook_DocNo.Focus();
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    string DocNo = "";
                    _DetailTable = gridView.GridControl.DataSource as DataTable;
                    if (cbx_Status.SelectedIndex == 0)
                    {
                        if (CheckError() == true)
                        {
                            DocNo = M0013_DAO.Insert_Summary_ByItem(_DetailTable, _DeleteRowTable, GetValue_Header());
                            if (!String.IsNullOrEmpty(DocNo))
                            {
                                MessageBox.Show("Thêm mới/Cập nhật thành công DocNo: " + DocNo.PadLeft(6, '0')
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear_Data();
                                Add_Value_sLookUp_DocNo();
                            }
                        }
                    }
                    else if (cbx_Status.SelectedIndex == 1)
                    {
                        if (sLook_DocNo.EditValue == null)
                        {
                            if (CheckError() == true)
                            {
                                DocNo = M0013_DAO.Insert_Confirm_Summary_ByItem(_DetailTable,  GetValue_Header());

                                if (!String.IsNullOrEmpty(DocNo))
                                {
                                    MessageBox.Show("Thêm mới/Cập nhật thành công DocNo: " + DocNo.PadLeft(6, '0')
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Clear_Data();
                                    Add_Value_sLookUp_DocNo();
                                }
                            }
                        }
                        else
                        {
                            if (CheckErrorConfirm() == true)
                            {
                                if (M0013_DAO.Update_Summary_ByItem(_DetailTable, _DeleteRowTable, GetValue_Header()))
                                {
                                    MessageBox.Show("Đã xác nhận thành công!", "Thông báo",         MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Clear_Data();
                                    Add_Value_sLookUp_DocNo();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới/Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sLookUp_ItemCode.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Load  các mã MMTB đã có theo mã LK/Pin/Dầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BbiLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(sLookUp_ItemCode.EditValue)))
            {
                string _itemCode = sLookUp_ItemCode.Text;

                _DetailTable = M0013_DAO.GetInfo_M0013_Detail_Item(_itemCode);
                gridControl.DataSource = _DetailTable;
                bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã LK/Pin/Dầu!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Form Closing
        /// </summary>
        private void Form_M0013_2_ByItem_FormClosing(object sender, FormClosingEventArgs e)
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
            gridView.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName);
            gridView.SetRowCellValue(e.RowHandle, "ConfUser", _systemDAL.userName);
            gridView.SetRowCellValue(e.RowHandle, "InActive", 0);
            gridView.SetRowCellValue(e.RowHandle, "ApplyDate", DateTime.Today.Date);
            gridView.SetRowCellValue(e.RowHandle, "QtyNeed", 1);
            gridView.SetRowCellValue(e.RowHandle, "Lifetime", 0);
            gridView.SetRowCellValue(e.RowHandle, "Point", 0);
            gridView.SetRowCellValue(e.RowHandle, "ClassifyID", txt_Classify.Text);
            gridView.SetRowCellValue(e.RowHandle, "ItemCode", sLookUp_ItemCode.EditValue);

            // Set focus in a specific cell
            gridView.Focus();
            gridView.FocusedRowHandle = e.RowHandle;
            gridView.FocusedColumn = gridCol_Model;
        }
        #endregion
        #endregion

        #region Khởi tạo form
        //Dữ liệu trên Form_M0013_2_ByItem
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName.ToUpper();
            //Định nghĩa datatable gán cho header
            Define_HeaderTable();
            //Định nghĩa datatable gán cho gridView
            Define_DetailTable();
            Define_DeleteRowTable();
            //
            Add_Value_sLook_NameEN();
            AddValue_CBox_Status(cbx_Status);
            Add_Value_sLookUp_DocNo();
            Add_Value_sLook_ItemCode();
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
            bbi_AddNewRow.Enabled = IsEnable;
            bbi_DeleteRow.Enabled = IsEnable;

            //PopUp
            //bbi_PopUp_AddNewRow.Enabled = IsEnable;
            //bbi_PopUp_DeleteRow.Enabled = IsEnable;

            //Header
            date_Doc.Enabled = IsEnable;
            cbx_Status.Enabled = IsEnable;
            sLookUp_ItemCode.Enabled = IsEnable;

            //Collumn
            gridCol_NameEN.OptionsColumn.AllowEdit = IsEnable;
            gridCol_QtyNeed.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Lifetime.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Point.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Location.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Using.OptionsColumn.AllowEdit = IsEnable;
            gridCol_Memo.OptionsColumn.AllowEdit = IsEnable;
            gridCol_ApplyDate.OptionsColumn.AllowEdit = IsEnable;

            //Button
            bbiSave.Enabled = IsEnable;
            bbiLoad.Enabled = IsEnable;

            //gridView
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }

        //Xóa dữ liệu
        private void Clear_Data()
        {
            //Clear header
            DocNo = "";
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            cbx_Status.SelectedIndex = 0;
            sLookUp_ItemCode.EditValue = null;
            txt_NameEN.Text = "";
            txt_NameVN.Text = "";
            txt_NameJP.Text = "";
            txt_Maker.Text = "";
            txt_Unit.Text = "";
            txt_Classify.Text = "";
            //Clear detail
            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;

            //Refresh value for sLookUp DocNo
            Add_Value_sLookUp_DocNo();

            //Focus on the first item
            sLook_DocNo.Focus();
        }
        #endregion
        /// <summary>
        /// Định nghĩa cấu trúc datatable gán cho grid control
        /// </summary>
        //Định nghĩa bảng Header
        private void Define_HeaderTable()
        {
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("DocStatus", typeof(int));
            _HeaderTable.Columns.Add("Program", typeof(string));
            _HeaderTable.Columns.Add("NameEN", typeof(string));
            _HeaderTable.Columns.Add("NameVN", typeof(string));
            _HeaderTable.Columns.Add("NameJP", typeof(string));
            _HeaderTable.Columns.Add("Maker", typeof(string));
            _HeaderTable.Columns.Add("Model_Item", typeof(string));
            _HeaderTable.Columns.Add("Unit", typeof(string));
            _HeaderTable.Columns.Add("ClassifyID", typeof(string));
            _HeaderTable.Columns.Add("UserName", typeof(string));
            _HeaderTable.Columns.Add("ConfUser", typeof(string));
        }
        //Giá trị cho Header
        private DataTable GetValue_Header()
        {
            DataTable _tempTable = new DataTable();
            _tempTable = _HeaderTable.Clone();

            DataRow dtRow = _tempTable.NewRow();
            dtRow["DocNo"] = sLook_DocNo.EditValue;
            dtRow["DocDate"] = date_Doc.EditValue;
            dtRow["DocStatus"] = cbx_Status.SelectedIndex;
            dtRow["Program"] = "M0013_2";
            dtRow["NameEN"] = txt_NameEN.Text.ToString();
            dtRow["NameVN"] = txt_NameVN.Text.ToString();
            dtRow["NameJP"] = txt_NameJP.Text.ToString();
            if (string.IsNullOrEmpty(txt_Maker.Text.ToString()))
            {
                dtRow["Maker"] = null;
            }
            else
            {
                dtRow["Maker"] = txt_Maker.Text.ToString();
            }
            dtRow["Model_Item"] = sLookUp_ItemCode.EditValue;
            dtRow["Unit"] = txt_Unit.Text.ToString();
            dtRow["ClassifyID"] = txt_Classify.Text.ToString();
            dtRow["UserName"] = bsiUser.ToString();
            dtRow["ConfUser"] = bsiUser.ToString();
            _tempTable.Rows.Add(dtRow);

            return _tempTable;
        }
        //Điền dữ liệu cho header
        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            if (_tempTable.Rows[0].Field<Boolean>("DocStatus"))
            {
                cbx_Status.SelectedIndex = 1;
                Set_Enable_Control(false);
            }
            else
            {
                cbx_Status.SelectedIndex = 0;
                Set_Enable_Control(true);
            }
            txt_NameEN.EditValue = _tempTable.Rows[0].Field<string>("NameEN").Trim();
            txt_NameVN.EditValue = _tempTable.Rows[0].Field<string>("NameVN").Trim();
            txt_NameJP.EditValue = _tempTable.Rows[0].Field<string>("NameJP").Trim();
            txt_Maker.EditValue = _tempTable.Rows[0].Field<string>("Maker").Trim();
            sLookUp_ItemCode.EditValue = _tempTable.Rows[0].Field<string>("Model_Item").Trim();
            txt_Unit.EditValue = _tempTable.Rows[0].Field<string>("Unit").Trim();
            txt_Classify.EditValue = _tempTable.Rows[0].Field<string>("ClassifyID").Trim();
        }
        //Định nghĩa bảng Detail table
        private void Define_DetailTable()
        {
            //Các cột theo bảng M0013_Summary
            _DetailTable.Columns.Add("DocNo", typeof(string));
            _DetailTable.Columns.Add("NameEN", typeof(string));
            _DetailTable.Columns.Add("NameVN", typeof(string));
            _DetailTable.Columns.Add("NameJP", typeof(string));
            _DetailTable.Columns.Add("Maker", typeof(string));
            _DetailTable.Columns.Add("Model", typeof(string));
            _DetailTable.Columns.Add("ClassifyID", typeof(string));
            _DetailTable.Columns.Add("ItemCode", typeof(string));
            _DetailTable.Columns.Add("ItemNameEN", typeof(string));
            _DetailTable.Columns.Add("ItemNameVN", typeof(string));
            _DetailTable.Columns.Add("ItemNameJP", typeof(string));
            _DetailTable.Columns.Add("ItemMaker", typeof(string));
            _DetailTable.Columns.Add("Unit", typeof(string));
            _DetailTable.Columns.Add("QtyNeed", typeof(int));
            _DetailTable.Columns.Add("Lifetime", typeof(int));
            _DetailTable.Columns.Add("Point", typeof(int));
            _DetailTable.Columns.Add("Location", typeof(string));
            _DetailTable.Columns.Add("Using", typeof(string));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActive", typeof(int));
            _DetailTable.Columns.Add("InActiveDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActiveUser", typeof(string));
        }
        //Table_Xóa thông tin
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("DocNo", typeof(string));
        }

        /// <summary>
        /// Các tình huống cần kiểm tra lỗi
        /// </summary>
        private Boolean CheckError()
        {
            //Thông tin MMTB
            string Dept = Convert.ToString(sLookUp_ItemCode.EditValue);
            if (String.IsNullOrEmpty(Dept))
            {
                MessageBox.Show("Hãy nhập \"Mã LK/Pin/Dầu\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLookUp_ItemCode.Focus();
                return false;
            }
            //Kiểm tra trùng trên lưới
            //Trùng thông tin Mã hàng MMTB, Maker, Model, ItemCode, QtyNeed, Lifetime, Point
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _nameEN;
                string _maker;
                string _model;
                string _itemCode;
                int _qtyNeed;
                int _lifetime;
                int _point;

                _nameEN = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["NameEN"]));
                _maker = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Maker"]));
                _model = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Model"]));
                _itemCode = Convert.ToString(sLookUp_ItemCode.EditValue);
                _qtyNeed = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["QtyNeed"]));
                _lifetime = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Lifetime"]));
                _point = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Point"]));

                try
                {
                    DataTable _tempTable = M0013_DAO.GetInfo_M0013_Check(_nameEN, _maker, _model, _itemCode, _qtyNeed, _lifetime, _point);
                    if (_tempTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", Master đã có (trùng Mã LK/Dầu/Pin, Số lượng, Tuổi thọ, Điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Kiểm tra thông tin lỗi khi confirm
        /// </summary>
        private Boolean CheckErrorConfirm()
        {
            //Thông tin MMTB
            string Dept = Convert.ToString(sLookUp_ItemCode.EditValue);
            if (String.IsNullOrEmpty(Dept))
            {
                MessageBox.Show("Hãy nhập \"Mã LK/Pin/Dầu\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLookUp_ItemCode.Focus();
                return false;
            }
            //Kiểm tra trùng trên lưới
            //Trùng thông tin Mã hàng MMTB, Maker, Model, ItemCode, QtyNeed, Lifetime, Point
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _nameEN;
                string _maker;
                string _model;
                string _itemCode;
                int _qtyNeed;
                int _lifetime;
                int _point;

                _nameEN = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["NameEN"]));
                _maker = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Maker"]));
                _model = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Model"]));
                _itemCode = Convert.ToString(sLookUp_ItemCode.EditValue);
                _qtyNeed = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["QtyNeed"]));
                _lifetime = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Lifetime"]));
                _point = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Point"]));

                try
                {
                    DataTable _tempTable = M0013_DAO.GetInfo_M0013_Check(_nameEN, _maker, _model, _itemCode, _qtyNeed, _lifetime, _point);
                    if (_tempTable.Rows.Count > 1)
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", Master đã có (trùng Mã LK/Dầu/Pin, Số lượng, Tuổi thọ, Điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Cảnh báo dòng trùng trên lưới khi chọn MMTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool IsDublicatedRowFound(string _value, string column1, string column2, string column3)
        {
            for (int rows = 0; rows < gridView.DataRowCount; rows++)
                if (rows != gridView.FocusedRowHandle)
                {
                    string _rowCodeValue = "";
                    string _rowFocusValue = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns[column1]));
                    if (!String.IsNullOrEmpty(_rowFocusValue))
                    {
                        _rowCodeValue = (string)gridView.GetRowCellValue(rows, gridView.Columns[column1]) + (string)gridView.GetRowCellValue(rows, gridView.Columns[column2]) + (string)gridView.GetRowCellValue(rows, gridView.Columns[column3]);
                        if (Equals(_value, _rowCodeValue))
                            return true;
                    }
                }
            return false;
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