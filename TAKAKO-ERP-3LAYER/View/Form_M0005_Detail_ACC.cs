using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using MMTB.DAO;
using MMTB.DAL;
using System.Globalization;

namespace MMTB.View
{
    public partial class Form_M0005_Detail_ACC : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitDetailTable;
        public DataTable _DetailTable;
        public M0005_DAO M0005_DAO;
        public System_DAL _systemDAL = new System_DAL();
        public String DocNo = "";
        public Boolean InitValue = true;
        #endregion

        //Khởi tạo form
        public Form_M0005_Detail_ACC(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_ACC(String _docNo)
        {
            InitializeComponent();
            DocNo = _docNo;
        }
        //Load Form_M0005_Detail_ACC
        private void Form_M0005_Detail_ACC_Load(object sender, EventArgs e)
        {
            M0005_DAO = new M0005_DAO();

            _DetailTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();

            bsiUser.Caption = _systemDAL.userName.ToUpper();

            GetInfo_gridView();
        }

        //Dữ liệu trên Form_M0005_Detail_ACC
        private void Setting_Init_Control()
        {
            //Định nghĩa datatable gán cho gridview
        }
        //Giá trị khi khởi tạo form
        private void Setting_Init_Value()
        {
            Define_DetailTable();
        }
        //Load dữ liệu
        private void GetInfo_gridView()
        {
            try
            {
                _DetailTable = M0005_DAO.GetInfo_M0005();
                if (_DetailTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _DetailTable;
                    gridView.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xóa dữ liệu gridView
        private void Clear_Data()
        {
            gridControl.DataSource = _DetailTable;
        }
        //Hiển thị thông tin MMTB chưa thanh lý sau khi chọn lên gridView
        private void Define_DetailTable()
        {
            string _ACCcode = "";
            string _ACCDoc = "";
            string _ACCDoc_Disposal = "";
            string _invNo = "";
            DateTime _invDate = DateTime.Now;
            int _lifeTime = 0;
            DateTime _startDeprDate = DateTime.Now;
            DateTime _endDeprDate = DateTime.Now;

            //Set value to variables
            _ACCcode = Convert.ToString(gridView.GetFocusedRowCellValue("ACCcode"));
            _ACCDoc = Convert.ToString(gridView.GetFocusedRowCellValue("ACCDoc"));
            _ACCDoc_Disposal = Convert.ToString(gridView.GetFocusedRowCellValue("ACCDoc_Disposal"));
            _invNo = Convert.ToString(gridView.GetFocusedRowCellValue("InvNo"));
            _invDate = Convert.ToDateTime(gridView.GetFocusedRowCellValue("InvDate"));
            _lifeTime = Convert.ToInt32(gridView.GetFocusedRowCellValue("Lifetime"));
            _startDeprDate = Convert.ToDateTime(gridView.GetFocusedRowCellValue("StartDeprDate"));
            _endDeprDate = Convert.ToDateTime(gridView.GetFocusedRowCellValue("EndDeprDate"));

            //Set value to column ACCcode, NameEN, NameVN, Maker, Model...
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "ACCcode", _ACCcode);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "ACCDoc", _ACCDoc);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "ACCDoc_Disposal", _ACCDoc_Disposal);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "InvNo", _invNo);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "InvDate", _invDate);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Lifetime", _lifeTime);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "StartDeprDate", _startDeprDate);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "EndDeprDate", _endDeprDate);
        }

        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear_Data();
        }
        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Click nút Save
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonControl.Focus();
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Question
            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                try
                {
                    if (CheckError() == true)
                    {
                        Define_DetailTable();
                        if (M0005_DAO.ACC_Update_MMTB(_DetailTable))
                        {
                            MessageBox.Show("Đã lưu thành công thông tin ACC!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear_Data();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //Bật hiện các nút điều khiển
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbiSave.Enabled = IsEnable;
            bbiRefresh.Enabled = IsEnable;
            //GridView
            gridView.OptionsBehavior.Editable = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (bCheck_Confirm.Checked)
            {
                for (int rows = 0; rows < gridView.RowCount; rows++)
                {
                    DateTime _invDate;
                    _invDate = Convert.ToDateTime(gridView.GetRowCellValue(rows, gridView.Columns["InvDate"]));
                    if (_invDate == null)
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Ngày hóa đơn\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["InvDate"];
                        return false;
                    }
                }
            }
            return true;
        }
        //Hiển thị các MMTB nghiệm thu chờ bổ sung chứng từ thanh lý ACC
        private void BCheck_Confirm_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (bCheck_Confirm.Checked)
                {
                    gridControl.DataSource = _DetailTable.AsEnumerable()
                        .Where(row => row.Field<string>("ACCcode") == null 
                                   || row.Field<string>("ACCcode") == "").CopyToDataTable();
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
                }
                else
                {
                    gridControl.DataSource = _DetailTable;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
                }
            }
            catch
            {
                gridControl.DataSource = "";
            }
        }
        //Hiển thị các MMTB thanh lý chờ bổ sung chứng từ thanh lý ACC
        private void BCheck_Disposal_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (bCheck_Disposal.Checked)
                {
                    gridControl.DataSource = _DetailTable.AsEnumerable()
                        .Where(row => (row.Field<string>("ACCDoc_Disposal") == null
                                    && row.Field<string>("DocNo_Disposal")  != null)
                                    || (row.Field<string>("ACCDoc_Disposal") == ""
                                        && row.Field<string>("DocNo_Disposal")  != null)).CopyToDataTable();
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
                }
                else
                {
                    gridControl.DataSource = _DetailTable;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _DetailTable.Rows.Count + " records";
                }
            }
            catch
            {
                gridControl.DataSource = "";
            }
        }
        //Kiểm tra mã ACC bị trùng trên lưới
        bool IsDuplicatedRowFound(string _value, string column)
        {
            for (int rows = 0; rows < gridView.DataRowCount; rows++)
                if (rows != gridView.FocusedRowHandle)
                {
                    string _rowCodeValue = "";
                    string _rowFocusValue = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns[column]));
                    if (!String.IsNullOrEmpty(_rowFocusValue))
                    {
                        _rowCodeValue = (string)gridView.GetRowCellValue(rows, gridView.Columns[column]);
                        if (Equals(_value, _rowCodeValue))
                            return true;
                    }
                }
            return false;
        }
        //Kiểm tra mã ACC trùng khi nhập liệu
        private void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridView.FocusedColumn == gridCol_ACCCode)
            {
                string _code = (string)e.Value;
                e.Valid = !IsDuplicatedRowFound(_code, "ACCcode");
                if (!e.Valid)
                {
                    e.ErrorText = "Mã MMTB đã tồn tại trên lưới!";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_code))
                    {
                        DataTable _tempDataTable = M0005_DAO.Check_M0005_ACCcode(_code);
                        if (_tempDataTable.Rows.Count > 0)
                        {
                            e.Valid = false;
                            e.ErrorText = "Mã MMTB đã tồn tại trong cơ sở dữ liệu!";
                        }
                    }
                }
            }
        }
        //Tính lại ngày kết thúc khấu hao khi thay đổi ngày bắt đầu khấu hao
        private void repo_ItemDate_StartDerprDate_EditValueChanged(object sender, EventArgs e)
        {
            int lifetime = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "Lifetime"));
            DateTime endDerprDate = (sender as DevExpress.XtraEditors.DateEdit).DateTime.AddMonths(lifetime);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "EndDeprDate", endDerprDate);
        }
        //Tính lại ngày kết thúc khấu hao khi thay đổi Lifetime
        private void repo_TextEdit_Lifetime_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "Lifetime")) >= 36)
            {
                int lifetime = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "Lifetime"));
                DateTime _endDerprDate = Convert.ToDateTime(gridView.GetRowCellValue(gridView.FocusedRowHandle, "StartDeprDate")).AddMonths(lifetime);
                try
                {
                    //Điều chỉnh ngày hết khấu hao về đầu tháng
                    int _month = Convert.ToInt32(_endDerprDate.Month);
                    string _monthEnd = "";
                    if ( _month < 10)
                    {
                        _monthEnd = "0" + Convert.ToString(_month);
                    }
                    else
                    {
                        _monthEnd = Convert.ToString(_month);
                    }
                    string _end = "01" + _monthEnd + Convert.ToString(_endDerprDate.Year);
                    string format = "ddMMyyyy"; // define a date pattern according to your requirements  
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    DateTime _endDate = DateTime.Now.Date;
                    _endDate = DateTime.ParseExact(_end, format, provider);
                    //Chuyển ngày hết khấu hao lên gridView
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "EndDeprDate", _endDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Tính lại ngày kết thúc khấu hao khi thay đổi ngày bắt đầu khấu hao
        private void Repo_ItemDate_StartDerprDate_EditValueChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "Lifetime")) >= 36)
            {
                int lifetime = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "Lifetime"));
                DateTime _endDerprDate = Convert.ToDateTime(gridView.GetRowCellValue(gridView.FocusedRowHandle, "StartDeprDate")).AddMonths(lifetime);
                try
                {
                    //Điều chỉnh ngày hết khấu hao về đầu tháng
                    int _month = Convert.ToInt32(_endDerprDate.Month);
                    string _monthEnd = "";
                    if (_month < 10)
                    {
                        _monthEnd = "0" + Convert.ToString(_month);
                    }
                    else
                    {
                        _monthEnd = Convert.ToString(_month);
                    }
                    string _end = "01" + _monthEnd + Convert.ToString(_endDerprDate.Year);
                    string format = "ddMMyyyy"; // define a date pattern according to your requirements  
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    DateTime _endDate = DateTime.Now.Date;
                    _endDate = DateTime.ParseExact(_end, format, provider);
                    //Chuyển ngày hết khấu hao lên gridView
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "EndDeprDate", _endDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView.SetRowCellValue(e.RowHandle, "InputUser", _systemDAL.userName);
        }
    }
}