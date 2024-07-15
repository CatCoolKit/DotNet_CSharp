using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    public class BLL_Lop
    {
        private static BLL_Lop instance; // ctr + r + e

        public static BLL_Lop Instance
        {
            get { if (instance == null) instance = new BLL_Lop(); return instance; }
            private set => instance = value;
        }

        private BLL_Lop() { }

        public bool Them(string MaLop, string TenLop, int SoLuong, string MaKhoa)
        {
            return DAL_Lop.Instance.Them(MaLop, TenLop, SoLuong, MaKhoa);
        }

        public bool Sua(string MaLop, string TenLop, int SoLuong, string MaKhoa, int id)
        {
            return DAL_Lop.Instance.Sua(MaLop, TenLop, SoLuong, MaKhoa, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Lop.Instance.Xoa(id);
        }

        public DataTable DanhSach()
        {
            return DAL_Lop.Instance.DanhSach();
        }
    }
}
