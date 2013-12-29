using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Collections;

namespace DataAccessTier
{
    public class PhieuNhapDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        public DataTable LaydsTheoNgay(DateTime tu, DateTime den)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = "SELECT * FROM PHIEUNHAP WHERE Ngay BETWEEN '" + tu.ToString("s").Substring(0, 10) + "' AND '" + den.ToString("s").Substring(0, 10) + "'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        
        public string LayMaMax()
        {
            string mamax = "";
            cnn = helper.GetConnect();   
            sqlString = "SELECT TOP 1 id FROM PHIEUNHAP ORDER BY id DESC";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    mamax = (dr["id"].ToString());

                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong lay duoc ma max");
                }
            }
            cnn.Close();
            return mamax;
        }
        public ArrayList LaydsMaSach()
        {
            ArrayList ds = new ArrayList();
            cnn = helper.GetConnect();
            string sql = "  SELECT MaSach FROM  CHITIETPHIEUNHAP";
            cmd = new SqlCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ds.Add(dr["MaSach"].ToString());
                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong add vao mang Array đc.");
                }
            }
            return ds;
        }

    }
}
