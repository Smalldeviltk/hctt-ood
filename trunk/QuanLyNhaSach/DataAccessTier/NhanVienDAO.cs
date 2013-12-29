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
    public class NhanVienDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        public DataTable LaydsNhanVien()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã nhân viên], Ten as [Tên nhân viên], NgaySinh as [Ngày sinh], CMND as [CMND], GioiTinh as [Giới tính], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email as [Email], UserName as [Tài khoản], PassWord as [Mật khẩu], Loai as [Loại] FROM NHANVIEN";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public void Insert(NhanVien info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into NhanVien(id, Ten, NgaySinh, CMND, GioiTinh, SoDienThoai, DiaChi, Email, UserName, PassWord, Loai ) values ('" + info.id + "',N'" + info.Ten + "','" + info.NgaySinh + "','" + info.CMND + "','" + info.GioiTinh + "','" + info.SoDienThoai + "','" + info.DiaChi + "','" + info.Email + "','" + info.Username + "','" + info.Password + "',N'" + info.Loai + "')";

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
            sqlString = "DELETE FROM NHANVIEN WHERE id='" + id + "'";
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

        public void Update(NhanVien info)
        {
            sqlString = "UPDATE NHANVIEN SET Ten=N'" + info.Ten +
                 "',NgaySinh='" + info.NgaySinh +
                 "',CMND='" + info.CMND +
                 "',GioiTinh=N'" + info.GioiTinh +
                 "',SoDienThoai='" + info.SoDienThoai +
                 "',DiaChi=N'" + info.DiaChi +
                 "',Email='" + info.Email +
                 "',UserName=N'" + info.Username +
                 "',PassWord=N'" + info.Password +
                 "',Loai=N'" + info.Loai +
                 "' WHERE id='" + info.id + "'";
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
            sqlString = "SELECT TOP 1 id FROM NHANVIEN ORDER BY id DESC";
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

        public DataTable TimTheoTen(string tennv)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã nhân viên], Ten as [Tên nhân viên], NgaySinh as [Ngày sinh], CMND as [CMND], GioiTinh as [Giới tính], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email as [Email], UserName as [Tài khoản], PassWord as [Mật khẩu], Loai as [Loại] FROM NHANVIEN where Ten LIKE N'" + tennv + "%'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimTheoCMND(string cmnd)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã nhân viên], Ten as [Tên nhân viên], NgaySinh as [Ngày sinh], CMND as [CMND], GioiTinh as [Giới tính], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email as [Email], UserName as [Tài khoản], PassWord as [Mật khẩu], Loai as [Loại] FROM NHANVIEN where CMND LIKE '" + cmnd + "%'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TimTheoNgaySinh(string ngaysinh)
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã nhân viên], Ten as [Tên nhân viên], NgaySinh as [Ngày sinh], CMND as [CMND], GioiTinh as [Giới tính], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email as [Email], UserName as [Tài khoản], PassWord as [Mật khẩu], Loai as [Loại] FROM NHANVIEN where NgaySinh LIKE '" + ngaysinh + "%'";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

        public DataTable login(string username, string password)
        {
            SqlConnection cn = helper.GetConnect();
            string sql = "SELECT * FROM NHANVIEN WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
