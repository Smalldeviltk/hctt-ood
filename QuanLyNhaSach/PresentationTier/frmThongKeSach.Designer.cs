﻿namespace PresentationTier
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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày";
            // 
            // dtpNNDen
            // 
            this.dtpNNDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNDen.Location = new System.Drawing.Point(479, 32);
            this.dtpNNDen.Name = "dtpNNDen";
            this.dtpNNDen.Size = new System.Drawing.Size(91, 20);
            this.dtpNNDen.TabIndex = 12;
            this.dtpNNDen.ValueChanged += new System.EventHandler(this.dtpNNDen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpNNTu
            // 
            this.dtpNNTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNTu.Location = new System.Drawing.Point(162, 32);
            this.dtpNNTu.Name = "dtpNNTu";
            this.dtpNNTu.Size = new System.Drawing.Size(91, 20);
            this.dtpNNTu.TabIndex = 10;
            this.dtpNNTu.ValueChanged += new System.EventHandler(this.dtpNNTu_ValueChanged);
            // 
            // btTTLoai
            // 
            this.btTTLoai.Location = new System.Drawing.Point(120, 223);
            this.btTTLoai.Name = "btTTLoai";
            this.btTTLoai.Size = new System.Drawing.Size(122, 23);
            this.btTTLoai.TabIndex = 14;
            this.btTTLoai.Text = "Theo thể loại";
            this.btTTLoai.UseVisualStyleBackColor = true;
            this.btTTLoai.Click += new System.EventHandler(this.btTTLoai_Click);
            // 
            // btTTDe
            // 
            this.btTTDe.Location = new System.Drawing.Point(280, 223);
            this.btTTDe.Name = "btTTDe";
            this.btTTDe.Size = new System.Drawing.Size(122, 23);
            this.btTTDe.TabIndex = 15;
            this.btTTDe.Text = "Theo tựa đề";
            this.btTTDe.UseVisualStyleBackColor = true;
            // 
            // btTNVien
            // 
            this.btTNVien.Location = new System.Drawing.Point(447, 223);
            this.btTNVien.Name = "btTNVien";
            this.btTNVien.Size = new System.Drawing.Size(122, 23);
            this.btTNVien.TabIndex = 16;
            this.btTNVien.Text = "Theo Nhân Viên";
            this.btTNVien.UseVisualStyleBackColor = true;
            // 
            // btNCC
            // 
            this.btNCC.Location = new System.Drawing.Point(159, 300);
            this.btNCC.Name = "btNCC";
            this.btNCC.Size = new System.Drawing.Size(122, 23);
            this.btNCC.TabIndex = 17;
            this.btNCC.Text = "Theo Nhà Cung Cấp";
            this.btNCC.UseVisualStyleBackColor = true;
            // 
            // btNXB
            // 
            this.btNXB.Location = new System.Drawing.Point(340, 300);
            this.btNXB.Name = "btNXB";
            this.btNXB.Size = new System.Drawing.Size(122, 23);
            this.btNXB.TabIndex = 18;
            this.btNXB.Text = "Theo Nhà Xuất Bản";
            this.btNXB.UseVisualStyleBackColor = true;
            // 
            // rdNhap
            // 
            this.rdNhap.AutoSize = true;
            this.rdNhap.Checked = true;
            this.rdNhap.Location = new System.Drawing.Point(121, 89);
            this.rdNhap.Name = "rdNhap";
            this.rdNhap.Size = new System.Drawing.Size(51, 17);
            this.rdNhap.TabIndex = 19;
            this.rdNhap.TabStop = true;
            this.rdNhap.Text = "Nhập";
            this.rdNhap.UseVisualStyleBackColor = true;
            // 
            // rdXuat
            // 
            this.rdXuat.AutoSize = true;
            this.rdXuat.Location = new System.Drawing.Point(216, 89);
            this.rdXuat.Name = "rdXuat";
            this.rdXuat.Size = new System.Drawing.Size(47, 17);
            this.rdXuat.TabIndex = 20;
            this.rdXuat.TabStop = true;
            this.rdXuat.Text = "Xuất";
            this.rdXuat.UseVisualStyleBackColor = true;
            // 
            // frmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 377);
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
    }
}