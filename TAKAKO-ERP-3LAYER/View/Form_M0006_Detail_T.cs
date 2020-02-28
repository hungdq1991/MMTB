using System;
using System.Data;
using TAKAKO_ERP_3LAYER.DAO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0006_Detail_T : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Biến
        public DataTable _tempTable_T;
        public DataTable _tempTable_P;
        public DataRow dataRow;
        public M0006_DAO M0006_DAO;
        public M0006_MayTien_DAO M0006_MayTien_DAO;
        public M0006_MayPhay_DAO M0006_MayPhay_DAO;
        //Các biến theo bảng M0006_TechMMTB
        public string Code;
        public string ACCCode;
        public string NameEN;
        public string NameVN;
        public string NameJP;
        public string Maker;
        public string Model;
        public string Group;
        public Boolean MayTien;
        public Boolean MayPhay;
        public int Level;
        public int SizeL;
        public int SizeW;
        public int SizeH;
        public string Chuck3Jaw;
        public string Collet1;
        public string Collet2;
        public string Collet3;
        public string Voltage;
        public string OperatingSys;
        public decimal Wattage_KVA;
        public Boolean inActive;
        //Các biến theo bảng M0006_TechMMTB_T
        public int Turret_TipQty;
        public int Horizontal_TipQty;
        public Boolean Tailstock;
        public Boolean AxisC;
        public Boolean inActive_T;
        //Các biến theo bảng M0006_TechMMTB_P
        public int TableLength_L;
        public int TableLength_W;
        public int Speed;
        public decimal BTSize;
        public int TipQty;
        public Boolean WaterLine;
        public Boolean AxisXYZ;
        public Boolean AxisA;
        public Boolean AxisB;
        public Boolean AxisC_P;
        public Boolean inActive_P;
        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;
        #endregion
        public Form_M0006_Detail_T()
        {
            InitializeComponent();
        }
        //Tạo mới form theo kiểu True/False
        public Form_M0006_Detail_T(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0006_Detail_T(DataRow _mainDataRow)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
        }
        //Load form M0006_Detail
        private void Form_M0006_Detail_T_Load(object sender, EventArgs e)
        {
            //
            M0006_DAO = new M0006_DAO();
            M0006_MayTien_DAO = new M0006_MayTien_DAO();
            M0006_MayPhay_DAO = new M0006_MayPhay_DAO();
            //
            grctr_Tien.Visible = true;
            grctr_Phay.Visible = true;
            lbl_ChiTiet.Visible = true;
            //
            sLookUpEdit_Code1();
            //
            Initialization_Control();
            //
            Setting_Init_Control();
            //
            Update_Control();
            //
            SetValue_Combobox(cbx_Tailstock);
            SetValue_Combobox(cbx_AxisC);
            SetValue_Combobox(cbx_WaterLine);
            SetValue_Combobox(cbx_AxisXYZ);
            SetValue_Combobox(cbx_AxisA);
            SetValue_Combobox(cbx_AxisB);
            SetValue_Combobox(cbx_AxisC_P);
        }
        //Tạo nội dung combo box cho user lựa chọn: Yes/No
        private void SetValue_Combobox(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("No");
            Boolean.Add("Yes");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Điền dữ liệu cho ô Code
        private void sLookUpEdit_Code() //Chỉ lấy các mã MMTB chưa có thông tin kỹ thuật
        {
            DataTable tempTable = new DataTable();
            tempTable = M0006_DAO.GetInfo_M0005_Code();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Code.Properties.DataSource = tempTable;
                sLook_Code.Properties.ValueMember = "Code";
                sLook_Code.Properties.DisplayMember = "Code";
            }
            else
            {
                sLook_Code.Properties.DataSource = "";
            }
        }
        private void sLookUpEdit_Code1() //Lấy các mã MMTB đã có thông tin kỹ thuật
        {
            DataTable tempTable = new DataTable();
            tempTable = M0006_DAO.GetInfo_M0006_Code();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Code.Properties.DataSource = tempTable;
                sLook_Code.Properties.ValueMember = "Code";
                sLook_Code.Properties.DisplayMember = "Code";
            }
        }
        //Lấy kết quả ô Code, điền dữ liệu tương ứng cho ô ACCCode, NameEN, Maker, Model...
        private void SLook_Code_Validated(object sender, EventArgs e)
        {
            string tempCode = sLook_Code.Text.Trim();
            DataTable tempTable = new DataTable();
            if (IsNewValue && !String.IsNullOrEmpty(tempCode))
            {
                tempTable = M0006_DAO.GetInfo_Code(tempCode);

                if (tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        txt_ACCCode.Text = row.Field<string>("ACCCode");
                        txt_NameEN.Text = row.Field<string>("NameEN");
                        txt_NameVN.Text = row.Field<string>("NameVN");
                        txt_NameJP.Text = row.Field<string>("NameJP");
                        txt_Maker.Text = row.Field<string>("Maker");
                        txt_Model.Text = row.Field<string>("Model");
                        string group = row.Field<string>("Group2");
                        if (group == "Lathe Machine")
                        {
                            lbl_ChiTiet.Visible = true;
                            grctr_Tien.Visible = true;
                            grctr_Phay.Visible = false;
                            txt_Turret.EditValue = Turret_TipQty;
                            txt_Horizontal.EditValue = Horizontal_TipQty;
                            cbx_Tailstock.SelectedIndex = 0;
                            cbx_AxisC.SelectedIndex = 0;
                        }
                        if (group == "Machining center machine")
                        {
                            lbl_ChiTiet.Visible = true;
                            grctr_Phay.Visible = true;
                            grctr_Tien.Visible = false;
                            txt_TableL.EditValue = TableLength_L;
                            txt_TableW.EditValue = TableLength_W;
                            txt_Speed.EditValue = Speed;
                            txt_BTSize.EditValue = BTSize;
                            txt_TipQty.EditValue = TipQty;
                            cbx_WaterLine.SelectedIndex = 0;
                            cbx_AxisXYZ.SelectedIndex = 0;
                            cbx_AxisA.SelectedIndex = 0;
                            cbx_AxisB.SelectedIndex = 0;
                            cbx_AxisC_P.SelectedIndex = 0;
                        }
                        if (group != "Machining center machine" && group != "Lathe Machine")
                        {
                            lbl_ChiTiet.Visible = false;
                            grctr_Phay.Visible = false;
                            grctr_Tien.Visible = false;
                        }
                    }
                }
            }
        }

        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        //double click tại group control: Máy tiện
        private void Initialization_Control()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                sLookUpEdit_Code();
                Code = String.Empty;
                ACCCode = String.Empty;
                NameEN = String.Empty;
                Maker = String.Empty;
                Model = String.Empty;
                Level = 0;
                SizeL = 0;
                SizeW = 0;
                SizeH = 0;
                Chuck3Jaw = String.Empty;
                Collet1 = String.Empty;
                Collet2 = String.Empty;
                Collet3 = String.Empty;
                Voltage = String.Empty;
                OperatingSys = String.Empty;
                Wattage_KVA = 0;
                inActive = false;
                Turret_TipQty = 0;
                Horizontal_TipQty = 0;
                Tailstock = false;
                AxisC = false;
                inActive_T = false;
                TableLength_L = 0;
                TableLength_W = 0;
                Speed = 0;
                BTSize = 0;
                TipQty = 0;
                WaterLine = false;
                AxisXYZ = false;
                AxisA = false;
                AxisB = false;
                AxisC_P = false;
                inActive_P = false;
            }
            else
            {
                Code = Convert.ToString(dataRow[0]);
                Group = Convert.ToString(dataRow[8]);
                if (Group == "Lathe Machine")
                {
                    lbl_ChiTiet.Visible = true;
                    grctr_Tien.Visible = true;
                    grctr_Phay.Visible = false;
                    SetValue_Combobox(cbx_Tailstock);
                    SetValue_Combobox(cbx_AxisC);
                }
                if (Group == "Machining center machine")
                {
                    lbl_ChiTiet.Visible = true;
                    grctr_Phay.Visible = true;
                    grctr_Tien.Visible = false;
                    SetValue_Combobox(cbx_WaterLine);
                    SetValue_Combobox(cbx_AxisXYZ);
                    SetValue_Combobox(cbx_AxisA);
                    SetValue_Combobox(cbx_AxisB);
                    SetValue_Combobox(cbx_AxisC_P);
                }
                if (Group != "Machining center machine" && Group != "Lathe Machine")
                {
                    grctr_Tien.Visible = false;
                    grctr_Phay.Visible = false;
                    lbl_ChiTiet.Visible = false;
                }
                //Load dữ liệu cho thông tin chung MMTB
                string tempCode = Code;
                DataTable tempTable = new DataTable();
                tempTable = M0006_DAO.GetInfo_M0006_Code(tempCode);
                if (tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        ACCCode = Convert.ToString(row.Field<string>("ACCCode"));
                        NameEN = Convert.ToString(row.Field<string>("NameEN"));
                        NameVN = Convert.ToString(row.Field<string>("NameVN"));
                        NameJP = Convert.ToString(row.Field<string>("NameJP"));
                        Maker = Convert.ToString(row.Field<string>("Maker"));
                        Model = Convert.ToString(row.Field<string>("Model"));
                        Level = Convert.ToInt32(row.Field<int>("Level"));
                        SizeL = Convert.ToInt32(row.Field<int>("SizeL"));
                        SizeW = Convert.ToInt32(row.Field<int>("SizeW"));
                        SizeH = Convert.ToInt32(row.Field<int>("SizeH"));
                        Chuck3Jaw = Convert.ToString(row.Field<string>("Chuck3Jaw"));
                        Collet1 = Convert.ToString(row.Field<string>("Collet1"));
                        Collet2 = Convert.ToString(row.Field<string>("Collet2"));
                        Collet3 = Convert.ToString(row.Field<string>("Collet3"));
                        Voltage = Convert.ToString(row.Field<string>("Voltage"));
                        OperatingSys = Convert.ToString(row.Field<string>("OperatingSys"));
                        Wattage_KVA = Convert.ToDecimal(row.Field<decimal>("Wattage_KVA"));
                        inActive = Convert.ToBoolean(row.Field<bool>("InActive"));
                    }
                }
                else
                {
                    ACCCode = "";
                    NameEN = "";
                    NameVN = "";
                    NameJP = "";
                    Maker = "";
                    Model = "";
                    Level = 0;
                    SizeL = 0;
                    SizeW = 0;
                    SizeH = 0;
                    Chuck3Jaw = "";
                    Collet1 = "";
                    Collet2 = "";
                    Collet3 = "";
                    Voltage = "";
                    OperatingSys = "";
                    Wattage_KVA = 0;
                    inActive = false;
                }
                //Load dữ liệu cho group control Máy tiện
                lbl_ChiTiet.Visible = true;
                grctr_Tien.Visible = true;
                grctr_Phay.Visible = false;
                SetValue_Combobox(cbx_Tailstock);
                SetValue_Combobox(cbx_AxisC);
                Turret_TipQty = Convert.ToInt32(dataRow[9]);
                Horizontal_TipQty = Convert.ToInt32(dataRow[10]);
                Tailstock = Convert.ToBoolean(dataRow[11]);
                AxisC = Convert.ToBoolean(dataRow[12]);
                inActive_T = Convert.ToBoolean(dataRow[13]);
                //Load dữ liệu cho group control: Máy phay
                DataTable tempTable1 = new DataTable();
                tempTable1 = M0006_MayPhay_DAO.GetInfo_Code(tempCode);
                if (tempTable1.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable1.Rows)
                    {
                        TableLength_L = Convert.ToInt32(row.Field<int>("TableLength_L"));
                        TableLength_W = Convert.ToInt32(row.Field<int>("TableLength_W"));
                        Speed = Convert.ToInt32(row.Field<int>("Speed"));
                        BTSize = Convert.ToDecimal(row.Field<decimal>("BTSize"));
                        TipQty = Convert.ToInt32(row.Field<int>("TipQty"));
                        WaterLine = Convert.ToBoolean(row.Field<bool>("WaterLine"));
                        AxisXYZ = Convert.ToBoolean(row.Field<bool>("AxisXYZ"));
                        AxisA = Convert.ToBoolean(row.Field<bool>("AxisA"));
                        AxisB = Convert.ToBoolean(row.Field<bool>("AxisB"));
                        AxisC_P = Convert.ToBoolean(row.Field<bool>("AxisC_P"));
                        inActive_P = Convert.ToBoolean(row.Field<bool>("InActive"));
                    }
                }
                else
                {
                    TableLength_L = 0;
                    TableLength_W = 0;
                    Speed = 0;
                    BTSize = 0;
                    TipQty = 0;
                    WaterLine = false;
                    AxisXYZ = false;
                    AxisA = false;
                    AxisB = false;
                    AxisC_P = false;
                    inActive_P = false;
                }
            }
        }
        //Kiểm soát key Code: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp cần cập nhật thông tin
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                sLook_Code.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                sLook_Code.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Đưa dữ liệu trên form
        private void Update_Control()
        {
            sLook_Code.Text = Code;
            txt_ACCCode.Text = ACCCode;
            txt_NameEN.Text = NameEN;
            txt_NameVN.Text = NameVN;
            txt_NameJP.Text = NameJP;
            txt_Maker.Text = Maker;
            txt_Model.Text = Model;
            txt_Level.EditValue = Level;
            txt_SizeL.EditValue = SizeL;
            txt_SizeW.EditValue = SizeW;
            txt_SizeH.EditValue = SizeH;
            txt_Chuck3Jaw.Text = Chuck3Jaw;
            txt_Collet1.Text = Collet1;
            txt_Collet2.Text = Collet2;
            txt_Collet3.Text = Collet3;
            txt_Voltage.Text = Voltage;
            txt_OperatingSys.Text = OperatingSys;
            txt_Wattage_KVA.EditValue = Wattage_KVA;
            txt_Turret.EditValue = Turret_TipQty;
            txt_Horizontal.EditValue = Horizontal_TipQty;
            if (Tailstock)
            {
                cbx_Tailstock.SelectedIndex = 1;
            }
            else
            {
                cbx_Tailstock.SelectedIndex = 0;
            }
            if (AxisC)
            {
                cbx_AxisC.SelectedIndex = 1;
            }
            else
            {
                cbx_AxisC.SelectedIndex = 0;
            }
            txt_TableL.EditValue = TableLength_L;
            txt_TableW.EditValue = TableLength_W;
            txt_Speed.EditValue = Speed;
            txt_BTSize.EditValue = BTSize;
            txt_TipQty.EditValue = TipQty;
            if (WaterLine)
            {
                cbx_WaterLine.SelectedIndex = 1;
            }
            else
            {
                cbx_WaterLine.SelectedIndex = 0;
            }
            if (AxisXYZ)
            {
                cbx_AxisXYZ.SelectedIndex = 1;
            }
            else
            {
                cbx_AxisXYZ.SelectedIndex = 0;
            }
            if (AxisA)
            {
                cbx_AxisA.SelectedIndex = 1;
            }
            else
            {
                cbx_AxisA.SelectedIndex = 0;
            }
            if (AxisB)
            {
                cbx_AxisB.SelectedIndex = 1;
            }
            else
            {
                cbx_AxisB.SelectedIndex = 0;
            }
            if (AxisC_P)
            {
                cbx_AxisC_P.SelectedIndex = 1;
            }
            else
            {
                cbx_AxisC_P.SelectedIndex = 0;
            }
        }
        //Click nút New
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsNewValue = true;
            lbl_ChiTiet.Visible = false;
            grctr_Tien.Visible = false;
            grctr_Phay.Visible = false;
            Initialization_Control();
            Update_Control();
            Setting_Init_Control();
            sLook_Code.Focus();
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrEmpty(sLook_Code.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập Mã MMTB", "Xác nhận", MessageBoxButtons.OK);
                sLook_Code.Focus();
            }
            else
            {
                #region
                string Message = "";
                string MessageResult = "";
                string curr_Code = sLook_Code.Text.Trim();
                string curr_ACCCode = txt_ACCCode.Text.Trim();
                string curr_NameEN = txt_NameEN.Text.Trim();
                string curr_NameVN = txt_NameVN.Text.Trim();
                string curr_NameJP = txt_NameJP.Text.Trim();
                string curr_Maker = txt_Maker.Text.Trim();
                string curr_Model = txt_Model.Text.Trim();
                int curr_Level = Int32.Parse(txt_Level.Text.Trim());
                int curr_SizeL = Int32.Parse(txt_SizeL.Text.Trim());
                int curr_SizeW = Int32.Parse(txt_SizeW.Text.Trim());
                int curr_SizeH = Int32.Parse(txt_SizeH.Text.Trim());
                string curr_Chuck3Jaw = txt_Chuck3Jaw.Text.Trim();
                string curr_Collet1 = txt_Collet1.Text.Trim();
                string curr_Collet2 = txt_Collet2.Text.Trim();
                string curr_Collet3 = txt_Collet3.Text.Trim();
                string curr_Voltage = txt_Voltage.Text.Trim();
                string curr_OperatingSys = txt_OperatingSys.Text.Trim();
                decimal curr_Wattage = Decimal.Parse(txt_Wattage_KVA.Text.Trim());
                int curr_InActive = 0;
                int curr_Turret = Int32.Parse(txt_Turret.Text.Trim());
                int curr_Horizontal = Int32.Parse(txt_Horizontal.Text.Trim());
                int curr_Tailstock = cbx_Tailstock.SelectedIndex;
                int curr_AxisC = cbx_AxisC.SelectedIndex;
                int curr_InActive_T = 0;
                int curr_TableL = Int32.Parse(txt_TableL.Text.Trim());
                int curr_TableW = Int32.Parse(txt_TableW.Text.Trim());
                int curr_Speed = Int32.Parse(txt_Speed.Text.Trim());
                decimal curr_BTSize = Decimal.Parse(txt_BTSize.Text.Trim());
                int curr_TipQty = Int32.Parse(txt_TipQty.Text.Trim());
                int curr_WaterLine = cbx_WaterLine.SelectedIndex;
                int curr_AxisXYZ = cbx_AxisXYZ.SelectedIndex;
                int curr_AxisA = cbx_AxisA.SelectedIndex;
                int curr_AxisB = cbx_AxisB.SelectedIndex;
                int curr_AxisC_P = cbx_AxisC_P.SelectedIndex;
                int curr_InActive_P = 0;
                #endregion
                //Trường hợp thêm mới
                if (IsNewValue)
                {
                    Message = "Bạn muốn thêm mới Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"?";
                    if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        if (CheckError() == true)
                        {
                            //Lưu thông tin chung MMTB
                            if (M0006_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_Level, curr_SizeL, curr_SizeW,
                                    curr_SizeH, curr_Chuck3Jaw, curr_Collet1, curr_Collet2, curr_Collet3,
                                    curr_Voltage, curr_OperatingSys, curr_Wattage, curr_InActive, "IT"))
                            {
                                Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
                            }
                            //Lưu thông tin Máy tiện
                            if (grctr_Tien.Visible == true)
                            {
                                if (M0006_MayTien_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_Turret, curr_Horizontal, curr_Tailstock,
                                    curr_AxisC, curr_InActive_T, "IT"))
                                {
                                    Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
                                }
                            }
                            //Lưu thông tin Máy phay
                            if (grctr_Phay.Visible == true)
                            {
                                if (M0006_MayPhay_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_TableL, curr_TableW, curr_Speed,
                                    curr_BTSize, curr_TipQty, curr_WaterLine, curr_AxisXYZ, curr_AxisA, curr_AxisB,
                                    curr_AxisC_P, curr_InActive_P, "IT"))
                                {
                                    Message = "Lưu thành công Mã MMTB: \"" + sLook_Code.Text.ToString() + "\"!";
                                }
                            }
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        IsNewValue = true;
                        Initialization_Control();
                        Update_Control();
                        Setting_Init_Control();
                        lbl_ChiTiet.Visible = false;
                        grctr_Tien.Visible = false;
                        grctr_Phay.Visible = false;
                    }
                }
                //Trường hợp sửa
                else
                {
                    if (CheckError() == true)
                    {
                        Message = "Bạn muốn cập nhật Mã MMTB: " + sLook_Code.Text.ToString() + "?";
                        if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            //Cập nhật thông tin chung
                            if (CheckError_MMTB() == true)
                            {
                                M0006_DAO.Update(curr_Code, "IT");
                                if (M0006_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_Level, curr_SizeL, curr_SizeW,
                                    curr_SizeH, curr_Chuck3Jaw, curr_Collet1, curr_Collet2, curr_Collet3,
                                    curr_Voltage, curr_OperatingSys, curr_Wattage, curr_InActive, "IT"))
                                {
                                    MessageResult = "Đã cập nhật Thông tin chung:      " + sLook_Code.Text.ToString() + " !";
                                }
                            }
                            else
                            {
                                MessageResult = "Thông tin chung MMTB không đổi !";
                            }
                            //Cập nhật thông tin Máy tiện
                            if (grctr_Tien.Visible == true)
                            {
                                if (CheckError_MMTB_T() == true)
                                {
                                    M0006_MayTien_DAO.Update(curr_Code, "IT");
                                    if ((M0006_MayTien_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_Turret, curr_Horizontal, curr_Tailstock,
                                    curr_AxisC, curr_InActive, "IT")))
                                    {
                                        MessageResult = MessageResult + "\n" + "Đã cập nhật Thông tin Máy tiện:  " + sLook_Code.Text.ToString() + " !";
                                    }
                                }
                                else
                                {
                                    MessageResult = MessageResult + "\n" + "Thông tin Máy tiện không đổi !";
                                }
                            }
                            //Cập nhật thông tin Máy phay
                            if (grctr_Phay.Visible == true)
                            {
                                if (CheckError_MMTB_P() == true)
                                {
                                    M0006_MayPhay_DAO.Update(curr_Code, "IT");
                                    if ((M0006_MayPhay_DAO.Insert(curr_Code, curr_ACCCode, curr_NameEN, curr_NameVN,
                                    curr_NameJP, curr_Maker, curr_Model, curr_TableL, curr_TableW, curr_Speed,
                                    curr_BTSize, curr_TipQty, curr_WaterLine, curr_AxisXYZ, curr_AxisA, curr_AxisB,
                                    curr_AxisC_P, curr_InActive_P, "IT")))
                                    {
                                        MessageResult = MessageResult + "\n" + "Đã cập nhật Thông tin Máy phay: " + sLook_Code.Text.ToString() + " !";
                                    }
                                }
                                else
                                {
                                    MessageResult = MessageResult + "\n" + "Thông tin Máy phay không đổi !";
                                }
                            }
                            MessageBox.Show(MessageResult, "Xác nhận");
                            sLookUpEdit_Code1();
                        }
                    }
                }
            }
        }
        //Click nút Reset
        private void BbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Control();
            sLook_Code.Focus();
        }
        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(sLook_Code.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Mã MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_Code.Focus();
                return false;
            }
            return true;
        }
        

        //Check thông tin MMTB chung
        public Boolean CheckError_MMTB()
        {
            DataTable _check = new DataTable();
            _check = M0006_DAO.GetInfo_M0006_Check(
                                sLook_Code.Text.Trim(),
                                Int32.Parse(txt_Level.Text.Trim()),
                                Int32.Parse(txt_SizeL.Text.Trim()),
                                Int32.Parse(txt_SizeW.Text.Trim()),
                                Int32.Parse(txt_SizeH.Text.Trim()),
                                txt_Chuck3Jaw.Text.Trim(),
                                txt_Collet1.Text.Trim(),
                                txt_Collet2.Text.Trim(),
                                txt_Collet3.Text.Trim(),
                                txt_Voltage.Text.Trim(),
                                txt_OperatingSys.Text.Trim(),
                                Decimal.Parse(txt_Wattage_KVA.Text.Trim()));
            if (_check.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        //Check thông tin MMTB - máy tiện
        public Boolean CheckError_MMTB_T()
        {
            DataTable _checkTien = new DataTable();
            _checkTien = M0006_MayTien_DAO.GetInfo_M0006_Check(
                                sLook_Code.Text.Trim(),
                                Int32.Parse(txt_Turret.Text.Trim()),
                                Int32.Parse(txt_Horizontal.Text.Trim()),
                                cbx_Tailstock.SelectedIndex,
                                cbx_AxisC.SelectedIndex);

            if (_checkTien.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        //Check thông tin MMTB - máy phay
        public Boolean CheckError_MMTB_P()
        {
            DataTable _checkPhay = new DataTable();
            _checkPhay = M0006_MayPhay_DAO.GetInfo_M0006_Check(
                                sLook_Code.Text.Trim(),
                                Int32.Parse(txt_TableL.Text.Trim()),
                                Int32.Parse(txt_TableW.Text.Trim()),
                                Int32.Parse(txt_Speed.Text.Trim()),
                                Decimal.Parse(txt_BTSize.Text.Trim()),
                                Int32.Parse(txt_TipQty.Text.Trim()),
                                cbx_WaterLine.SelectedIndex,
                                cbx_AxisXYZ.SelectedIndex,
                                cbx_AxisA.SelectedIndex,
                                cbx_AxisB.SelectedIndex,
                                cbx_AxisC_P.SelectedIndex);
            if (_checkPhay.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        //Cảnh báo khi nhập liệu thiếu thông tin //(Chưa có)
        //Thông báo khi chưa nhập mã MMTB
        private void SLook_Code_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sLook_Code.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập Mã MMTB", "Xác nhận", MessageBoxButtons.OK);
                sLook_Code.Focus();
            }
        }
    }
}

