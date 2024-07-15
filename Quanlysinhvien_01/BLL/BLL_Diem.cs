using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    internal class BLL_Diem
    {
        public static BLL_Diem instance; // ctr + r + e

        public static BLL_Diem Instance
        {
            get { if (instance == null) instance = new BLL_Diem(); return instance; }
            private set => instance = value;
        }
        private BLL_Diem() { }

        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramTH, double DiemTrenLop, double DiemTH, double DiemTB, char Loai, int NamHoc)
        {
            return DAL_Diem.Instance.Them(MaSV, MaMH, PhanTramTrenLop, PhanTramTH, DiemTrenLop, DiemTH, DiemTB, Loai, NamHoc);
        }

        public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramTH, double DiemTrenLop, double DiemTH, double DiemTB, char Loai, int NamHoc, int id)
        {
            return DAL_Diem.Instance.Sua(MaSV, MaMH, PhanTramTrenLop, PhanTramTH, DiemTrenLop, DiemTH, DiemTB, Loai, NamHoc, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Diem.Instance.Xoa(id);
        }

        public DataTable DanhSach()
        {
            return DAL_Diem.Instance.DanhSach();
        }
    }
}
