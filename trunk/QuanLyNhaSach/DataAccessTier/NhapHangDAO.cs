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
    public class NhapHangDAO
    {
        private static SqlConnection cnn;
        private static SqlDataReader dr;
        private SqlCommand cmd;
        static DAOHelper helper = new DAOHelper();
        public static DataTable TimSach(string str)
        {
            cnn = helper.GetConnect();
            string sql = "SELECT Results.id, Results.Ten, REPLACE(REPLACE(REPLACE((SELECT CAST(TACGIA.Ten AS NVARCHAR(MAX)) AS Expr1 FROM SACHTACGIA INNER JOIN TACGIA ON SACHTACGIA.MaTacGia = TACGIA.id WHERE (SACHTACGIA.MaSach = Results.id) FOR XML PATH('')), '</Expr1><Expr1>', ', '), '<Expr1>', ''), '</Expr1>', '') AS TacGia, Results.GiaMua, Results.SoLuong FROM SACH AS Results INNER JOIN NHACUNGCAP ON Results.MaNhaCungCap = NHACUNGCAP.id WHERE Results.Ten like '%" +
            str + "%' GROUP BY Results.id, Results.Ten, Results.GiaMua, Results.SoLuong";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static int insertPhieuNhap(PhieuNhap m)
        {
            cnn = helper.GetConnect();
            string sql = "INSERT INTO PhieuNhap(id,MaNhanVien,TongTien,Ngay) VALUES(@id,@MaNhanVien,@TongTien,@Ngay)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.Parameters.AddWithValue("@MaNhanVien", m.MaNhanVien);
            cmd.Parameters.AddWithValue("@TongTien", m.TongTien);
            DateTime date = Convert.ToDateTime(m.Ngay);
            cmd.Parameters.AddWithValue("@Ngay", date);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT @@IDENTITY";
            //int insertID = Convert.ToInt32(cmd.ExecuteScalar());
            int insertID = 1;
            cmd.Dispose();
            cmd = null;

            return insertID;
        }

        public static string LayMaMax()
        {
            string mamax = "";
            cnn = helper.GetConnect();
            string sql = "SELECT TOP 1 id FROM PHIEUNHAP ORDER BY id DESC";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(sql, cnn);
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

        public static string LayMaMaxCT()
        {
            string mamax = "";
            cnn = helper.GetConnect();
            string sql = "SELECT TOP 1 id FROM CHITIETPHIEUNHAP ORDER BY id DESC";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(sql, cnn);
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

        public static void updateSoLuongSach(string MaSach, string SoLuong)
        {
            string sql = "update SACH set SoLuong=SoLuong+@SoLuong where id=@id";
            cnn = helper.GetConnect();
            SqlCommand scmd = new SqlCommand(sql, cnn);
            scmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            scmd.Parameters.AddWithValue("@id", MaSach);
            scmd.ExecuteNonQuery();
        }
        public static void insertChiTietPhieuNhap(ChiTietPhieuNhap m)
        {
            string sql = "INSERT INTO ChiTietPhieuNhap(id,MaPhieuNhap,MaSach,SoLuong) VALUES(@id,@MaHoaDon,@MaSach,@SoLuong)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cnn = helper.GetConnect();
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", m.Id);
            cmd.Parameters.AddWithValue("@MaHoaDon", m.MaPhieuNhap);
            cmd.Parameters.AddWithValue("@MaSach", m.MaSach);
            cmd.Parameters.AddWithValue("@SoLuong", m.SoLuong);
            cmd.ExecuteNonQuery();
        }

        
    }
}
