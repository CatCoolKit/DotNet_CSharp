using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance; // ctr + r + e

        public static BLL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BLL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private BLL_TaiKhoan() { }

        public DataTable DanhSach() {
            return DAL_TaiKhoan.Instance.DanhSach();
        }

        public bool Them(string ten, string matkhau, string loai, string macvht)
        {
            matkhau = Hethong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Them(ten, matkhau, loai, macvht);
        }

        public bool Sua_Het(string ten, string matkhau, string loai, string macvht, int id)
        {
            matkhau = Hethong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Sua_Het(ten, matkhau, loai, macvht, id);
        }

        public bool KhongSuaMatKhau(string ten, string loai, string macvht, int id)
        {
            
            return DAL_TaiKhoan.Instance.KhongSuaMatKhau(ten, loai, macvht, id);
        }

        public bool Xoa(int id)
        {
            return DAL_TaiKhoan.Instance.Xoa(id);
        }

        public bool DangNhap(string ten, string matkhau) {
            matkhau = Hethong.Hash(matkhau);
            DataTable dulieu = DAL_TaiKhoan.Instance.DangNhap(ten, matkhau);
            if (dulieu.Rows.Count == 0) {

                return false;
            }
            else {
                Hethong.TENDANGNHAP = ten;
                Hethong.LOAITAIKHOAN = dulieu.Rows[0]["LoaiTaiKhoan"].ToString().Trim();
                Hethong.MACVHT = dulieu.Rows[0]["MaCVHT"].ToString().Trim();
            }
            return true;
        }

        public bool DoiMatKhau(string tendangnhap, string matkhaumoi, string matkhaucu) {
            matkhaucu = Hethong.Hash(matkhaucu);
            matkhaumoi = Hethong.Hash(matkhaumoi);
            return DAL_TaiKhoan.Instance.DoiMatKhau(tendangnhap, matkhaumoi, matkhaucu);
        }

    }
}
