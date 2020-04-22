using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress;

namespace MMTB.Report
{
    public partial class M0005_DD_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public M0005_DD_Report(string DocNo)
        {
            InitializeComponent();
            //
            MMTB_DataSet mMTB_DataSet = new MMTB_DataSet();
            MMTB_DataSetTableAdapters.mmtb_DD_TableAdapter mmtb_DD_TableAdapter = new MMTB_DataSetTableAdapters.mmtb_DD_TableAdapter();
            mmtb_DD_TableAdapter.Fill(this.mmtB_DataSet1.MMTB_DD_Table, DocNo);
        }
    }
}
