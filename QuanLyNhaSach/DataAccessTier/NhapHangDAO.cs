﻿using System;
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
            string sql = "INSERT INTO PhieuNhap(MaNhanVien,TongTien,Ngay) VALUES(@MaNhanVien,@TongTien,@Ngay)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = cnn;
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
            string sql = "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap,MaSach,SoLuong) VALUES(@MaHoaDon,@MaSach,@SoLuong)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cnn = helper.GetConnect();
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@MaHoaDon", m.MaPhieuNhap);
            cmd.Parameters.AddWithValue("@MaSach", m.MaSach);
            cmd.Parameters.AddWithValue("@SoLuong", m.SoLuong);
            cmd.ExecuteNonQuery();
        }
    }
}
