using System;
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

namespace MMTB.View
{
    public partial class Form_M0005_Detail_DD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        public M0003_Line_DAO M0003_Line_DAO;
        public M0005_DAO M0005_DAO;
        public String DocNo = "";
        public Boolean InitValue = true;
        public System_DAL _systemDAL = new System_DAL();
        #endregion
        //Khởi tạo form
        public Form_M0005_Detail_DD(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_DD(String _docNo, System_DAL systemDAL)
        {
            InitializeComponent();
            DocNo = _docNo;
            _systemDAL = systemDAL;
        }
        //Load Form_M0005_Detail_DD
        private void Form_M0005_Detail_DD_Load(object sender, EventArgs e)
        {
            M0003_Line_DAO = new M0003_Line_DAO();
            M0005_DAO = new M0005_DAO();

            _HeaderTable = new DataTable();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();

            advBandedGridView1.AddNewRow();
        }

        //Dữ liệu trên Form_M0005_Detail_DD
        private void Setting_Init_Control()
        {
            //Định nghĩa datatable gán cho header
            Define_HeaderTable();

            //Định nghĩa datatable gán cho advBandedGridView1
            Define_DetailTable();
            Define_DeleteRowTable();

            AddValue_CBox_Status(cbx_Status);

            Add_Value_sLookUp_DocNo();

            AddValue_sLook_ControlDept();

            AddValue_repo_sLookUp_Code();

            Add_Value_repo_sLookUp_ProcessCode();
            bsiUser.Caption = _systemDAL.userName.ToUpper();
        }
        //Giá trị khi khởi tạo form
        private void Setting_Init_Value()
        {
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            }
            else
            {
                sLook_DocNo.EditValue = DocNo;
            }
        }
        //Thêm thông tin combo box
        private void AddValue_CBox_Status(ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Chuẩn bị");
            Boolean.Add("Xác nhận");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Thông tin line, process...
        private void Add_Value_repo_sLookUp_ProcessCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0003_Line_DAO.GetInfo_M0003_ProgressGroup();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookup_LineCode1.DataSource = tempTable;
                repo_sLookup_LineCode1.ValueMember = "LineCode";
                repo_sLookup_LineCode1.DisplayMember = "LineCode";
            }
        }
        //Điền thông tin Line
        private void repo_sLookUp_LineCode_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                string _desLineEN = "";
                string _desProcessCode = "";
                string _desGroupLineACC = "";
                string _desUsingDept = "";

                //Get index
                SearchLookUpEdit editor = sender as SearchLookUpEdit;

                //Set value variables
                _desLineEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("LineEN"));
                _desProcessCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ProcessCode"));
                _desGroupLineACC = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("GroupLineACC"));
                _desUsingDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("UsingDept"));

                //Set value to column OrgLineEN, OrgProcessCode, OrgGroupLineACC, OrgUsingDept
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesLineEN", _desLineEN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesProcessCode", _desProcessCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesGroupLineACC", _desGroupLineACC);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesUsingDept", _desUsingDept);
            }
        }
        //Thêm cột header
        private void Define_HeaderTable()
        {
            //Các cột theo bảng M0005_ListMMTB_Doc3
            _HeaderTable = new DataTable();
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("MoveDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ControlDept", typeof(string));
            _HeaderTable.Columns.Add("DocStatus", typeof(int));
            _HeaderTable.Columns.Add("Memo", typeof(string));
            _HeaderTable.Columns.Add("InputUser", typeof(string));
            _HeaderTable.Columns.Add("ConfUser", typeof(string));
            _HeaderTable.Columns.Add("ConfDate", typeof(DateTime));
            _HeaderTable.Columns.Add("Column3", typeof(string));
            _HeaderTable.Columns.Add("Column4", typeof(string));
            _HeaderTable.Columns.Add("Column5", typeof(string));
        }
        //Điền dữ liệu cho header
        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            txt_Memo.Text = _tempTable.Rows[0].Field<string>("Memo");
            sLook_ControlDept.EditValue = _tempTable.Rows[0].Field<string>("ControlDept");
            date_Move.EditValue = _tempTable.Rows[0].Field<DateTime>("MoveDate");
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
        }
        //Giá trị bảng Header
        private DataTable GetValue_Header()
        {
            DataTable _tempTable = new DataTable();
            _tempTable = _HeaderTable.Clone();

            DataRow dtRow = _tempTable.NewRow();
            dtRow["DocNo"] = sLook_DocNo.EditValue;
            dtRow["DocDate"] = date_Doc.EditValue;
            dtRow["MoveDate"] = date_Move.EditValue;
            dtRow["ControlDept"] = sLook_ControlDept.EditValue;
            dtRow["DocStatus"] = cbx_Status.SelectedIndex;
            dtRow["Memo"] = txt_Memo.Text;
            dtRow["InputUser"] = _systemDAL.userName.ToUpper();
            dtRow["ConfUser"] = _systemDAL.userName.ToUpper();
            dtRow["ConfDate"] = DateTime.Now;
            dtRow["Column3"] = "";
            dtRow["Column4"] = "";
            dtRow["Column5"] = "";
            _tempTable.Rows.Add(dtRow);

            return _tempTable;
        }
        //Định nghĩa cấu trúc datatable gán cho grid control
        private void Define_DetailTable()
        {
            //Các cột theo bảng M0005_ListMMTB và M0005_ListMMTBLine
            _DetailTable.Columns.Add("Code", typeof(string));
            _DetailTable.Columns.Add("ACCcode", typeof(string));
            _DetailTable.Columns.Add("NameEN", typeof(string));
            _DetailTable.Columns.Add("NameVN", typeof(string));
            _DetailTable.Columns.Add("NameJP", typeof(string));
            _DetailTable.Columns.Add("Maker", typeof(string));
            _DetailTable.Columns.Add("Model", typeof(string));
            _DetailTable.Columns.Add("ConfirmDate", typeof(DateTime));
            _DetailTable.Columns.Add("DocNo_Confirm", typeof(string));
            _DetailTable.Columns.Add("ControlDept", typeof(string));
            _DetailTable.Columns.Add("OrgProcessCode", typeof(string));
            _DetailTable.Columns.Add("OrgLineCode", typeof(string));
            _DetailTable.Columns.Add("OrgLineEN", typeof(string));
            _DetailTable.Columns.Add("OrgGroupLineACC", typeof(string));
            _DetailTable.Columns.Add("OrgUsingDept", typeof(string));
            _DetailTable.Columns.Add("SourceProcessCode", typeof(string));
            _DetailTable.Columns.Add("SourceLineCode", typeof(string));
            _DetailTable.Columns.Add("SourceLineEN", typeof(string));
            _DetailTable.Columns.Add("SourceGroupLineACC", typeof(string));
            _DetailTable.Columns.Add("SourceUsingDept", typeof(string));
            _DetailTable.Columns.Add("DesProcessCode", typeof(string));
            _DetailTable.Columns.Add("DesLineCode", typeof(string));
            _DetailTable.Columns.Add("DesLineEN", typeof(string));
            _DetailTable.Columns.Add("DesGroupLineACC", typeof(string));
            _DetailTable.Columns.Add("DesUsingDept", typeof(string));
            _DetailTable.Columns.Add("MoveDate", typeof(DateTime));
            _DetailTable.Columns.Add("DocNo_Move", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InputUser", typeof(string));
        }
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("Code", typeof(string));
        }
        #region Add data to control
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
        //Điền dữ liệu cho ô Số chứng từ
        private void Add_Value_sLookUp_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_M0005_DocDD();
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

        #endregion

        #region event
        //Lấy số chứng từ, điền thông tin vào Form_M0005_Detail_DD
        
        private void SLook_DocNo_TextChanged(object sender, EventArgs e)
        {
            string _docNo = "";
            int _status;
            if (sLook_DocNo.EditValue != null)
            {
                _docNo = sLook_DocNo.EditValue.ToString();
            }
            try
            {
                if (!string.IsNullOrEmpty(_docNo))
                {
                    _HeaderTable.Clear();
                    _HeaderTable = M0005_DAO.GetInfo_M0005_DD_Header(_docNo);
                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                        _status = cbx_Status.SelectedIndex;
                        if (_status == 0)
                        {
                            Set_Enable_Control(true);
                            _DetailTable.Clear();
                            _DetailTable = M0005_DAO.GetInfo_M0005_DD_Detail_Temp(_docNo);
                        }
                        if (_status == 1)
                        {
                            Set_Enable_Control(false);
                            _DetailTable.Clear();
                            _DetailTable = M0005_DAO.GetInfo_M0005_DD_Detail(_docNo);
                        }
                    }
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
        private void Clear_Data()
        {
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            txt_Memo.EditValue = null;
            date_Move.EditValue = DateTime.Now;
            sLook_ControlDept.EditValue = null;
            cbx_Status.SelectedIndex = 0;

            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;

            sLook_DocNo.Focus();
        }

        //Danh sách MMTB chưa thanh lý
        private void AddValue_repo_sLookUp_Code()
        {
            DataTable tempTableCode = new DataTable();
            tempTableCode = M0005_DAO.GetInfo_MMTB_Move();
            if (tempTableCode.Rows.Count > 0)
            {
                repo_sLookUp_Code.DataSource = tempTableCode;
                repo_sLookUp_Code.ValueMember = "Code";
                repo_sLookUp_Code.DisplayMember = "Code";
            }
        }
        //Hiển thị thông tin MMTB chưa thanh lý sau khi chọn
        private void repo_sLookUp_Code_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                string _code = "";
                string _ACCcode = "";
                string _nameEN = "";
                string _nameVN = "";
                string _nameJP = "";
                string _maker = "";
                string _model = "";
                DateTime _confirmDate = DateTime.Now;
                string _docNoConfirm = "";
                string _controlDept = "";
                string _orgProcessCode = "";
                string _orgLineCode = "";
                string _orgLineEN = "";
                string _orgGroupLineACC = "";
                string _orgUsingDept = "";
                string _sourceProcessCode = "";
                string _sourceLineCode = "";
                string _sourceLineEN = "";
                string _sourceGroupLineACC = "";
                string _sourceUsingDept = "";
                string _desProcessCode = "";
                string _desLineCode = "";
                string _desLineEN = "";
                string _desGroupLineACC = "";
                string _desUsingDept = "";

                //Get index
                SearchLookUpEdit editor = sender as SearchLookUpEdit;
                int index = editor.Properties.GetIndexByKeyValue(editor.EditValue);

                //Set value to variables
                _code = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Code"));
                _ACCcode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ACCcode"));
                _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
                _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
                _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
                _maker = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"));
                _model = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Model"));
                _confirmDate = Convert.ToDateTime(editor.Properties.View.GetFocusedRowCellValue("ConfirmDate"));
                _docNoConfirm = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DocNo_Confirm"));
                _controlDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ControlDept"));
                _orgProcessCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgProcessCode"));
                _orgLineCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgLineCode"));
                _orgLineEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgLineEN"));
                _orgGroupLineACC = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgGroupLineACC"));
                _orgUsingDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgUsingDept"));
                _sourceProcessCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("SourceProcessCode"));
                _sourceLineCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("SourceLineCode"));
                _sourceLineEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("SourceLineEN"));
                _sourceGroupLineACC = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("SourceGroupLineACC"));
                _sourceUsingDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("SourceUsingDept"));
                _desProcessCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesProcessCode"));
                _desLineCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesLineCode"));
                _desLineEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesLineEN"));
                _desGroupLineACC = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesGroupLineACC"));
                _desUsingDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesUsingDept"));

                //Set value to column ACCcode, NameEN, NameVN, Maker, Model...
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "Code", _code);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "ACCcode", _ACCcode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "NameEN", _nameEN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "NameVN", _nameVN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "NameJP", _nameJP);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "Maker", _maker);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "Model", _model);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "ConfirmDate", _confirmDate);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DocNo_Confirm", _docNoConfirm);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "ControlDept", _controlDept);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "OrgProcessCode", _orgProcessCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "OrgLineCode", _orgLineCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "OrgLineEN", _orgLineEN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "OrgGroupLineACC", _orgGroupLineACC);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "OrgUsingDept", _orgUsingDept);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SourceProcessCode", _sourceProcessCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SourceLineCode", _sourceLineCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SourceLineEN", _sourceLineEN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SourceGroupLineACC", _sourceGroupLineACC);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SourceUsingDept", _sourceUsingDept);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesProcessCode", _desProcessCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesLineCode", _desLineCode);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesLineEN", _desLineEN);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesGroupLineACC", _desGroupLineACC);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "DesUsingDept", _desUsingDept);
            }
        }
        //Click nút thêm mới
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn tạo mới biên bản di dời?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Set_Enable_Control(true);
                InitValue = true;
                Clear_Data();
                advBandedGridView1.AddNewRow();
            }
        }

        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DocNo = sLook_DocNo.Text;
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            }
            else
            {
                SLook_DocNo_TextChanged(sender, e);
            }
        }

        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        //Click chuột phải chọn Delete row
        private void bbi_PopUp_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["Code"] = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "Code");
            _DeleteRowTable.Rows.Add(dtrow);

            //
            var row = advBandedGridView1.FocusedRowHandle;
            advBandedGridView1.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Click chuột phải chọn Add new row
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            advBandedGridView1.AddNewRow();
        }
        //Click nút Add new row
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            advBandedGridView1.AddNewRow();
        }
        //Click nút Save
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            sLook_DocNo.Focus(); //Ghi nhận dữ liệu đã hoàn thành dưới advBandedGridView1
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Question
            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (CheckError() == true)
                {
                    try
                    {
                        if (cbx_Status.SelectedIndex == 0)
                        {
                            if (M0005_DAO.Move_MMTB(_DetailTable, GetValue_Header()))
                            {
                                MessageBox.Show("Đã lưu thành công chứng từ di dời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            Clear_Data();
                            Add_Value_sLookUp_DocNo();
                            AddValue_repo_sLookUp_Code();
                            advBandedGridView1.AddNewRow();
                        }
                        else if (cbx_Status.SelectedIndex == 1)
                        {
                            if (sLook_DocNo.EditValue == null)
                            {
                                if (M0005_DAO.Insert_Confirm_Move_MMTB(_DetailTable, GetValue_Header()))
                                {
                                    MessageBox.Show("Đã lưu thành công chứng từ di dời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                if (M0005_DAO.Confirm_Move_MMTB(_DetailTable, GetValue_Header()))
                                {
                                    MessageBox.Show("Đã lưu thành công chứng từ di dời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            Clear_Data();
                            Add_Value_sLookUp_DocNo();
                            AddValue_repo_sLookUp_Code();
                            advBandedGridView1.AddNewRow();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbiSave.Enabled = IsEnable;
            bbiRefresh.Enabled = IsEnable;
            bbi_AddNewRow.Enabled = IsEnable;
            bbi_DeleteRow.Enabled = IsEnable;
            //PopUp
            bbi_PopUp_AddNewRow.Enabled = IsEnable;
            bbi_PopUp_DeleteRow.Enabled = IsEnable;
            //Header
            date_Doc.Enabled = IsEnable;
            txt_Memo.Enabled = IsEnable;
            date_Move.Enabled = IsEnable;
            sLook_ControlDept.Enabled = IsEnable;
            cbx_Status.Enabled = IsEnable;
            //advBandedGridView1
            advBandedGridView1.OptionsBehavior.Editable = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }

        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(Convert.ToString(sLook_ControlDept.EditValue)))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận di dời MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ControlDept.Focus();
                return false;
            }
            for (int rows = 0; rows < advBandedGridView1.RowCount; rows++)
            {
                string _desLineCode;

                //Disposal memo
                _desLineCode = Convert.ToString(advBandedGridView1.GetRowCellValue(rows, advBandedGridView1.Columns["DesLineCode"]));
                if (String.IsNullOrEmpty(_desLineCode))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Line đến\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    advBandedGridView1.Focus();
                    advBandedGridView1.FocusedRowHandle = rows;
                    advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["DesLineCode"];
                    return false;
                }
            }
            return true;
        }

        #region event advBandedGridView1
        //Hiển thị bảng Pop up
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

        //Hiển thị thông tin khi tìm Code MMTB
        private void advBandedGridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == gridCol_Code)
            {
                e.RepositoryItem = repo_sLookUp_Code;
            }
        }
        #endregion

        private void BbiReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            int docStatus = cbx_Status.SelectedIndex;
            if (docStatus == 1)
            {
                string DocNo = Convert.ToString(sLook_DocNo.EditValue);
                M0005_DD_Report rpt_DD = new M0005_DD_Report(DocNo);
                ReportPrintTool print = new ReportPrintTool(rpt_DD);
                rpt_DD.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Chứng từ di dời chưa được xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void advBandedGridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            advBandedGridView1.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName.ToUpper());
        }
    }
}
