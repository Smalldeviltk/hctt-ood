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
        public ArrayList LayDsMaNCC()
        {
            return sD.LaydsMaNCC();
        }
        public ArrayList LayDsMaNXB()
        {
            return sD.LaydsMaNXB();
        }
        public ArrayList LaydsMaTheLoai()
        {
            return sD.LaydsMaTheLoai();
        }
        public DataTable TimSachTheoTen(string tensach)
        {
            return sD.TimSachTheoTen(tensach);
        }
        public DataTable TimSachTheoGiaBanTrongKhoang(string giatu, string giaden)
        {
            return sD.TimSachTheoGiaBanTrongKhoang(giatu, giaden);
        }
        public DataTable TimSachTheoGiaBanTu(string gia)
        {
            return sD.TimSachTheoGiaBanTu(gia);
        }
        public DataTable TimSachTheoGiaBanDen(string gia)
        {
            return sD.TimSachTheoGiaBanDen(gia);
        }
        public DataTable TimSachTheoTacGia(string matacgia)
        {
            return sD.TimSachTheoTacGia(matacgia);
        }
        public DataTable TimSachTheoTenVaTacGia(string matacgia, string tensach)
        {
            return sD.TimSachTheoTenVaTacGia(matacgia, tensach);
        }
    }
}
