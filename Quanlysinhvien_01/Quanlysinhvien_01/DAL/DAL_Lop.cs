using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    internal class DAL_Lop
    {
        private static DAL_Lop instance; // ctr + r + e

        public static DAL_Lop Instance
        {
            get { if (instance == null) instance = new DAL_Lop(); return instance; }
            private set => instance = value;
        }
        private DAL_Lop() { }

        public bool Them(string MaLop, string TenLop, int SoLuong, string MaKhoa)
        {
            string sql = "INSERT INTO Lop (MaLop, TenLop, SoLuong, MaKhoa) " +
                         "VALUES ( @MaLop , @TenLop , @SoLuong , @MaKhoa )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaLop, TenLop, SoLuong, MaKhoa });
        }

        public bool Sua(string MaLop, string TenLop, int SoLuong, string MaKhoa, int id)
        {
            string sql = "UPDATE Lop SET MaLop = @MaLop , TenLop = @TenLop , SoLuong = @SoLuong , MaKhoa = @MaKhoa WHERE id = @id";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaLop, TenLop, SoLuong, MaKhoa, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Lop where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public System.Data.DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from Lop");
        }
    }
}
