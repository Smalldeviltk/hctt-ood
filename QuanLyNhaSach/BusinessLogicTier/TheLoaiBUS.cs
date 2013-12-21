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
    public class TheLoaiBUS
    {
        TheLoaiDAO tlD = new TheLoaiDAO();
        TheLoai tl = new TheLoai();
        public DataTable LaydsTheLoai()
        {
            return tlD.LaydsTheLoai();
        }
        public void Insert(TheLoai info)
        {
            tlD.Insert(info);
        }
        public void Delete(string id)
        {
            tlD.Delete(id);
        }
        public void Update(TheLoai info)
        {
            tlD.Update(info);
        }
        public string LayMaMax()
        {
            return tlD.LayMaMax();
        }

    }
}
