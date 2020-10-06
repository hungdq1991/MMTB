using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0001_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0001_DAO M0001_DAO;
        private string nameEN;
        private string nameVN;
        private string nameJP;
        private Boolean name;
        private Boolean group1;
        private Boolean group2;
        private Boolean line;
        private Boolean inActive;
        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;

        public System_DAL _systemDAL = new System_DAL();

        // Tạo mới form theo kiểu True/False
        public Form_M0001_Detail(Boolean _isNewValue, System_DAL systemDAL)
        {
            //
            InitializeComponent();
            //
            IsNewValue = _isNewValue;
            //
            _systemDAL = systemDAL;
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0001_Detail(DataRow _mainDataRow, System_DAL systemDAL)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
            //
            _systemDAL = systemDAL;
        }
        //Load form
        private void Form_M0001_Detail_Load(object sender, EventArgs e)
        {
            //
            M0001_DAO = new M0001_DAO();
            //
            Initialization_Control();
            //
            Setting_Init_Control();
            //
            SetValue_Combobox(cbx_Name);
            cbx_Name.SelectedIndex = 0;
            //
            SetValue_Combobox(cbx_Group1);
            cbx_Group1.SelectedIndex = 0;
            //
            SetValue_Combobox(cbx_Group2);
            cbx_Group2.SelectedIndex = 0;
            //
            SetValue_Combobox(cbx_Line);
            cbx_Line.SelectedIndex = 0;
            //
            SetValue_Combobox(cbx_InActive);
            cbx_InActive.SelectedIndex = 0;
            Update_Control();
        }
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Control()
        {
            if (IsNewValue)
            {
                nameEN = String.Empty;
                nameVN = String.Empty;
                nameJP = String.Empty;
                name = false;
                group1 = false;
                group2 = false;
                line = false;
                inActive = false;
            }
            else
            {
                nameEN = Convert.ToString(dataRow[0]);
                nameVN = Convert.ToString(dataRow[1]);
                nameJP = Convert.ToString(dataRow[2]);
                name = Convert.ToBoolean(dataRow[3]);
                group1 = Convert.ToBoolean(dataRow[4]);
                group2 = Convert.ToBoolean(dataRow[5]);
                line = Convert.ToBoolean(dataRow[6]);
                inActive = Convert.ToBoolean(dataRow[7]);
            }
        }
        //Kiểm soát key NameEN: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                txt_NameEN.Enabled = true;
                bbiDelete.Enabled = false;
            } else
            {
                txt_NameEN.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Tạo nội dung combo box cho user lựa chọn
        private void SetValue_Combobox(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("No"); //SelectIndex = 0
            Boolean.Add("Yes"); //SelectIndex = 1
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            txt_NameEN.Text = nameEN;
            txt_NameVN.Text = nameVN;
            txt_NameJP.Text = nameJP;
            //
            if (name)
            {
                cbx_Name.SelectedIndex = 1;
            }
            else
            {
                cbx_Name.SelectedIndex = 0;
            }
            //
            if (group1)
            {
                cbx_Group1.SelectedIndex = 1;
            }
            else
            {
                cbx_Group1.SelectedIndex = 0;
            }
            if (group2)
            {
                cbx_Group2.SelectedIndex = 1;
            }
            else
            {
                cbx_Group2.SelectedIndex = 0;
            }
            if (line)
            {
                cbx_Line.SelectedIndex = 1;
            }
            else
            {
                cbx_Line.SelectedIndex = 0;
            }
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

        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_NameEN.Enabled = true;
            txt_NameEN.Focus();
            IsNewValue = true;
            txt_NameEN.Text = "";
            txt_NameVN.Text = "";
            txt_NameJP.Text = "";
            cbx_Name.Enabled = true;
            cbx_Name.SelectedIndex = 0;
            cbx_Group1.Enabled = true;
            cbx_Group1.SelectedIndex = 0;
            cbx_Group2.Enabled = true;
            cbx_Group2.SelectedIndex = 0;
            cbx_Line.Enabled = true;
            cbx_Line.SelectedIndex = 0;
            cbx_InActive.Enabled = false;
            cbx_InActive.SelectedIndex = 0;
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = txt_NameEN.Text.Trim().ToUpper();
            string curr_NameVN = txt_NameVN.Text.Trim().ToUpper();
            string curr_NameJP = txt_NameJP.Text.Trim().ToUpper();
            int curr_Name = cbx_Name.SelectedIndex;
            int curr_Group1 = cbx_Group1.SelectedIndex;
            int curr_Group2 = cbx_Group2.SelectedIndex;
            int curr_Line = cbx_Line.SelectedIndex;
            int curr_InActive = cbx_InActive.SelectedIndex;
            //Trường hợp thêm mới
            if (IsNewValue)
            {
                Message = "Bạn muốn thêm mới name: " + txt_NameEN.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0001_DAO.Insert_Name(curr_NameEN, curr_NameVN, curr_NameJP, curr_Name, curr_Group1, curr_Group2, curr_Line, curr_InActive, _systemDAL.userName.ToUpper()))
                        {
                            Message = "Lưu thành công name: \"" + txt_NameEN.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            //Trường hợp sửa
            else
            {
                Message = "Bạn muốn cập nhật name: " + txt_NameEN.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true && CheckError1() == true)
                    {
                        if (M0001_DAO.Update_Name(curr_NameEN, curr_NameVN, curr_NameJP, curr_Name, curr_Group1, curr_Group2, curr_Line, curr_InActive, _systemDAL.userName.ToUpper()))
                        {
                            Message = "Cập nhật thành công name: \"" + txt_NameEN.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }
        //Click nút Reset
        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Control();
            txt_NameEN.Focus();
        }
        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = txt_NameEN.Text.Trim();
            Message = "Bạn muốn xóa name: " + txt_NameEN.Text.ToString() + "?";
            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (M0001_DAO.Delete_Name(curr_NameEN))
                {
                    Message = "Xóa thành công name: \"" + txt_NameEN.Text.ToString() + "\"!";
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(txt_NameEN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (Tiếng Anh)\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameEN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_NameVN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (Tiếng Việt)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameVN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_NameJP.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (Tiếng Nhật)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameJP.Focus();
                return false;
            }
            if (IsNewValue)
            {
                DataTable _check = M0001_DAO.GetInfo_M0001_Check(txt_NameEN.Text.Trim());
                if (_check.Rows.Count > 0)
                {
                    MessageBox.Show("Tên: " + txt_NameEN.Text.ToString() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NameEN.Focus();
                    return false;
                }
            }
            if ((cbx_Name.SelectedIndex == 0) & (cbx_Group1.SelectedIndex == 0) & (cbx_Group2.SelectedIndex == 0) & (cbx_Line.SelectedIndex == 0))
            {
                MessageBox.Show("Hãy chọn \"Yes\" ít nhất 1 trong 4 nhóm: \"Tên / Nhóm trung/ Nhóm đại/ Line\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_Name.Focus();
                return false;
            }
            return true;
        }
        public Boolean CheckError1()
        {
            try
            { 
                string nameEN = txt_NameEN.Text.Trim();
                string group1 = txt_NameEN.Text.Trim();
                string group2 = txt_NameEN.Text.Trim();
                string message = "";
                DataTable _tempTable = M0001_DAO.GetInfo_M0001_NameEN(nameEN);
                DataTable _tempTable1 = M0001_DAO.GetInfo_M0001_Group1(nameEN);
                DataTable _tempTable2 = M0001_DAO.GetInfo_M0001_Group2(nameEN);
                if (_tempTable.Rows.Count > 0 && cbx_Name.SelectedIndex == 0)
                {
                    message = "Tên đang sử dụng trong Phân nhóm!";
                }
                if (_tempTable1.Rows.Count > 0 && cbx_Group1.SelectedIndex == 0)
                {
                    message = message + "\n" +"Tên đang sử dụng làm Nhóm trung trong Phân nhóm!";
                }
                if (_tempTable2.Rows.Count > 0 && cbx_Group2.SelectedIndex == 0)
                {
                    message = message + "\n" + "Tên đang sử dụng làm Nhóm đại trong Phân nhóm!";
                }
                if (!String.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
    }
}
