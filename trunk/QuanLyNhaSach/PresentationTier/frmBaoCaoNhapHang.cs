using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BusinessLogicTier;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;

namespace PresentationTier
{
    public partial class frmBaoCaoNhapHang : Form
    {


        PhieuNhapBUS bus = new PhieuNhapBUS();
        public frmBaoCaoNhapHang()
        {
            InitializeComponent();
        }
        private void frmBaoCaoNhapHang_Load(object sender, EventArgs e)
        {

        }
        private void btInBaoCao_Click(object sender, EventArgs e)
        {

            DataTable dt = bus.LaydsTheoNgay(dtpNNTu.Value,dtpNNDen.Value);
            Report.rptBaoCaoNhapHang rpt = new Report.rptBaoCaoNhapHang();
            //-----------
          //  rpt.SetDataSource(dt);

            frmReport f = new frmReport(rpt, dtpNNTu.Value, dtpNNDen.Value);
            f.Text = "Báo cáo nhập hàng";
            f.Show();
        }

        private void dtpNNTu_ValueChanged(object sender, EventArgs e)
        {
                dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }

        private void dtpNNDen_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }
        
    }
}
