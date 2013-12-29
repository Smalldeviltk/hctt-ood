namespace PresentationTier
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến ngày";
            // 
            // dtpNNDen
            // 
            this.dtpNNDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNNDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNDen.Location = new System.Drawing.Point(304, 111);
            this.dtpNNDen.Name = "dtpNNDen";
            this.dtpNNDen.Size = new System.Drawing.Size(91, 20);
            this.dtpNNDen.TabIndex = 8;
            this.dtpNNDen.ValueChanged += new System.EventHandler(this.dtpNNDen_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpNNTu
            // 
            this.dtpNNTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNNTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNTu.Location = new System.Drawing.Point(304, 68);
            this.dtpNNTu.Name = "dtpNNTu";
            this.dtpNNTu.Size = new System.Drawing.Size(91, 20);
            this.dtpNNTu.TabIndex = 6;
            this.dtpNNTu.ValueChanged += new System.EventHandler(this.dtpNNTu_ValueChanged);
            // 
            // btXemThongKe
            // 
            this.btXemThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXemThongKe.Location = new System.Drawing.Point(227, 158);
            this.btXemThongKe.Name = "btXemThongKe";
            this.btXemThongKe.Size = new System.Drawing.Size(168, 23);
            this.btXemThongKe.TabIndex = 5;
            this.btXemThongKe.Text = "Xem thống kê";
            this.btXemThongKe.UseVisualStyleBackColor = true;
            this.btXemThongKe.Click += new System.EventHandler(this.btXemThongKe_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(54, 198);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(510, 238);
            this.dgvThongKe.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(227, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "In thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(189, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "Báo Cáo Bán Hàng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(616, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNNDen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNNTu);
            this.Controls.Add(this.btXemThongKe);
            this.Name = "frmBaoCaoBanHang";
            this.Text = "frmBaoCaoBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNNDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNNTu;
        private System.Windows.Forms.Button btXemThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}