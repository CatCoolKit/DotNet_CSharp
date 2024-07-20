using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace Quanlysinhvien_01
{
    public class Hethong
    {
        public static string TENDANGNHAP = "";
        public static string LOAITAIKHOAN = "";
        public static string MACVHT = "";
        public static string Hash(string text)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder hashSb = new StringBuilder();
                foreach (byte b in hash)
                {
                    hashSb.Append(b.ToString("X2"));
                }
                return hashSb.ToString();
            }
        }
    }
}
