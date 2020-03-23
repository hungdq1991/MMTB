using System;
using System.Collections.Generic;
using System.Data;
using TAKAKO_ERP_3LAYER.DAO;
using System.Windows.Forms;


namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005_NT_Detail_Cancel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataRow dataRow;
        public M0005_DAO M0005_DAO;
        public M0004_DAO M0004_DAO;
        public DataTable initTable;

        //Tạo biến để ghi nhận New / Edit
        private Boolean IsNewValue = true;
        //
        public Form_M0005_NT_Detail_Cancel()
        {
            InitializeComponent();
        }

        //Tạo mới form theo kiểu True/False
        public Form_M0005_NT_Detail_Cancel(Boolean _isNewValue)
        {
            InitializeComponent();
            IsNewValue = _isNewValue;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_NT_Detail_Cancel(DataRow _mainDataRow)
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
            Initialization_Control();
            //
            Initialization_Value();
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
            initTable.Columns.Add("Progress_Group");
            initTable.Columns.Add("Line_ID");
            initTable.Columns.Add("Group_Line_ACC");
            initTable.Columns.Add("Production_Dept");
            initTable.Columns.Add("Start_Date_Depreciation", typeof(DateTime));
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

        #region Add data to control
        //Điền dữ liệu cho ô NameEN
        private void sLookUpEdit_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_Maker();
            if (tempTable.Rows.Count > 0)
            {
                sLookEdit_NameEN.Properties.DataSource = tempTable;
                sLookEdit_NameEN.Properties.ValueMember = "NameEN";
                sLookEdit_NameEN.Properties.DisplayMember = "NameEN";
            }
        }
        //Điền dữ liệu cho ô Quốc gia (xuất xứ)
        private void sLookUpEdit_Nation()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_NationMF();
            if (tempTable.Rows.Count > 0)
            {
                sLookEdit_Nation.Properties.DataSource = tempTable;
                sLookEdit_Nation.Properties.ValueMember = "NATION_CODE";
                sLookEdit_Nation.Properties.DisplayMember = "NATION_NAME";
            }
        }
        private void sLookUpEdit_ProgressGroup()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_ProgressGroup();
            if (tempTable.Rows.Count > 0)
            {
                sLookEdit_ProgressGroup.Properties.DataSource = tempTable;
                sLookEdit_ProgressGroup.Properties.ValueMember = "ProcessGroup";
                sLookEdit_ProgressGroup.Properties.DisplayMember = "ProcessEN";
            }
        }
        private void AddValue_CBox_NT()
        {
            cBox_Result.Properties.Items.Add("OK");
            cBox_Result.Properties.Items.Add("NG");
        }

        private void AddValue_CBox_Status()
        {
            cBox_Status.Properties.Items.Add("Mới");
            cBox_Status.Properties.Items.Add("Cũ");
        }
        #endregion

        //Event
        //Tạo form trong điều kiện thêm mới hoặc sửa/xóa
        private void Initialization_Value()
        {
            DataRow dr = initTable.NewRow();
            if (IsNewValue) //Nếu IsNewValue = true
            {

            }
            else
            {
                dr["Code"] = Convert.ToString(dataRow[0]);
                dr["ACCCode"] = Convert.ToString(dataRow[1]);
                dr["NameEN"] = Convert.ToString(dataRow[2]);
                dr["Maker"] = Convert.ToString(dataRow[3]);
                dr["Moder"] = Convert.ToString(dataRow[4]);
                dr["Series"] = Convert.ToString(dataRow[5]);
                dr["Nation"] = Convert.ToString(dataRow[6]);
                dr["Date_Manufacture"] = Convert.ToDateTime(dataRow[7]);
                dr["Longevity"] = Convert.ToInt32(dataRow[8]);
                dr["Progress_Group"] = Convert.ToString(dataRow[9]);
                dr["Line_ID"] = Convert.ToString(dataRow[10]);
                dr["Group_Line_ACC"] = Convert.ToString(dataRow[11]);
                dr["Production_Dept"] = Convert.ToString(dataRow[12]);
                dr["Start_Date_Depreciation"] = Convert.ToString(dataRow[13]);
                dr["End_Date_Depreciation"] = Convert.ToString(dataRow[14]);
                dr["Status"] = Convert.ToInt32(dataRow[15]);
                dr["Results"] = Convert.ToString(dataRow[16]);
                dr["Note"] = Convert.ToString(dataRow[17]);
                dr["Guide"] = Convert.ToString(dataRow[18]);
            }
            initTable.Rows.Add(dataRow);
        }

        private void Initialization_Control()
        {
            AddValue_CBox_NT();

            AddValue_CBox_Status();

            define_initTable();

            sLookUpEdit_NameEN();

            sLookUpEdit_Nation();

            sLookUpEdit_ProgressGroup();
        }

        //Kiểm soát cho thêm mới, chỉnh sửa hoặc không được chỉnh sửa
        private void Setting_Init_Control()
        {
            if (IsNewValue)
            {
                cBox_Result.SelectedIndex = 0;
                cBox_Status.SelectedIndex = 0;
                txt_Maker.Enabled = true;
                txt_Model.Enabled = true;
                bbiDelete.Enabled = false;
            }
            else
            {
                txt_Maker.Enabled = false; 
                txt_Model.Enabled = false;
                bbiDelete.Enabled = true;
            }
        }
        //Lấy dữ liệu trên form
        private void Update_Control()
        {
            foreach (DataRow dr in initTable.Rows)
            {
                txt_Code.EditValue = Convert.ToString(dr["Code"]);
                txt_ACCCode.EditValue = Convert.ToString(dr["ACCCode"]);
                sLookEdit_NameEN.EditValue = Convert.ToString(dr["NameEN"]);
                txt_Maker.EditValue = Convert.ToString(dr["Maker"]);
                txt_Model.EditValue = Convert.ToString(dr["Moder"]);
                txt_Series.EditValue = Convert.ToString(dr["Series"]);
                sLookEdit_Nation.EditValue = Convert.ToString(dr["Nation"]);
                date_Manufacture.EditValue = Convert.ToDateTime(dr["Date_Manufacture"]);
                txt_Longevity.EditValue = Convert.ToInt32(dr["Longevity"]);
                sLookEdit_ProgressGroup.EditValue = Convert.ToString(dr["Progress_Group"]);
                sLookEdit_Line.EditValue = Convert.ToString(dr["Line_ID"]);
                txt_GroupLineACC.EditValue = Convert.ToString(dr["Group_Line_ACC"]);
                txt_Production_Dept.EditValue = Convert.ToString(dr["Production_Dept"]);
                dateEdit_StartDepreciation.EditValue = Convert.ToDateTime(dr["Start_Date_Depreciation"]);
                dateEdit_EndDepreciation.EditValue = Convert.ToDateTime(dr["End_Date_Depreciation"]);
                cBox_Status.SelectedText = Convert.ToString(dr["Status"]);
                cBox_Result.SelectedText = Convert.ToString(dr["Results"]);
                cBox_Status.SelectedText = Convert.ToString(dr["Status"]);
                cBox_Status.SelectedText = Convert.ToString(dr["Status"]);
                txt_Note.EditValue = Convert.ToString(dr["Note"]);
                txt_Guide.EditValue = Convert.ToString(dr["Guide"]);
            }
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