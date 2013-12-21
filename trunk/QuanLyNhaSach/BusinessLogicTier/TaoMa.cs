using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicTier
{
    public class TaoMa
    {
        public string TaoMaTuDong(string maGoc, int batDau)
        {
            string str, kq;
            int so;
            try
            {
                str = maGoc.Substring(batDau);
                kq = maGoc.Substring(0, batDau);
                so = Int32.Parse(str) + 1;

                for (int i = 0; i < str.Length - so.ToString().Length; i++)
                {
                    kq += "0";                
                }
                kq = kq + so;
            }
            catch (Exception e)
            {
                return null;
            }
            return kq;
        }
    }
}
