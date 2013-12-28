namespace PresentationTier
{
    partial class frmTimSach
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
            this.panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btTimMoi = new System.Windows.Forms.Button();
            this.cbbDen = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTu = new System.Windows.Forms.ComboBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.btTimMoi);
            this.panel.Controls.Add(this.cbbDen);
            this.panel.Controls.Add(this.btTim);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.cbbTacGia);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.cbbTu);
            this.panel.Controls.Add(this.tbTen);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(202, 67);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(411, 244);
            this.panel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "vnđ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "vnđ";
            // 
            // btTimMoi
            // 
            this.btTimMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTimMoi.Location = new System.Drawing.Point(228, 200);
            this.btTimMoi.Name = "btTimMoi";
            this.btTimMoi.Size = new System.Drawing.Size(75, 30);
            this.btTimMoi.TabIndex = 15;
            this.btTimMoi.Text = "Tìm mới";
            this.btTimMoi.UseVisualStyleBackColor = true;
            this.btTimMoi.Click += new System.EventHandler(this.btTimMoi_Click);
            // 
            // cbbDen
            // 
            this.cbbDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDen.FormattingEnabled = true;
            this.cbbDen.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "70000",
            "80000",
            "90000",
            "100000",
            "120000",
            "150000",
            "200000",
            "400000",
            "500000",
            "600000",
            "700000",
            "800000",
            "900000",
            "1000000"});
            this.cbbDen.Location = new System.Drawing.Point(138, 151);
            this.cbbDen.Name = "cbbDen";
            this.cbbDen.Size = new System.Drawing.Size(165, 24);
            this.cbbDen.TabIndex = 14;
            this.cbbDen.SelectedIndexChanged += new System.EventHandler(this.cbbDen_SelectedIndexChanged);
            // 
            // btTim
            // 
            this.btTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTim.Location = new System.Drawing.Point(123, 200);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 30);
            this.btTim.TabIndex = 13;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "từ";
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbbTacGia.Location = new System.Drawing.Point(137, 67);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(166, 24);
            this.cbbTacGia.TabIndex = 9;
            this.cbbTacGia.SelectedIndexChanged += new System.EventHandler(this.cbbTacGia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "đến";
            // 
            // cbbTu
            // 
            this.cbbTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTu.FormattingEnabled = true;
            this.cbbTu.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "70000",
            "80000",
            "90000",
            "100000",
            "120000",
            "150000",
            "200000",
            "400000",
            "500000",
            "600000",
            "700000",
            "800000",
            "900000",
            "1000000"});
            this.cbbTu.Location = new System.Drawing.Point(137, 111);
            this.cbbTu.Name = "cbbTu";
            this.cbbTu.Size = new System.Drawing.Size(166, 24);
            this.cbbTu.TabIndex = 5;
            this.cbbTu.SelectedIndexChanged += new System.EventHandler(this.cbbTu_SelectedIndexChanged);
            // 
            // tbTen
            // 
            this.tbTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTen.Location = new System.Drawing.Point(137, 29);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(166, 22);
            this.tbTen.TabIndex = 3;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 318);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(796, 138);
            this.gridView.TabIndex = 2;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tìm kiếm sách";
            // 
            // frmTimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 468);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM SÁCH";
            this.Load += new System.EventHandler(this.frmTimSach_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTu;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.ComboBox cbbDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btTimMoi;
        private System.Windows.Forms.Label label8;
    }
}