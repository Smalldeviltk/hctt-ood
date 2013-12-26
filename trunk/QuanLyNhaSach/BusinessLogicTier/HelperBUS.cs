using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class HelperBUS
    {
        DAOHelper helper;
        public HelperBUS()
        {
            this.helper = new DAOHelper();
        }
        public SqlConnection GetConnect()
        {
            return helper.GetConnect();
        }
        public static void WriteFile(string server, string data, string uid, string pass)
        {
            DAOHelper.WriteFile(server, data, uid, pass);
        }
        public string GetAccount()
        {
            return this.helper.Server + " " + helper.Database + " " + helper.UserName + " " + helper.Password;
        }
    }
}
