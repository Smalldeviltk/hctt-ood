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
    public class SachTacGiaBus
    {
        SachTacGiaDAO stgD = new SachTacGiaDAO();
        public void Insert(SachTacGia info)
        {
            stgD.Insert(info);
        }
        public void Delete(string masach)
        {
            stgD.Delete(masach);
        }
        public void Update(SachTacGia info)
        {
            stgD.Update(info);
        }
        public string LayMaTheoMaSach(string masach)
        {
            return stgD.LayMaTheoMaSach(masach);
        }
        public string LayMaMax()
        {
            return stgD.LayMaMax();
        }
    }

}
