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

        private void btTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia f = new frmTacGia();
            f.ShowDialog();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
        }

        private void btNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan f = new frmNhaXuatBan();
            f.ShowDialog();
        }

        private void btTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai f = new frmTheLoai();
            f.ShowDialog();
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.ShowDialog();
        }


     


    }
}
