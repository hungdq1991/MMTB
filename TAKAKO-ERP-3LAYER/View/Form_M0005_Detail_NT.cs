using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TAKAKO_ERP_3LAYER.DAO;
using DevExpress.XtraGrid.Views.Grid;



namespace TAKAKO_ERP_3LAYER.View
{

    public partial class Form_M0005_Detail_NT : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _initTable;
        public DataRow dataRow;
        public M0005_DAO M0005_DAO;
        public M0005_Line_DAO M0005_Line_DAO;
        //Các biến theo bảng thông tin tổng hợp
        public string DocNo;
        public DateTime DocDate;
        public string EF_VendID;
        public string SupplierID;
        public string SupplierName;
        public string InvNo;
        public DateTime InvDate;
        public DateTime ReceiptDate;
        public DateTime ConfirmDate;
        public string ControlDept;
        public DateTime ApplyDate;
        //Tạo biến để ghi nhận New / Edit / Confirm
        private Boolean IsNewValue;
        private Boolean IsCheck;
        #endregion
        public Form_M0005_Detail_NT()
        {
            InitializeComponent();
        }
        //Tạo mới form theo kiểu True/False
        public Form_M0005_Detail_NT(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_NT(DataRow _mainDataRow)
        {
            InitializeComponent();
            dataRow = _mainDataRow;
        }
        //Tạo table cho grid control khi load (dữ liệu trống)
        private void createTable()
        {
            //Các cột theo bảng M0005_ListMMTB
            _initTable.Columns.Add("Code", typeof(string));
            _initTable.Columns.Add("ACCcode", typeof(string));
            _initTable.Columns.Add("NameEN", typeof(string));
            _initTable.Columns.Add("NameVN", typeof(string));
            _initTable.Columns.Add("NameJP", typeof(string));
            _initTable.Columns.Add("Maker", typeof(string));
            _initTable.Columns.Add("Model", typeof(string));
            _initTable.Columns.Add("Series", typeof(string));
            _initTable.Columns.Add("OrgCountry", typeof(string));
            _initTable.Columns.Add("ProDate", typeof(DateTime));
            _initTable.Columns.Add("Lifetime", typeof(int));
            _initTable.Columns.Add("StartDeprDate", typeof(DateTime));
            _initTable.Columns.Add("EndDeprDate", typeof(DateTime));
            _initTable.Columns.Add("ACCDoc", typeof(string));
            _initTable.Columns.Add("InstDoc", typeof(string));
            _initTable.Columns.Add("Status", typeof(string));
            _initTable.Columns.Add("Result", typeof(string));
            _initTable.Columns.Add("Memo", typeof(string));
            _initTable.Columns.Add("OrgProcessCode", typeof(string));
            _initTable.Columns.Add("OrgLineCode", typeof(string));
            _initTable.Columns.Add("OrgGroupLineACC", typeof(string));
            _initTable.Columns.Add("OrgUsingDept", typeof(string));
            _initTable.Columns.Add("OrgLineEN", typeof(string));
        }
        //Load Form_M0005_Detail_NT
        private void Form_M0005_Detail_NT_Load(object sender, EventArgs e)
        {
            IsNewValue = true;
            M0005_DAO = new M0005_DAO();
            M0005_Line_DAO = new M0005_Line_DAO();
            //Khởi tạo bảng
            _initTable = new DataTable();
            //Lấy các cột đã tạo
            createTable();
            //Truyền table vào gridControl
            gridControl.DataSource = _initTable;
            sLookUpEdit_DocNo();
            sLookUpEdit_Supplier();
            //Combo box
            SetValue_Combobox(cbx_Check);
            cbx_Check.SelectedIndex = 0;
            Initialization_Control();
            Update_Control();
            sLook_DocNo.Focus();
        }
        //Dữ liệu trên Form_M0005_Detail_NT
        private void Initialization_Control()
        {
            if (IsNewValue)
            {
                sLook_DocNo.Text = "";
                DocDate = DateTime.Now.Date;
                sLook_Supplier.Text = "";
                SupplierID = "";
                SupplierName = "";
                InvNo = "";
                InvDate = DateTime.Now.Date;
                ReceiptDate = DateTime.Now.Date;
                ConfirmDate = DateTime.Now.Date;
                sLook_ControlDept.Text = "";
                IsCheck = false;
                gridControl.DataSource = _initTable;
                _initTable.Clear();
            }
            else
            {
                sLookUpEdit_DocNo();
                DocNo = sLook_DocNo.Text.Trim();
                DataTable tempTable = new DataTable();
                if (!String.IsNullOrEmpty(DocNo))
                {
                    tempTable = M0005_DAO.GetInfo_M0005_NT(DocNo);
                    if (tempTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in tempTable.Rows)
                        {
                            DocDate = Convert.ToDateTime(row.Field<DateTime>("DocDate"));
                            EF_VendID = Convert.ToString(row.Field<string>("EF_VendID"));
                            SupplierID = Convert.ToString(row.Field<string>("SupplierID"));
                            SupplierName = Convert.ToString(row.Field<string>("SupplierName"));
                            InvNo = Convert.ToString(row.Field<string>("InvNo"));
                            InvDate = Convert.ToDateTime(row.Field<DateTime>("InvDate"));
                            ReceiptDate = Convert.ToDateTime(row.Field<DateTime>("ReceiptDate"));
                            ConfirmDate = Convert.ToDateTime(row.Field<DateTime>("ConfirmDate"));
                            ControlDept = Convert.ToString(row.Field<string>("ControlDept"));
                            IsCheck = Convert.ToBoolean(row.Field<Byte>("DocStatus")); ;
                            gridControl.DataSource = tempTable;
                        }
                    }
                }
            }
        }
        //Kiểm soát key: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp cần cập nhật thông tin
        private void Setting_Init_Control()
        {
            if (IsCheck)
            {
                sLook_Supplier.Enabled = false;
                txt_SupplierID.Enabled = false;
                txt_SupplierName.Enabled = false;
                txt_InvNo.Enabled = false;
                date_Inv.Enabled = false;
                date_Receipt.Enabled = false;
                date_Confirm.Enabled = false;
                txt_ControlDept.Enabled = false;
                cbx_Check.Enabled = false;
                gridView.OptionsBehavior.ReadOnly = true;
            }
            else
            {
                sLook_Supplier.Enabled = true;
                txt_SupplierID.Enabled = false;
                txt_SupplierName.Enabled = false;
                txt_InvNo.Enabled = true;
                date_Inv.Enabled = true;
                date_Receipt.Enabled = true;
                date_Confirm.Enabled = true;
                txt_ControlDept.Enabled = true;
                cbx_Check.Enabled = true;
                gridView.OptionsBehavior.ReadOnly = false;
            }
        }
        //Đưa dữ liệu trên form
        private void Update_Control()
        {
            sLook_DocNo.Text = DocNo;
            date_Doc.DateTime = DocDate;
            sLook_Supplier.EditValue = EF_VendID;
            txt_SupplierID.EditValue = SupplierID;
            txt_SupplierName.Text = SupplierName;
            txt_InvNo.Text = InvNo;
            date_Inv.DateTime = InvDate;
            date_Receipt.DateTime = ReceiptDate;
            date_Confirm.DateTime = ConfirmDate;
            sLook_ControlDept.Text = ControlDept;
            if (IsCheck)
            {
                cbx_Check.SelectedIndex = 1;
            }
            else
            {
                cbx_Check.SelectedIndex = 0;
            }
            _initTable = new DataTable();
            //Lấy các cột đã tạo
            createTable();
            //Truyền table vào gridControl
            gridControl.DataSource = _initTable;
            _initTable.Clear();
        }
        //Thông tin lưới chi tiết

        //Tạo nội dung combo box cho user lựa chọn: Yes/No
        private void SetValue_Combobox(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Chuẩn bị");
            Boolean.Add("Xác nhận");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Điền dữ liệu cho ô Số chứng từ
        private void sLookUpEdit_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_M0005_DocNT();
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
        private void sLookUpEdit_Supplier()
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
        //Lấy kết quả ô NCC, điền dữ liệu tương ứng cho tên NCC
        private void SLook_Supplier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tempCode = sLook_Supplier.EditValue.ToString().Trim();
                DataTable tempTable = new DataTable();
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
                }
            }
            catch (Exception ex)
            {
                sLook_Supplier.Focus();
            }
        }
        //Lấy số chứng từ, điền thông tin vào Form_M0005_Detail_NT 
        private void SLook_DocNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tempDocNo = sLook_DocNo.Text.Trim();
                DataTable _tempTable = new DataTable();
                if (!string.IsNullOrEmpty(tempDocNo))
                {
                    _tempTable = M0005_DAO.GetInfo_M0005_NT(tempDocNo);

                    if (_tempTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        foreach (DataRow row in _tempTable.Rows)
                        {
                            date_Doc.EditValue = row.Field<DateTime>("DocDate");
                            sLook_Supplier.EditValue = row.Field<string>("EF_VendID").Trim();
                            txt_SupplierID.Text = row.Field<string>("SupplierID");
                            txt_SupplierName.Text = row.Field<string>("SupplierName");
                            txt_InvNo.Text = row.Field<string>("InvNo");
                            date_Inv.EditValue = row.Field<DateTime>("InvDate");
                            date_Receipt.EditValue = row.Field<DateTime>("ReceiptDate");
                            date_Confirm.EditValue = row.Field<DateTime>("ConfirmDate");
                            txt_ControlDept.Text = row.Field<string>("ControlDept");
                            IsCheck = row.Field<Boolean>("DocStatus");
                            if (IsCheck)
                            {
                                cbx_Check.SelectedIndex = 1;
                                Setting_Init_Control();
                            }
                            else
                            {
                                cbx_Check.SelectedIndex = 0;
                                Setting_Init_Control();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Click nút thêm mới
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsNewValue = true;
            Initialization_Control();
            Update_Control();
            Setting_Init_Control();
            sLookUpEdit_DocNo();
            sLookUpEdit_Supplier();
            _initTable.Clear();
            gridControl.DataSource = _initTable;
        }
        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string tempDocNo = sLook_DocNo.Text.Trim();
                DataTable _tempTable = new DataTable();
                if (!string.IsNullOrEmpty(tempDocNo))
                {
                    sLook_DocNo.Focus();
                    _tempTable = M0005_DAO.GetInfo_M0005_NT(tempDocNo);

                    if (_tempTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _tempTable;
                        bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        foreach (DataRow row in _tempTable.Rows)
                        {
                            date_Doc.EditValue = row.Field<DateTime>("DocDate");
                            sLook_Supplier.EditValue = row.Field<string>("EF_VendID").Trim();
                            txt_SupplierID.Text = row.Field<string>("SupplierID");
                            txt_SupplierName.Text = row.Field<string>("SupplierName");
                            txt_InvNo.Text = row.Field<string>("InvNo");
                            date_Inv.EditValue = row.Field<DateTime>("InvDate");
                            date_Receipt.EditValue = row.Field<DateTime>("ReceiptDate");
                            date_Confirm.EditValue = row.Field<DateTime>("ConfirmDate");
                            txt_ControlDept.Text = row.Field<string>("ControlDept");
                            IsCheck = row.Field<Boolean>("DocStatus");
                            if (IsCheck)
                            {
                                cbx_Check.SelectedIndex = 1;
                                Setting_Init_Control();
                            }
                            else
                            {
                                cbx_Check.SelectedIndex = 0;
                                Setting_Init_Control();
                            }
                        }
                    }
                    else
                    {
                        IsNewValue = true;
                        Initialization_Control();
                        Update_Control();
                        Setting_Init_Control();
                        sLookUpEdit_DocNo();
                        sLookUpEdit_Supplier();
                        _initTable.Clear();
                        gridControl.DataSource = _initTable;
                    }
                }
            }
            catch (Exception ex)
            {
                sLook_DocNo.Focus();
            }
        }

        //Click nút Save
        //private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        #region
        //    string Message = "";
        //    string MessageResult = "";
        //    string curr_EF_VendID = sLook_Supplier.Text.Trim();
        //    string curr_SupplierID = txt_SupplierID.Text.Trim();
        //    string curr_SupplierName = txt_SupplierName.Text.Trim();
        //    string curr_InvNo = txt_InvNo.Text.Trim();
        //    DateTime curr_InvDate = DateTime.Parse(date_Inv.Text.Trim());
        //    DateTime curr_ReceiptDate = DateTime.Parse(date_Receipt.Text.Trim());
        //    DateTime curr_ConfirmDate = DateTime.Parse(date_Confirm.Text.Trim());
        //    string curr_ControlDept = sLook_ControlDept.Text.Trim();
        //    int curr_DocStatus = 0;
        #endregion
        //    Trường hợp thêm mới
        //    if (IsNewValue)
        //    {
        //        Message = "Bạn muốn tạo Biên bản nghiệm thu MMTB\"" + "\"?";
        //        if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
        //            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
        //        {
        //            if (CheckError() == true)
        //            {
        //                Lưu thông tin chung MMTB
        //                if (M0006_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_Level, curr_SizeL, curr_SizeW,
        //                        curr_SizeH, curr_Chuck3Jaw, curr_Collet1, curr_Collet2, curr_Collet3,
        //                        curr_Voltage, curr_OperatingSys, curr_Wattage, curr_InActive, "IT"))
        //                {
        //                    Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
        //                }
        //                Lưu thông tin Máy tiện
        //                if (grctr_Tien.Visible == true)
        //                {
        //                    if (M0006_MayTien_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_Turret, curr_Horizontal, curr_Tailstock,
        //                        curr_AxisC, curr_InActive_T, "IT"))
        //                    {
        //                        Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
        //                    }
        //                }
        //                Lưu thông tin Máy phay
        //                if (grctr_Phay.Visible == true)
        //                {
        //                    if (M0006_MayPhay_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_TableL, curr_TableW, curr_Speed,
        //                        curr_BTSize, curr_TipQty, curr_WaterLine, curr_AxisXYZ, curr_AxisA, curr_AxisB,
        //                        curr_AxisC_P, curr_InActive_P, "IT"))
        //                    {
        //                        Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
        //                    }
        //                }
        //                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        IsNewValue = true;
        //        Initialization_Control();
        //        Update_Control();
        //        Setting_Init_Control();
        //        lbl_ChiTiet.Visible = false;
        //        grctr_Tien.Visible = false;
        //        grctr_Phay.Visible = false;
        //    }
        //    Trường hợp sửa
        //    else
        //    {
        //        if (CheckError() == true)
        //        {
        //            Message = "Bạn muốn cập nhật Mã MMTB: " + sLook_Code.Text.ToString() + "?";
        //            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
        //            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
        //            {
        //                Cập nhật thông tin chung
        //                if (CheckError_MMTB() == true)
        //                {
        //                    M0006_DAO.Update(curr_Code, "IT");
        //                    if (M0006_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_Level, curr_SizeL, curr_SizeW,
        //                        curr_SizeH, curr_Chuck3Jaw, curr_Collet1, curr_Collet2, curr_Collet3,
        //                        curr_Voltage, curr_OperatingSys, curr_Wattage, curr_InActive, "IT"))
        //                    {
        //                        MessageResult = "Đã cập nhật Thông tin chung:      " + sLook_Code.Text.ToString() + " !";
        //                    }
        //                }
        //                else
        //                {
        //                    MessageResult = "Thông tin chung MMTB không đổi !";
        //                }
        //                Cập nhật thông tin Máy tiện
        //                if (grctr_Tien.Visible == true)
        //                {
        //                    if (CheckError_MMTB_T() == true)
        //                    {
        //                        M0006_MayTien_DAO.Update(curr_Code, "IT");
        //                        if ((M0006_MayTien_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_Turret, curr_Horizontal, curr_Tailstock,
        //                        curr_AxisC, curr_InActive, "IT")))
        //                        {
        //                            MessageResult = MessageResult + "\n" + "Đã cập nhật Thông tin Máy tiện:  " + sLook_Code.Text.ToString() + " !";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageResult = MessageResult + "\n" + "Thông tin Máy tiện không đổi !";
        //                    }
        //                }
        //                Cập nhật thông tin Máy phay
        //                if (grctr_Phay.Visible == true)
        //                {
        //                    if (CheckError_MMTB_P() == true)
        //                    {
        //                        M0006_MayPhay_DAO.Update(curr_Code, "IT");
        //                        if ((M0006_MayPhay_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
        //                        curr_NameJP, curr_Maker, curr_Model, curr_TableL, curr_TableW, curr_Speed,
        //                        curr_BTSize, curr_TipQty, curr_WaterLine, curr_AxisXYZ, curr_AxisA, curr_AxisB,
        //                        curr_AxisC_P, curr_InActive_P, "IT")))
        //                        {
        //                            MessageResult = MessageResult + "\n" + "Đã cập nhật Thông tin Máy phay: " + sLook_Code.Text.ToString() + " !";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageResult = MessageResult + "\n" + "Thông tin Máy phay không đổi !";
        //                    }
        //                }
        //                MessageBox.Show(MessageResult, "Xác nhận");
        //                sLookUpEdit_Code1();
        //            }
        //        }
        //    }
        //}

        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(txt_InvNo.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Số hóa đơn\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_Supplier.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_ControlDept.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận quản lý MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_Supplier.Focus();
                return false;
            }
            return true;
        }

        //Check thông tin MMTB chung
        //public Boolean CheckError_MMTB()
        //{
        //    DataTable _check = new DataTable();
        //    _check = M0005_DAO.GetInfo_M0005_Check(
        //                        );
        //    if (_check.Rows.Count > 0)
        //    {
        //        //MessageBox.Show("Mã MMTB: " + sLook_Code.Text.ToString() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //sLook_Code.Focus();
        //        return false;
        //    }
        //    return true;
        //}
        //Cảnh báo khi nhập liệu thiếu thông tin
        private void SLook_Supplier_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sLook_Supplier.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập Mã NCC", "Xác nhận", MessageBoxButtons.OK);
                sLook_Supplier.Focus();
            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string tempCode = e.Value.ToString();
            DataTable tempTable = M0005_DAO.GetInfo_M0005_Check(tempCode);
            if (tempTable.Rows.Count > 0)
            {
                gridView.FocusedColumn = gridView.Columns[0];
                MessageBox.Show("Mã MMTB: " + tempCode + "đã có!", "Xác nhận", MessageBoxButtons.OK);
            }
        }
    }
}

