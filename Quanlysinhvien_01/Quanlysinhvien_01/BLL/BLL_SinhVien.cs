using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien instance; // ctr + r + e

        public static BLL_SinhVien Instance
        {
            get { if (instance == null) instance = new BLL_SinhVien(); return instance; }
            private set => instance = value;
        }

        private BLL_SinhVien() { }

        public DataTable DanhSach()
        {
            return DAL_SinhVien.Instance.DanhSach();
        }

        public DataTable DanhSachSV_CVHT(string maCVHT)
        {
            return DAL_SinhVien.Instance.DanhSachSV_CVHT(maCVHT);
        }

        public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT)
        {

            return DAL_SinhVien.Instance.Them(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT);
        }

        public bool Sua(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
        {
            
            return DAL_SinhVien.Instance.Sua(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id);
        }

        public bool Xoa(int id)
        {
            return DAL_SinhVien.Instance.Xoa(id);
        }
    }
}
