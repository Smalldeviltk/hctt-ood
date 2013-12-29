using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace BusinessLogicTier
{
    public class HoaDonBUS
    {
        HoaDonDAO tgD = new HoaDonDAO();
        HoaDon pn = new HoaDon();
        public DataTable LaydsTheoNgay(DateTime tu, DateTime den)
        {
            return tgD.LaydsTheoNgay(tu,den);
        }
        public string LayMaMax()
        {
            return tgD.LayMaMax();
        }
        public ArrayList LaydsMa()
        {
            return tgD.LaydsMa();
        }
    }
}
