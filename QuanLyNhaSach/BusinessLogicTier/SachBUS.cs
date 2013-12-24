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
    public class SachBUS
    {
        SachDAO sD = new SachDAO();
        public DataTable LaydsSach()
        {
            return sD.LaydsSach();
        }
        public ArrayList LaydsMa()
        {
            return sD.LaydsMa();
        }
        public void Insert(Sach info)
        {
            sD.Insert(info);
        }
        public void Delete(string id)
        {
            sD.Delete(id);
        }
        public void Update(Sach info)
        {
            sD.Update(info);
        }
        public string LayMaMax()
        {
            return sD.LayMaMax();
        }
    }
}
