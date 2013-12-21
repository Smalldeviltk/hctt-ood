using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BusinessLogicTier;
using System.Collections;

namespace PresentationTier
{
    public partial class frmNhaXuatBan : Form
    {
        TaoMa ma = new TaoMa();
        NhaXuatBanBUS bus = new NhaXuatBanBUS();
        NhaXuatBan data = new NhaXuatBan();
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            gridView.DataSource = bus.LaydsNhaCungCap();
            tbTen.Text = "";
            tbDiaChi.Text = "";
            tbDienThoai.Text = "";
            tbEmail.Text = "";
            tbDiaChi.Text = "";
            tbGhiChu.Text = "";
            btXoa.Enabled = false;
            btCapNhat.Enabled = false;
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mamax = bus.LayMaMax();
            if (mamax.Equals(""))
            {
                data.Id = "NXB000001";
            }
            else
            {
                data.Id = ma.TaoMaTuDong(mamax, 3);
            }
            data.Ten = tbTen.Text;
            data.DienThoai = tbDienThoai.Text;
            data.Email = tbEmail.Text;
            data.DiaChi = tbDiaChi.Text;
            data.GhiChu = tbGhiChu.Text;
            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            bus.Insert(data);
            loadData();
            MessageBox.Show("Thêm nhà xuất bản thành công");
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
            data.Id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            data.Ten = tbTen.Text;
            data.DienThoai = tbDienThoai.Text;
            data.Email = tbEmail.Text;
            data.DiaChi = tbDiaChi.Text;
            data.GhiChu = tbGhiChu.Text;
            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            bus.Update(data);
            loadData();
            MessageBox.Show("Cập nhật thành công");
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            tbTen.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[1].Value.ToString();
            tbDiaChi.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[2].Value.ToString();
            tbDienThoai.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[3].Value.ToString();
            tbEmail.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[4].Value.ToString();
            tbGhiChu.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[5].Value.ToString();
            btXoa.Enabled = true;
            btCapNhat.Enabled = true;
        }
    }
}
