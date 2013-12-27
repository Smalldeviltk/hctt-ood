using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace BusinessLogicTier
{
    public class BaoCaoBUS
    {
        BaoCaoDAO tgD = new BaoCaoDAO();
        /*TheoTheLoai*/

        public DataTable TheoTheLoai_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoTheLoai_Xuat(tu, den);
        }
        public DataTable TheoTheLoai_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoTheLoai_Nhap(tu, den);
        }

        /*TheoTuaDe*/

        public DataTable TheoTuaDe_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoTuaDe_Xuat(tu, den);
        }
        public DataTable TheoTuaDe_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoTuaDe_Nhap(tu, den);
        }
        /*TheoNXB*/

        public DataTable TheoNXB_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoNXB_Xuat(tu, den);
        }
        public DataTable TheoNXB_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoNXB_Nhap(tu, den);
        }
        /*TheoNCC*/

        public DataTable TheoNCC_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoNCC_Xuat(tu, den);
        }
        public DataTable TheoNCC_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoNCC_Nhap(tu, den);
        }
        /*TheoTacGia*/

        public DataTable TheoTacGia_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoTacGia_Xuat(tu, den);
        }
        public DataTable TheoTacGia_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoTacGia_Nhap(tu, den);
        }
        /*TheoNhanVien*/

        public DataTable TheoNhanVien_Xuat(DateTime tu, DateTime den)
        {
            return tgD.TheoNhanVien_Xuat(tu, den);
        }
        public DataTable TheoNhanVien_Nhap(DateTime tu, DateTime den)
        {
            return tgD.TheoNhanVien_Nhap(tu, den);
        }
        /*ThongKe*/

        public DataTable BaoCao_Xuat(DateTime tu, DateTime den)
        {
            return tgD.BaoCao_Xuat(tu, den);
        }
        public DataTable BaoCao_Nhap(DateTime tu, DateTime den)
        {
            return tgD.BaoCao_Nhap(tu, den);
        }
    
    }
}
