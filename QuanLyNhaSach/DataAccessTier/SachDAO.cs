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
    public class SachDAO : DAOHelper
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
            sqlString = " SELECT id as [Mã sách], Ten as [Tên sách], GiaMua as [Giá mua], GiaBan as [Giá bán], MaNhaCungCap as [Mã nhà cung cấp], SoLuong as [Số lượng] FROM SACH";
            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

        public void Insert(Sach info)
        {
            cnn = helper.GetConnect();
            sqlString = "Insert into Sach(id, Ten, GiaMua, GiaBan, MaNhaCungCap, SoLuong ) values ('" + info.Id + "',N'" + info.TenSach + "','" + info.GiaMua + "','" + info.GiaBan + "','" + info.NhaCungCap + "','" + info.SoLuong + "')";

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

        //public void Update(Sach info)
        //{
        //    sqlString = "UPDATE SACH SET Ten='" + info.Ten +
        //        "',GiaMua='" + info.Giamua +
        //        "',GiaBan='" + info.Giaban +
        //        "',MaNhaCungCap='" + info.Manhacungcap +
        //        "',SoLuong='" + info.Soluong +
        //        "' WHERE id='" + info.Id + "'";
        //    cnn = helper.GetConnect();
        //    try
        //    {

        //        //Thực thi câu lệnh SQL
        //        cmd = new SqlCommand(sqlString, cnn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (System.Exception e)
        //    {
        //        cnn.Close();
        //        throw new Exception("Lỗi Kết Nối Cơ sở dữ liệu.");
        //    }
        //    cnn.Close();
        //}


        //public string LayMaMax()
        //{
        //    string mamax = "";

        //    cnn = getConnect();

        //    sqlString = "SELECT TOP 1 id FROM Sach ORDER BY id DESC";
        //    cmd = new SqlCommand(sqlString, cnn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        try
        //        {
        //            mamax = (dr["id"].ToString());

        //        }
        //        catch (System.Exception e)
        //        {
        //            cnn.Close();
        //            throw new Exception("Khong lay duoc ma max");
        //        }

        //    }
        //    cnn.Close();
        //    return mamax;
        //}
    }

}
