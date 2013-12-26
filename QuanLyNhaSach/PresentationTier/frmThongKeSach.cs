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

        BaoCaoBUS busBc = new BaoCaoBUS();
        int type=0;
        public frmThongKeSach()
        {
            InitializeComponent();
        }
        private void dtpNNTu_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }

        private void dtpNNDen_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }
        private void btTTLoai_Click(object sender, EventArgs e)
        {
            //1---
            label3.Text = "Theo thể loại";
            if (rdNhap.Checked)         
            {
                dgvThongKe.DataSource = busBc.TheoTheLoai_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 1;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoTheLoai_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -1;
            }



        }  

        private void btTTDe_Click(object sender, EventArgs e)
        {
            label3.Text = "Theo tựa đề";
            //2
            if (rdNhap.Checked)
            {
                dgvThongKe.DataSource = busBc.TheoTuaDe_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 2;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoTuaDe_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -2;
            }
        }

        private void btTNVien_Click(object sender, EventArgs e)
        {
            //6
            label3.Text = "Theo Nhân viên";
            if (rdNhap.Checked)
            {
                dgvThongKe.DataSource = busBc.TheoNhanVien_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 6 ;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoNhanVien_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -6;
            }
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            //3
            label3.Text = "Theo Nhà cung cấp";
            if (rdNhap.Checked)
            {
                dgvThongKe.DataSource = busBc.TheoNCC_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 3;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoNCC_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -3;
            }
        }

        private void btNXB_Click(object sender, EventArgs e)
        {
            //4
            label3.Text = "Theo nhà xuất bản";
            if (rdNhap.Checked)
            {
                dgvThongKe.DataSource = busBc.TheoNXB_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 4;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoNXB_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -4;
            }
        }

        private void btTTGia_Click(object sender, EventArgs e)
        {
            //5
            label3.Text = "Theo tác giả";
            if (rdNhap.Checked)
            {
                dgvThongKe.DataSource = busBc.TheoTacGia_Nhap(dtpNNTu.Value, dtpNNDen.Value);
                type = 5;
            }
            else
            {
                dgvThongKe.DataSource = busBc.TheoTacGia_Xuat(dtpNNTu.Value, dtpNNDen.Value);
                type = -5;
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            ReportClass rpt=null;
            switch (type)
            {
                case 1: rpt = new Report.rptTheoTheLoai_Nhap();
                    break;

                case -1: rpt = new Report.rptTheoTheLoai_Xuat();
                    break;

                case 2: rpt = new Report.rptTheoTuaDe_Nhap();
                    break;

                case -2: rpt = new Report.rptTheoTuaDe_Xuat();
                    break;

                case 3: rpt = new Report.rptTheoNCC_Nhap();
                    break;

                case -3: rpt = new Report.rptTheoNCC_Xuat();
                    break;

                case 4: rpt = new Report.rptTheoNXB_Nhap();
                    break;

                case -4: rpt = new Report.rptTheoNXB_Xuat();
                    break;

                case 5: rpt = new Report.rptTheoTacGia_Nhap();
                    break;

                case -5: rpt = new Report.rptTheoTacGia_Xuat();
                    break;

                case 6: rpt = new Report.rptTheoNhanVien_Nhap();
                    break;

                case -6: rpt = new Report.rptTheoNhanVien_Xuat();
                    break;
                case 0:
                    return;
            }

            frmReport f = new frmReport(rpt, dtpNNTu.Value, dtpNNDen.Value);
            f.Show();     
        }


    }
}
