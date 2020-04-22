using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TAKAKO_ERP_3LAYER.DAO;
using TAKAKO_ERP_3LAYER.DAL;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_M0012_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _DetailTable;
        public DataTable _DeleteRowTable;
        public M0002_DAO M0002_DAO;
        public M0004_DAO M0004_DAO;
        public M0012_DAO M0012_DAO;
        public Boolean InitValue = true;
        public System_DAL _systemDAL = new System_DAL();
        //Khởi tạo form
        public Form_M0012_Detail()
        {
            InitializeComponent();
        }
        //Khởi tạo form theo nội dung InitValue
        public Form_M0012_Detail(Boolean _InitValue, System_DAL systemDAL)
        {
            InitializeComponent();
            InitValue = _InitValue;
                //
            _systemDAL = systemDAL;
            
        }
        //Update, delete _ form theo kiểu dữ liệu
        public Form_M0012_Detail(DataTable DetailTable, System_DAL systemDAL)
        {
            //
            InitializeComponent();
            //
            _DetailTable = DetailTable;
            //
            _systemDAL = systemDAL;
        }
        //Update, delete _ form theo kiểu dữ liệu
        private void Form_M0012_Detail_Load(object sender, EventArgs e)
        {
            _DetailTable = new DataTable();
            _DeleteRowTable = new DataTable();
            //
            M0002_DAO = new M0002_DAO();
            M0004_DAO = new M0004_DAO();
            M0012_DAO = new M0012_DAO();
            //Load Init
            Setting_Init_Control();
            Setting_Init_Value();
            AddValue_CBox_SessionID();
            AddValue_sLookUp_NameEN();
            AddValue_sLookUp_WH1Code();
            AddValue_sLookUp_WH2Code();
            AddValue_sLookUp_PurCode();
            AddValue_CBox_InActive();
        }
        //Thông tin table cho gridView
        private void Define_DetailTable()
        {
            _DetailTable.Columns.Add("SessionID", typeof(string));
            _DetailTable.Columns.Add("ItemCode", typeof(string));
            _DetailTable.Columns.Add("NameEN", typeof(string));
            _DetailTable.Columns.Add("NameVN", typeof(string));
            _DetailTable.Columns.Add("NameJP", typeof(string));
            _DetailTable.Columns.Add("Maker", typeof(string));
            _DetailTable.Columns.Add("Unit", typeof(string));
            _DetailTable.Columns.Add("UnitMultDiv", typeof(string));
            _DetailTable.Columns.Add("CnvFact", typeof(int));
            _DetailTable.Columns.Add("Point", typeof(int));
            _DetailTable.Columns.Add("MinimumQty", typeof(int));
            _DetailTable.Columns.Add("Lifetime", typeof(int));
            _DetailTable.Columns.Add("PurCode", typeof(string));
            _DetailTable.Columns.Add("WH1Code", typeof(string));
            _DetailTable.Columns.Add("WH2Code", typeof(string));
            _DetailTable.Columns.Add("ApplyDate", typeof(DateTime));
            _DetailTable.Columns.Add("InActive", typeof(int));
            _DetailTable.Columns.Add("Memo", typeof(string));
            _DetailTable.Columns.Add("InputDate", typeof(DateTime));
            _DetailTable.Columns.Add("InputUser", typeof(string));
            _DetailTable.Columns.Add("ModifyDate", typeof(DateTime));
            _DetailTable.Columns.Add("ModifyUser", typeof(string));
            _DetailTable.Columns.Add("Column1", typeof(string));
            _DetailTable.Columns.Add("Column2", typeof(string));
            _DetailTable.Columns.Add("Column3", typeof(string));
            _DetailTable.Columns.Add("Column4", typeof(string));
            _DetailTable.Columns.Add("Column5", typeof(string));
        }
        //Dữ liệu trên Form_M0012_Detail
        private void Setting_Init_Control()
        {
            //Định nghĩa datatable gán cho gridview
            Define_DetailTable();
            Define_DeleteRowTable();
        }
        //Giá trị khi khởi tạo form
        private void Setting_Init_Value()
        {
            Clear_Data();
        }
        //Xóa dữ liệu gridView
        private void Clear_Data()
        {
            _DetailTable.Clear();
            gridControl.DataSource = _DetailTable;
            gridView.AddNewRow();
        }
        //Nhập thông tin LK
        //Hiển thị bảng pop up
        #region 
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
        //Click chuột phải chọn Add new row
        private void bbi_PopUp_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear_Data();
        }
        //Click nút Add new row
        private void bbi_AddNewRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.AddNewRow();
            gridView.SetFocusedRowCellValue("InActive", 0);
        }
        //Click chuột phải chọn Delete row
        private void bbi_PopUp_DeleteRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataRow dtrow = _DeleteRowTable.NewRow();
            dtrow["ItemCode"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemCode");
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
            dtrow["ItemCode"] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemCode");
            _DeleteRowTable.Rows.Add(dtrow);
            //
            var row = gridView.FocusedRowHandle;
            gridView.DeleteRow(row);
            _DetailTable.AcceptChanges();
        }
        //Nhập liệu trên lưới - SessionID
        private void AddValue_CBox_SessionID()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("ID", typeof(int));
            _ResultTable.Columns.Add("Tên", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["ID"] = 1;
            dtRow["Tên"] = "LK";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["ID"] = 4;
            dtRow1["Tên"] = "Dầu";
            _ResultTable.Rows.Add(dtRow1);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["ID"] = 5;
            dtRow2["Tên"] = "Pin";
            _ResultTable.Rows.Add(dtRow2);

            repo_sLookUp_SessionID.DataSource = _ResultTable;
            repo_sLookUp_SessionID.ValueMember = "ID";
            repo_sLookUp_SessionID.DisplayMember = "Tên";
        }
        //Nhập liệu trên lưới - Tên LK
        private void AddValue_sLookUp_NameEN()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0002_DAO.GetInfo_M0002_LK();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_NameEN.DataSource = tempTable;
                repo_sLookUp_NameEN.ValueMember = "NameEN";
                repo_sLookUp_NameEN.DisplayMember = "NameEN";
            }
        }
        //Lấy tên tiếng Việt, Nhật của LK
        private void Repo_sLookUp_NameEN_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                string _nameEN = "";
                string _nameVN = "";
                string _nameJP = "";

                //Get index
                SearchLookUpEdit editor = sender as SearchLookUpEdit;
                int index = editor.Properties.GetIndexByKeyValue(editor.EditValue);

                //Set value to variables
                _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
                _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
                _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
                //Set value to column ACCcode, NameEN, NameVN, Maker, Model...
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameEN", _nameEN);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameVN", _nameVN);
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameJP", _nameJP);
            }
        }
        //Nhập liệu trên lưới - Mã tồn kho
        private void AddValue_sLookUp_WH1Code()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_Solomon_WH1();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_WH1Code.DataSource = tempTable;
                repo_sLookUp_WH1Code.ValueMember = "InvtID";
                repo_sLookUp_WH1Code.DisplayMember = "InvtID";
            }
        }
        private void AddValue_sLookUp_WH2Code()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_Solomon_WH2();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_WH2Code.DataSource = tempTable;
                repo_sLookUp_WH2Code.ValueMember = "InvtID";
                repo_sLookUp_WH2Code.DisplayMember = "InvtID";
            }
        }
        //Nhập liệu trên lưới - Mã mua hàng
        private void AddValue_sLookUp_PurCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_Solomon_PurCode();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_PurCode.DataSource = tempTable;
                repo_sLookUp_PurCode.ValueMember = "EF_InvtID";
                repo_sLookUp_PurCode.DisplayMember = "EF_InvtID";
            }
        }
        //Lấy đơn vị quy đổi mua hàng và nhập kho (nếu có)
        private void Repo_sLookUp_PurCode_CloseUp(object sender, CloseUpEventArgs e)
        {
            string _unitMultDiv = "";
            int _cnvFact = 0;

            //Get index
            SearchLookUpEdit editor = sender as SearchLookUpEdit;
            int index = editor.Properties.GetIndexByKeyValue(editor.EditValue);

            //Set value to variables
            _unitMultDiv = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("UnitMultDiv"));
            _cnvFact = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("CnvFact"));
            //Set value to column UnitMultDiv, CnvFact
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "UnitMultDiv", _unitMultDiv);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "CnvFact", _cnvFact);
        }
        //Inactive / Active
        private void AddValue_CBox_InActive()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("ID", typeof(int));
            _ResultTable.Columns.Add("Status", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["ID"] = 0;
            dtRow["Status"] = "No";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["ID"] = 1;
            dtRow1["Status"] = "Yes";
            _ResultTable.Rows.Add(dtRow1);

            repo_sLookUp_InActive.DataSource = _ResultTable;
            repo_sLookUp_InActive.ValueMember = "ID";
            repo_sLookUp_InActive.DisplayMember = "Status";
        }
        //Chỉnh sửa nội dung mã LK
        private void AddValue_sLookUp_ItemCode()
        {
            DataTable tempTable = new DataTable();
            tempTable = M0012_DAO.GetInfo_M0012_Update();
            if (tempTable.Rows.Count > 0)
            {
                repo_sLookUp_ItemCode.DataSource = tempTable;
                repo_sLookUp_ItemCode.ValueMember = "ItemCode";
                repo_sLookUp_ItemCode.DisplayMember = "ItemCode";
            }
        }
        //Điền thông tin LK
        private void Repo_sLookUp_ItemCode_CloseUp(object sender, CloseUpEventArgs e)
        {
            int    _sessionID      = 1;
            string _itemCode       = "";
            string _nameEN         = "";
            string _nameVN         = "";
            string _nameJP         = "";
            string _maker          = "";
            string _unit           = "";
            string _unitMultDiv    = "";
            int    _cnvFact        = 0;
            int    _point          = 0;
            int    _minimumQty     = 0;
            int    _lifetime       = 0;
            string _purCode        = "";
            string _wh1Code        = "";
            string _wh2Code        = "";
            DateTime _applyDate    = DateTime.Now;
            int    _inActive       = 0;
            string _memo           = "";

            //Get index
            SearchLookUpEdit editor = sender as SearchLookUpEdit;
            int index = editor.Properties.GetIndexByKeyValue(editor.EditValue);

            //Set value to variables
            _sessionID = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("SessionID"));
            _itemCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("ItemCode"));
            _nameEN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameEN"));
            _nameVN = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameVN"));
            _nameJP = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("NameJP"));
            _maker = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Maker"));
            _unit = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Unit"));
            _unitMultDiv = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("UnitMultDiv"));
            _cnvFact = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("CnvFact"));
            _point = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("Point"));
            _minimumQty = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("MinimumQty"));
            _lifetime = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("Lifetime"));
            _purCode = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("PurCode"));
            _wh1Code = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("WH1Code"));
            _wh2Code = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("WH2Code"));
            _applyDate = Convert.ToDateTime(editor.Properties.View.GetFocusedRowCellValue("ApplyDate"));
            _inActive = Convert.ToInt32(editor.Properties.View.GetFocusedRowCellValue("InActive"));
            _memo = Convert.ToString(editor.Properties.View.GetFocusedRowCellValue("Memo"));

            //Set value to column 
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "SessionID", _sessionID);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "ItemCode", _itemCode);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameEN", _nameEN);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameVN", _nameVN);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "NameJP", _nameJP);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Maker", _maker);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Unit", _unit);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "UnitMultDiv", _unitMultDiv);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "CnvFact", _cnvFact);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Point", _point);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "MinimumQty", _minimumQty);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Lifetime", _lifetime);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "PurCode", _purCode);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "WH1Code", _wh1Code);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "WH2Code", _wh2Code);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "ApplyDate", _applyDate);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "InActive", _inActive);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Memo", _memo);
        }
        //Xóa dòng trên gridView
        private void Define_DeleteRowTable()
        {
            _DeleteRowTable.Columns.Add("ItemCode", typeof(string));
        }
        //Click nút New
        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear_Data();
            InitValue = true;
            Set_Enable_Control(true);
            //GridView
            gridCol_SessionID.OptionsColumn.AllowEdit = true;
            gridCol_NameEN.OptionsColumn.AllowEdit = true;
            gridCol_NameVN.OptionsColumn.AllowEdit = true;
            gridCol_NameJP.OptionsColumn.AllowEdit = true;
            gridCol_Unit.OptionsColumn.AllowEdit = true;
            gridCol_Maker.OptionsColumn.AllowEdit = true;
        }
        private void BbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear_Data();
            InitValue = false;
            AddValue_sLookUp_ItemCode();
            gridView.FocusedColumn = gridCol_ItemCode;
            Set_Enable_Control(false);
            //GridView
            gridCol_SessionID.OptionsColumn.AllowEdit = false;
            gridCol_NameEN.OptionsColumn.AllowEdit = false;
            gridCol_NameVN.OptionsColumn.AllowEdit = false;
            gridCol_NameJP.OptionsColumn.AllowEdit = false;
            gridCol_Unit.OptionsColumn.AllowEdit = false;
            gridCol_Maker.OptionsColumn.AllowEdit = false;
        }
        //Click nút Reset
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl.DataSource = _DetailTable;
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
                        if (M0012_DAO.Update_M0012(_DetailTable))
                        {
                            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bbi_PopUp_Delete.Enabled = IsEnable;
        }
        //Các tình huống cần kiểm tra lỗi
        public Boolean CheckError()
        {
            if (InitValue)
            {
                //Nhóm hàng
                for (int rows = 0; rows < gridView.RowCount; rows++)
                {
                    int _sessionID;
                    _sessionID = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["SessionID"]));
                    if (_sessionID == 0 )
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Nhóm hàng\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["SessionID"];
                        return false;
                    }
                //Mã hàng
                    string _itemCode;
                    _itemCode = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["ItemCode"]));
                    if (String.IsNullOrEmpty(_itemCode))
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Mã hàng\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["ItemCode"];
                        return false;
                    }
                //Tên hàng
                    string _nameEN;
                    _nameEN = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["NameEN"]));
                    if (String.IsNullOrEmpty(_nameEN))
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Tên hàng\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["NameEN"];
                        return false;
                    }
                //Unit
                     string _unit;
                    _unit = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Unit"]));
                    if (String.IsNullOrEmpty(_unit))
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Đvt\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["Unit"];
                        return false;
                    }
                //PurCode
                    string _purCode;
                    _purCode = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["PurCode"]));
                    if (String.IsNullOrEmpty(_purCode))
                    {
                        MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Mã mua hàng\" chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.Focus();
                        gridView.FocusedRowHandle = rows;
                        gridView.FocusedColumn = gridView.Columns["PurCode"];
                        return false;
                    }
                //Trùng thông tin Mã hàng, Maker, Point, Lifetime, MinimumQty
                    string _maker;
                    int _point;
                    int _minimumQty;
                    int _lifetime;
                    _maker = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns["Maker"]));
                    _point = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Point"]));
                    _minimumQty = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["MinimumQty"]));
                    _lifetime = Convert.ToInt32(gridView.GetRowCellValue(rows, gridView.Columns["Lifetime"]));
                    try
                    {
                        DataTable _tempTable = M0012_DAO.GetInfo_M0012_Check(_itemCode, _maker, _point, _minimumQty, _lifetime);
                        if (_tempTable.Rows.Count > 0)
                        {
                            gridControl.DataSource = _tempTable;
                            MessageBox.Show("Dòng " + (rows + 1) + ", cột \"Mã hàng\" đã có (trùng Maker, Điểm, Tuổi thọ và SL tối thiểu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gridView.Focus();
                            gridControl.DataSource = _DetailTable;
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return true;
        }
        //Load thông tin mã LK khi user cần Edit
        private void GridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == gridCol_ItemCode && InitValue == false)
            {
                e.RepositoryItem = repo_sLookUp_ItemCode;
            }
            if (e.Column == gridCol_PurCode)
            {
                e.RepositoryItem = repo_sLookUp_PurCode;
            }
        }
        //Kiểm tra trùng trên lưới
        bool IsDuplicatedRowFound(string _value, string column)
        {
            for (int rows = 0; rows < gridView.DataRowCount; rows++)
                if (rows != gridView.FocusedRowHandle)
                {
                    string _rowCodeValue = Convert.ToString(gridView.GetRowCellValue(rows, gridView.Columns[column]));
                    if (!String.IsNullOrEmpty(_rowCodeValue))
                    {
                        if (Equals(_value, _rowCodeValue))
                            return true;
                    }
                }
            return false;
        }
        //Kiểm tra mã LK trùng khi nhập liệu
        private void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridView.FocusedColumn == gridCol_ItemCode)
            {
                string _itemCode = (string)e.Value;
                e.Valid = !IsDuplicatedRowFound(_itemCode, "ItemCode");
                if (!e.Valid)
                {
                    e.ErrorText = "Mã LK/Dầu/Pin đã tồn tại trên lưới";
                }
            }
        }

        private void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView.SetFocusedRowCellValue("ApplyDate", DateTime.Now);
            gridView.SetFocusedRowCellValue("InActive", 0);
            gridView.SetFocusedRowCellValue("SessionID", 0);
            gridView.SetFocusedRowCellValue("Point", 0);
            gridView.SetFocusedRowCellValue("Lifetime", 0);
            gridView.SetFocusedRowCellValue("MinimumQty", 0);
            gridView.SetFocusedRowCellValue("Unit", "PCS");
        }
    }
}
