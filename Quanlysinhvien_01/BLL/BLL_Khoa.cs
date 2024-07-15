using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    public class BLL_Khoa
    {
        private static BLL_Khoa instance; // ctr + r + e

        public static BLL_Khoa Instance
        {
            get { if (instance == null) instance = new BLL_Khoa(); return instance; }
            private set => instance = value;
        }

        private BLL_Khoa() { }

        public bool Them(string MaKhoa, string TenKhoa)
        {
            return DAL.DAL_Khoa.Instance.Them(MaKhoa, TenKhoa);
        }

        public bool Sua(string MaKhoa, string TenKhoa, int id)
        {
            return DAL.DAL_Khoa.Instance.Sua(MaKhoa, TenKhoa, id);
        }

        public bool Xoa(int id)
        {
            return DAL.DAL_Khoa.Instance.Xoa(id);
        }

        public DataTable DanhSach()
        {
            return DAL.DAL_Khoa.Instance.DanhSach();
        }
    }
}
