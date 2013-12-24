using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessTier
{
    class sqlDB
    {
        //private static string _connectionString = "Data Source=TIEUTINH-PC;AttachDbFilename=D:\\NhaSach\\NhaSach.mdf;Integrated Security=True";
        //private static string _connectionString = "Data Source=;AttachDbFilename=NHASACH;Integrated Security=True;User Instance=True";
        private static string _connectionString = "Server = SMALLDEVIL; Database = NHASACH; User Id = sa; Password = 123456";

        private static SqlConnection _myConnection = new SqlConnection(_connectionString);

        public static SqlConnection MyConnection
        {
            get { return _myConnection; }
            set { _myConnection = value; }
        }

        public static void connectDB()
        {
            _myConnection.Open();
        }

        public static void closeDB()
        {
            _myConnection.Close();
        }
    }
}
