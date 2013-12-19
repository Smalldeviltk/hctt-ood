using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoai
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
    }
}
