using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0003_Line_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0003_Line_DAO M0003_Line_DAO;
        public M0005_DAO M0005_DAO;
        private string TVC;
        private string LineCode;
        private string LineEN;
        private string LineVN;
        private string LineJP;
        private string ProcessCode;
        private string GroupLineACC;
        private string UsingDept;
        private int Point;
        private string ExpenseGroup;
        private DateTime applyDate;
        private Boolean inActive;
        private string Memo;

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;

        //
        public System_DAL _systemDAL = new System_DAL();

        //Tạo mới form theo kiểu True/False
        public Form_M0003_Line_Detail(Boolean _isNewValue, System_DAL systemDAL)
        {
            InitializeComponent();
            //
            IsNewValue = _isNewValue;
            //
            _systemDAL = systemDAL;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0003_Line_Detail(DataRow _mainDataRow, System_DAL systemDAL)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
            //
            _systemDAL = systemDAL;
        }
        //Load form
        private void Form_M0003_Detail_Load(object sender, EventArgs e)
        {
            //
            M0003_Line_DAO = new M0003_Line_DAO();
            M0005_DAO = new M0005_DAO();
            //
            SetValue_Combobox1(cbx_TVC);
            cbx_TVC.SelectedIndex = 0;
            //
            sLookUpEdit_LineEN();
            //
            sLookUpEdit_ProcessCode();
            //
            LookUpEdit_GroupLineACC();
            //
            LookUpEdit_UsingDept();
            //
            LookUpEdit_ExpenseGroup();
            //
            LookUpEdit_Memo();
            //
            SetValue_Combobox(cbx_InActive);
            cbx_InActive.SelectedIndex = 0;
            //
            Initialization_Control();
            //
            Setting_Init_Control();
            //
            Update_Control();
        }
        //Tạo nội dung combo box cho user lựa chọn: InActive Yes/No
        private void SetValue_Combobox(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("No");
            Boolean.Add("Yes");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Tạo nội dung combo box cho user lựa chọn: TVC1/TVC2
        private void SetValue_Combobox1(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> TVC = new List<string>();
            TVC.Add("TVC1");
            TVC.Add("TVC2");
            comboBox.Properties.Items.AddRange(TVC);
        }
        //Điền dữ liệu cho ô LineEN
        private void sLookUpEdit_LineEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0003_Line_DAO.GetInfo_M0001_LineEN();
            if (tempTable.Rows.Count > 0)
            {
                sLook_LineEN.Properties.DataSource = tempTable;
                sLook_LineEN.Properties.ValueMember = "NameEN";
                sLook_LineEN.Properties.DisplayMember = "NameEN";
            }
        }
        //Lấy kết quả ô LineEN, điền dữ liệu tương ứng cho ô LineVN, LineJP
        private void SLook_LineEN_Validated(object sender, EventArgs e)
        {
            string tempLineEN = sLook_LineEN.Text.Trim();
            txt_LineVN.Text = tempLineEN;
            txt_LineJP.Text = tempLineEN;
        }
        //Điền dữ liệu cho ô ProcessCode
        private void sLookUpEdit_ProcessCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0003_Line_DAO.GetInfo_M0003_ProcessCode();
            if (tempTable.Rows.Count > 0)
            {
                sLook_ProcessCode.Properties.DataSource = tempTable;
                sLook_ProcessCode.Properties.ValueMember = "ProcessCode";
                sLook_ProcessCode.Properties.DisplayMember = "ProcessCode";
            }
        }
        //Điền dữ liệu cho ô GroupLineACC
        private void LookUpEdit_GroupLineACC()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0003_Line_DAO.GetInfo_M0003_GroupLineACC();
            if (tempTable.Rows.Count > 0)
            {
                sLookUp_GroupLineACC.Properties.DataSource = tempTable;
                sLookUp_GroupLineACC.Properties.ValueMember = "ConsolSub";
                sLookUp_GroupLineACC.Properties.DisplayMember = "ConsolSub";
            }
        }
        //Điền dữ liệu cho ô UsingDept
        private void LookUpEdit_UsingDept()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_ControlDept();
            if (tempTable.Rows.Count > 0)
            {
                sLookUp_UsingDept.Properties.DataSource = tempTable;
                sLookUp_UsingDept.Properties.ValueMember = "SectionID";
                sLookUp_UsingDept.Properties.DisplayMember = "SectionID";
            }
        }
        //Điền dữ liệu cho ô ExpenseGroup
        private void LookUpEdit_ExpenseGroup()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            DataTable tempDataTable = new DataTable();
            tempDataTable = M0003_Line_DAO.GetInfo_M0003_ExpenseGroup();

            if (tempDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    collection.Add(row["ExpenseGroup"].ToString());
                }
                txt_ExpenseGroup.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_ExpenseGroup.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_ExpenseGroup.MaskBox.AutoCompleteCustomSource = collection;
            }
        }
        //Điền dữ liệu cho ô Memo
        private void LookUpEdit_Memo()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            DataTable tempDataTable = new DataTable();
            tempDataTable = M0003_Line_DAO.GetInfo_M0003_Memo();

            if (tempDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    collection.Add(row["Memo"].ToString());
                }
                txt_Memo.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_Memo.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_Memo.MaskBox.AutoCompleteCustomSource = collection;
            }
        }
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Control()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                TVC = "TVC1";
                LineCode = String.Empty;
                LineEN = String.Empty;
                LineVN = String.Empty;
                LineJP = String.Empty;
                ProcessCode = String.Empty;
                GroupLineACC = String.Empty;
                UsingDept = String.Empty;
                Point = 0;
                ExpenseGroup = String.Empty;
                applyDate = DateTime.Today;
                inActive = false;
                Memo = String.Empty;
            }
            else
            {
                TVC = Convert.ToString(dataRow[0]);
                LineCode = Convert.ToString(dataRow[1]);
                LineEN = Convert.ToString(dataRow[2]);
                LineVN = Convert.ToString(dataRow[3]);
                LineJP = Convert.ToString(dataRow[4]);
                ProcessCode = Convert.ToString(dataRow[5]);
                GroupLineACC = Convert.ToString(dataRow[6]);
                UsingDept = Convert.ToString(dataRow[7]);
                Point = Convert.ToInt32(dataRow[8]);
                ExpenseGroup = Convert.ToString(dataRow[9]);
                applyDate = Convert.ToDateTime(dataRow[10]);
                inActive = Convert.ToBoolean(dataRow[11]);
                Memo = Convert.ToString(dataRow[12]);
            }
        }
        //Kiểm soát key LineCode: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                cbx_TVC.Enabled = true;
                txt_LineCode.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                cbx_TVC.Enabled = false;
                txt_LineCode.Enabled = false;
                sLook_ProcessCode.Enabled = false;
                sLookUp_GroupLineACC.Enabled = false;
                sLookUp_UsingDept.Enabled = false;
                txt_Point.Enabled = false;
                txt_ExpenseGroup.Enabled = false;
                date_ApplyDate.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            cbx_TVC.Text = TVC;
            txt_LineCode.Text = LineCode;
            sLook_LineEN.EditValue = LineEN;
            txt_LineVN.Text = LineVN;
            txt_LineJP.Text = LineJP;
            sLook_ProcessCode.EditValue = ProcessCode;
            sLookUp_GroupLineACC.EditValue = GroupLineACC;
            sLookUp_UsingDept.EditValue = UsingDept;
            txt_Point.Text = Point.ToString();
            txt_ExpenseGroup.Text = ExpenseGroup;
            date_ApplyDate.EditValue = applyDate;
            txt_Memo.EditValue = Memo;
            if (inActive)
            {
                cbx_InActive.SelectedIndex = 1;
            }
            else
            {
                cbx_InActive.SelectedIndex = 0;
            }
        }
        //Click nút New
        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsNewValue = true;
            cbx_TVC.Enabled = true;
            cbx_TVC.Focus();
            txt_LineCode.Enabled = true;
            txt_LineCode.Text = "";
            txt_LineCode.Focus();
            sLook_LineEN.Enabled = true;
            sLook_LineEN.Text = "";
            txt_LineVN.Text = "";
            txt_LineJP.Text = "";
            sLook_ProcessCode.Enabled = true;
            sLook_ProcessCode.Text = "";
            sLookUp_GroupLineACC.Enabled = true;
            sLookUp_GroupLineACC.EditValue = "";
            sLookUp_UsingDept.Enabled = true;
            sLookUp_UsingDept.EditValue = "";
            txt_Point.Text = "0";
            txt_ExpenseGroup.Enabled = true;
            txt_ExpenseGroup.Text = "";
            date_ApplyDate.Enabled = true;
            date_ApplyDate.EditValue = DateTime.Today;
            txt_Memo.Enabled = true;
            txt_Memo.Text = "";
            cbx_InActive.Enabled = true;
            cbx_InActive.SelectedIndex = 0;
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Message = "";
            string curr_TVC = cbx_TVC.SelectedIndex.ToString();
            string TVC;
            if (curr_TVC == "0")
            {
                TVC = "TVC1";
            }
            else
            {
                TVC = "TVC2";
            }
            string curr_LineCode = txt_LineCode.Text.Trim();
            string curr_LineEN = sLook_LineEN.Text.Trim();
            string curr_LineVN = txt_LineVN.Text.Trim();
            string curr_LineJP = txt_LineJP.Text.Trim();
            string curr_ProcessCode = sLook_ProcessCode.EditValue.ToString();
            string curr_GroupLineACC = sLookUp_GroupLineACC.EditValue.ToString();
            string curr_UsingDept = sLookUp_UsingDept.EditValue.ToString();
            int curr_Point = Int32.Parse(txt_Point.Text.Trim());
            string curr_ExpenseGroup = txt_ExpenseGroup.Text.Trim();
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            int curr_InActive = cbx_InActive.SelectedIndex;
            string curr_Memo = txt_Memo.Text.Trim();
            //Trường hợp thêm mới
            if (IsNewValue)
            {
                Message = "Bạn muốn thêm mới tên: " + txt_LineCode.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0003_Line_DAO.Insert(TVC, curr_LineCode, curr_LineEN, curr_LineVN, curr_LineJP, curr_ProcessCode, curr_GroupLineACC, curr_UsingDept, curr_Point, curr_ExpenseGroup, curr_ApplyDate, curr_InActive, curr_Memo, _systemDAL.userName))
                        {
                            Message = "Lưu thành công tên: \"" + txt_LineCode.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            //Trường hợp sửa
            else
            {
                Message = "Bạn muốn cập nhật tên: " + txt_LineCode.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0003_Line_DAO.Update(curr_LineCode, curr_LineEN, curr_LineVN, curr_LineJP, curr_ApplyDate, curr_InActive, curr_Memo, _systemDAL.userName))
                        {
                            Message = "Cập nhật thành công tên: \"" + txt_LineCode.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        //Click nút Reset
        private void BbiReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            Update_Control();
            txt_LineCode.Focus();
        }

        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Message = "";
            string curr_LineCode = txt_LineCode.Text.Trim();
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            Message = "Bạn muốn xóa tên: " + txt_LineCode.Text.ToString() + "?";
            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (M0003_Line_DAO.Delete(curr_LineCode, curr_ApplyDate))
                {
                    Message = "Xóa thành công tên: \"" + txt_LineCode.Text.ToString() + "\"!";
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        //Click nút Close
        private void BbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(txt_LineCode.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Mã line\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LineCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_LineEN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Anh)\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_LineEN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_LineVN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Việt)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LineVN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_LineJP.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Nhật)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LineJP.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_ProcessCode.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Công đoạn\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ProcessCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLookUp_GroupLineACC.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Nhóm line ACC\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLookUp_GroupLineACC.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLookUp_UsingDept.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận SX\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLookUp_UsingDept.Focus();
                return false;
            }
            if (IsNewValue && DateTime.Today > date_ApplyDate.DateTime)
            {
                MessageBox.Show("\"Ngày hiệu lực\" phải >= Ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_ApplyDate.Focus();
                return false;
            }
            if (IsNewValue)
            {
                DataTable _check = M0003_Line_DAO.GetInfo_M0003_Check(txt_LineCode.Text.Trim(), sLook_ProcessCode.Text.Trim(), sLookUp_GroupLineACC.Text.Trim(), sLookUp_UsingDept.Text.ToString(), txt_ExpenseGroup.Text.ToString(), DateTime.Parse(date_ApplyDate.Text.Trim()));
                if (_check.Rows.Count > 0)
                {
                    MessageBox.Show("Tên: " + txt_LineCode.Text.ToString() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_LineCode.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
