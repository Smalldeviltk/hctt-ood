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
    public partial class frmTimSach : Form
    {
        TacGiaBUS tgbus = new TacGiaBUS();
        SachBUS bus = new SachBUS();
        public frmTimSach()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            ArrayList dstacgiatheosach = new ArrayList();
            ArrayList dsmsach = new ArrayList();
            ArrayList dstacgia = new ArrayList();
            DataTable stable = new DataTable();
            dsmsach = bus.LaydsMa();
            for (int j = 0; j < dsmsach.Count; j++)
            {
                dstacgiatheosach = tgbus.LayTacGiaTheoSach(dsmsach[j].ToString());

                string tentacgia = "";
                for (int i = 0; i < dstacgiatheosach.Count - 1; i++)
                {
                    tentacgia += dstacgiatheosach[i].ToString() + ",";
                }
                tentacgia += dstacgiatheosach[dstacgiatheosach.Count - 1];
                dstacgia.Add(tentacgia);
            }
            stable = bus.LaydsSach();
            DataColumn colum = stable.Columns.Add("Tác giả", typeof(string));
            colum.SetOrdinal(3);
            int k = 0;
            foreach (DataRow dr in stable.Rows)
            {
                dr["Tác giả"] = dstacgia[k];
                k++;
            }
            gridView.DataSource = stable;
        }
        private void frmTimSach_Load(object sender, EventArgs e)
        {
            ArrayList dstacgia = tgbus.LaydsTen();
            cbbTacGia.DataSource = dstacgia;
            cbbDen.SelectedIndex = -1;
            cbbTu.SelectedIndex = -1;
            cbbTacGia.SelectedIndex = -1;
            loadData();
        }

        private void tbTen_TextChanged(object sender, System.EventArgs e)
        {
            string tensach = tbTen.Text;
            gridView.DataSource = bus.TimSachTheoTen(tensach);
        }
        private bool SoSanhGia(string giatu, string giaden)
        {
            int gtu = Int32.Parse(giatu);
            int gden = Int32.Parse(giaden);
            if (gtu <= gden)
                return true;
            else return false;
        }

        private void btTim_Click(object sender, System.EventArgs e)
        {
            if (cbbTu.SelectedIndex == -1 && cbbDen.SelectedIndex == -1 && cbbTacGia.SelectedIndex == -1 && tbTen.Text=="")
            {
                MessageBox.Show("Bạn phải nhập thông tin tìm kiếm!");
                return;
            }
            string giatu = cbbTu.SelectedItem.ToString();
            string giaden = cbbDen.SelectedItem.ToString();
            if (SoSanhGia(giatu, giaden))
            {
                gridView.DataSource = bus.TimSachTheoGiaBanTrongKhoang(giatu, giaden);
            }
            else
            {
                MessageBox.Show("Giá từ phải nhỏ hơn hoặc bằng giá đến!");
            }
        }

        private void btTimMoi_Click(object sender, System.EventArgs e)
        {
            tbTen.Text = "";
            cbbDen.SelectedIndex = -1;
            cbbTu.SelectedIndex = -1;
            cbbTacGia.SelectedIndex = -1;
            loadData();
        }

        private void cbbTu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btTim.Enabled = true;
            if (cbbTu.SelectedIndex != -1)
            {
                string giatu = cbbTu.SelectedItem.ToString();
                gridView.DataSource = bus.TimSachTheoGiaBanTu(giatu);
            }

        }

        private void cbbDen_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btTim.Enabled = false;
            if (cbbDen.SelectedIndex != -1)
            {
                string giaden = cbbDen.SelectedItem.ToString();
                gridView.DataSource = bus.TimSachTheoGiaBanDen(giaden);
            }

        }

        private void cbbTacGia_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tbTen.Text != "" && cbbTacGia.SelectedIndex != -1)
            {
                string matacgia = tgbus.LayMaTheoTen(cbbTacGia.SelectedItem.ToString());
                string tensach = tbTen.Text;
                gridView.DataSource = bus.TimSachTheoTenVaTacGia(matacgia, tensach);
            }
            if (cbbTacGia.SelectedIndex != -1)
            {
                string matacgia = tgbus.LayMaTheoTen(cbbTacGia.SelectedItem.ToString());
                gridView.DataSource = bus.TimSachTheoTacGia(matacgia);
            }
        }


    }
}
