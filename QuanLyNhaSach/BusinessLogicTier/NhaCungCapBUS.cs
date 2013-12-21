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
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nccD = new NhaCungCapDAO();
        NhaCungCap ncc = new NhaCungCap();
        public DataTable LaydsNhaCungCap()
        {
            return nccD.LaydsNhaCungCap();
        }
        public void Insert(NhaCungCap info)
        {
            nccD.Insert(info);
        }
        public void Delete(string id)
        {
            nccD.Delete(id);
        }
        public void Update(NhaCungCap info)
        {
            nccD.Update(info);
        }
        public string LayMaMax()
        {
            return nccD.LayMaMax();
        }
    }
}
