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
    public class NhanVienBus
    {
        NhanVienDAO nvD = new NhanVienDAO();
        NhanVien nv = new NhanVien();
        public DataTable LaydsNhanVien()
        {
            return nvD.LaydsNhanVien();
        }
        public void Insert(NhanVien info)
        {
            nvD.Insert(info);
        }
        public void Delete(string id)
        {
            nvD.Delete(id);
        }
        public void Update(NhanVien info)
        {
            nvD.Update(info);
        }
        public string LayMaMax()
        {
            return nvD.LayMaMax();
        }
    }
}
