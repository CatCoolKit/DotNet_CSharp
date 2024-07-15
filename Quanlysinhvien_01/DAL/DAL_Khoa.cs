using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    class DAL_Khoa
    {

        private static DAL_Khoa instance; // ctr + r + e

        public static DAL_Khoa Instance
        {
            get { if (instance == null) instance = new DAL_Khoa(); return instance; }
            private set => instance = value;
        }
        private DAL_Khoa() { }

        public bool Them(string MaKhoa, string TenKhoa)
        {
            string sql = "INSERT INTO Khoa (MaKhoa, TenKhoa) " +
                         "VALUES ( @MaKhoa , @TenKhoa )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaKhoa, TenKhoa });
        }

        public bool Sua(string MaKhoa, string TenKhoa, int id)
        {
            string sql = "UPDATE Khoa SET MaKhoa = @MaKhoa , TenKhoa = @TenKhoa WHERE id = @id";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaKhoa, TenKhoa, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Khoa where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from Khoa");
        }
    }
}
