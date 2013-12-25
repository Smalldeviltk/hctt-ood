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
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoTheLoai_Nhap();
            else rpt = new Report.rptTheoTheLoai_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo thể loại";
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

        private void btTTDe_Click(object sender, EventArgs e)
        {
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoTuaDe_Nhap();
            else rpt = new Report.rptTheoTuaDe_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo tựa đề";
            f.Show();
        }

        private void btTNVien_Click(object sender, EventArgs e)
        {
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoNhanVien_Nhap();
            else rpt = new Report.rptTheoNhanVien_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo nhân viên";
            f.Show();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoNCC_Nhap();
            else rpt = new Report.rptTheoNCC_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo nhà cung cấp";
            f.Show();
        }

        private void btNXB_Click(object sender, EventArgs e)
        {
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoNXB_Nhap();
            else rpt = new Report.rptTheoNXB_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo nhà xuất bản";
            f.Show();
        }

        private void btTTGia_Click(object sender, EventArgs e)
        {
            ReportClass rpt;
            if (rdNhap.Checked)
                rpt = new Report.rptTheoTacGia_Nhap();
            else rpt = new Report.rptTheoTacGia_Xuat();

            //------------
            frmReport f = new frmReport();
            rpt.SetParameterValue("den", dtpNNDen.Value);
            rpt.SetParameterValue("tu", dtpNNTu.Value);
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo theo tác giả";
            f.Show();
        }
    }
}
