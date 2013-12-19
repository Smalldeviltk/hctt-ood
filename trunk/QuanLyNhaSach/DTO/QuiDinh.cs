using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class QuiDinh
    {
        string _tenCuaHang;

        public string TenCuaHang
        {
            get { return _tenCuaHang; }
            set { _tenCuaHang = value; }
        }

        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _dienThoai;

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        string _website;

        public string Website
        {
            get { return _website; }
            set { _website = value; }
        }
    }
}
