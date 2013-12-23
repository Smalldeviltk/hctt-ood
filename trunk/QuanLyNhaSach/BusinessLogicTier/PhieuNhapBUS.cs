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
    public class PhieuNhapBUS
    {
        PhieuNhapDAO tgD = new PhieuNhapDAO();
        PhieuNhap pn = new PhieuNhap();
        public DataTable LaydsTheoNgay(DateTime tu, DateTime den)
        {
            return tgD.LaydsTheoNgay(tu,den);
        }
        public string LayMaMax()
        {
            return tgD.LayMaMax();
        }
    }
}
