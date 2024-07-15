using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace Quanlysinhvien_01.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance; // ctr + r + e

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private DAL_TaiKhoan() { }


        public bool Them(string ten, string matkhau, string loai, string macvht)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan, MaCVHT) values( @TenDangNhap , @MatKhau , @LoaiTaiKhoan , @MaCVHT )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, matkhau, loai, macvht });
        }


        public bool Sua_Het(string ten, string matkhau, string loai, string macvht, int id) {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTaiKhoan = @LoaiTaiKhoan , MaCVHT = @MaCVHT where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] {ten, matkhau, loai, macvht, id });
        }

        public bool KhongSuaMatKhau(string ten, string loai, string macvht, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , LoaiTaiKhoan = @LoaiTaiKhoan , MaCVHT = @MaCVHT where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, loai, macvht, id });
        }

        public bool Xoa(int id) {
            string sql = "delete from TaiKhoan where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from TaiKhoan");
        }
        public DataTable DangNhap(string ten, string matkhau) {
            string sql = "select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            return KetNoi.Instance.ExecuteQuery(sql, new object[] { ten, matkhau});
        }
        public bool DoiMatKhau(string ten, string matkhaumoi, string matkhaucu) {
            string sql = "update TaiKhoan set MatKhau = @MatKhauMoi where TenDangNhap = @TenDangNhap and MatKhau = @MatKhauCu";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { matkhaumoi, ten, matkhaucu});
        }

    }
}
