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
    public class NhaXuatBanBUS
    {
        NhaXuatBanDAO nxbD = new NhaXuatBanDAO();
        NhaXuatBan nxb = new NhaXuatBan();
        public DataTable LaydsNhaCungCap()
        {
            return nxbD.LaydsNhaXuatBan();
        }
        public void Insert(NhaXuatBan info)
        {
            nxbD.Insert(info);
        }
        public void Delete(string id)
        {
            nxbD.Delete(id);
        }
        public void Update(NhaXuatBan info)
        {
            nxbD.Update(info);
        }
        public string LayMaMax()
        {
            return nxbD.LayMaMax();
        }
        public ArrayList LaydsTen()
        {
            return nxbD.LaydsTen();
        }
        public string LayMaTheoTen(string ten)
        {
            return nxbD.LayMaTheoTen(ten);
        }
    }
}
