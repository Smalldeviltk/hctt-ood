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
    public class TacGiaDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        public DataTable LaydsTacGia()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã tác giả], Ten as [Tên tác giả], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], Email as [Email], GhiChu as [Ghi chú] FROM TACGIA";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable LayTacGiaTheoSach()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = "select tg.Ten from TACGIA tg, SACHTACGIA stg, SACH s  where tg.id=stg.MaTacGia and s.id = stg.MaSach";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public void Insert(TacGia info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into TacGia(id, Ten, DiaChi, DienThoai, Email, GhiChu ) values ('" + info.Id + "',N'" + info.Ten + "',N'" + info.DiaChi + "','" + info.DienThoai + "','" + info.Email + "',N'" + info.GhiChu + "')";
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
            sqlString = "DELETE FROM TACGIA WHERE id='" + id + "'";
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

        public void Update(TacGia info)
        {
            sqlString = "UPDATE TACGIA SET Ten=N'" + info.Ten +
                "',DiaChi=N'" + info.DiaChi +
                "',DienThoai='" + info.DienThoai +
                "',Email='" + info.Email +
                "',GhiChu=N'" + info.GhiChu +
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
            sqlString = "SELECT TOP 1 id FROM TACGIA ORDER BY id DESC";
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
        public ArrayList LaydsTen()
        {
            ArrayList ds = new ArrayList();
            cnn = helper.GetConnect();
            sqlString = "  SELECT TEN FROM  TACGIA ";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ds.Add(dr["Ten"].ToString());
                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong add vao mang Array đc.");
                }
            }
            return ds;
        }

        public ArrayList LayTacGiaTheoSach(string masach)
        {
            ArrayList ds = new ArrayList();
            cnn = helper.GetConnect();
            sqlString = "select tg.Ten from TACGIA tg, SACHTACGIA stg where tg.id=stg.MaTacGia and stg.MaSach='" + masach + "'";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ds.Add(dr["Ten"].ToString());
                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong add vao mang Array đc.");
                }
            }
            return ds;
        }

        public string LayMaTheoTen(string ten)
        {
            string ma = "";
            cnn = helper.GetConnect();
            sqlString = "SELECT id from TacGia where Ten=N'" + ten + "'";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ma = (dr["id"].ToString());

                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong lay duoc ma max");
                }

            }
            cnn.Close();
            return ma;
        }
    }
}
