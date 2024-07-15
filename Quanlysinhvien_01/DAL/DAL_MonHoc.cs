using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    class DAL_MonHoc
    {
        private static DAL_MonHoc instance; // ctr + r + e

        public static DAL_MonHoc Instance
        {
            get { if (instance == null) instance = new DAL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private DAL_MonHoc() { }

        public bool Them(string MaMonHoc, string TenMonHoc, int SoTC, int TietLT, int TietTH)
        {
            string sql = "INSERT INTO MonHoc (MaMH, TenMH, SoTC, TietLT, TietTH) " +
                         "VALUES ( @MaMH , @TenMH , @SoTC , @TietLT , @TietTH )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaMonHoc, TenMonHoc, SoTC, TietLT, TietTH });
        }

        public bool Sua(string MaMonHoc, string TenMonHoc, int SoTC, int TietLT, int TietTH, int id)
        {
            string sql = "UPDATE MonHoc " +
                         "SET MaMH = @MaMH , TenMH = @TenMH , SoTC = @SoTC , TietLT = @TietLT , TietTH = @TietTH " +
                         "WHERE Id = @Id";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaMonHoc, TenMonHoc, SoTC, TietLT, TietTH, id });
        }



        public bool Xoa(int id)
        {
            string sql = "delete from MonHoc where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from MonHoc");
        }
    }
}
