﻿using System;
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
        HoaDonBUS bus = new HoaDonBUS();
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void btXemThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = bus.LaydsTheoNgay(dtpNNTu.Value, dtpNNDen.Value);
             Report.rptBaoCaoBanHang rpt = new  Report.rptBaoCaoBanHang();
            
            //-----------
            rpt.SetDataSource(dt);
            frmReport f = new frmReport();
            rpt.SetParameterValue("tu", dtpNNTu.Value);
             rpt.SetParameterValue("den", dtpNNDen.Value);
//              
            f.cryRViewer.ReportSource = rpt;
            f.Text = "Báo cáo nhập hàng";
            f.Show();
        }

        private void dtpNNDen_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }

        private void dtpNNTu_ValueChanged(object sender, EventArgs e)
        {
            dtpNNDen.Value = dtpNNDen.Value > dtpNNTu.Value ? dtpNNDen.Value : dtpNNTu.Value;
        }
    }
}