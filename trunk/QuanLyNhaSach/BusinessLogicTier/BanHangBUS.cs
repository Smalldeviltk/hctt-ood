using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicTier
{
    public class BanHangBUS
    {
        static BanHangDAO bhD = new BanHangDAO();
        HoaDon hd = new HoaDon();

        public static DataTable TimSach(string str)
        {
            try
            {
                return bhD.TimSach(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm sách");
            }
            return null;
        }
        public static int insertHoaDon(HoaDon m)
        {
            try
            {
                return bhD.insertHoaDon(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm hóa đơn");
            }
            return -1;
        }
        public static void insertChiTietHoaDon(ChiTietHoaDon m)
        {
            try
            {
                bhD.insertChiTietHoaDon(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm chi tiết hóa đơn");
            }
        }
        public static void updateSoLuongSach(string MaSach, string SoLuong)
        {
            try
            {
                bhD.updateSoLuongSach(MaSach, SoLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm chi tiết hóa đơn");
            }
        }
    }
}
