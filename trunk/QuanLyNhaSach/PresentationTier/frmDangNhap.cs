using BusinessLogicTier;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class frmDangNhap : Form
    {
        NhanVienBUS nvB = new NhanVienBUS();
        frmMain f;
        public frmDangNhap(frmMain fMain)
        {
            InitializeComponent();
            f = fMain;
        }
        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
            DataTable dt = null;
            dt = nvB.login(txtTenDangNhap.Text, txtMatKhau.Text);

            if (dt.Rows.Count == 0 || dt.Rows[0][10].ToString() == "out")
                MessageBox.Show("Sai Tên hoặc Mật Khẩu");
            else
            {
                Auth.logged = new NhanVien();
                Auth.logged.id = dt.Rows[0][0].ToString();
                Auth.logged.Ten = dt.Rows[0][1].ToString();
                Auth.logged.NgaySinh = dt.Rows[0][2].ToString();
                Auth.logged.CMND = dt.Rows[0][3].ToString();
                Auth.logged.GioiTinh = dt.Rows[0][4].ToString();
                Auth.logged.SoDienThoai = dt.Rows[0][5].ToString();
                Auth.logged.DiaChi = dt.Rows[0][6].ToString();
                Auth.logged.Email = dt.Rows[0][7].ToString();
                Auth.logged.Username = dt.Rows[0][8].ToString();
                Auth.logged.Password = dt.Rows[0][9].ToString();
                Auth.logged.Loai = dt.Rows[0][10].ToString();
                //new frmMain(this).Show();
                this.Close();
                f.CheckAuth();
                MessageBox.Show("Đăng nhập thành công");
            }
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {
            
        }
    }

    public static class Auth
    {
        public static NhanVien logged;
    }
}
