using System;
using System.Collections.Generic;
using System.Data;
using TAKAKO_ERP_3LAYER.DAO;
using System.Windows.Forms;


namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005_NT_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0005_DAO M0005_DAO;
        public M0004_DAO M0004_DAO;
        public DataTable initTable;
        public Boolean inActive;
        public string Memo;

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = false;

        //Tạo mới form theo kiểu True/False
        public Form_M0005_NT_Detail(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_NT_Detail(DataRow _mainDataRow)
        {
            //
            InitializeComponent();
            //
            dataRow = _mainDataRow;
        }

        //Load form
        private void Form_M0005_NT_Detail_Load(object sender, EventArgs e)
        {
            //
            
            //
            M0004_DAO = new M0004_DAO();
            //
            M0005_DAO = new M0005_DAO();
            //
            Initialization_Value();
            //
            Initialization_Control();
            //
            Setting_Init_Control();
            //
            Update_Control();
        }

        private void define_initTable()
        {
            initTable = new DataTable();
            initTable.Columns.Add("Code");
            initTable.Columns.Add("ACCCode");
            initTable.Columns.Add("NameEN");
            initTable.Columns.Add("Maker");
            initTable.Columns.Add("Moder");
            initTable.Columns.Add("Series");
            initTable.Columns.Add("Nation");
            initTable.Columns.Add("Date_Manufacture", typeof(DateTime));
            initTable.Columns.Add("Longevity",typeof(Int32));
            initTable.Columns.Add("Stage");
            initTable.Columns.Add("Line_ID");
            initTable.Columns.Add("Group_Line_ACC");
            initTable.Columns.Add("Production_Dept");
            initTable.Columns.Add("Date_Depreciation", typeof(DateTime));
            initTable.Columns.Add("End_Date_Depreciation", typeof(DateTime));
            initTable.Columns.Add("Status", typeof(Boolean));
            initTable.Columns.Add("Results");
            initTable.Columns.Add("Note");
            initTable.Columns.Add("Guide");
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
            tempTable = M0004_DAO.GetInfo_M0001_Name();
            if (tempTable.Rows.Count > 0)
            {
                sLookEdit_NameEN.Properties.DataSource = tempTable;
                sLookEdit_NameEN.Properties.ValueMember = "NameEN";
                sLookEdit_NameEN.Properties.DisplayMember = "NameEN";
            }
        }

        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Value()
        {
            if (IsNewValue) //Nếu IsNewValue = true
            {
                //NameEN = String.Empty;
                //NameVN = String.Empty;
                //NameJP = String.Empty;
                //Maker = String.Empty;
                //Model = String.Empty;
                inActive = false;
                Memo = String.Empty;
            }
            else
            {
                //NameEN = Convert.ToString(dataRow[0]);
                //NameVN = Convert.ToString(dataRow[1]);
                //NameJP = Convert.ToString(dataRow[2]);
                //Maker = Convert.ToString(dataRow[5]);
                //Model = Convert.ToString(dataRow[6]);
                inActive = Convert.ToBoolean(dataRow[7]);
                Memo = Convert.ToString(dataRow[8]);
            }
        }

        //
        private void Initialization_Control()
        {
            sLookUpEdit_NameEN();
        }

        //Kiểm soát key NameEN: cho thêm mới hoặc không được chỉnh sửa nếu trường hợp là Edit/Delete
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                //sLook_Code.Enabled = true;
                txt_Maker.Enabled = true;
                txt_Model.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                //sLook_Code.Enabled = false;
                txt_Maker.Enabled = false;
                txt_Model.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }

        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            //sLook_Code.Text = NameEN;
            //txt_ACCCode.Text = NameVN;
            //txt_NameJP.Text = NameJP;
            //txt_Maker.Text = Maker;
            //txt_Model.Text = Model;
            //if (inActive)
            //{
            //    cbx_InActive.SelectedIndex = 1;
            //}
            //else
            //{
            //    cbx_InActive.SelectedIndex = 0;
            //}
            //txt_Memo.Text = Memo;
        }

        //Click nút New
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //IsNewValue = true;
            //sLook_Code.Enabled = true;
            //sLook_Code.Text = "";
            //txt_ACCCode.Text = "";
            //txt_NameJP.Text = "";
            //txt_Maker.Enabled = true;
            //txt_Maker.Text = "";
            //txt_Model.Enabled = true;
            //txt_Model.Text = "";
            //cbx_InActive.Enabled = true;
            //cbx_InActive.SelectedIndex = 0;
            //txt_Memo.Enabled = true;
            //txt_Memo.Text = "";
        }

        //Click nút Save
        private void BbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string Message = "";
            //string curr_NameEN = sLook_Code.Text.Trim();
            //string curr_NameVN = txt_ACCCode.Text.Trim();
            //string curr_NameJP = txt_NameJP.Text.Trim();
            //string curr_Maker = txt_Maker.Text.Trim();
            //string curr_Model = txt_Model.Text.Trim();
            //int curr_InActive = cbx_InActive.SelectedIndex;
            //string curr_Memo = txt_Memo.Text.Trim();
            ////Trường hợp thêm mới
            //if (IsNewValue)
            //{
            //    if (String.IsNullOrEmpty(txt_Maker.Text.Trim()) || String.IsNullOrEmpty(txt_Model.Text.Trim()))
            //    {
            //        var result = MessageBox.Show("Thiếu thông tin \"Maker/Model\"", "Chú ý", MessageBoxButtons.OKCancel);
            //        if (result == DialogResult.Cancel)
            //        {
            //            txt_Maker.Focus();
            //        }
            //        else
            //        {
            //            Message = "Bạn muốn thêm mới Tên: \"" + sLook_Code.Text.ToString() + ", Maker: " + txt_Maker.Text.Trim() + ", Model: " + txt_Model.Text.Trim() + "\"?";
            //            if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            //                , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            //            {
            //                if (CheckError() == true)
            //                {
            //                    if (M0004_DAO.Insert(curr_NameEN, curr_NameVN, curr_NameJP, curr_Maker, curr_Model, curr_InActive, curr_Memo, "IT"))
            //                    {
            //                        Message = "Lưu thành công Tên: \"" + sLook_Code.Text.ToString() + ", Maker: " + txt_Maker.Text.Trim() + ", Model: " + txt_Model.Text.Trim() + "\"!";
            //                        MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            ////Trường hợp sửa
            //else
            //{
            //    Message = "Bạn muốn cập nhật Tên: " + sLook_Code.Text.ToString() + "?";
            //    if ((MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            //        , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            //    {
            //        if (CheckError() == true)
            //        {
            //            if (M0004_DAO.Update(curr_NameEN, curr_Maker, curr_Model, curr_InActive, curr_Memo, "IT"))
            //            {
            //                {
            //                    Message = "Cập nhật thành công Tên: \"" + sLook_Code.Text.ToString() + "\"!";
            //                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //        }
            //    }
            //}
        }
       
        //Click nút Reset
        private void BbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Control();
            txt_Code.Focus();
        }

        //Click nút Delete
        private void BbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        //Check lỗi
        public Boolean CheckError()
        {
            if (String.IsNullOrEmpty(txt_Code.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Mã MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Code.Focus();
                return false;
            }
            return true;
        }

        private void textEdit_Code_Leave(object sender, EventArgs e)
        {
            if (IsNewValue)
            {
                string code = txt_Code.Text.Trim();
                DataTable tempTable = new DataTable();
                tempTable = M0005_DAO.GetInfo_M0005_Check(code);
                if (tempTable.Rows.Count > 0)
                {
                    MessageBox.Show("Mã MMTB đã tồn tại", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Code.Focus();
                }
            }
        }
    }
}