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
    public class NhaXuatBanDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        public DataTable LaydsNhaXuatBan()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã xuất bản], Ten as [Tên nhà xuất bản], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], Email as [Email], GhiChu as [Ghi chú] FROM NHAXUATBAN";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public void Insert(NhaXuatBan info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into NhaXuatBan(id, Ten, DiaChi, DienThoai, Email, GhiChu ) values ('" + info.Id + "',N'" + info.Ten + "',N'" + info.DiaChi + "','" + info.DienThoai + "','" + info.Email + "',N'" + info.GhiChu + "')";
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
            sqlString = "DELETE FROM NHAXUATBAN WHERE id='" + id + "'";
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

        public void Update(NhaXuatBan info)
        {
            sqlString = "UPDATE NHAXUATBAN SET Ten=N'" + info.Ten +
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
            sqlString = "SELECT TOP 1 id FROM NHAXUATBAN ORDER BY id DESC";
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

    }
}
