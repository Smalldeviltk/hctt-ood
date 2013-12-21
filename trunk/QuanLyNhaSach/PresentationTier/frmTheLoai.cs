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
    public partial class frmTheLoai : Form
    {
        TaoMa ma = new TaoMa();
        TheLoaiBUS bus = new TheLoaiBUS();
        TheLoai data = new TheLoai();
        public frmTheLoai()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            gridView.DataSource = bus.LaydsTheLoai();
            tbTen.Text = "";
            btXoa.Enabled = false;
            btCapNhat.Enabled = false;
        }
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string mamax = bus.LayMaMax();
            if (mamax.Equals(""))
            {
                data.Id = "TL000001";
            }
            else
            {
                data.Id = ma.TaoMaTuDong(mamax, 2);
            }
            data.Ten = tbTen.Text;

            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên thể loại sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            bus.Insert(data);
            loadData();
            MessageBox.Show("Thêm thể loại sách thành công");
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
            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên thể loại sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btXoa.Enabled = true;
            btCapNhat.Enabled = true;
        }


    }
}
