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
    public partial class frmSach : Form
    {
        TaoMa ma = new TaoMa();
        NhaXuatBanBUS nxbbus = new NhaXuatBanBUS();
        NhaCungCapBUS nccbus = new NhaCungCapBUS();
        TheLoaiBUS tlbus = new TheLoaiBUS();
        TacGiaBUS tgbus = new TacGiaBUS();
        SachTacGiaBus stgbus = new SachTacGiaBus();
        SachBUS bus = new SachBUS();
        Sach data = new Sach();
        SachTacGia stgdata = new SachTacGia();
        HoaDonBUS hdbus = new HoaDonBUS();
        PhieuNhapBUS pnbus = new PhieuNhapBUS();
        public frmSach()
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
            btXoa.Enabled = false;
            btCapNhat.Enabled = false;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            ArrayList dstacgia = new ArrayList();
            dstacgia = tgbus.LaydsTen();
            cbbNhaXuatBan.DataSource = nxbbus.LaydsTen();
            cbbMaNhaCungCap.DataSource = nccbus.LaydsTen();
            cbbTheLoai.DataSource = tlbus.LaydsTen();
            for (int i = 0; i < dstacgia.Count; i++)
            {
                clbTacGia.Items.Add(dstacgia[i]);
            }
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mamax = bus.LayMaMax();
            if (mamax.Equals(""))
            {
                data.Id = "S000001";
            }
            else
            {
                data.Id = ma.TaoMaTuDong(mamax, 1);
            }

            #region kiểm tra dữ liệu nhập
            if (tbTenSach.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbGiaMua.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập giá mua!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbGiaBan.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập giá bán!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbSoLuong.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập số lượng!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            #region kiểm tra dữ liệu nhập
            try
            {
                Int32.Parse(tbGiaMua.Text);
            }
            catch
            {
                MessageBox.Show("Giá mua không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbGiaBan.Text);
            }
            catch
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            data.TenSach = tbTenSach.Text;
            data.GiaMua = tbGiaMua.Text;
            data.GiaBan = tbGiaBan.Text;
            data.SoLuong = tbSoLuong.Text;
            data.NhaXuatBan = nxbbus.LayMaTheoTen(cbbNhaXuatBan.SelectedItem.ToString());
            data.NhaCungCap = nccbus.LayMaTheoTen(cbbMaNhaCungCap.SelectedItem.ToString());
            data.TheLoai = tlbus.LayMaTheoTen(cbbTheLoai.SelectedItem.ToString());

            int count = 0;
            for (int i = 0; i < clbTacGia.Items.Count; i++)
            {
                if (clbTacGia.GetItemChecked(i))
                    count++;
            }
            if (count <= 0)
            {
                MessageBox.Show("Bạn phải chọn tác giả!");
                return;
            }

            bus.Insert(data);
            for (int i = 0; i < count; i++)
            {
                string mamaxstg = stgbus.LayMaMax();
                if (mamaxstg.Equals(""))
                {
                    stgdata.Id = "STG000001";
                }
                else
                {
                    stgdata.Id = ma.TaoMaTuDong(mamaxstg, 3);
                }
                stgdata.MaSach = data.Id;

                stgdata.MaTacGia = tgbus.LayMaTheoTen(clbTacGia.CheckedItems[i].ToString());
                stgbus.Insert(stgdata);
            }


            MessageBox.Show("Thêm thành công!");
            loadData();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTenSach.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[1].Value.ToString();
            cbbTheLoai.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[2].Value.ToString();
            tbGiaMua.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[4].Value.ToString();
            tbGiaBan.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[5].Value.ToString();
            tbSoLuong.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[6].Value.ToString();
            cbbMaNhaCungCap.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[7].Value.ToString();
            cbbNhaXuatBan.Text = gridView.Rows[gridView.CurrentRow.Index].Cells[8].Value.ToString();
            string dstacgia = gridView.Rows[gridView.CurrentRow.Index].Cells[3].Value.ToString();

            string[] tacgia = dstacgia.Split(',');
            for (int k = 0; k < clbTacGia.Items.Count; k++)
            {
                clbTacGia.SetItemChecked(k, false);
            }
            for (int i = 0; i < tacgia.Count(); i++)
            {
                for (int j = 0; j < clbTacGia.Items.Count; j++)
                {
                    if (tacgia[i].Equals(clbTacGia.Items[j].ToString()))
                    {
                        clbTacGia.SetItemChecked(j, true);
                    }
                }

            }
            btCapNhat.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            ArrayList dsmahd = hdbus.LaydsMa();
            for (int i = 0; i < dsmahd.Count; i++)
            {
                if (id.Equals(dsmahd[i]))
                {
                    MessageBox.Show("Sách tồn tại trong hóa đơn, không được xóa!");
                    return;
                }
            }
            ArrayList dsmasct = pnbus.LaydsMaSach();
            for (int i = 0; i < dsmasct.Count; i++)
            {
                if (id.Equals(dsmasct[i]))
                {
                    MessageBox.Show("Sách tồn tại trong phiếu nhập, không được xóa!");
                    return;
                }
            }
            stgbus.Delete(id);
            bus.Delete(id);
            MessageBox.Show("Xóa thành công");
            loadData();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            data.Id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            #region kiểm tra dữ liệu nhập
            if (tbTenSach.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbGiaMua.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập giá mua!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbGiaBan.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập giá bán!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbSoLuong.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập số lượng!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            #region kiểm tra dữ liệu nhập
            try
            {
                Int32.Parse(tbGiaMua.Text);
            }
            catch
            {
                MessageBox.Show("Giá mua không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbGiaBan.Text);
            }
            catch
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Int32.Parse(tbSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            data.TenSach = tbTenSach.Text;
            data.GiaMua = tbGiaMua.Text;
            data.GiaBan = tbGiaBan.Text;
            data.SoLuong = tbSoLuong.Text;
            data.NhaXuatBan = nxbbus.LayMaTheoTen(cbbNhaXuatBan.SelectedItem.ToString());
            data.NhaCungCap = nccbus.LayMaTheoTen(cbbMaNhaCungCap.SelectedItem.ToString());
            data.TheLoai = tlbus.LayMaTheoTen(cbbTheLoai.SelectedItem.ToString());


            bus.Update(data);


            stgbus.Delete(data.Id);

            string mastg = stgbus.LayMaTheoMaSach(data.Id);
            int count = 0;
            for (int i = 0; i < clbTacGia.Items.Count; i++)
            {
                if (clbTacGia.GetItemChecked(i))
                    count++;
            }
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    string mamaxstg = stgbus.LayMaMax();
                    if (mamaxstg.Equals(""))
                    {
                        stgdata.Id = "STG000001";
                    }
                    else
                    {
                        stgdata.Id = ma.TaoMaTuDong(mamaxstg, 3);
                    }
                    stgdata.MaSach = data.Id;
                    stgdata.MaTacGia = tgbus.LayMaTheoTen(clbTacGia.CheckedItems[i].ToString());
                    stgbus.Insert(stgdata);

                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn tác giả!");
                return;
            }
            MessageBox.Show("Cập nhật thành công!");
            loadData();
        }

    }
}
