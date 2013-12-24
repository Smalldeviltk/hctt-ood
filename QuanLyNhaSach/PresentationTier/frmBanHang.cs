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
    public partial class frmBanHang : Form
    {
        DataTable tb = new DataTable();
        long tongtien;
        Timer time = new Timer();

        public frmBanHang()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(time_Tick);
            time.Start();
        }

        void time_Tick(object sender, EventArgs e)
        {
            lbNgay.Text = DateTime.Now.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtTimSach.Text = "";
            dataGridView2.Refresh();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lbNgay.Text = DateTime.Now.ToString();
            //lbNhanVien.Text = Auth.logged.Ten;
            txtTongTien.Text = "";

            tb.Columns.Add("Mã");
            tb.Columns.Add("Tên Sách");
            tb.Columns.Add("Tác Giả");
            tb.Columns.Add("Đơn Giá");
            tb.Columns.Add("Số Lượng");
            tb.Columns.Add("Tiền");
            dataGridView2.DataSource = tb;
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].ReadOnly = true;
            dataGridView2.Columns[3].ReadOnly = true;
            dataGridView2.Columns[4].ReadOnly = true;
            dataGridView2.Columns[5].ReadOnly = true;

            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
