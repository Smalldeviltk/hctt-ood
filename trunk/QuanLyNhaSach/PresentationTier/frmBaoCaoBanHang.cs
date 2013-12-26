using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicTier;

namespace PresentationTier
{
    public partial class frmBaoCaoBanHang : Form
    {
        BaoCaoBUS bus = new BaoCaoBUS();
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void btXemThongKe_Click(object sender, EventArgs e)
        {

            dgvThongKe.DataSource = bus.BaoCao_Xuat(dtpNNTu.Value, dtpNNDen.Value);
      
        }

        private void dtpNNDen_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }

        private void dtpNNTu_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report.rptBaoCaoBanHang rpt = new Report.rptBaoCaoBanHang();

            //-----------
            frmReport f = new frmReport(rpt, dtpNNTu.Value, dtpNNDen.Value);
            f.Text = "Báo cáo nhập hàng";
            f.Show();
        }
    }
}
