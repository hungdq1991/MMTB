using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.DAL;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0003_ProcessGroup_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0003_ProcessGroup_DAO M0003_ProcessGroup_DAO;
        public string ProcessGroup;
        public string ProcessEN;
        public string ProcessVN;
        public string ProcessJP;
        public int Point;
        public DateTime applyDate;
        public Boolean inActive;
        public string Memo;

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;

        //
        public System_DAL _systemDAL = new System_DAL();

        //Tạo mới form theo kiểu True/False
        public Form_M0003_ProcessGroup_Detail(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0003_ProcessGroup_Detail(DataRow _mainDataRow, System_DAL systemDAL)
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
            M0003_ProcessGroup_DAO = new M0003_ProcessGroup_DAO();
            //
            sLookUpEdit_Process();
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
        //Điền dữ liệu cho ô ProcessGroup
        private void sLookUpEdit_Process()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0003_ProcessGroup_DAO.GetInfo_M0003_Process();
            if (tempTable.Rows.Count > 0)
            {
                sLook_ProcessGroup.Properties.DataSource = tempTable;
                sLook_ProcessGroup.Properties.ValueMember = "PROCESS_CODE";
                sLook_ProcessGroup.Properties.DisplayMember = "PROCESS_CODE";
            }
        }
        //Lấy kết quả ô ProcessGroup, điền dữ liệu tương ứng cho ô ProcessEN, ProcessVN, ProcessJP
        private void SLook_ProcessGroup_Validated(object sender, EventArgs e)
        {
            string tempProcess = sLook_ProcessGroup.Text.Trim();
            DataTable tempTable = new DataTable();

            if (IsNewValue && !String.IsNullOrEmpty(tempProcess))
            {
                tempTable = M0003_ProcessGroup_DAO.GetInfo_M0003_ProcessGroup(tempProcess);

                if (tempTable.Rows.Count > 0)
                {
                    foreach (DataRow row in tempTable.Rows)
                    {
                        txt_ProcessEN.Text = row.Field<string>("PROCESS_NAME");
                        txt_ProcessVN.Text = row.Field<string>("PROCESS_NAME_V");
                        txt_ProcessJP.Text = row.Field<string>("PROCESS_NAME_J");
                    }
                }
            }
        }
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Control()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                ProcessGroup = String.Empty;
                ProcessEN = String.Empty;
                ProcessVN = String.Empty;
                ProcessJP = String.Empty;
                Point = 0;
                applyDate = DateTime.Today;
                inActive = false;
                Memo = String.Empty;
            }
            else
            {
                ProcessGroup = Convert.ToString(dataRow[0]);
                ProcessEN = Convert.ToString(dataRow[1]);
                ProcessVN = Convert.ToString(dataRow[2]);
                ProcessJP = Convert.ToString(dataRow[3]);
                Point = Convert.ToInt32(dataRow[4]);
                applyDate = Convert.ToDateTime(dataRow[5]);
                inActive = Convert.ToBoolean(dataRow[6]);
                Memo = Convert.ToString(dataRow[7]);
            }
        }
        //Kiểm soát key ProcessGroup: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                sLook_ProcessGroup.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                sLook_ProcessGroup.Enabled = false;
                txt_Point.Enabled = false;
                date_ApplyDate.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            sLook_ProcessGroup.Text = ProcessGroup;
            txt_ProcessEN.EditValue = ProcessEN;
            txt_ProcessVN.Text = ProcessVN;
            txt_ProcessJP.Text = ProcessJP;
            txt_Point.Text = Point.ToString();
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
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsNewValue = true;
            sLook_ProcessGroup.Enabled = true;
            sLook_ProcessGroup.Text = "";
            txt_ProcessEN.Text = "";
            txt_ProcessVN.Text = "";
            txt_ProcessJP.Text = "";
            txt_Point.Text = "0";
            date_ApplyDate.Enabled = true;
            date_ApplyDate.EditValue = DateTime.Today;
            txt_Memo.Enabled = true;
            txt_Memo.Text = "";
            cbx_InActive.Enabled = true;
            cbx_InActive.SelectedIndex = 0;
        }
        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_ProcessGroup = sLook_ProcessGroup.Text.Trim();
            string curr_ProcessEN = txt_ProcessEN.Text.Trim();
            string curr_ProcessVN = txt_ProcessVN.Text.Trim();
            string curr_ProcessJP = txt_ProcessJP.Text.Trim();
            int curr_Point = Int32.Parse(txt_Point.Text.Trim());
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            int curr_InActive = cbx_InActive.SelectedIndex;
            string curr_Memo = txt_Memo.Text.Trim();

            //Trường hợp thêm mới
            if (IsNewValue)
            {
                Message = "Bạn muốn thêm mới Công đoạn: " + curr_ProcessGroup + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0003_ProcessGroup_DAO.Insert(curr_ProcessGroup
                                                        , curr_ProcessEN
                                                        , curr_ProcessVN
                                                        , curr_ProcessJP
                                                        , curr_Point
                                                        , curr_ApplyDate
                                                        , curr_InActive
                                                        , curr_Memo
                                                        , _systemDAL.userName))
                        {
                            Message = "Lưu thành công Công đoạn: \"" + curr_ProcessGroup + "\"!";
                            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            //Trường hợp sửa
            else
            {
                Message = "Bạn muốn cập nhật Công đoạn: " + curr_ProcessGroup + "?";
                if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (CheckError() == true)
                    {
                        if (M0003_ProcessGroup_DAO.Update(curr_ProcessGroup
                                                        , curr_ProcessEN
                                                        , curr_ProcessVN
                                                        , curr_ProcessJP
                                                        , curr_ApplyDate
                                                        , curr_InActive
                                                        , curr_Memo
                                                        , _systemDAL.userName))
                        {
                            {
                                Message = "Cập nhật thành công Công đoạn: \"" + curr_ProcessGroup + "\"!";
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
            sLook_ProcessGroup.Focus();
        }
        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Message = "";
            string curr_ProcessGroup = sLook_ProcessGroup.Text.Trim();
            DateTime curr_ApplyDate = DateTime.Parse(date_ApplyDate.Text.Trim());
            Message = "Bạn muốn xóa Công đoạn: " + curr_ProcessGroup + "?";
            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (M0003_ProcessGroup_DAO.Delete(curr_ProcessGroup, curr_ApplyDate))
                {
                    Message = "Xóa thành công Công đoạn: \"" + curr_ProcessGroup + "\"!";
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
            if (String.IsNullOrEmpty(sLook_ProcessGroup.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Công đoạn\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ProcessGroup.Focus();
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
                DataTable _check = new DataTable();
                _check = M0003_ProcessGroup_DAO.GetInfo_M0003_Check(sLook_ProcessGroup.Text.Trim(),  DateTime.Parse(date_ApplyDate.Text.Trim()));
                if (_check.Rows.Count > 0)
                {
                    MessageBox.Show("Công đoạn: " + sLook_ProcessGroup.Text.ToString() + " đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sLook_ProcessGroup.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}