using System.Drawing;
using System.Windows.Forms;
using DevExpress.Skins;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //
        public System_DAL _systemDAL = new System_DAL();

        public Form_Menu()
        {
            InitializeComponent();
        }

        public Form_Menu(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }
        private void Form_Menu_Shown(object sender, System.EventArgs e)
        {
            (sender as Form).Location = new Point(15, 0);
        }
        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BbiName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0001 formDetail = new Form_M0001(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0002 formDetail = new Form_M0002(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_ProcessCode formDetail = new Form_M0003_ProcessCode(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line formDetail = new Form_M0003_Line(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiMakerModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004 formDetail = new Form_M0004(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiPartList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012 formDetail = new Form_M0012(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005 formDetail = new Form_M0005(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiDisposal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_TL formDetail = new Form_M0005_Detail_TL(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiMoving_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_DD formDetail = new Form_M0005_Detail_DD(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiTech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0006 formDetail = new Form_M0006(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiACC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_ACC formDetail = new Form_M0005_Detail_ACC(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiNoUsed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NoUsed formDetail = new Form_M0005_Detail_NoUsed(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiSupport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_Request_Detail formDetail = new Form_M01_Request_Detail(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiListRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_Request formDetail = new Form_M01_Request(_systemDAL))
            {
                formDetail.Shown += Form_Menu_Shown;
                formDetail.ShowDialog();
                //formDetail.StartPosition = FormStartPosition.CenterScreen;
                //formDetail.Show();
            }
        }
        private void BbiAddModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_1_ByModel formDetail = new Form_M0013_1_ByModel(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_2_ByItem formDetail = new Form_M0013_2_ByItem(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiSummary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_All formDetail = new Form_M0013_All(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiPart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_LK formDetail = new Form_M0013_LK(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiBattery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_Pin formDetail = new Form_M0013_Pin(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiOil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013_Dau formDetail = new Form_M0013_Dau(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012_Stock formDetail = new Form_M0012_Stock(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiReplace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012_Replace formDetail = new Form_M0012_Replace(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012_Cancel formDetail = new Form_M0012_Cancel(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
        private void BbiPur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012_StockWarning formDetail = new Form_M0012_StockWarning(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiTelEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_TelEmail formDetail = new Form_M01_TelEmail(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiGEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M01_GroupEmail formDetail = new Form_M01_GroupEmail(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiChangePw_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_ChangePw formDetail = new Form_ChangePw(_systemDAL))
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }
    }
}
