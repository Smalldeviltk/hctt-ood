using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Sach
    {
        public bool flag = true;
        private string _id;
        private string _TenSach;
        private string _SoLuong;
        private string _GiaMua;
        private string _GiaBan;
        private string _TheLoai;
        private string _TacGia;
        private string _NhaXuatBan;
        private string _NhaCungCap;

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
        public string TenSach
        {
            get
            {
                return _TenSach;
            }
            set
            {
                if (value != "")
                    _TenSach = value;
                else
                {
                    flag = false;
                }
            }
        }
        public string SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                if (value != "")
                    _SoLuong = value;
                else
                {
                    flag = false;
                }
            }
        }
        public string GiaBan
        {
            get
            {
                return _GiaBan;
            }
            set
            {
                if (value != "")
                    _GiaBan = value;
                else
                {
                    flag = false;
                }
            }
        }
        public string GiaMua
        {
            get
            {
                return _GiaMua;
            }
            set
            {
                if (value != "")
                    _GiaMua = value;
                else
                {
                    flag = false;
                }
            }
        }
        public string TheLoai
        {
            get
            {
                return _TheLoai;
            }
            set
            {

                _TheLoai = value;
            }
        }
        public string TacGia
        {
            get
            {
                return _TacGia;
            }
            set
            {

                _TacGia = value;

            }
        }
        public string NhaXuatBan
        {
            get
            {
                return _NhaXuatBan;
            }
            set
            {

                _NhaXuatBan = value;

            }
        }
        public string NhaCungCap
        {
            get
            {
                return _NhaCungCap;
            }
            set
            {

                _NhaCungCap = value;

            }
        }
    }
}
