using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.DAL;

namespace TAKAKO_ERP_3LAYER.View
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
            using (Form_M0002 formDetail = new Form_M0002())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_ProcessCode formDetail = new Form_M0003_ProcessCode())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line formDetail = new Form_M0003_Line())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiMakerModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004 formDetail = new Form_M0004())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiPartList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012 formDetail = new Form_M0012())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005 formDetail = new Form_M0005())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiDisposal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_TL formDetail = new Form_M0005_Detail_TL())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiMoving_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_DD formDetail = new Form_M0005_Detail_DD())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void BbiPart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0015_Master formDetail = new Form_M0015_Master())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiBattery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0014 formDetail = new Form_M0014())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiOil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013 formDetail = new Form_M0013())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BbiTech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0006 formDetail = new Form_M0006())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void BbiACC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_ACC formDetail = new Form_M0005_Detail_ACC())
            {
                formDetail.ShowDialog();
                formDetail.StartPosition = FormStartPosition.CenterScreen;
                formDetail.Show();
            }
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
