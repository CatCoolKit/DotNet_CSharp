using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    public class DAL_CoVanHocTap
    {
        private static DAL_CoVanHocTap instance; // ctr + r + e

        public static DAL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }
        private DAL_CoVanHocTap() { }

        public bool Them(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string MaKhoa, string MaLop)
        {
            string sql = "INSERT INTO CoVanHocTap (MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop) " +
                         "VALUES ( @MaCVHT , @TenCVHT , @NgaySinh , @GioiTinh , @MaKhoa , @MaLop )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaKhoa, MaLop });
        }

        public bool Sua(string MaCVHT, string TenCVHT, string NgaySinh, string GioiTinh, string MaKhoa, string MaLop, int id)
        {
            string sql = "UPDATE CoVanHocTap " +
                         "SET MaCVHT = @MaCVHT , TenCVHT = @TenCVHT , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , MaKhoa = @MaKhoa , MaLop = @MaLop " +
                         "WHERE Id = @Id";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop, id });
        }



        public bool Xoa(int id)
        {
            string sql = "delete from CoVanHocTap where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from CoVanHocTap");
        }

    }
}
