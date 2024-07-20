using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    public class BLL_MonHoc
    {
        public static BLL_MonHoc instance; // ctr + r + e

        public static BLL_MonHoc Instance
        {
            get { if (instance == null) instance = new BLL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private BLL_MonHoc() { }

        public bool Them(string MaMonHoc, string TenMonHoc, int SoTC, int TietLT, int TietTH)
        {
            return DAL_MonHoc.Instance.Them(MaMonHoc, TenMonHoc, SoTC, TietLT, TietTH);
        }

        public bool Sua(string MaMonHoc, string TenMonHoc, int SoTC, int TietLT, int TietTH, int id)
        {
            return DAL_MonHoc.Instance.Sua(MaMonHoc, TenMonHoc, SoTC, TietLT, TietTH, id);
        }

        public bool Xoa(int id)
        {
            return DAL_MonHoc.Instance.Xoa(id);
        }

        public DataTable DanhSach()
        {
            return DAL_MonHoc.Instance.DanhSach();
        }
    }
}
