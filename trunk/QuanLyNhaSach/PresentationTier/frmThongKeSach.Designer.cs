namespace PresentationTier
{
    partial class frmThongKeSach
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNNDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNNTu = new System.Windows.Forms.DateTimePicker();
            this.btTTLoai = new System.Windows.Forms.Button();
            this.btTTDe = new System.Windows.Forms.Button();
            this.btTNVien = new System.Windows.Forms.Button();
            this.btNCC = new System.Windows.Forms.Button();
            this.btNXB = new System.Windows.Forms.Button();
            this.rdNhap = new System.Windows.Forms.RadioButton();
            this.rdXuat = new System.Windows.Forms.RadioButton();
            this.btTTGia = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày";
            // 
            // dtpNNDen
            // 
            this.dtpNNDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNNDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNDen.Location = new System.Drawing.Point(421, 53);
            this.dtpNNDen.Name = "dtpNNDen";
            this.dtpNNDen.Size = new System.Drawing.Size(91, 20);
            this.dtpNNDen.TabIndex = 12;
            this.dtpNNDen.ValueChanged += new System.EventHandler(this.dtpNNDen_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpNNTu
            // 
            this.dtpNNTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNNTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNTu.Location = new System.Drawing.Point(158, 53);
            this.dtpNNTu.Name = "dtpNNTu";
            this.dtpNNTu.Size = new System.Drawing.Size(91, 20);
            this.dtpNNTu.TabIndex = 10;
            this.dtpNNTu.ValueChanged += new System.EventHandler(this.dtpNNTu_ValueChanged);
            // 
            // btTTLoai
            // 
            this.btTTLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTTLoai.Location = new System.Drawing.Point(119, 120);
            this.btTTLoai.Name = "btTTLoai";
            this.btTTLoai.Size = new System.Drawing.Size(122, 23);
            this.btTTLoai.TabIndex = 14;
            this.btTTLoai.Text = "Theo thể loại";
            this.btTTLoai.UseVisualStyleBackColor = true;
            this.btTTLoai.Click += new System.EventHandler(this.btTTLoai_Click);
            // 
            // btTTDe
            // 
            this.btTTDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTTDe.Location = new System.Drawing.Point(279, 120);
            this.btTTDe.Name = "btTTDe";
            this.btTTDe.Size = new System.Drawing.Size(122, 23);
            this.btTTDe.TabIndex = 15;
            this.btTTDe.Text = "Theo tựa đề";
            this.btTTDe.UseVisualStyleBackColor = true;
            this.btTTDe.Click += new System.EventHandler(this.btTTDe_Click);
            // 
            // btTNVien
            // 
            this.btTNVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTNVien.Location = new System.Drawing.Point(446, 120);
            this.btTNVien.Name = "btTNVien";
            this.btTNVien.Size = new System.Drawing.Size(122, 23);
            this.btTNVien.TabIndex = 16;
            this.btTNVien.Text = "Theo Nhân Viên";
            this.btTNVien.UseVisualStyleBackColor = true;
            this.btTNVien.Click += new System.EventHandler(this.btTNVien_Click);
            // 
            // btNCC
            // 
            this.btNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNCC.Location = new System.Drawing.Point(119, 169);
            this.btNCC.Name = "btNCC";
            this.btNCC.Size = new System.Drawing.Size(122, 23);
            this.btNCC.TabIndex = 17;
            this.btNCC.Text = "Theo Nhà Cung Cấp";
            this.btNCC.UseVisualStyleBackColor = true;
            this.btNCC.Click += new System.EventHandler(this.btNCC_Click);
            // 
            // btNXB
            // 
            this.btNXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNXB.Location = new System.Drawing.Point(279, 169);
            this.btNXB.Name = "btNXB";
            this.btNXB.Size = new System.Drawing.Size(122, 23);
            this.btNXB.TabIndex = 18;
            this.btNXB.Text = "Theo Nhà Xuất Bản";
            this.btNXB.UseVisualStyleBackColor = true;
            this.btNXB.Click += new System.EventHandler(this.btNXB_Click);
            // 
            // rdNhap
            // 
            this.rdNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdNhap.AutoSize = true;
            this.rdNhap.Checked = true;
            this.rdNhap.Location = new System.Drawing.Point(229, 88);
            this.rdNhap.Name = "rdNhap";
            this.rdNhap.Size = new System.Drawing.Size(51, 17);
            this.rdNhap.TabIndex = 19;
            this.rdNhap.TabStop = true;
            this.rdNhap.Text = "Nhập";
            this.rdNhap.UseVisualStyleBackColor = true;
            // 
            // rdXuat
            // 
            this.rdXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdXuat.AutoSize = true;
            this.rdXuat.Location = new System.Drawing.Point(324, 88);
            this.rdXuat.Name = "rdXuat";
            this.rdXuat.Size = new System.Drawing.Size(47, 17);
            this.rdXuat.TabIndex = 20;
            this.rdXuat.TabStop = true;
            this.rdXuat.Text = "Xuất";
            this.rdXuat.UseVisualStyleBackColor = true;
            // 
            // btTTGia
            // 
            this.btTTGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTTGia.Location = new System.Drawing.Point(446, 169);
            this.btTTGia.Name = "btTTGia";
            this.btTTGia.Size = new System.Drawing.Size(122, 23);
            this.btTTGia.TabIndex = 21;
            this.btTTGia.Text = "Theo Tác giả";
            this.btTTGia.UseVisualStyleBackColor = true;
            this.btTTGia.Click += new System.EventHandler(this.btTTGia_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(63, 220);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(532, 243);
            this.dgvThongKe.TabIndex = 22;
            // 
            // btIn
            // 
            this.btIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btIn.Location = new System.Drawing.Point(257, 481);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(122, 23);
            this.btIn.TabIndex = 23;
            this.btIn.Text = "In thống kê";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Thống kê";
            // 
            // frmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btTTGia);
            this.Controls.Add(this.rdXuat);
            this.Controls.Add(this.rdNhap);
            this.Controls.Add(this.btNXB);
            this.Controls.Add(this.btNCC);
            this.Controls.Add(this.btTNVien);
            this.Controls.Add(this.btTTDe);
            this.Controls.Add(this.btTTLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNNDen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNNTu);
            this.Name = "frmThongKeSach";
            this.Text = "frmThongKeSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNNDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNNTu;
        private System.Windows.Forms.Button btTTLoai;
        private System.Windows.Forms.Button btTTDe;
        private System.Windows.Forms.Button btTNVien;
        private System.Windows.Forms.Button btNCC;
        private System.Windows.Forms.Button btNXB;
        private System.Windows.Forms.RadioButton rdNhap;
        private System.Windows.Forms.RadioButton rdXuat;
        private System.Windows.Forms.Button btTTGia;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Label label3;
    }
}