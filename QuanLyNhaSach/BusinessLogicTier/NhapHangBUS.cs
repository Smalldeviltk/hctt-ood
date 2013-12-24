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
        static NhapHangDAO nhD = new NhapHangDAO();
        PhieuNhap pn = new PhieuNhap();

        public static DataTable TimSach(string str)
        {
            try
            {
                return nhD.TimSach(str);
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
                return nhD.insertPhieuNhap(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm hóa đơn");
            }
            return -1;
        }
        public static void insertChiTietPhieuNhap(ChiTietPhieuNhap m)
        {
            try
            {
                nhD.insertChiTietPhieuNhap(m);
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
                nhD.updateSoLuongSach(MaSach, SoLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm chi tiết hóa đơn");
            }
        }
    }
}
