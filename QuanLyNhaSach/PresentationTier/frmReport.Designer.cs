namespace PresentationTier
{
    partial class frmReport
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
            this.cryRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.cryRViewer.ActiveViewIndex = -1;
            this.cryRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRViewer.Location = new System.Drawing.Point(0, 0);
            this.cryRViewer.Name = "crystalReportViewer1";
            this.cryRViewer.Size = new System.Drawing.Size(287, 261);
            this.cryRViewer.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.cryRViewer);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryRViewer;

    }
}