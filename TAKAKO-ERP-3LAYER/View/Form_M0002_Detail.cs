using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using TAKAKO_ERP_3LAYER.DAO;
using System.Collections.Generic;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0002_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0002_DAO M0002_DAO;
        private string nameEN;
        private string nameVN;
        private string nameJP;
        private string group1;
        private string group2;
        private string classifyID;
        private string classifyDesc;
        private DateTime applyDate;
        private Boolean inActive;

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;
        private const string LinhKien = "1";

        //Tạo mới form theo kiểu True/False
        public Form_M0002_Detail(Boolean _isNewValue)
        {
            //
            InitializeComponent();
            //
            IsNewValue = _isNewValue;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0002_Detail(DataRow _mainDataRow)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
        }

        //Load form
        private void Form_M0002_Detail_Load(object sender, EventArgs e)
        {
            //
            M0002_DAO = new M0002_DAO();
            //
            sLookUpEdit_NameEN();
            //
            sLookUpEdit_Group1();
            //
            sLookUpEdit_Group2();
            //
            LookUpEdit_Classify();
            //
            Initialization_Control();
            //
            Setting_Init_Control();
            //
            SetValue_Combobox(cbx_InActive);
            cbx_InActive.SelectedIndex = 0;
            //
            Update_Control();
        }
        //Tạo nội dung combo box cho user lựa chọn
        private void SetValue_Combobox(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("No"); //SelectIndex = 0
            Boolean.Add("Yes"); //SelectIndex = 1
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Lấy nội dung ô NameEN
        private void sLookUpEdit_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M0001_Name();
            if (tempTable.Rows.Count > 0)
            {
                sLook_NameEN.Properties.DataSource = tempTable;
                sLook_NameEN.Properties.ValueMember = "NameEN";
                sLook_NameEN.Properties.DisplayMember = "NameEN";
            }
        }
        //Lấy kết quả ô NameEN, điền dữ liệu tương ứng cho ô NameVN, NameJP
        private void sLook_NameEN_Validated(object sender, EventArgs e)
        {
            string tempNameEN = sLook_NameEN.Text.Trim();
            DataTable tempTable = new DataTable();
            if (IsNewValue && !String.IsNullOrEmpty(tempNameEN))
            {
                tempTable = M0002_DAO.GetInfo_Name(tempNameEN);

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
        //Điền dữ liệu cho ô Group1
        private void sLookUpEdit_Group1()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M0001_Group1();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Group1.Properties.DataSource = tempTable;
                sLook_Group1.Properties.ValueMember = "NameEN";
                sLook_Group1.Properties.DisplayMember = "NameEN";
            }
        }
        //Điền dữ liệu cho ô Group2
        private void sLookUpEdit_Group2()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M0001_Group2();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Group2.Properties.DataSource = tempTable;
                sLook_Group2.Properties.ValueMember = "NameEN";
                sLook_Group2.Properties.DisplayMember = "NameEN";
            }
        }
        //Lấy dữ liệu từ table M01_Classify LookUpEdit_Classify
        private void LookUpEdit_Classify()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M01_Classify();
            if (tempTable.Rows.Count > 0)
            {
                look_ClassifyID.Properties.DataSource = tempTable;
                look_ClassifyID.Properties.ValueMember = "ClassifyID";
                look_ClassifyID.Properties.DisplayMember = "ClassifyID";
            }
        }
        //Lấy kết quả ô ClassifyID điền vào ô txt_ClassifyDesc
        private void Look_ClassifyID_Validated(object sender, EventArgs e)
        {
            int ClassifyID = int.Parse(look_ClassifyID.Text.Trim());
            DataTable tempTable = new DataTable();
            if (ClassifyID > 0)
            {
                tempTable = M0002_DAO.GetInfo_M01_ClassifyD(ClassifyID);
                if (tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        txt_ClassifyDesc.Text = row.Field<string>("ClassifyDesc");
                    }
                }
            }
        }
       
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Control()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                nameEN = String.Empty;
                nameVN = String.Empty;
                nameJP = String.Empty;
                group1 = String.Empty;
                group2 = String.Empty;
                classifyID = "1";
                classifyDesc = "LK";
                applyDate = DateTime.Today;
                inActive = false;
            }
            else
            {
                nameEN = Convert.ToString(dataRow[0]);
                nameVN = Convert.ToString(dataRow[1]);
                nameJP = Convert.ToString(dataRow[2]);
                group1 = Convert.ToString(dataRow[3]);
                group2 = Convert.ToString(dataRow[4]);
                classifyID = Convert.ToString(dataRow[5]);
                classifyDesc = Convert.ToString(dataRow[6]);
                applyDate = Convert.ToDateTime(dataRow[7]);
                inActive = Convert.ToBoolean(dataRow[8]);
            }
        }

        //Kiểm soát key NameEN: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                sLook_NameEN.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                sLook_NameEN.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }

        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            sLook_NameEN.Text = nameEN;
            txt_NameVN.Text = nameVN;
            txt_NameJP.Text = nameJP;
            sLook_Group1.Text = group1;
            sLook_Group2.Text = group2;
            look_ClassifyID.EditValue = classifyID;
            txt_ClassifyDesc.Text = classifyDesc;
            date_ApplyDate.EditValue = applyDate;
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
            IsNewValue = true;
            sLook_NameEN.Enabled = true;
            sLook_NameEN.EditValue = "";
            txt_NameVN.Text = "";
            txt_NameJP.Text = "";
            sLook_Group1.EditValue = "";
            sLook_Group2.EditValue = "";
            look_ClassifyID.EditValue = "1";
            txt_ClassifyDesc.Text = "LK";
            date_ApplyDate.EditValue = DateTime.Today;
            cbx_InActive.Enabled = false;
            cbx_InActive.SelectedIndex = 0;
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = sLook_NameEN.Text.Trim();
            string curr_NameVN = txt_NameVN.Text.Trim();
            string curr_NameJP = txt_NameJP.Text.Trim();
            string curr_Group1 = sLook_Group1.Text.Trim();
            string curr_Group2 = sLook_Group2.Text.Trim();
            string curr_ClassifyID = look_ClassifyID.EditValue.ToString();
            string curr_ClassifyDesc = txt_ClassifyDesc.Text.Trim();
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            int curr_InActive = cbx_InActive.SelectedIndex;
            //Trường hợp thêm mới
            if (IsNewValue)
            {
                Message = "Bạn muốn thêm mới Tên: " + sLook_NameEN.Text.ToString() + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0002_DAO.Insert(curr_NameEN, curr_NameVN, curr_NameJP, curr_Group1, curr_Group2, curr_ClassifyID, curr_ClassifyDesc, curr_ApplyDate, curr_InActive, "IT"))
                        {
                            Message = "Lưu thành công Tên: \"" + sLook_NameEN.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (M0002_DAO.Update(curr_NameEN, curr_NameVN, curr_NameJP, curr_Group1, curr_Group2, curr_ClassifyID, curr_ClassifyDesc, curr_ApplyDate, curr_InActive, "IT"))
                        {
                            Message = "Cập nhật thành công Tên: \"" + sLook_NameEN.Text.ToString() + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        //Click nút Reset
        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Control();
        }
        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_NameEN = sLook_NameEN.Text.Trim();
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            Message = "Bạn muốn xóa Tên: " + sLook_NameEN.Text.ToString() + "?";
            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (M0002_DAO.Delete(curr_NameEN, curr_ApplyDate))
                {
                    Message = "Xóa thành công Tên: \"" + sLook_NameEN.Text.ToString() + "\"!";
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        //Click nút Close
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(sLook_NameEN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Anh)\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_NameEN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_NameVN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Việt)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameVN.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_NameJP.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Tên (t.Nhật)\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameJP.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_NameEN.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Nhóm trung\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameJP.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_Group2.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Nhóm đại\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NameJP.Focus();
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
                DataTable _check = M0002_DAO.GetInfo_M0002_Check(sLook_NameEN.Text.Trim(), sLook_Group1.Text.Trim(), sLook_Group2.Text.Trim(), look_ClassifyID.EditValue.ToString(), DateTime.Parse(date_ApplyDate.Text.Trim()));
                if (_check.Rows.Count > 0)
                {
                    MessageBox.Show("Tên: " + sLook_NameEN.Text.ToString() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sLook_NameEN.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
