using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

namespace TAKAKO_ERP_3LAYER.View
{
    public partial class Form_Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void BbiName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0001 formDetail = new Form_M0001())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0002 formDetail = new Form_M0002())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_ProcessGroup formDetail = new Form_M0003_ProcessGroup())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0003_Line formDetail = new Form_M0003_Line())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiMakerModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0004 formDetail = new Form_M0004())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiPartList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0012 formDetail = new Form_M0012())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005 formDetail = new Form_M0005())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_NT formDetail = new Form_M0005_Detail_NT())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiDisposal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_TL formDetail = new Form_M0005_Detail_TL())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiMoving_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_DD formDetail = new Form_M0005_Detail_DD())
            {
                formDetail.ShowDialog();
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
            }
        }

        private void BbiBattery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0014 formDetail = new Form_M0014())
            {
                formDetail.ShowDialog();
            }
        }

        private void BbiOil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0013 formDetail = new Form_M0013())
            {
                formDetail.ShowDialog();
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
            }
        }

        private void BbiACC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Form_M0005_Detail_ACC formDetail = new Form_M0005_Detail_ACC())
            {
                formDetail.ShowDialog();
            }
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
