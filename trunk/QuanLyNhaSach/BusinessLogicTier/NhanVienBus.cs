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
    public class NhanVienBUS
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
        public DataTable TimTheoTen(string tennv)
        {
            return nvD.TimTheoTen(tennv);
        }
        public DataTable TimTheoCMND(string cmnd)
        {
            return nvD.TimTheoCMND(cmnd);
        }
        public DataTable TimTheoNgaySinh(string ngaysinh)
        {
            return nvD.TimTheoNgaySinh(ngaysinh);
        }

        public DataTable login(string username, string password)
        {
            return nvD.login(username, password);
        }
    }
}
