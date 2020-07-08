 using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M01_Request : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataTable _tempTable;
        public M01_DAO M01_DAO;
        //
        public System_DAL _systemDAL = new System_DAL();

        //Khởi tạo M01_Request
        public Form_M01_Request()
        {
            InitializeComponent();
        }
        public Form_M01_Request (System_DAL systemDAL)
        {
            InitializeComponent();

            _systemDAL = systemDAL;
        }

        //Load form
        private void Form_M01_Request_Load(object sender, System.EventArgs e)
        {
            //
            _tempTable = new DataTable();
            //
            M01_DAO = new M01_DAO();
            //
            bsiUser.Caption = _systemDAL.userName.ToUpper().ToUpper();
            //Load Init
            GetInfo_advBandedGridView1();
            Add_Value_repo_sLookUp_Check();
            Add_Value_repo_sLookUp_Confirm();
            AddValue_CBox_ReqType();
        }
        //Load dữ liệu
        private void GetInfo_advBandedGridView1()
        {
            try
            {
                _tempTable = M01_DAO.GetInfo_M01();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    advBandedGridView1.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thay đổi thông tin số lượng records khi filter
        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        //Lọc lại danh sách yêu cầu
        private void filter_List()
        {
            Boolean _urgent = bCheck_Urgent.Checked;
            Boolean _unConfirm = bCheck_UnConfirm.Checked;
            try
            {
                DataTable _tempTable = M01_DAO.GetInfo_M01();
                if (_tempTable.Rows.Count > 0)
                {
                    gridControl.DataSource = _tempTable;
                    advBandedGridView1.FormatRules[0].ApplyToRow = true;
                    bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                    try
                    {

                        if (_urgent == true && _unConfirm == true)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable()
                                .Where(row => row.Field<Boolean>("Urgent") == true && (row.Field<Int32>("ITConfirm") == 0 || row.Field<Int32>("ITConfirm") == 1 || row.Field<Int32>("ITConfirm") == 2)).CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_urgent == true && _unConfirm == false)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable()
                                    .Where(row => row.Field<Boolean> ("Urgent") == true).CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_urgent == false && _unConfirm == true)
                        {
                            gridControl.DataSource = _tempTable.AsEnumerable().Where(row => row.Field<Int32>("ITConfirm") == 0 || row.Field<Int32>("ITConfirm") == 1 || row.Field<Int32>("ITConfirm") == 2).CopyToDataTable();
                            bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                        if (_urgent == false && _unConfirm == false)
                        {
                                gridControl.DataSource = _tempTable;
                                advBandedGridView1.FormatRules[0].ApplyToRow = true;
                                bsiRecordsCount.Caption = advBandedGridView1.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                        }
                    }
                    catch
                    {
                        gridControl.DataSource = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Điền dữ liệu cho ô yêu cầu
        /// </summary>
        private void AddValue_CBox_ReqType()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("ReqType", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["ReqType"] = "Chỉnh sửa";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 1;
            dtRow1["ReqType"] = "Thêm chức năng";
            _ResultTable.Rows.Add(dtRow1);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 2;
            dtRow2["ReqType"] = "Báo lỗi";
            _ResultTable.Rows.Add(dtRow2);

            DataRow dtRow3 = _ResultTable.NewRow();
            dtRow3["STT"] = 3;
            dtRow3["ReqType"] = "Thêm chương trình";
            _ResultTable.Rows.Add(dtRow3);

            repo_sLookUp_ReqType.DataSource = _ResultTable;
            repo_sLookUp_ReqType.ValueMember = "STT";
            repo_sLookUp_ReqType.DisplayMember = "ReqType";
        }
        /// <summary>
        ///Xác nhận IT
        /// </summary>
        private void Add_Value_repo_sLookUp_Confirm()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Confirm", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["Confirm"] = "Chưa nhận thông tin";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow1 = _ResultTable.NewRow();
            dtRow1["STT"] = 1;
            dtRow1["Confirm"] = "Đang thực hiện";
            _ResultTable.Rows.Add(dtRow1);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 2;
            dtRow2["Confirm"] = "Đã nhận thông tin";
            _ResultTable.Rows.Add(dtRow2);

            DataRow dtRow3 = _ResultTable.NewRow();
            dtRow3["STT"] = 3;
            dtRow3["Confirm"] = "Đã hoàn thành";
            _ResultTable.Rows.Add(dtRow3);

            DataRow dtRow4 = _ResultTable.NewRow();
            dtRow4["STT"] = 4;
            dtRow4["Confirm"] = "Hủy yêu cầu";
            _ResultTable.Rows.Add(dtRow4);

            repo_sLookUp_Confirm.DataSource = _ResultTable;
            repo_sLookUp_Confirm.ValueMember = "STT";
            repo_sLookUp_Confirm.DisplayMember = "Confirm";
        }
        /// <summary>
        /// Điền dữ liệu cho ô kiểm tra chương trình có hay không
        /// </summary>
        private void Add_Value_repo_sLookUp_Check()
        {
            DataTable _ResultTable = new DataTable();
            _ResultTable.Columns.Add("STT", typeof(int));
            _ResultTable.Columns.Add("Check", typeof(string));

            DataRow dtRow = _ResultTable.NewRow();
            dtRow["STT"] = 0;
            dtRow["Check"] = "Không";
            _ResultTable.Rows.Add(dtRow);

            DataRow dtRow2 = _ResultTable.NewRow();
            dtRow2["STT"] = 1;
            dtRow2["Check"] = "Có";
            _ResultTable.Rows.Add(dtRow2);

            repo_sLookUp_Check.DataSource = _ResultTable;
            repo_sLookUp_Check.ValueMember = "STT";
            repo_sLookUp_Check.DisplayMember = "Check";
        }
        //Kiểm tra yêu cầu cần xử lý gấp check changed
        private void BCheck_Urgent_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }
        //Kiểm tra yêu cầu cần chưa xử lý check changed
        private void BCheck_Confirm_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filter_List();
        }
        //Xem chứng từ yêu cầu
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            //String param_DocNo = advBandedGridView1.GetFocusedDataRow()["DocNo_Confirm"].ToString();
            using (Form_M01_Request_Detail formDetail = new Form_M01_Request_Detail(advBandedGridView1.GetFocusedDataRow()["DocNo"].ToString(), _systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.ShowDialog();
            }
        }
        //Tạo chứng từ yêu cầu
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_Request_Detail formDetail = new Form_M01_Request_Detail(_systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //IT xác nhận chứng từ
        private void BbiIT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_Request_Detail formDetail = new Form_M01_Request_Detail(_systemDAL))
            {
                formDetail.StartPosition = FormStartPosition.CenterParent;
                formDetail.ShowDialog();
            }
        }
        //Click nút Refresh 
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bCheck_Urgent.Checked = false;
            bCheck_UnConfirm.Checked = false;
            filter_List();
        }
        //Hiển thị dữ liệu trên cột, ngày tháng không có
        private void AdvBandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ConfDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
            if (e.Column.FieldName == "ITConfDate" && e.DisplayText == "01/01/1900")
            {
                e.DisplayText = "";
            }
        }
    }
}
