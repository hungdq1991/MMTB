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
    public partial class Form_M0005_Detail_TL : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        public M0003_Line_DAO M0003_Line_DAO;
        public M0004_DAO M0004_DAO;
        public M0005_DAO M0005_DAO;
        public String DocNo = "";
        public Boolean InitValue = true;
        public System_DAL _systemDAL = new System_DAL();
        #endregion

        //Khởi tạo form
        public Form_M0005_Detail_TL(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_TL(String _docNo)
        {
            InitializeComponent();
            DocNo = _docNo;
        }
        //Load Form_M0005_Detail_TL
        private void Form_M0005_Detail_TL_Load(object sender, EventArgs e)
        {
            M0003_Line_DAO = new M0003_Line_DAO();
            M0004_DAO = new M0004_DAO();
            M0005_DAO = new M0005_DAO();

            _HeaderTable = new DataTable();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();

            gridView.AddNewRow();
        }

        //Dữ liệu trên Form_M0005_Detail_TL
        private void Setting_Init_Control()
        {
            //Pass username
            bsiUser.Caption = _systemDAL.userName.ToUpper();

            //Định nghĩa datatable gán cho header
            Define_HeaderTable();

            //Định nghĩa datatable gán cho gridview
            Define_DetailTable();
            Define_DeleteRowTable();

            AddValue_CBox_Status(cbx_Status);

            Add_Value_sLookUp_DocNo();

            AddValue_sLook_ControlDept();

            AddValue_sLookUp_Supplier();

            AddValue_repo_sLookUp_Code();
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

        //Thêm cột header
        private void Define_HeaderTable()
        {
            //Các cột theo bảng M0005_ListMMTB_Doc2
            _HeaderTable = new DataTable();
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("EF_VendID", typeof(string));
            _HeaderTable.Columns.Add("SupplierID", typeof(string));
            _HeaderTable.Columns.Add("SupplierName", typeof(string));
            _HeaderTable.Columns.Add("InvNo", typeof(string));
            _HeaderTable.Columns.Add("InvDate", typeof(DateTime));
            _HeaderTable.Columns.Add("DisposalDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ControlDept", typeof(string));
            _HeaderTable.Columns.Add("DocStatus", typeof(int));
            _HeaderTable.Columns.Add("Memo", typeof(string));
            _HeaderTable.Columns.Add("InputUser", typeof(string));
            _HeaderTable.Columns.Add("Column2", typeof(string));
            _HeaderTable.Columns.Add("Column3", typeof(string));
            _HeaderTable.Columns.Add("Column4", typeof(string));
            _HeaderTable.Columns.Add("Column5", typeof(string));
        }

        //Điền dữ liệu cho header
        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            sLook_Supplier.EditValue = _tempTable.Rows[0].Field<string>("EF_VendID");
            txt_InvNo.Text = _tempTable.Rows[0].Field<string>("InvNo");
            date_Inv.EditValue = _tempTable.Rows[0].Field<DateTime>("InvDate");
            sLook_ControlDept.EditValue = _tempTable.Rows[0].Field<string>("ControlDept");
            date_Disposal.EditValue = _tempTable.Rows[0].Field<DateTime>("DisposalDate");
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
            txt_Memo.Text = _tempTable.Rows[0].Field<string>("Memo");
        }

        //Giá trị bảng Header
        private DataTable GetValue_Header()
        {
            DataTable _tempTable = new DataTable();
            _tempTable = _HeaderTable.Clone();

            DataRow dtRow = _tempTable.NewRow();
            dtRow["DocNo"] = sLook_DocNo.EditValue;
            dtRow["DocDate"] = date_Doc.EditValue;
            dtRow["EF_VendID"] = sLook_Supplier.EditValue;
            dtRow["SupplierID"] = txt_SupplierID.EditValue;
            dtRow["SupplierName"] = txt_SupplierName.EditValue;
            dtRow["InvNo"] = txt_InvNo.Text;
            if (!string.IsNullOrEmpty(txt_InvNo.Text))
            {
                dtRow["InvDate"] = date_Inv.EditValue;
            }
            else
            {
                dtRow["InvDate"] = DBNull.Value;
            }
            dtRow["DisposalDate"] = date_Disposal.EditValue;
            dtRow["ControlDept"] = sLook_ControlDept.EditValue;
            dtRow["DocStatus"] = cbx_Status.SelectedIndex;
            dtRow["Memo"] = txt_Memo.Text;
            dtRow["InputUser"] = _systemDAL.userName;
            dtRow["Column2"] = "";
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
            _DetailTable.Columns.Add("Series", typeof(string));
            _DetailTable.Columns.Add("OrgCountry", typeof(string));
            _DetailTable.Columns.Add("ProDate", typeof(DateTime));
            _DetailTable.Columns.Add("Lifetime", typeof(Decimal));
            _DetailTable.Columns.Add("StartDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("EndDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("NetValue_Disposal", typeof(Decimal));
            _DetailTable.Columns.Add("DesProcessCode", typeof(string));
            _DetailTable.Columns.Add("DesLineCode", typeof(string));
            _DetailTable.Columns.Add("DesLineEN", typeof(string));
            _DetailTable.Columns.Add("DesGroupLineACC", typeof(string));
            _DetailTable.Columns.Add("DesUsingDept", typeof(string));
            _DetailTable.Columns.Add("DisposalDate", typeof(DateTime));
            _DetailTable.Columns.Add("DisposalMemo", typeof(string));
            _DetailTable.Columns.Add("DisposalStatus", typeof(int));
            _DetailTable.Columns.Add("DocNo", typeof(string));
            _DetailTable.Columns.Add("ControlDept", typeof(string));
            _DetailTable.Columns.Add("InputUser", typeof(string));
        }

        //Xóa dòng trên gridView
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("Code", typeof(string));
        }

        #region Add data to control
        //Điền dữ liệu bộ phận
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
            tempTable = M0005_DAO.GetInfo_M0005_DocTL();
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

        //Điền dữ liệu cho ô Supplier
        private void AddValue_sLookUp_Supplier()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_VendorSolomon();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Supplier.Properties.DataSource = tempTable;
                sLook_Supplier.Properties.ValueMember = "EF_VendID";
                sLook_Supplier.Properties.DisplayMember = "EF_VendID";
            }
            else
            {
                sLook_Supplier.Properties.DataSource = "";
            }
        }
        #endregion

        #region event
        //Lấy kết quả ô NCC, điền dữ liệu tương ứng cho tên NCC
        private void SLook_Supplier_TextChanged(object sender, EventArgs e)
        {
            DataTable tempTable = new DataTable();
            string tempCode = Convert.ToString(sLook_Supplier.EditValue);
            try
            {
                if (!String.IsNullOrEmpty(tempCode))
                {
                    tempTable = M0005_DAO.GetInfo_VendorName(tempCode);

                    if (tempTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in tempTable.Rows)
                        {
                            txt_SupplierID.Text = row.Field<string>("VendID");
                            txt_SupplierName.Text = row.Field<string>("VendName");
                        }
                    }
                    if (tempTable.Rows.Count == 0)
                    {
                        tempTable = M0005_DAO.GetInfo_VendorName1(tempCode);
                        foreach (DataRow row in tempTable.Rows)
                        {
                            txt_SupplierID.Text = row.Field<string>("SupplierID");
                            txt_SupplierName.Text = row.Field<string>("SupplierName");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                sLook_Supplier.Focus();
            }
        }

        //Lấy số chứng từ, điền thông tin vào Form_M0005_Detail_TL 
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
                    _HeaderTable = M0005_DAO.GetInfo_M0005_TL_Header(_docNo);
                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                        _status = cbx_Status.SelectedIndex;
                        if (_status == 0)
                        {
                            Set_Enable_Control(true);
                            _DetailTable.Clear();
                            _DetailTable = M0005_DAO.GetInfo_M0005_TL_Detail_Temp(_docNo);
                        }
                        if (_status == 1)
                        {
                            Set_Enable_Control(false);
                            _DetailTable.Clear();
                            _DetailTable = M0005_DAO.GetInfo_M0005_TL_Detail(_docNo);
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

        //Xóa dữ liệu header & gridView
        private void Clear_Data()
        {
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            sLook_Supplier.EditValue = null;
            txt_SupplierID.EditValue = null;
            txt_SupplierName.EditValue = null;
            txt_InvNo.EditValue = null;
            date_Inv.EditValue = DateTime.Now;
            date_Disposal.EditValue = DateTime.Now;
            sLook_ControlDept.EditValue = null;
            cbx_Status.SelectedIndex = 0;

            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;

            sLook_DocNo.Focus();

            Add_Value_sLookUp_DocNo();

            AddValue_repo_sLookUp_Code();
        }

        //Danh sách MMTB chưa thanh lý
        private void AddValue_repo_sLookUp_Code()
        {
            DataTable tempTableCode = new DataTable();
            tempTableCode = M0005_DAO.GetInfo_MMTB();
            if (tempTableCode.Rows.Count > 0)
            {
                repo_sLookUp_Code.DataSource = tempTableCode;
                repo_sLookUp_Code.ValueMember = "Code";
                repo_sLookUp_Code.DisplayMember = "Code";
            }
        }

        //Hiển thị thông tin MMTB chưa thanh lý sau khi chọn lên gridView
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
                string _series = "";
                string _orgCountry = "";
                DateTime _proDate = DateTime.Now;
                int _Lifetime = 0;
                DateTime _startDeprDate = DateTime.Now;
                DateTime _endDeprDate = DateTime.Now;
                decimal _netValue = 0;
                string _desProcessCode = "";
                string _desLineCode = "";
                string _desLineEN = "";
                string _desGroupLineACC = "";
                string _desUsingDept = "";
                DateTime _disposalDate = DateTime.Now;
                string _disposalMemo = "";
                string _disposalStatus = "";
                string _controlDept = "";

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
                _series = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Series"));
                _orgCountry = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("OrgCountry"));
                if (editor.Properties.View.GetFocusedRowCellValue("ProDate") != null)
                {
                    _proDate = Convert.ToDateTime(editor.Properties.View.GetFocusedRowCellValue("ProDate"));
                }
                _Lifetime = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("Lifetime"));
                _startDeprDate = Convert.ToDateTime(editor.Properties.View.GetFocusedRowCellValue("StartDeprDate"));
                _endDeprDate = Convert.ToDateTime(editor.Properties.View.GetFocusedRowCellValue("EndDeprDate"));
                _netValue = Convert.ToDecimal(editor.Properties.View.GetFocusedRowCellValue("NetValue_Disposal"));
                _desProcessCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesProcessCode"));
                _desLineCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesLineCode"));
                _desLineEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesLineEN"));
                _desGroupLineACC = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesGroupLineACC"));
                _desUsingDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DesUsingDept"));
                _disposalMemo = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DisposalMemo"));
                _disposalStatus = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("DisposalStatus"));
                _controlDept = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ControlDept"));
                //Set value to column ACCcode, NameEN, NameVN, Maker, Model...
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Code", _code);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "ACCcode", _ACCcode);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameEN", _nameEN);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameVN", _nameVN);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameJP", _nameJP);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Maker", _maker);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Model", _model);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Series", _series);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "OrgCountry", _orgCountry);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "ProDate", _proDate);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "Lifetime", _Lifetime);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "StartDeprDate", _startDeprDate);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "EndDeprDate", _endDeprDate);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NetValue_Disposal", _netValue);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DesProcessCode", _desProcessCode);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DesLineCode", _desLineCode);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DesLineEN", _desLineEN);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DesGroupLineACC", _desGroupLineACC);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DesUsingDept", _desUsingDept);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DisposalDate", _disposalDate);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DisposalMemo", _disposalMemo);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "DisposalStatus", _disposalStatus);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "ControlDept", _controlDept);
            }
        }
    
        //Click nút thêm mới
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn tạo mới biên bản thanh lý?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Set_Enable_Control(true);
                InitValue = true;
                Clear_Data();
                gridView.AddNewRow();
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
            dtrow["Code"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Code");
            _DeleteRowTable.Rows.Add(dtrow);

            //
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Click nút Delete row
        private void Bbi_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["Code"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Code");
            _DeleteRowTable.Rows.Add(dtrow);

            //
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Click chuột phải chọn Add new row
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        //Click nút Add new row
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        //Click nút Save
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            sLook_DocNo.Focus(); //Ghi nhận dữ liệu đã hoàn thành dưới gridView
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
                            if (M0005_DAO.Disposal_MMTB(_DetailTable, GetValue_Header()))
                            {
                                MessageBox.Show("Đã lưu thành công chứng từ nghiệm thu!", "Thông báo",     MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (cbx_Status.SelectedIndex == 1)
                        {
                            if (M0005_DAO.Confirm_Disposal_MMTB(_DetailTable, GetValue_Header()))
                            {
                                MessageBox.Show("Đã lưu thành công chứng từ nghiệm thu!", "Thông báo",             MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        Clear_Data();
                        Add_Value_sLookUp_DocNo();
                        gridView.AddNewRow();
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
            sLook_Supplier.Enabled = IsEnable;
            txt_SupplierID.Enabled = IsEnable;
            txt_SupplierName.Enabled = IsEnable;
            txt_InvNo.Enabled = IsEnable;
            date_Inv.Enabled = IsEnable;
            date_Disposal.Enabled = IsEnable;
            sLook_ControlDept.Enabled = IsEnable;
            cbx_Status.Enabled = IsEnable;
            //GridView
            gridView.OptionsBehavior.Editable = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }

        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(Convert.ToString(sLook_ControlDept.EditValue)))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận thanh lý MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ControlDept.Focus();
                return false;
            }
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _disposalMemo;
                _disposalMemo = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["DisposalMemo"]));
                if (String.IsNullOrEmpty(_disposalMemo))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Lý do thanh lý\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView.Focus();
                    gridView.FocusedRowHandle = rows;
                    gridView.FocusedColumn = gridView.Columns["DisposalMemo"];
                    return false;
                }
            }
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _code;
                _code = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Code"]));
                if (String.IsNullOrEmpty(_code))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Mã MMTB\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView.Focus();
                    gridView.FocusedRowHandle = rows;
                    gridView.FocusedColumn = gridView.Columns["Code"];
                    return false;
                }
            }
            return true;
        }
        #region event Gridview - hiển thị pop up
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
        #endregion
        //Thông tin cột Code (TextEdit / Repo_sLookUp_Code)
        private void GridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == gridCol_Code)
            {
                e.RepositoryItem = repo_sLookUp_Code;
            }
        }
        //Xuất báo cáo thanh lý
        private void BbiReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            int docStatus = cbx_Status.SelectedIndex;
            if (docStatus == 1)
            { 
            string DocNo = Convert.ToString(sLook_DocNo.EditValue);
            M0005_TL_Report rpt_TL = new M0005_TL_Report(DocNo);
            ReportPrintTool print = new ReportPrintTool(rpt_TL);
            rpt_TL.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Chứng từ thanh lý chưa được xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName);
        }
    }
}