using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Data.SqlClient;
using BusinessLogicTier;
using CrystalDecisions.Shared;
using PresentationTier;

namespace QuanLiNhaSachGUI
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
        }

        public void viewHoaDon(DataTable dt)
        {
            //CrystalReportHoaDon objRpt = new CrystalReportHoaDon();
            //objRpt.SetDataSource(dt);
            //objRpt.SetParameterValue("TenNhaSach", QuiDinhBUS.LayGiaTri("TenNhaSach"));
            //objRpt.SetParameterValue("DiaChi", QuiDinhBUS.LayGiaTri("DiaChi"));
            //objRpt.SetParameterValue("Email", QuiDinhBUS.LayGiaTri("Email"));
            //objRpt.SetParameterValue("DienThoai", QuiDinhBUS.LayGiaTri("DienThoai"));
            //objRpt.SetParameterValue("Website", QuiDinhBUS.LayGiaTri("Website"));
            //crystalReportViewer1.ReportSource = objRpt;
            //crystalReportViewer1.Refresh();
            //this.Show();
        }

        internal void viewPhieuNhap(DataTable dt)
        {
            CrystalReportPhieuNhap objRpt = new CrystalReportPhieuNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();            
        }
		public void viewTuaBan(DataTable dt)
        {
            CR.TuaBan objRpt = new CR.TuaBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTuaNhap(DataTable dt)
        {
            CR.TuaMua objRpt = new CR.TuaMua();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewTuaE(DataTable dt)
        {
            CR.TuaE objRpt = new CR.TuaE();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTLBan(DataTable dt)
        {
            CR.TLBan objRpt = new CR.TLBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTLNhap(DataTable dt)
        {
            CR.TLNhap objRpt = new CR.TLNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewTLE(DataTable dt)
        {
            CR.TLE objRpt = new CR.TLE();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTGBan(DataTable dt)
        {
            CR.TGBan objRpt = new CR.TGBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewTGNhap(DataTable dt)
        {
            CR.TGNhap objRpt = new CR.TGNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTGE(DataTable dt)
        {
            CR.TGE objRpt = new CR.TGE();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewNXBBan(DataTable dt)
        {
            CR.NXBBan objRpt = new CR.NXBBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewNXBNhap(DataTable dt)
        {
            CR.NXBNhap objRpt = new CR.NXBNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewNXBE(DataTable dt)
        {
            CR.NXBE objRpt = new CR.NXBE();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewNCCBan(DataTable dt)
        {
            CR.NCCBan objRpt = new CR.NCCBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewNCCNhap(DataTable dt)
        {
            CR.NCCNhap objRpt = new CR.NCCNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewNCCE(DataTable dt)
        {
            CR.NCCE objRpt = new CR.NCCE();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewNVBan(DataTable dt)
        {
            CR.NVBan objRpt = new CR.NVBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
        public void viewNVNhap(DataTable dt)
        {
            CR.NVNhap objRpt = new CR.NVNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewBCNhap(DataTable dt)
        {
            CR.BCNhap objRpt = new CR.BCNhap();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewBCBan(DataTable dt)
        {
            CR.BCBan objRpt = new CR.BCBan();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }

        public void viewTonKho(DataTable dt)
        {
            CR.TonKho objRpt = new CR.TonKho();
            objRpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
            this.Show();
        }
    }
}
