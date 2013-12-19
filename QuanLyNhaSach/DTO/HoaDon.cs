using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDon
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _tongTien;

        public string TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        private string _ngay;

        public string Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
    }
}
