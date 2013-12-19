using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _maPhieuNhap; }
            set { _maPhieuNhap = value; }
        }

       
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private string _soLuong;

        public string SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
