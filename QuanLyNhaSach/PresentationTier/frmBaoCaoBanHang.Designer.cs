﻿namespace PresentationTier
{
    partial class frmBaoCaoBanHang
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
            this.btXemThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến ngày";
            // 
            // dtpNNDen
            // 
            this.dtpNNDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNDen.Location = new System.Drawing.Point(201, 111);
            this.dtpNNDen.Name = "dtpNNDen";
            this.dtpNNDen.Size = new System.Drawing.Size(91, 20);
            this.dtpNNDen.TabIndex = 8;
            this.dtpNNDen.ValueChanged += new System.EventHandler(this.dtpNNDen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpNNTu
            // 
            this.dtpNNTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNTu.Location = new System.Drawing.Point(201, 34);
            this.dtpNNTu.Name = "dtpNNTu";
            this.dtpNNTu.Size = new System.Drawing.Size(91, 20);
            this.dtpNNTu.TabIndex = 6;
            this.dtpNNTu.ValueChanged += new System.EventHandler(this.dtpNNTu_ValueChanged);
            // 
            // btXemThongKe
            // 
            this.btXemThongKe.Location = new System.Drawing.Point(124, 180);
            this.btXemThongKe.Name = "btXemThongKe";
            this.btXemThongKe.Size = new System.Drawing.Size(168, 23);
            this.btXemThongKe.TabIndex = 5;
            this.btXemThongKe.Text = "Xem thống kê";
            this.btXemThongKe.UseVisualStyleBackColor = true;
            this.btXemThongKe.Click += new System.EventHandler(this.btXemThongKe_Click);
            // 
            // frmBaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNNDen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNNTu);
            this.Controls.Add(this.btXemThongKe);
            this.Name = "frmBaoCaoBanHang";
            this.Text = "frmBaoCaoBanHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNNDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNNTu;
        private System.Windows.Forms.Button btXemThongKe;
    }
}