using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.Report;
using DevExpress.XtraReports.UI;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005_Detail_NoUsed : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        public M0005_DAO M0005_DAO;
        public String DocNo = "";
        public Boolean InitValue = true;
        #endregion
        //Khởi tạo form
        public Form_M0005_Detail_NoUsed()
        {
            InitializeComponent();
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_NoUsed(String _docNo)
        {
            InitializeComponent();
            DocNo = _docNo;
        }
        //Load Form_M0005_Detail_NoUsed
        private void Form_M0005_Detail_NoUsed_Load(object sender, EventArgs e)
        {
            M0005_DAO = new M0005_DAO();

            _HeaderTable = new DataTable();
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();

            Setting_Init_Control();
            Setting_Init_Value();
        }

        //Dữ liệu trên Form_M0005_Detail_NoUsed
        private void Setting_Init_Control()
        {
            //Định nghĩa datatable gán cho header
            Define_HeaderTable();

            //Định nghĩa datatable gán cho gridview
            Define_DetailTable();
            Define_DeleteRowTable();

            AddValue_CBox_Status(cbx_Status);

            Add_Value_sLookUp_DocNo();

            AddValue_sLook_ControlDept();

            AddValue_repo_sLookUp_Plan();

            AddValue_repo_sLookUp_Reason();
        }
        //Giá trị khi khởi tạo form
        private void Setting_Init_Value()
        {
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            }
            else
            {
                sLook_DocNo.EditValue = DocNo;
            }
        }
        //Thêm thông tin combo box
        private void AddValue_CBox_Status(ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Chuẩn bị");
            Boolean.Add("Xác nhận");
            comboBox.Properties.Items.AddRange(Boolean);
        }
        //Thông tin cho repo_sLookUp_Plan
        private void AddValue_repo_sLookUp_Plan()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Kế hoạch", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 1;
            dtRow["Kế hoạch"] = "Bảo quản";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 2;
            dtRow1["Kế hoạch"] = "Hủy bỏ";
            _ResultTable.Rows.Add(dtRow1);

            repo_sLookUp_Plan.DataSource = _ResultTable;
            repo_sLookUp_Plan.ValueMember = "STT";
            repo_sLookUp_Plan.DisplayMember = "Kế hoạch";
        }
        //Thông tin cho repo_sLookUp_Reason
        private void AddValue_repo_sLookUp_Reason()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Lý do", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 1;
            dtRow["Lý do"] = "Hư hỏng";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 2;
            dtRow1["Lý do"] = "Không có KH";
            _ResultTable.Rows.Add(dtRow1);

            repo_sLookUp_Reason.DataSource = _ResultTable;
            repo_sLookUp_Reason.ValueMember = "STT";
            repo_sLookUp_Reason.DisplayMember = "Lý do";
        }
        //Thêm cột header
        private void Define_HeaderTable()
        {
            //Các cột theo bảng M0005_ListMMTB_Doc4
            _HeaderTable = new DataTable();
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("FromDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ToDate", typeof(DateTime));
            _HeaderTable.Columns.Add("DocStatus", typeof(int));
            _HeaderTable.Columns.Add("ControlDept", typeof(string));
        }
        //Điền dữ liệu cho header
        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            date_From.EditValue = _tempTable.Rows[0].Field<DateTime>("FromDate");
            date_To.EditValue = _tempTable.Rows[0].Field<DateTime>("ToDate");
            if (_tempTable.Rows[0].Field<Boolean>("DocStatus"))
            {
                cbx_Status.SelectedIndex = 1;
                Set_Enable_Control(false);
            }
            else
            {
                cbx_Status.SelectedIndex = 0;
                Set_Enable_Control(true);
            }
            sLook_ControlDept.EditValue = _tempTable.Rows[0].Field<string>("ControlDept");
        }
       //Giá trị bảng Header
        private DataTable GetValue_Header()
        {
            DataTable _tempTable = new DataTable();
            _tempTable = _HeaderTable.Clone();

            DataRow dtRow = _tempTable.NewRow();
            dtRow["DocNo"] = sLook_DocNo.EditValue;
            dtRow["DocDate"] = date_Doc.EditValue;
            dtRow["FromDate"] = date_From.EditValue;
            dtRow["ToDate"] = date_To.EditValue;
            dtRow["DocStatus"] = cbx_Status.SelectedIndex;
            dtRow["ControlDept"] = sLook_ControlDept.EditValue;

            _tempTable.Rows.Add(dtRow);

            return _tempTable;
        }
        //Định nghĩa cấu trúc datatable gán cho grid control
        private void Define_DetailTable()
        {
            //Các cột theo bảng M0005_ListMMTB và M0005_ListMMTBLine
            _DetailTable.Columns.Add("Code", typeof(string));
            _DetailTable.Columns.Add("ACCcode", typeof(string));
            _DetailTable.Columns.Add("NameEN", typeof(string));
            _DetailTable.Columns.Add("NameVN", typeof(string));
            _DetailTable.Columns.Add("NameJP", typeof(string));
            _DetailTable.Columns.Add("Maker", typeof(string));
            _DetailTable.Columns.Add("Model", typeof(string));
            _DetailTable.Columns.Add("Series", typeof(string));
            _DetailTable.Columns.Add("OrgCountry", typeof(string));
            _DetailTable.Columns.Add("ProDate", typeof(DateTime));
            _DetailTable.Columns.Add("Lifetime", typeof(Decimal));
            _DetailTable.Columns.Add("NetValue", typeof(int));
            _DetailTable.Columns.Add("StartDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("EndDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("Reason", typeof(string));
            _DetailTable.Columns.Add("CurStatus", typeof(string));
            _DetailTable.Columns.Add("CurPlan", typeof(string));
            _DetailTable.Columns.Add("Solve", typeof(string));
        }
        //Xóa dòng trên gridView
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("Code", typeof(string));
        }
        #region Add data to control
        //Điền dữ liệu bộ phận
        private void AddValue_sLook_ControlDept()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_ControlDept();
            if (tempTable.Rows.Count > 0)
            {
                sLook_ControlDept.Properties.DataSource = tempTable;
                sLook_ControlDept.Properties.ValueMember = "SectionID";
                sLook_ControlDept.Properties.DisplayMember = "SectionID";
            }
        }
        //Điền dữ liệu cho ô Số chứng từ
        private void Add_Value_sLookUp_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_M0005_Doc_NoUsed();
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
        #endregion

        #region event
        //Lấy số chứng từ, điền thông tin vào Form_M0005_Detail_NoUsed 
        private void SLook_DocNo_TextChanged(object sender, EventArgs e)
        {
            string _docNo = "";
            int _status;
            if (sLook_DocNo.EditValue != null)
            { 
                _docNo = sLook_DocNo.EditValue.ToString();
            }
            try
            {
                if (!string.IsNullOrEmpty(_docNo))
                {
                    _HeaderTable.Clear();
                    _HeaderTable = M0005_DAO.GetInfo_M0005_NoUsed_Header(_docNo);
                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                        _status = cbx_Status.SelectedIndex;
                        if (_status == 0)
                        {
                            Set_Enable_Control(true);
                        }
                        if (_status == 1)
                        {
                            Set_Enable_Control(false);
                        }
                        _DetailTable.Clear();
                        _DetailTable = M0005_DAO.GetInfo_M0005_NoUsed_Detail(_docNo);
                    }
                    if (_DetailTable.Rows.Count > 0)
                    {
                        gridControl.DataSource = _DetailTable;
                        bsiRecordsCount.Caption = "Records: " + _DetailTable.Rows.Count;
                    }
                    if (InitValue)
                    {
                        _InitHeaderTable = _HeaderTable.Copy();
                        _InitDetailTable = _DetailTable.Copy();
                        InitValue = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xóa dữ liệu header & gridView
        private void Clear_Data()
        {
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            date_From.EditValue = DateTime.Now;
            date_To.EditValue = DateTime.Now;
            sLook_ControlDept.EditValue = null;
            cbx_Status.SelectedIndex = 0;

            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;

            sLook_DocNo.Focus();
        }
        //Click nút tạo mới
        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataTable _tempTable = M0005_DAO.GetInfo_M0005_Doc_NoUsed_Pre();
            if (_tempTable.Rows.Count > 0)
            {
                MessageBox.Show("Có chứng từ chưa được xác nhận, vui lòng hoàn thành chứng từ!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                Set_Enable_Control(true);
                InitValue = true;
                Clear_Data();
            }
        }
        //Click nút Load thông tin
        private void BbiLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn load thông tin MMTB không sử dụng?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DataTable _tempTable1 = M0005_DAO.GetInfo_M0005_Doc_NoUsed_Pre();
                if (_tempTable1.Rows.Count > 0 && sLook_DocNo.EditValue == null)
                {
                    MessageBox.Show("Có chứng từ chưa được xác nhận, vui lòng hoàn thành chứng từ!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (sLook_DocNo.EditValue == null)
                    {
                        Set_Enable_Control(true);
                        InitValue = true;
                        Clear_Data();
                        DataTable _tempTable = M0005_DAO.GetInfo_M0005_NoUsed();
                        gridControl.DataSource = _tempTable;
                    }
                    else
                    {
                        DataTable _tempTable = M0005_DAO.GetInfo_M0005_NoUsed();
                        gridControl.DataSource = _tempTable;
                    }
                }
            }
        }
        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DocNo = sLook_DocNo.Text;
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            }
            else
            {
                SLook_DocNo_TextChanged(sender, e);
            }
        }

        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        //Click chuột phải chọn Delete row
        private void bbi_PopUp_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["Code"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Code");
            _DeleteRowTable.Rows.Add(dtrow);

            //
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Click nút Delete row
        private void Bbi_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["Code"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Code");
            _DeleteRowTable.Rows.Add(dtrow);

            //
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Click chuột phải chọn Add new row
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        //Click nút Add new row
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }
        //Click nút Save
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            sLook_DocNo.Focus(); //Ghi nhận dữ liệu đã hoàn thành dưới gridView
            if ((MessageBox.Show("Bạn muốn lưu dữ liệu?", "Xác nhận"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Question
            , MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (CheckError() == true)
                {
                    try
                    {
                        string DocNo = "";
                        _DetailTable = gridView.GridControl.DataSource as DataTable;
                        DocNo = M0005_DAO.Update_MMTB_No_Used(_DetailTable, _DeleteRowTable, GetValue_Header());

                        if (!String.IsNullOrEmpty(DocNo))
                        {
                            MessageBox.Show("Thêm mới/Cập nhật thành công DocNo: " + DocNo.PadLeft(6, '0')
                                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear_Data();
                            Add_Value_sLookUp_DocNo();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
        //Cài đặt hiệu lực các nút nhấn 
        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbiSave.Enabled = IsEnable;
            bbi_AddNewRow.Enabled = IsEnable;
            bbi_DeleteRow.Enabled = IsEnable;
            //PopUp
            bbi_PopUp_AddNewRow.Enabled = IsEnable;
            bbi_PopUp_DeleteRow.Enabled = IsEnable;
            //Header
            date_Doc.Enabled = IsEnable;
            date_From.Enabled = IsEnable;
            date_To.Enabled = IsEnable;
            sLook_ControlDept.Enabled = IsEnable;
            cbx_Status.Enabled = IsEnable;
            //GridView
            gridView.OptionsBehavior.Editable = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Append.Visible = IsEnable;
            gridControl.EmbeddedNavigator.Buttons.Remove.Visible = IsEnable;
        }

        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            //Thông tin bộ phận phụ trách
            if (String.IsNullOrEmpty(Convert.ToString(sLook_ControlDept.EditValue)))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_ControlDept.Focus();
                return false;
            }
            //Nhập liệu cột Hiện trạng MMTB 
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _status;
                _status = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["CurStatus"]));
                if (String.IsNullOrEmpty(_status))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Hiện trạng MMTB\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView.Focus();
                    gridView.FocusedRowHandle = rows;
                    gridView.FocusedColumn = gridView.Columns["CurStatus"];
                    return false;
                }
            }
            //Nhập liệu cột Kế hoạch        
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _plan;
                _plan = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["CurPlan"]));
                if (String.IsNullOrEmpty(_plan))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Kế hoạch\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView.Focus();
                    gridView.FocusedRowHandle = rows;
                    gridView.FocusedColumn = gridView.Columns["CurPlan"];
                    return false;
                }
            }
            //Nhập liệu cột Phương án xử lý
            for (int rows = 0; rows < gridView.RowCount; rows++)
            {
                string _solve;
                _solve = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Solve"]));
                if (String.IsNullOrEmpty(_solve))
                {
                    MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Phương án xử lý\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView.Focus();
                    gridView.FocusedRowHandle = rows;
                    gridView.FocusedColumn = gridView.Columns["Solve"];
                    return false;
                }
            }
            //Không cho nhập ngày bắt đầu từ tháng trước
            if (date_From.DateTime.Month < DateTime.Now.Month)
            {
                MessageBox.Show("Xem lại ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_From.Focus();
                return false;
            }
            //Không cho nhập ngày bắt đầu (from) > ngày kết thúc (to)
            if (date_From.DateTime > date_To.DateTime)
            {
                MessageBox.Show("Xem lại ngày bắt đầu/ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_From.Focus();
                return false;
            }
            return true;
        }
        #region event Gridview - hiển thị pop up
        private void gridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var currentRow = gridView.FocusedRowHandle;
            var focusRowView = (DataRowView)gridView.GetFocusedRow();

            if (focusRowView == null || focusRowView.IsNew) return;

            if (currentRow >= 0)
            {
                popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
            }
            else
            {
                popupMenu1.HidePopup();
            }
        }
        #endregion
        //Xuất báo cáo MMTB không sử dụng
        private void BbiReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            int docStatus = cbx_Status.SelectedIndex;
            if (docStatus == 1)
            { 
            string DocNo = sLook_DocNo.EditValue.ToString();
            M0005_TL_Report rpt_TL = new M0005_TL_Report(DocNo);
            ReportPrintTool print = new ReportPrintTool(rpt_TL);
            rpt_TL.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Chứng từ chưa được xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}