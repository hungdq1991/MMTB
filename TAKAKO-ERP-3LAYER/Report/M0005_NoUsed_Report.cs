using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MMTB.Report
{
    public partial class M0005_NoUsed_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public M0005_NoUsed_Report(string DocNo)
        {
                InitializeComponent();
                //
                MMTB_DataSet mMTB_DataSet = new MMTB_DataSet();
                MMTB_DataSetTableAdapters.mmtb_NoUsed_TableAdapter mmtb_NoUsed_TableAdapter = new MMTB_DataSetTableAdapters.mmtb_NoUsed_TableAdapter();
            mmtb_NoUsed_TableAdapter.Fill(this.mmtB_DataSet1.MMTB_NoUsed_Table, DocNo);
            
        }
    }
}
