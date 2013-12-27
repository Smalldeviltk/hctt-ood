using BusinessLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CheckAuth();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                HelperBUS h = new HelperBUS();
                SqlConnection con = h.GetConnect();
            }
            catch (Exception)
            {
                frmConnection f = new frmConnection();
                f.ShowDialog();
            }
        }
      
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmDangNhap f = new frmDangNhap(this);
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        public void CheckAuth()
        {
            if (Auth.logged != null)
            {
                dangNhapToolStripMenuItem.Enabled = false;
                dangXuatToolStripMenuItem.Enabled = true;
                thongTinTaiKhoanToolStripMenuItem.Enabled = true;
                quanLyToolStripMenuItem.Enabled = true;
                timKiemNhanVienToolStripMenuItem.Enabled = true;
                thayDoiQuiDinhToolStripMenuItem.Enabled = true;
                kinhDoanhToolStripMenuItem.Enabled = true;
                baoCaoToolStripMenuItem.Enabled = true;
            }
            else
            {
                dangNhapToolStripMenuItem.Enabled = true;
                dangXuatToolStripMenuItem.Enabled = false;
                thongTinTaiKhoanToolStripMenuItem.Enabled = false;
                quanLyToolStripMenuItem.Enabled = false;
                timKiemNhanVienToolStripMenuItem.Enabled = false;
                thayDoiQuiDinhToolStripMenuItem.Enabled = false;
                kinhDoanhToolStripMenuItem.Enabled = false;
                baoCaoToolStripMenuItem.Enabled = false;
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth.logged = null;
            CheckAuth();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmTacGia f = new frmTacGia();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmNhaXuatBan f = new frmNhaXuatBan();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmNhaCungCap f = new frmNhaCungCap();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmTheLoai f = new frmTheLoai();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmSach f = new frmSach();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmNhanVien f = new frmNhanVien();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmBanHang f = new frmBanHang();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmPhieuNhap f = new frmPhieuNhap();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmThongKeSach f = new frmThongKeSach();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void baoCaoNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmBaoCaoNhapHang f = new frmBaoCaoNhapHang();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void baoCaoBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmBaoCaoBanHang f = new frmBaoCaoBanHang();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmTimSach f = new frmTimSach();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void timKiemNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFrm.Controls.Clear();
            frmTimNhanVien f = new frmTimNhanVien();
            f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(f);
            f.Show();
        }

        private void thayDoiQuiDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
}
