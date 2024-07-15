using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    public class DAL_SinhVien
    {
        private static DAL_SinhVien instance; // ctr + r + e

        public static DAL_SinhVien Instance {
            get { if(instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }
        public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT)
        {
            string sql = "INSERT INTO SinhVien (MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT) " +
                         "VALUES ( @MaSV , @TenSV , @NgaySinh , @GioiTinh , @QueQuan , @NgayNhapHoc , @MaLop , @MaKhoa , @MaCVHT )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT });
        }



        public bool Sua(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
        {
            string sql = "UPDATE SinhVien SET MaSV = @MaSV , TenSV = @TenSV , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , QueQuan = @QueQuan , NgayNhapHoc = @NgayNhapHoc , MaLop = @MaLop , MaKhoa = @MaKhoa , MaCVHT = @MaCVHT WHERE id = @id";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id });
        }


        public bool Xoa(int id) {
            string sql = "delete from SinhVien where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach() { 
        return KetNoi.Instance.ExecuteQuery("select * from SinhVien");
        }

        public DataTable DanhSachSV_CVHT(string maCVHT)
        {
            string query = "SELECT * FROM SinhVien WHERE MaCVHT = @MaCVHT";
            return KetNoi.Instance.ExecuteQuery(query, new object[] { maCVHT });
        }

    }
}
