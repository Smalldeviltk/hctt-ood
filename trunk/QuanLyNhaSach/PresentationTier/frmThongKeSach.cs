using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicTier;
using CrystalDecisions.CrystalReports.Engine;

namespace PresentationTier
{
    public partial class frmThongKeSach : Form
    {

        PhieuNhapBUS busPn = new PhieuNhapBUS();
        HoaDonBUS busHd = new HoaDonBUS();
        public frmThongKeSach()
        {
            InitializeComponent();
        }

        private void btTTLoai_Click(object sender, EventArgs e)
        {
            ReportClass rpt ;
            if (rdNhap.Checked)         
               rpt = new Report.rptTheoTheLoai_Nhap();
            else rpt = new Report.rptTheoTheLoai_Xuat();       
     
            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
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
