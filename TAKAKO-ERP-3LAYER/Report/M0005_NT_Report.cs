using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress;

namespace TAKAKO_ERP_3LAYER.Report
{
    public partial class M0005_NT_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public M0005_NT_Report(string DocNo)
        {
            InitializeComponent();
            //
            MMTB_DataSet mMTB_DataSet = new MMTB_DataSet();
            MMTB_DataSetTableAdapters.mmtb_NT_TableAdapter mmtb_NT_TableAdapter = new MMTB_DataSetTableAdapters.mmtb_NT_TableAdapter();
            mmtb_NT_TableAdapter.Fill(this.mmtB_DataSet1.MMTB_NT_Table, DocNo);
        }
    }
}
