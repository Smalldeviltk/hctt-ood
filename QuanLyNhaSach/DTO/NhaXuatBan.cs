using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhaXuatBan
    {
        public bool flag = true;
        private string _id;
        private string _Ten;
        private string _DiaChi;
        private string _DienThoai;
        private string _Email;
        private string _GhiChu;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Ten
        {
            get
            {
                return _Ten;
            }
            set
            {
                if (value != "")
                    _Ten = value;
                else
                {
                    flag = false;
                }
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }
            set
            {
                _DienThoai = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }
            set
            {
                _GhiChu = value;
            }
        }
    }
}
