using BusinessLogicTier;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class frmReport : Form
    {
        HelperBUS help = new HelperBUS();
        ReportClass rpt;
        DateTime tu, den;
        public frmReport(ReportClass _rpt,DateTime _tu,DateTime _den)
        {
            rpt = _rpt;
            tu = _tu;
            den = _den;
            InitializeComponent();
        }
        public DataTable dt;
        private void frmReport_Load(object sender, EventArgs e)
        {

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            string[] Account = help.GetAccount().Split(' ');
            crConnectionInfo.ServerName = Account[0];
            crConnectionInfo.DatabaseName = Account[1];
            crConnectionInfo.UserID = Account[2];
            object pwd = Account[3];
            crConnectionInfo.Password=(pwd.ToString());
            //---------Xét account truy cập vào các table
            CrTables = rpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            //----------set resource---------------

              rpt.SetParameterValue("tu",tu);
              rpt.SetParameterValue("den", den);
            cryRViewer.ReportSource = rpt;
            cryRViewer.Refresh();
        }       
    }
}
