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
    public class NhapHangBUS
    {
        public static DataTable TimSach(string str)
        {
            try
            {
                return NhapHangDAO.TimSach(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm sách");
            }
            return null;
        }

        public static int insertPhieuNhap(PhieuNhap m)
        {
            try
            {
                return NhapHangDAO.insertPhieuNhap(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm phiếu nhập");
            }
            return -1;
        }

        public static void insertChiTietPhieuNhap(ChiTietPhieuNhap m)
        {
            try
            {
                NhapHangDAO.insertChiTietPhieuNhap(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm chi tiết phiếu nhập");
            }
        }

        public static void updateSoLuongSach(string MaSach, string SoLuong)
        {
            try
            {
                NhapHangDAO.updateSoLuongSach(MaSach, SoLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm chi tiết hóa đơn");
            }
        }

        public static string layMaMax()
        {
            return NhapHangDAO.LayMaMax();
        }

        public static string layMaMaxCT()
        {
            return NhapHangDAO.LayMaMaxCT();
        }
    }
}
