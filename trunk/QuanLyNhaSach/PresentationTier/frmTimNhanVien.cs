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

namespace PresentationTier
{
    public partial class frmTimNhanVien : Form
    {
        NhanVienBUS bus = new NhanVienBUS();
        public frmTimNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimNhanVien_Load(object sender, EventArgs e)
        {
            tbCMND.Text = "";
            tbNam.Text = "";
            tbTen.Text = "";

            cbbNgay.SelectedIndex = 0;
            cbbThang.SelectedIndex = 0;
            gridView.DataSource = bus.LaydsNhanVien();
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            string tennv = tbTen.Text;
            gridView.DataSource = bus.TimTheoTen(tennv);
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            string cmnd = tbCMND.Text;
            gridView.DataSource = bus.TimTheoCMND(cmnd);
        }

        private void tbNam_TextChanged(object sender, EventArgs e)
        {
            string ngaysinh=cbbNgay.SelectedItem.ToString()+"/"+cbbThang.SelectedItem.ToString()+"/"+tbNam.Text;
            gridView.DataSource = bus.TimTheoNgaySinh(ngaysinh);
        }



    }
}
