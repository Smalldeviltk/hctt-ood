﻿using System;
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
    public partial class frmTacGia : Form
    {
        TaoMa ma = new TaoMa();
        TacGiaBUS bus = new TacGiaBUS();
        TacGia data = new TacGia();
        SachTacGiaBus stgbus = new SachTacGiaBus();
        public frmTacGia()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            gridView.DataSource = bus.LaydsTacGia();
            tbTen.Text = "";
            tbDiaChi.Text = "";
            tbDienThoai.Text = "";
            tbEmail.Text = "";
            tbDiaChi.Text = "";
            tbGhiChu.Text = "";
            btXoa.Enabled = false;
            btCapNhat.Enabled = false;
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {        
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mamax = bus.LayMaMax();
            if (mamax.Equals(""))
            {
                data.Id = "TG000001";
            }
            else
            {
                data.Id = ma.TaoMaTuDong(mamax, 2);
            }
            data.Ten = tbTen.Text;
            data.DienThoai = tbDienThoai.Text;
            data.Email = tbEmail.Text;
            data.DiaChi = tbDiaChi.Text;
            data.GhiChu = tbGhiChu.Text;
            #region kiểm tra dữ liệu nhập
            if (tbTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            bus.Insert(data);
            loadData();
            MessageBox.Show("Thêm sách thành công");
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = gridView.Rows[gridView.CurrentRow.Index].Cells[0].Value.ToString();
            ArrayList dsma = stgbus.LayDsMa();
            for (int i = 0; i<dsma.Count; i++)
            {
                if (id.Equals(dsma[i]))
                {
                    MessageBox.Show("Tồn tại sách của tác giả, không được xóa!");
                    return;
                }
            }
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
                MessageBox.Show("Bạn phải nhập tên sách!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            bus.Update(data);
            loadData();
            MessageBox.Show("Cập nhật thành công");
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
