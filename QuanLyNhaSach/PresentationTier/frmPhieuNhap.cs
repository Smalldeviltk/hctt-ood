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
    public partial class frmPhieuNhap : Form
    {
        DataTable tb = new DataTable();
        long tongtien;
        Timer time = new Timer();

        public frmPhieuNhap()
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn sách trước khi thêm");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng");
            }
            else
            {
                DataRow dr = tb.NewRow();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                dr[0] = row.Cells[0].Value.ToString();
                dr[1] = row.Cells[1].Value.ToString();
                dr[2] = row.Cells[2].Value.ToString();
                dr[3] = row.Cells[3].Value.ToString();
                dr[4] = txtSoLuong.Text.ToString();
                dr[5] = (int.Parse(dr[3].ToString()) * int.Parse(dr[4].ToString())).ToString();

                bool flag = true;
                foreach (DataRow myRow in tb.Rows)
                {
                    if (dr[0].ToString() == myRow[0].ToString())
                    {
                        int temp = int.Parse(myRow[4].ToString()) + int.Parse(dr[4].ToString());
                        myRow[4] = temp;
                        myRow[5] = (int.Parse(myRow[3].ToString()) * int.Parse(myRow[4].ToString())).ToString();
                        flag = false;
                        break;
                    }
                }
                if (flag) tb.Rows.Add(dr);
                dataGridView2.Refresh();

                UpdateTongTien();
            }
        }

        private void UpdateTongTien()
        {
            tongtien = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                tongtien += long.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) * long.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }
            string st = tongtien.ToString();
            int len = st.Length;
            for (int i = len - 2; i > 0; i--)
            {
                if ((len - i) % 3 == 0)
                    st = st.Insert(i, ",");
            }
            txtTongTien.Text = st;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount <= 0)
            {
                MessageBox.Show("Không có sản phẩm để lưu");
            }
            else
            {
                PhieuNhap hd = new PhieuNhap();
                //hd.MaNhanVien = Auth.logged.id;
                hd.TongTien = tongtien.ToString();
                hd.Ngay = DateTime.Now.ToString();

                int maHoaDon = NhapHangBUS.insertPhieuNhap(hd);

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    ChiTietPhieuNhap cthd = new ChiTietPhieuNhap();
                    cthd.MaPhieuNhap = maHoaDon.ToString();
                    cthd.MaSach = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    cthd.SoLuong = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    NhapHangBUS.insertChiTietPhieuNhap(cthd);
                    NhapHangBUS.updateSoLuongSach(cthd.MaSach, cthd.SoLuong);
                }
                MessageBox.Show("Lưu thành công");
                //XuatPhieuNhap();
                btnNhapMoi_Click(sender, e);
            }
        }

        //public void XuatPhieuNhap()
        //{
        //    frmReportViewer frm = new frmReportViewer();
        //    DataTable dt = new DataTable();
        //    foreach (DataGridViewColumn col in dataGridView2.Columns)
        //    {
        //        dt.Columns.Add(col.DataPropertyName, col.ValueType);
        //    }
        //    Int32 t = new Int32();
        //    dt.Columns[5].DataType = t.GetType();
        //    dt.Columns[3].DataType = t.GetType();
        //    foreach (DataGridViewRow gridRow in dataGridView2.Rows)
        //    {
        //        if (gridRow.IsNewRow)
        //            continue;
        //        DataRow dtRow = dt.NewRow();
        //        for (int i1 = 0; i1 < dataGridView2.Columns.Count; i1++)
        //            dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
        //        dt.Rows.Add(dtRow);
        //    }
        //    frm.viewPhieuNhap(dt);
        //}

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
            txtTimSach.Text = "";
            txtTongTien.Text = "";
            dataGridView2.Refresh();
            //dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhapHangBUS.TimSach(txtTimSach.Text);
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoLuong.Focus();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTongTien();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void frmNhapHang_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhapHangBUS.TimSach(txtTimSach.Text);
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}