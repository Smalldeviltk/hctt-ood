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
    public class SachDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();

        public DataTable LaydsSach()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua],"
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s"
            + ", TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

        public ArrayList LaydsMa()
        {
            ArrayList ds = new ArrayList();
            cnn = helper.GetConnect();
            sqlString = "  SELECT id FROM  Sach ";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ds.Add(dr["id"].ToString());
                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong add vao mang Array đc.");
                }
            }
            return ds;
        }

        public void Insert(Sach info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into Sach(id, Ten, GiaMua, GiaBan, MaNhaCungCap, SoLuong, MaTheLoai, MaNhaXuatBan ) "
            + "values ('" + info.Id + "',N'" + info.TenSach + "','" + info.GiaMua + "','" + info.GiaBan + "','" + info.NhaCungCap + "','" + info.SoLuong + "','" + info.TheLoai + "','" + info.NhaXuatBan + "')";
            try
            {

                //Thực thi câu lệnh SQL
                cmd = new SqlCommand(sqlString, cnn);
                cmd.ExecuteNonQuery();

            }
            catch (System.Exception e)
            {
                cnn.Close();
                throw new Exception("Lỗi Kết Nối Cơ sở dữ liệu.");
            }
            cnn.Close();

        }

        public void Delete(string id)
        {
            sqlString = "DELETE FROM SACH WHERE id='" + id + "'";
            cnn = helper.GetConnect();
            try
            {

                //Thực thi câu lệnh SQL
                cmd = new SqlCommand(sqlString, cnn);
                cmd.ExecuteNonQuery();


            }
            catch (System.Exception e)
            {
                cnn.Close();
                throw new Exception("Lỗi Kết Nối Cơ sở dữ liệu.");
            }
            cnn.Close();

        }

        public void Update(Sach info)
        {
            sqlString = "UPDATE SACH SET Ten=N'" + info.TenSach +
                "',GiaMua='" + info.GiaMua +
                "',GiaBan='" + info.GiaBan +
                "',MaNhaCungCap='" + info.NhaCungCap +
                "',SoLuong='" + info.SoLuong +
                "',MaTheLoai='" + info.TheLoai +
                "',MaNhaXuatBan='" + info.NhaXuatBan +
                "' WHERE id='" + info.Id + "'";
            cnn = helper.GetConnect();
            try
            {

                //Thực thi câu lệnh SQL
                cmd = new SqlCommand(sqlString, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                cnn.Close();
                throw new Exception("Lỗi Kết Nối Cơ sở dữ liệu.");
            }
            cnn.Close();
        }

        public string LayMaMax()
        {
            string mamax = "";
            cnn = helper.GetConnect();
            sqlString = "SELECT TOP 1 id FROM Sach ORDER BY id DESC";
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

        public DataTable TimSachTheoTen(string tensach)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua],"
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s"
            + ", TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and s.Ten LIKE '" + tensach + "%'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimSachTheoGiaBanTrongKhoang(string giatu, string giaden)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua],"
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s"
            + ", TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and s.GiaBan>= '" + giatu + "' and s.GiaBan<= '"+giaden+"'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimSachTheoGiaBanTu(string gia)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua],"
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s"
            + ", TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and s.GiaBan>= '" + gia + "'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimSachTheoGiaBanDen(string gia)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua],"
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s"
            + ", TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and s.GiaBan<= '" + gia + "'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimSachTheoTacGia(string matacgia)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua], "
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s, "
            + "TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb, SachTacGia stg "
            + "where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and stg.MaSach=s.id and stg.MaTacGia='" + matacgia + "'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimSachTheoTenVaTacGia(string matacgia, string tensach)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT s.id as [Mã sách], s.Ten as [Tên Sách], tl.Ten as [Thể Loại], s.GiaMua as [Giá mua], "
            + "s.GiaBan as [Giá Bán], s.SoLuong as [Số lượng], ncc.Ten as [Nhà cung cấp], nxb.Ten as [Nhà xuất bản] FROM SACH s, "
            + "TheLoai tl, NhaCungCap ncc, NhaXuatBan nxb, SachTacGia stg "
            + "where s.MaTheLoai=tl.id and s.MaNhaCungCap=ncc.id and s.MaNhaXuatBan=nxb.id and stg.MaSach=s.id and stg.MaTacGia='" + matacgia + "'and s.Ten='"+tensach+"'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }


    }

}
