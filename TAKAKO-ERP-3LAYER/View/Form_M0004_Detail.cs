using System;
using System.Collections.Generic;
using System.Data;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.DAL;
using System.Windows.Forms;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0004_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0002_DAO M0002_DAO;
        public M0004_DAO M0004_DAO;
        public string NameEN;
        public string NameVN;
        public string NameJP;
        public string Maker;
        public string Model;
        public Boolean inActive;
        public string Memo;

        //
        public System_DAL _systemDAL = new System_DAL();

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;
        //Tạo mới form theo kiểu True/False
        public Form_M0004_Detail(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0004_Detail(DataRow _mainDataRow, System_DAL systemDAL)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
            //
            _systemDAL = systemDAL;
        }
        //Load form
        private void Form_M0004_Detail_Load(object sender, EventArgs e)
        {
            //
            M0004_DAO = new M0004_DAO();
            M0002_DAO = new M0002_DAO();
            //
            sLookUpEdit_NameEN();
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
        //Điền dữ liệu cho ô NameEN
        private void sLookUpEdit_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M0002_Name_MMTB();
            if (tempTable.Rows.Count > 0)
            {
                sLook_NameEN.Properties.DataSource = tempTable;
                sLook_NameEN.Properties.ValueMember = "NameEN";
                sLook_NameEN.Properties.DisplayMember = "NameEN";
            }
        }
        //Lấy kết quả ô NameEN, điền dữ liệu tương ứng cho ô NameVN, NameJP
        private void SLook_NameEN_Validated(object sender, EventArgs e)
        {
            string tempNameEN = sLook_NameEN.Text.Trim();
            DataTable tempTable = new DataTable();

            if (IsNewValue && !String.IsNullOrEmpty(tempNameEN))
            {
                tempTable = M0004_DAO.GetInfo_Name(tempNameEN);

                if (tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        txt_NameVN.Text = row.Field<string>("NameVN");
                        txt_NameJP.Text = row.Field<string>("NameJP");
                    }
                }
            }
        }
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Control()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                NameEN = String.Empty;
                NameVN = String.Empty;
                NameJP = String.Empty;
                Maker = String.Empty;
                Model = String.Empty;
                inActive = false;
                Memo = String.Empty;
            }
            else
            {
                NameEN = Convert.ToString(dataRow[0]);
                NameVN = Convert.ToString(dataRow[1]);
                NameJP = Convert.ToString(dataRow[2]);
                Maker = Convert.ToString(dataRow[5]);
                Model = Convert.ToString(dataRow[6]);
                inActive = Convert.ToBoolean(dataRow[7]);
                Memo = Convert.ToString(dataRow[8]);
            }
        }
        //Kiểm soát key NameEN: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                sLook_NameEN.Enabled = true;
                txt_Maker.Enabled = true;
                txt_Model.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                sLook_NameEN.Enabled = false;
                txt_Maker.Enabled = false;
                txt_Model.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            sLook_NameEN.Text = NameEN;
            txt_NameVN.Text = NameVN;
            txt_NameJP.Text = NameJP;
            txt_Maker.Text = Maker;
            txt_Model.Text = Model;
            if (inActive)
            {
                cbx_InActive.SelectedIndex = 1;
            }
            else
            {
                cbx_InActive.SelectedIndex = 0;
            }
            txt_Memo.Text = Memo;
        }
        //Click nút New
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsNewValue = true;
            sLook_NameEN.Enabled = true;
            sLook_NameEN.Text = "";
            txt_NameVN.Text = "";
            txt_NameJP.Text = "";
            txt_Maker.Enabled = true;
            txt_Maker.Text = "";
            txt_Model.Enabled = true;
            txt_Model.Text = "";
            cbx_InActive.Enabled = true;
            cbx_InActive.SelectedIndex = 0;
            txt_Memo.Enabled = true;
            txt_Memo.Text = "";
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = sLook_NameEN.Text.Trim();
            string curr_NameVN = txt_NameVN.Text.Trim();
            string curr_NameJP = txt_NameJP.Text.Trim();
            string curr_Maker = txt_Maker.Text.Trim();
            string curr_Model = txt_Model.Text.Trim();
            int curr_InActive = cbx_InActive.SelectedIndex;
            string curr_Memo = txt_Memo.Text.Trim();
            //Trường hợp thêm mới
            if (IsNewValue)
            {
                if (String.IsNullOrEmpty(txt_Maker.Text.Trim()) || String.IsNullOrEmpty(txt_Model.Text.Trim()))
                {
                    var result = MessageBox.Show("Thiếu thông tin \"Maker/Model\"", "Chú ý", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        txt_Maker.Focus();
                    }
                    else
                    {
                        Message = "Bạn muốn thêm mới Tên: \"" + sLook_NameEN.Text.ToString() + ", Maker: " + txt_Maker.Text.Trim() + ", Model: " + txt_Model.Text.Trim() + "\"?";
                        if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            if (CheckError() == true)
                            {
                                if (M0004_DAO.Insert(curr_NameEN, curr_NameVN, curr_NameJP, curr_Maker, curr_Model, curr_InActive, curr_Memo, _systemDAL.userName))
                                {
                                    Message = "Lưu thành công Tên: \"" + sLook_NameEN.Text.ToString() + ", Maker: " + txt_Maker.Text.Trim() + ", Model: " + txt_Model.Text.Trim() + "\"!";
                                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }

            //Trường hợp sửa
            else
            {
                Message = "Bạn muốn cập nhật Tên: " + sLook_NameEN.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0004_DAO.Update(curr_NameEN, curr_Maker, curr_Model, curr_InActive, curr_Memo,_systemDAL.userName))
                        {
                            {
                                Message = "Cập nhật thành công Tên: \"" + sLook_NameEN.Text.ToString() + "\"!";
                                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
       
        //Click nút Reset
        private void BbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Control();
            sLook_NameEN.Focus();
        }
        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = sLook_NameEN.Text.Trim();
            string curr_Maker = txt_Maker.Text.Trim();
            string curr_Model = txt_Model.Text.Trim();
            Message = "Bạn muốn xóa Tên: " + sLook_NameEN.Text.ToString() + "?";
            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (M0004_DAO.Delete(curr_NameEN, curr_Maker, curr_Model))
                {
                    Message = "Xóa thành công Tên: \"" + sLook_NameEN.Text.ToString() + "\"!";
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(sLook_NameEN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_NameEN.Focus();
                return false;
            }
            if (IsNewValue)
            {
                DataTable _check = new DataTable();
                _check = M0004_DAO.GetInfo_M0004_Check(sLook_NameEN.Text.Trim(), txt_Maker.Text.Trim(), txt_Model.Text.Trim());
                if (_check.Rows.Count > 0)
                {
                    MessageBox.Show("Tên: " + sLook_NameEN.Text.ToString() + ", Maker: " + txt_Maker.Text.Trim() + ", Model: " + txt_Model.Text.Trim() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sLook_NameEN.Focus();
                    return false;
                }
            }
            return true;
        }
        //Cảnh báo khi nhập liệu thiếu Maker/Model
        private void Txt_Maker_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Maker.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Maker\"", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Model_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Model.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Model\"", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}