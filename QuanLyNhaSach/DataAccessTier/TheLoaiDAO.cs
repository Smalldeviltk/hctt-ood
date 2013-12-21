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
    public class TheLoaiDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        public DataTable LaydsTheLoai()
        {
            dttable = new DataTable();
            cnn = helper.GetConnect();
            sqlString = " SELECT id as [Mã thể loại], Ten as [Tên thể loại] FROM THELOAI";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public void Insert(TheLoai info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into THELOAI(id, Ten) values ('" + info.Id + "',N'" + info.Ten +"')";
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
            sqlString = "DELETE FROM THELOAI WHERE id='" + id + "'";
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

        public void Update(TheLoai info)
        {
            sqlString = "UPDATE THELOAI SET Ten=N'" + info.Ten +
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
            sqlString = "SELECT TOP 1 id FROM THELOAI ORDER BY id DESC";
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
