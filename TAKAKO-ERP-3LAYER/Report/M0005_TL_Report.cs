using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress;

namespace TAKAKO_ERP_3LAYER.Report
{
    public partial class M0005_TL_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public M0005_TL_Report(string DocNo)
        {
            InitializeComponent();
            //
            MMTB_DataSet mMTB_DataSet = new MMTB_DataSet();
            MMTB_DataSetTableAdapters.mmtb_TL_TableAdapter mmtb_TL_TableAdapter = new MMTB_DataSetTableAdapters.mmtb_TL_TableAdapter();
            mmtb_TL_TableAdapter.Fill(this.mmtB_DataSet1.MMTB_TL_Table, DocNo);
        }
    }
}
