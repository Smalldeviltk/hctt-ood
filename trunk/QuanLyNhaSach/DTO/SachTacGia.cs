using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SachTacGia
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        private string _MaTacGia;

        public string MaTacGia
        {
            get { return _MaTacGia; }
            set { _MaTacGia = value; }
        }
    }
}
