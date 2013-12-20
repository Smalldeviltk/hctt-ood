namespace PresentationTier
{
    partial class frmMain
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
            this.btTacGia = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btNhaCungCap = new System.Windows.Forms.Button();
            this.btNhaXuatBan = new System.Windows.Forms.Button();
            this.btSach = new System.Windows.Forms.Button();
            this.btTheLoai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTacGia
            // 
            this.btTacGia.Location = new System.Drawing.Point(24, 246);
            this.btTacGia.Name = "btTacGia";
            this.btTacGia.Size = new System.Drawing.Size(79, 33);
            this.btTacGia.TabIndex = 0;
            this.btTacGia.Text = "Tác giả";
            this.btTacGia.UseVisualStyleBackColor = true;
            this.btTacGia.Click += new System.EventHandler(this.btTacGia_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(109, 246);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(79, 33);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btNhaCungCap
            // 
            this.btNhaCungCap.Location = new System.Drawing.Point(194, 246);
            this.btNhaCungCap.Name = "btNhaCungCap";
            this.btNhaCungCap.Size = new System.Drawing.Size(87, 33);
            this.btNhaCungCap.TabIndex = 2;
            this.btNhaCungCap.Text = "Nhà cung cấp";
            this.btNhaCungCap.UseVisualStyleBackColor = true;
            this.btNhaCungCap.Click += new System.EventHandler(this.btNhaCungCap_Click);
            // 
            // btNhaXuatBan
            // 
            this.btNhaXuatBan.Location = new System.Drawing.Point(287, 246);
            this.btNhaXuatBan.Name = "btNhaXuatBan";
            this.btNhaXuatBan.Size = new System.Drawing.Size(87, 33);
            this.btNhaXuatBan.TabIndex = 3;
            this.btNhaXuatBan.Text = "Nhà xuất bản";
            this.btNhaXuatBan.UseVisualStyleBackColor = true;
            this.btNhaXuatBan.Click += new System.EventHandler(this.btNhaXuatBan_Click);
            // 
            // btSach
            // 
            this.btSach.Location = new System.Drawing.Point(380, 246);
            this.btSach.Name = "btSach";
            this.btSach.Size = new System.Drawing.Size(87, 33);
            this.btSach.TabIndex = 4;
            this.btSach.Text = "Sách";
            this.btSach.UseVisualStyleBackColor = true;
            // 
            // btTheLoai
            // 
            this.btTheLoai.Location = new System.Drawing.Point(473, 246);
            this.btTheLoai.Name = "btTheLoai";
            this.btTheLoai.Size = new System.Drawing.Size(87, 33);
            this.btTheLoai.TabIndex = 5;
            this.btTheLoai.Text = "Thể loại";
            this.btTheLoai.UseVisualStyleBackColor = true;
            this.btTheLoai.Click += new System.EventHandler(this.btTheLoai_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 291);
            this.Controls.Add(this.btTheLoai);
            this.Controls.Add(this.btSach);
            this.Controls.Add(this.btNhaXuatBan);
            this.Controls.Add(this.btNhaCungCap);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.btTacGia);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTacGia;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btNhaCungCap;
        private System.Windows.Forms.Button btNhaXuatBan;
        private System.Windows.Forms.Button btSach;
        private System.Windows.Forms.Button btTheLoai;


    }
}

