using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAutomation
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        FrmUrunler frurunler;
        private void btnURUNLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frurunler = new FrmUrunler();
                frurunler.MdiParent = this;
                frurunler.Show();
            
        }
        FrmMusteriler frmusteriler;
        private void btnMUSTERILER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmusteriler = new FrmMusteriler();
                frmusteriler.MdiParent = this;
                frmusteriler.Show();
            
        }
        FrmFirmalar frmfirmalar;
        private void btnFIRMALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmfirmalar = new FrmFirmalar();
            frmfirmalar.MdiParent = this;
            frmfirmalar.Show();
        }
    }
}
