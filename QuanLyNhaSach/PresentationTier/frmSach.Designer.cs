namespace PresentationTier
{
    partial class frmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGiaMua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.clbTacGia = new System.Windows.Forms.CheckedListBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(162, 34);
            this.tbTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(132, 22);
            this.tbTenSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá mua";
            // 
            // tbGiaMua
            // 
            this.tbGiaMua.Location = new System.Drawing.Point(162, 72);
            this.tbGiaMua.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaMua.Name = "tbGiaMua";
            this.tbGiaMua.Size = new System.Drawing.Size(132, 22);
            this.tbGiaMua.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán";
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Location = new System.Drawing.Point(162, 106);
            this.tbGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(132, 22);
            this.tbGiaBan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhà cung cấp";
            // 
            // cbbMaNhaCungCap
            // 
            this.cbbMaNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNhaCungCap.FormattingEnabled = true;
            this.cbbMaNhaCungCap.Location = new System.Drawing.Point(162, 144);
            this.cbbMaNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaNhaCungCap.Name = "cbbMaNhaCungCap";
            this.cbbMaNhaCungCap.Size = new System.Drawing.Size(130, 24);
            this.cbbMaNhaCungCap.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(29, 315);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(567, 247);
            this.gridView.TabIndex = 10;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(124, 276);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 26);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(271, 276);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 26);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(418, 276);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(80, 26);
            this.btCapNhat.TabIndex = 13;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "vnđ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "vnđ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Thể loại";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(418, 32);
            this.cbbTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(130, 24);
            this.cbbTheLoai.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nhà xuất bản";
            // 
            // cbbNhaXuatBan
            // 
            this.cbbNhaXuatBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhaXuatBan.FormattingEnabled = true;
            this.cbbNhaXuatBan.Location = new System.Drawing.Point(162, 190);
            this.cbbNhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhaXuatBan.Name = "cbbNhaXuatBan";
            this.cbbNhaXuatBan.Size = new System.Drawing.Size(130, 24);
            this.cbbNhaXuatBan.TabIndex = 21;
            // 
            // clbTacGia
            // 
            this.clbTacGia.FormattingEnabled = true;
            this.clbTacGia.Location = new System.Drawing.Point(418, 78);
            this.clbTacGia.Name = "clbTacGia";
            this.clbTacGia.Size = new System.Drawing.Size(157, 174);
            this.clbTacGia.TabIndex = 23;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(162, 238);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(132, 22);
            this.tbSoLuong.TabIndex = 24;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 586);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.clbTacGia);
            this.Controls.Add(this.cbbNhaXuatBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMaNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGiaMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ SÁCH [SÁCH]";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGiaMua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMaNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbNhaXuatBan;
        private System.Windows.Forms.CheckedListBox clbTacGia;
        private System.Windows.Forms.TextBox tbSoLuong;
    }
}

