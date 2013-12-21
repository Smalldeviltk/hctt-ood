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
    public class TacGiaBUS
    {
        TacGiaDAO tgD = new TacGiaDAO();
        TacGia tg = new TacGia();
        public DataTable LaydsTacGia()
        {
            return tgD.LaydsTacGia();
        }
        public void Insert(TacGia info)
        {
            tgD.Insert(info);
        }
        public void Delete(string id)
        {
            tgD.Delete(id);
        }
        public void Update(TacGia info)
        {
            tgD.Update(info);
        }
        public string LayMaMax()
        {
            return tgD.LayMaMax();
        }
    }
}
