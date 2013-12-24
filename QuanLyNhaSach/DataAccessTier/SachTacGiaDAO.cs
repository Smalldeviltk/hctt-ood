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
    public class SachTacGiaDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();

        public void Insert(SachTacGia info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into SachTacGia(id, MaSach, MaTacGia) values ('" + info.Id + "',N'" + info.MaSach + "','" + info.MaTacGia + "')";
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

        public void Delete(string masach)
        {
            sqlString = "DELETE FROM SACHTACGIA WHERE MaSach='" + masach + "'";
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

        public void Update(SachTacGia info)
        {
            sqlString = "UPDATE SACHTACGIA SET MaTacGia='" + info.MaTacGia +
                "',MaSach='"+info.MaSach+
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

        public string LayMaTheoMaSach(string masach)
        {
            string ma = "";
            cnn = helper.GetConnect();
            sqlString = "  SELECT id FROM  SachTacGia where MaSach='"+masach+"'";
            cmd = new SqlCommand(sqlString, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    ma=(dr["id"].ToString());
                }
                catch (System.Exception e)
                {
                    cnn.Close();
                    throw new Exception("Khong add vao mang Array đc.");
                }
            }
            return ma;
        }

        public string LayMaMax()
        {
            string mamax = "";
            cnn = helper.GetConnect();
            sqlString = "SELECT TOP 1 id FROM SachTacGia ORDER BY id DESC";
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
