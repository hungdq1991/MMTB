using DevExpress.XtraEditors.Repository;
using System;
using System.Data;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_M0006 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Khai báo các datatable -> cho 3 tab control
        public DataTable _tempTable;
        public DataTable _tempTable1;
        public DataTable _tempTable2;
        public M0006_DAO M0006_DAO;
        public M0006_MayTien_DAO M0006_MayTien_DAO;
        public M0006_MayPhay_DAO M0006_MayPhay_DAO;
        public const Boolean AddNew = true;

        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_M0006()
        {
            InitializeComponent();
        }

        public Form_M0006(System_DAL systemDAL)
        {
            InitializeComponent();

            //
            _systemDAL = systemDAL;
        }

        //Load form M0006
        private void Form_M0006_Load(object sender, System.EventArgs e)
        {
            _tempTable = new DataTable();
            _tempTable1 = new DataTable();
            _tempTable2 = new DataTable();
            //
            M0006_DAO = new M0006_DAO();
            M0006_MayTien_DAO = new M0006_MayTien_DAO();
            M0006_MayPhay_DAO = new M0006_MayPhay_DAO();
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            //Load Init
            GetInfo_Gridview();
        }
        //Load dữ liệu
        private void GetInfo_Gridview()
        {
            try
            {
                _tempTable = M0006_DAO.GetInfo_M0006();
                _tempTable1 = M0006_MayTien_DAO.GetInfo_M0006();
                _tempTable2 = M0006_MayPhay_DAO.GetInfo_M0006();

                if (_tempTable.Rows.Count > 0)
                {
                    this.xtraTabPage1.Select();
                    gridControl.DataSource = _tempTable;
                    bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
                }
                if (_tempTable1.Rows.Count > 0)
                {
                    this.xtraTabPage2.Select();
                    gridControl2.DataSource = _tempTable1;
                }
                if (_tempTable2.Rows.Count > 0)
                {
                    this.xtraTabPage3.Select();
                    gridControl3.DataSource = _tempTable2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thông tin bsiRecordsCount thay đổi khi chọn tab control
        public void XtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                bsiRecordsCount.Caption = gridView2.RowCount.ToString() + " of " + _tempTable1.Rows.Count + " records";
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                bsiRecordsCount.Caption = gridView3.RowCount.ToString() + " of " + _tempTable2.Rows.Count + " records";
            }
        }
        //Thông tin bsiRecordsCount thay đổi khi filter column
        public void GridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView.RowCount.ToString() + " of " + _tempTable.Rows.Count + " records";
        }
        private void GridView2_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView2.RowCount.ToString() + " of " + _tempTable1.Rows.Count + " records";
        }
        private void GridView3_ColumnFilterChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = gridView3.RowCount.ToString() + " of " + _tempTable2.Rows.Count + " records";
        }
        //Hiển thị dữ liệu Yes/No theo hình ảnh
        private void GridView2_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Tailstock")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
            if (e.Column.FieldName == "AxisC")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
               // edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
        }
        private void GridView3_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "AxisB")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
            if (e.Column.FieldName == "AxisC_P")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
            if (e.Column.FieldName == "AxisXYZ")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
            if (e.Column.FieldName == "AxisA")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
            if (e.Column.FieldName == "WaterLine")
            {
                RepositoryItemCheckEdit edit = e.RepositoryItem as RepositoryItemCheckEdit;
                edit.PictureChecked = imageCollection1.Images[0];
                edit.PictureUnchecked = imageCollection1.Images[1];
                edit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            }
        }
        //Hiển thị dữ liệu và refresh gridview
        private void Setting_Init_Form()
        {
            GetInfo_Gridview();
            gridView.ClearFindFilter();
            gridView2.ClearFindFilter();
            gridView3.ClearFindFilter();
        }
        //Nội dung hiển thị khi click nút "Thêm mới"
        private void BbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0006_Detail formDetail = new Form_M0006_Detail(AddNew, _systemDAL))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        //Nội dung hiển thị khi click nút "Refresh"
        private void BbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ClearColumnsFilter();
            gridView2.ClearColumnsFilter();
            gridView3.ClearColumnsFilter();
            Setting_Init_Form();
        }
        //Nội dung hiển thị khi double click gridView
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0006_Detail formDetail = new Form_M0006_Detail(gridView.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        private void GridControl2_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0006_Detail_T formDetail = new Form_M0006_Detail_T(gridView2.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                Setting_Init_Form();
            }
        }
        private void GridControl3_DoubleClick(object sender, EventArgs e)
        {
            using (Form_M0006_Detail_P formDetail = new Form_M0006_Detail_P(gridView3.GetFocusedDataRow(), _systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterParent;
                Setting_Init_Form();
            }
        }
    }
}
