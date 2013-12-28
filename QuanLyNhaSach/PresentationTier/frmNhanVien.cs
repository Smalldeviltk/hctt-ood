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
    public partial class frmNhanVien : Form
    {
        TaoMa ma = new TaoMa();
        NhanVienBUS bus = new NhanVienBUS();
        NhanVien data = new NhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            gridView.DataSource = bus.LaydsNhanVien();

            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbEmail.Text = "";
            tbMatKhau.Text = "";
            tbNam.Text = "";
            tbSdt.Text = "";
            tbTaiKhoan.Text = "";
            tbTen.Text = "";

            cbbLoai.SelectedIndex = 0;
            cbbGioiTinh.SelectedIndex = 0;
            cbbNgay.SelectedIndex = 0;
            cbbThang.SelectedIndex = 0;
            btXoa.Enabled = false;
            btCapNhat.Enabled = false;
        }
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mamax = bus.LayMaMax();
            if (mamax.Equals(""))
            {
                data.id = "NV001";
            }
            else
            {
                data.id = ma.TaoMaTuDong(mamax, 2);
            }

            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbNam.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập năm sinh!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbNam.Text);
            }
            catch
            {
                MessageBox.Show("Năm sinh không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbCMND.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập CMND!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tài khoản!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            string ngay = cbbNgay.SelectedItem.ToString();
            string thang = cbbThang.SelectedItem.ToString();
            string nam = tbNam.Text;
            string ntn = ngay + "/" + thang + "/" + nam;
            data.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
            data.CMND = tbCMND.Text;
            data.DiaChi = tbDiaChi.Text;
            data.Email = tbEmail.Text;
            data.Loai = cbbLoai.SelectedItem.ToString();
            data.Password = tbMatKhau.Text;
            data.SoDienThoai = tbSdt.Text;
            data.Ten = tbTen.Text;
            data.Username = tbTaiKhoan.Text;
            data.NgaySinh = ntn;

            bus.Insert(data);
            loadData();
            MessageBox.Show("Thêm nhân viên thành công");

        }
        
        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            bus.Delete(id);
            loadData();
            MessageBox.Show("Xóa thành công");
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            data.id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbNam.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập năm sinh!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbNam.Text);
            }
            catch
            {
                MessageBox.Show("Năm sinh không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbCMND.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập CMND!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tài khoản!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            string ngay = cbbNgay.SelectedItem.ToString();
            string thang = cbbThang.SelectedItem.ToString();
            string nam = tbNam.Text;
            string ntn = ngay + "/" + thang + "/" + nam;
            data.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
            data.CMND = tbCMND.Text;
            data.DiaChi = tbDiaChi.Text;
            data.Email = tbEmail.Text;
            data.Loai = cbbLoai.SelectedItem.ToString();
            data.Password = tbMatKhau.Text;
            data.SoDienThoai = tbSdt.Text;
            data.Ten = tbTen.Text;
            data.Username = tbTaiKhoan.Text;
            data.NgaySinh = ntn;
            bus.Update(data);            
            MessageBox.Show("Cập nhật thành công");
            loadData();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTen.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[1].Value.ToString();
            string ngaysinh = gridView.Rows[gridView.CurrentRow.Index].Cells[2].Value.ToString();
            if (!ngaysinh.Equals(""))
            {
                string[] list = ngaysinh.Split('/');
                cbbNgay.Text = list[0];
                cbbThang.Text = list[1];
                tbNam.Text = list[2];
            }
            tbCMND.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[3].Value.ToString();
            cbbGioiTinh.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[4].Value.ToString();
            tbSdt.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[5].Value.ToString();
            tbDiaChi.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[6].Value.ToString();
            tbEmail.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[7].Value.ToString();
            tbTaiKhoan.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[8].Value.ToString();
            tbMatKhau.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[9].Value.ToString();
            cbbLoai.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[10].Value.ToString();
            btXoa.Enabled = true;
            btCapNhat.Enabled = true;
        }






    }
}
