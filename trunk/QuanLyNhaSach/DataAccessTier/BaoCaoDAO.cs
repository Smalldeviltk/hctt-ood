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
    public class BaoCaoDAO
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;


        private string sqlString;
        private DataTable dttable;
        DAOHelper helper = new DAOHelper();
        /*Thể loại*/

        public DataTable TheoTheLoai_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select tl.ten as [Tên thể loại],s.ten as [Tên],s.Giamua as [Giá mua],pn.ngay as [Ngày nhập], sum(ct.soluong) as [Số lượng] from phieunhap pn inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap inner join sach s on s.id = ct.masach inner join theloai tl on tl.id = s.matheloai	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tl.ten,s.ten,s.Giamua,pn.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoTheLoai_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select tl.ten as [Tên thể loại],s.ten as [Tên],s.Giaban as [Giá bán],hd.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng] 	from hoadon hd	inner join CHITIEThoadon ct on hd.id = ct.Mahoadon	inner join sach s on s.id = ct.masach	inner join theloai tl on tl.id = s.matheloai	where hd.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tl.ten,s.ten,s.Giaban,hd.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        /*Tác giả*/

        public DataTable TheoTacGia_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select tg.ten as [Tên tác giả],s.ten as [Tên sách],s.Giaban as [Giá bán],hd.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng] 	from hoadon hd	inner join CHITIEThoadon ct on hd.id = ct.Mahoadon	inner join sach s on s.id = ct.masach	inner join SACHTACGIA stg on s.id = stg.MaSach	inner join tacgia tg on tg.id = stg.matacgia	where hd.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tg.ten,s.ten,s.Giaban,hd.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoTacGia_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select tg.ten as [Tên tác giả],s.ten as [Tên sách],s.Giamua as [Giá mua],pn.ngay as [Ngày mua], sum(ct.soluong) as [Số lượng] 	from phieunhap pn	inner join CHITIETphieunhap ct on pn.id = ct.Maphieunhap	inner join sach s on s.id = ct.masach	inner join SACHTACGIA stg on s.id = stg.MaSach	inner join tacgia tg on tg.id = stg.matacgia	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tg.ten,s.ten,s.Giamua,pn.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

        /*nhà cung cấp*/

        public DataTable TheoNCC_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select ncc.ten as [Tên nhà cung cấp],s.ten as [Tên sách],s.Giaban as [Giá bán],pn.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng] from phieunhap pn	inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap	inner join sach s on s.id = ct.masach	inner join nhacungcap ncc on ncc.id = s.MaNhaCungCap	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by ncc.ten,s.ten,s.Giaban,pn.ngay";

            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoNCC_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select ncc.ten as [Tên nhà cung cấp],s.ten as [Tên sách],s.Giamua as [Giá mua],pn.ngay as [Ngày nhập], sum(ct.soluong) as [Số lượng] from phieunhap pn	inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap	inner join sach s on s.id = ct.masach	inner join nhacungcap ncc on ncc.id = s.MaNhaCungCap	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by ncc.ten,s.ten,s.Giamua,pn.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        /*nhà xuất bản*/

        public DataTable TheoNXB_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select nxb.ten as [Tên nhà xuất bản],s.ten as [Tên sách],s.Giaban as [Giá bán],pn.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng] from phieunhap pn	inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap	inner join sach s on s.id = ct.masach	inner join nhaxuatban nxb on nxb.id = s.Manhaxuatban	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by nxb.ten,s.ten,s.Giaban,pn.ngay";

            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoNXB_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select nxb.ten as [Tên nhà xuất bản],s.ten as [Tên sách],s.Giamua as [Giá mua],pn.ngay as [Ngày nhập], sum(ct.soluong) as [Số lượng] from phieunhap pn	inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap	inner join sach s on s.id = ct.masach	inner join nhaxuatban nxb on nxb.id = s.Manhaxuatban	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by nxb.ten,s.ten,s.Giamua,pn.ngay";

            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

        /*nhân viên*/

        public DataTable TheoNhanVien_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select nv.ten as [Tên nhân viên],hd.id as [Mã hóa đơn],hd.ngay as [Ngày mua], hd.TongTien as [Tổng tiền bán] from hoadon hd	inner join nhanvien nv on nv.id = hd.MaNhanVien	where hd.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoNhanVien_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select nv.ten as [Tên nhân viên],pn.id as [Mã phiếu nhập],pn.ngay as [Ngày nhập], pn.TongTien as [Tổng tiền nhập] from phieunhap pn inner join nhanvien nv on nv.id = pn.MaNhanVien	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        /*Theo tựa đề*/

        public DataTable TheoTuaDe_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select s.ten as [Tên],tl.ten as [Tên thể loại],s.Giaban as [Giá bán],hd.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng] 	from hoadon hd	inner join CHITIEThoadon ct on hd.id = ct.Mahoadon	inner join sach s on s.id = ct.masach	inner join theloai tl on tl.id = s.matheloai	where hd.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tl.ten,s.ten,s.Giaban,hd.ngay";

            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable TheoTuaDe_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select s.ten as [Tên sách],tl.ten as [Tên thể loại],s.Giamua as [Giá mua],pn.ngay as [Ngày nhập], sum(ct.soluong) as [Số lượng] from phieunhap pn	inner join CHITIETPHIEUNHAP ct on pn.id = ct.MaPhieuNhap	inner join sach s on s.id = ct.masach	inner join theloai tl on tl.id = s.matheloai	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by tl.ten,s.ten,s.Giamua,pn.ngay";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }


        /*Báo Cáo*/

        public DataTable BaoCao_Xuat(DateTime tu, DateTime den)
        {

            sqlString = "select hd.id as [Mã hóa đơn],hd.ngay as [Ngày bán], sum(ct.soluong) as [Số lượng sách bán],hd.TongTien as [Tổng tiền] from hoadon hd	inner join CHITIEThoadon ct on hd.id = ct.Mahoadon	where hd.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by hd.id,hd.ngay,hd.Tongtien";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }
        public DataTable BaoCao_Nhap(DateTime tu, DateTime den)
        {

            sqlString = "select pn.id as [Mã phiếu nhập],pn.ngay as [Ngày nhập], sum(ct.soluong) as [Số lượng sách nhập],pn.TongTien as [Tổng tiền] from phieunhap pn	inner join CHITIETphieunhap ct on pn.id = ct.Maphieunhap	where pn.ngay between '" + tu.ToString("s").Substring(0, 10) + "' and '" + den.ToString("s").Substring(0, 10) + "'	group by pn.id,pn.ngay,pn.Tongtien";
            //---------------------------
            dttable = new DataTable();
            cnn = helper.GetConnect();

            da = new SqlDataAdapter(sqlString, cnn);
            da.Fill(dttable);
            cnn.Close();
            return dttable;
        }

    

    }
}
