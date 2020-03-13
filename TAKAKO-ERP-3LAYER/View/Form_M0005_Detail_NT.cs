using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraBars;
using TAKAKO_ERP_3LAYER.DAO;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0005_Detail_NT : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Tạo biến
        public DataTable _InitHeaderTable;
        public DataTable _InitDetailTable;
        public DataTable _HeaderTable;
        public DataTable _DetailTable;
        public M0005_DAO M0005_DAO;
        public M0004_DAO M0004_DAO;
        public String DocNo = "";
        public Boolean InitValue = true;
        //public M0005_Line_DAO M0005_Line_DAO;

        ////Các biến theo bảng thông tin tổng hợp
        //public string DocNo;
        //public DateTime DocDate;
        //public string EF_VendID;
        //public string SupplierID;
        //public string SupplierName;
        //public string InvNo;
        //public DateTime InvDate;
        //public DateTime ReceiptDate;
        //public DateTime ConfirmDate;
        //public string ControlDept;
        //public DateTime ApplyDate;
        //Tạo biến để ghi nhận New / Edit / Confirm
        //private Boolean IsNewValue = false;
        //private Boolean IsCheck;
        #endregion
        public Form_M0005_Detail_NT()
        {
            InitializeComponent();
        }

        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0005_Detail_NT(String _docNo)
        {
            InitializeComponent();
            DocNo = _docNo;
        }

        //Load Form_M0005_Detail_NT
        private void Form_M0005_Detail_NT_Load(object sender, EventArgs e)
        {
            M0004_DAO = new M0004_DAO();
            M0005_DAO = new M0005_DAO();

            Setting_Init_Control();

            Setting_Init_Value();
        }

        //Dữ liệu trên Form_M0005_Detail_NT
        private void Setting_Init_Control()
        {
            //Định nghĩa datatable gán cho header
            Define_HeaderTable();

            //Định nghĩa datatable gán cho gridview
            Define_DetailTable();

            //Khởi tạo bảng _InitDetailTable

            AddValue_CBox_Status();

            AddValue_CBox_Status(cbx_Status);

            Add_Value_sLookUp_DocNo();

            AddValue_sLook_ControlDept();

            AddValue_sLookUp_Supplier();

            Add_Value_repo_sLookUp_NameEN();

            Add_Value_repo_sLookUp_Nation();

            Add_Value_repo_sLookUp_ProgressGroup();
        }

        private void Setting_Init_Value()
        {
            if(String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            } else
            {
                sLook_DocNo.EditValue = DocNo;
            }
        }

        private void Define_HeaderTable()
        {
            //Các cột theo bảng M0005_ListMMTB
            _HeaderTable = new DataTable();
            _HeaderTable.Columns.Add("DocNo", typeof(string));
            _HeaderTable.Columns.Add("DocDate", typeof(DateTime));
            _HeaderTable.Columns.Add("EF_VendID", typeof(string));
            _HeaderTable.Columns.Add("InvNo", typeof(string));
            _HeaderTable.Columns.Add("InvDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ReceiptDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ConfirmDate", typeof(DateTime));
            _HeaderTable.Columns.Add("ControlDept", typeof(string));
            _HeaderTable.Columns.Add("DocStatus", typeof(string));
            _HeaderTable.Columns.Add("Column1", typeof(string));
            _HeaderTable.Columns.Add("Column2", typeof(string));
            _HeaderTable.Columns.Add("Column3", typeof(string));
            _HeaderTable.Columns.Add("Column4", typeof(string));
            _HeaderTable.Columns.Add("Column5", typeof(string));
        }

        private void AddValue_Header(DataTable _tempTable)
        {
            date_Doc.EditValue = _tempTable.Rows[0].Field<DateTime>("DocDate");
            sLook_Supplier.EditValue = _tempTable.Rows[0].Field<string>("EF_VendID").Trim();
            txt_InvNo.Text = _tempTable.Rows[0].Field<string>("InvNo").ToString();
            date_Inv.EditValue = _tempTable.Rows[0].Field<DateTime>("InvDate");
            date_Receipt.EditValue = _tempTable.Rows[0].Field<DateTime>("ReceiptDate");
            date_Confirm.EditValue = _tempTable.Rows[0].Field<DateTime>("ConfirmDate");
            sLook_ControlDept.EditValue = _tempTable.Rows[0].Field<string>("ControlDept").ToString().Trim();
            if (_tempTable.Rows[0].Field<Boolean>("DocStatus"))
            {
                cbx_Status.SelectedIndex = 1;
            }
            else
            {
                cbx_Status.SelectedIndex = 0;
            }
        }

        //Định nghĩa cấu trúc datatable gán cho grid control
        private void Define_DetailTable()
        {
            //Các cột theo bảng M0005_ListMMTB
            _DetailTable = new DataTable();
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
            _DetailTable.Columns.Add("Lifetime", typeof(int));
            _DetailTable.Columns.Add("StartDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("EndDeprDate", typeof(DateTime));
            _DetailTable.Columns.Add("ACCDoc", typeof(string));
            _DetailTable.Columns.Add("InstDoc", typeof(string));
            _DetailTable.Columns.Add("Status", typeof(string));
            _DetailTable.Columns.Add("Result", typeof(string));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("OrgProcessCode", typeof(string));
            _DetailTable.Columns.Add("OrgLineCode", typeof(string));
            _DetailTable.Columns.Add("OrgGroupLineACC", typeof(string));
            _DetailTable.Columns.Add("OrgUsingDept", typeof(string));
            _DetailTable.Columns.Add("OrgLineEN", typeof(string));
        }

        #region Add data to control
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

        //Điền dữ liệu cho ô NameEN
        private void Add_Value_repo_sLookUp_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_Maker();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_NameEN.DataSource = tempTable;
                repo_sLookUp_NameEN.ValueMember = "NameEN";
                repo_sLookUp_NameEN.DisplayMember = "NameEN";
            }
        }

        private void Add_Value_repo_sLookUp_Nation()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_NationMF();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_Nation.DataSource = tempTable;
                repo_sLookUp_Nation.ValueMember = "NATION_CODE";
                repo_sLookUp_Nation.DisplayMember = "NATION_NAME";
            }
        }

        private void Add_Value_repo_sLookUp_ProgressGroup()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0004_DAO.GetInfo_ProgressGroup();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_LineID.DataSource = tempTable;
                repo_sLookUp_LineID.ValueMember = "ProcessGroup";
                repo_sLookUp_LineID.DisplayMember = "ProcessEN";
            }
        }

        private void AddValue_CBox_Status()
        {
            repo_cBox_Status.Items.Add("Mới");
            repo_cBox_Status.Items.Add("Cũ");
        }

        //Tạo nội dung combo box cho user lựa chọn: Yes/No
        private void AddValue_CBox_Status(DevExpress.XtraEditors.ComboBoxEdit comboBox)
        {
            List<string> Boolean = new List<string>();
            Boolean.Add("Chuẩn bị");
            Boolean.Add("Xác nhận");
            comboBox.Properties.Items.AddRange(Boolean);
        }

        //Điền dữ liệu cho ô Số chứng từ
        private void Add_Value_sLookUp_DocNo()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_M0005_DocNT();
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

        //Điền dữ liệu cho ô Supplier
        private void AddValue_sLookUp_Supplier()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0005_DAO.GetInfo_VendorSolomon();
            if (tempTable.Rows.Count > 0)
            {
                sLook_Supplier.Properties.DataSource = tempTable;
                sLook_Supplier.Properties.ValueMember = "EF_VendID";
                sLook_Supplier.Properties.DisplayMember = "EF_VendID";
            }
            else
            {
                sLook_Supplier.Properties.DataSource = "";
            }
        }
        #endregion

        #region event
        //Lấy kết quả ô NCC, điền dữ liệu tương ứng cho tên NCC
        private void SLook_Supplier_TextChanged(object sender, EventArgs e)
        {
            DataTable tempTable = new DataTable();
            string tempCode = Convert.ToString(sLook_Supplier.EditValue);
            try
            {
                if (!String.IsNullOrEmpty(tempCode))
                {
                    tempTable = M0005_DAO.GetInfo_VendorName(tempCode);

                    if (tempTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in tempTable.Rows)
                        {
                            txt_SupplierID.Text = row.Field<string>("VendID");
                            txt_SupplierName.Text = row.Field<string>("VendName");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                sLook_Supplier.Focus();
            }
        }

        //Lấy số chứng từ, điền thông tin vào Form_M0005_Detail_NT 
        private void SLook_DocNo_TextChanged(object sender, EventArgs e)
        {
            string _docNo = "";
            if (sLook_DocNo.EditValue != null)
            { 
                _docNo = sLook_DocNo.EditValue.ToString();
            }
            try
            {
                if (!string.IsNullOrEmpty(_docNo))
                {
                    _HeaderTable.Clear();
                    _HeaderTable = M0005_DAO.GetInfo_M0005_NT_Header(_docNo);

                    if (_HeaderTable.Rows.Count > 0)
                    {
                        AddValue_Header(_HeaderTable);
                    }

                    _DetailTable.Clear();
                    _DetailTable = M0005_DAO.GetInfo_M0005_NT_Detail(_docNo);
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

        private void Clear_Data()
        {
            sLook_DocNo.EditValue = null;
            date_Doc.EditValue = DateTime.Now;
            sLook_Supplier.EditValue = null;
            txt_SupplierID.EditValue = null;
            txt_SupplierName.EditValue = null;
            txt_InvNo.EditValue = null;
            date_Inv.EditValue = DateTime.Now;
            date_Receipt.EditValue = DateTime.Now;
            date_Confirm.EditValue = DateTime.Now;
            sLook_ControlDept.EditValue = null;
            cbx_Status.SelectedIndex = 0;

            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;
        }

        //Click nút thêm mới
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa dữ liệu hiện tại và tạo mới biên bản nghiệm thu?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                InitValue = true;
                Clear_Data();
            }
        }

        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrEmpty(DocNo))
            {
                Clear_Data();
            } else
            {
                SLook_DocNo_TextChanged(sender, e);
            }
        }

        //Click nút Close
        private void BbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbx_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Status.SelectedIndex == 0)
            {
                Set_Enable_Control(true);
            } else if (cbx_Status.SelectedIndex == 1)
            {
                Set_Enable_Control(false);
            }
        }

        private void bbi_PopUp_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
        }

        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }

        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {    
            if (String.IsNullOrEmpty(DocNo))
            {

            } else
            {

            }
        }
        #endregion

        private void Set_Enable_Control(Boolean IsEnable)
        {
            //Menu
            bbiSave.Enabled = IsEnable;
            bbiRefresh.Enabled = IsEnable;
            bbi_AddNewRow.Enabled = IsEnable;
            bbi_DeleteRow.Enabled = IsEnable;
            //PopUp
            bbi_PopUp_AddNewRow.Enabled = IsEnable;
            bbi_PopUp_DeleteRow.Enabled = IsEnable;
            //Header
            date_Doc.Enabled = IsEnable;
            sLook_Supplier.Enabled = IsEnable;
            txt_SupplierID.Enabled = IsEnable;
            txt_SupplierName.Enabled = IsEnable;
            txt_InvNo.Enabled = IsEnable;
            date_Inv.Enabled = IsEnable;
            date_Receipt.Enabled = IsEnable;
            date_Confirm.Enabled = IsEnable;
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
            if (String.IsNullOrEmpty(txt_InvNo.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Số hóa đơn\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_Supplier.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(sLook_ControlDept.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập \"Bộ phận quản lý MMTB\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sLook_Supplier.Focus();
                return false;
            }
            return true;
        }

        #region event Gridview
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

        //private void gridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{
        //    if (e.Column.FieldName == "Code")
        //    {
        //        GridCellInfo cellInfo = e.Cell as GridCellInfo;
        //        if (cellInfo == null)
        //        {
        //            if (!Directory.Exists(e.CellValue.ToString()))
        //            {
        //                cellInfo.ViewInfo.ErrorIconText = "No path exists";
        //                cellInfo.ViewInfo.ShowErrorIcon = true;
        //            }
        //        }
        //    }
        //}
        #endregion
    }
}