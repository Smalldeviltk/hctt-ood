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
    public class BanHangDAO
    {
        private static SqlDataAdapter da;
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static string sql;
        private static DataTable dt;
        static DAOHelper helper = new DAOHelper();

        public DataTable TimSach(string str)
        {
            sql = "SELECT Results.id, Results.Ten, REPLACE(REPLACE(REPLACE((SELECT CAST(TACGIA.Ten AS NVARCHAR(MAX)) AS Expr1 FROM SACHTACGIA INNER JOIN TACGIA ON SACHTACGIA.MaTacGia = TACGIA.id WHERE (SACHTACGIA.MaSach = Results.id) FOR XML PATH('')), '</Expr1><Expr1>', ', '), '<Expr1>', ''), '</Expr1>', '') AS TacGia, Results.GiaBan,Results.SoLuong FROM SACH AS Results INNER JOIN NHACUNGCAP ON Results.MaNhaCungCap = NHACUNGCAP.id WHERE Results.Ten like '%" +
            str + "%' GROUP BY Results.id, Results.Ten, Results.GiaBan, Results.SoLuong";
            da = new SqlDataAdapter(sql, helper.GetConnect());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int insertHoaDon(HoaDon m)
        {
            sql = "INSERT INTO HoaDon(MaNhanVien,TongTien,Ngay) VALUES(@MaNhanVien,@TongTien,@Ngay)";
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = helper.GetConnect();
            cmd.Parameters.AddWithValue("@MaNhanVien", m.MaNhanVien);
            cmd.Parameters.AddWithValue("@TongTien", m.TongTien);
            cmd.Parameters.AddWithValue("@Ngay", m.Ngay);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT @@IDENTITY";
            int insertID = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            cmd = null;

            return insertID;
        }
        public void updateSoLuongSach(string MaSach, string SoLuong)
        {
            sql = "update SACH set SoLuong=SoLuong-@SoLuong where id=@id";
            SqlCommand scmd = new SqlCommand(sql, helper.GetConnect());
            scmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            scmd.Parameters.AddWithValue("@id", MaSach);
            scmd.ExecuteNonQuery();
        }
        public void insertChiTietHoaDon(ChiTietHoaDon m)
        {
            sql = "INSERT INTO ChiTietHoaDon(MaHoaDon,MaSach,SoLuong) VALUES(@MaHoaDon,@MaSach,@SoLuong)";
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = helper.GetConnect();
            cmd.Parameters.AddWithValue("@MaHoaDon", m.MaHoaDon);
            cmd.Parameters.AddWithValue("@MaSach", m.MaSach);
            cmd.Parameters.AddWithValue("@SoLuong", m.SoLuong);
            cmd.ExecuteNonQuery();
        }
    }
}
