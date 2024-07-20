using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    internal class DAL_Diem
    {
        private static DAL_Diem instance; // ctr + r + e

        public static DAL_Diem Instance
        {
            get { if (instance == null) instance = new DAL_Diem(); return instance; }
            private set => instance = value;
        }
        private DAL_Diem() { }

        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramTH, double DiemTrenLop, double DiemTH, double DiemTB, char Loai, int NamHoc)
        {
            string sql = "INSERT INTO Diem (MaSV, MaMH, PhanTramTrenLop, PhanTramTH, DiemTrenLop, DiemTH, DiemTB, Loai, NamHoc) " +
                         "VALUES ( @MaSV , @MaMH , @PhanTramTrenLop , @PhanTramTH , @DiemTrenLop , @DiemTH , @DiemTB , @Loai , @NamHoc )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramTH, DiemTrenLop, DiemTH, DiemTB, Loai, NamHoc });
        }

        public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramTH, double DiemTrenLop, double DiemTH, double DiemTB, char Loai, int NamHoc, int id)
        {
            string sql = "UPDATE Diem " +
                         "SET MaSV = @MaSV , MaMH = @MaMH , PhanTramTrenLop = @PhanTramTrenLop , PhanTramTH = @PhanTramTH , " +
                         "DiemTrenLop = @DiemTrenLop , DiemTH = @DiemTH , DiemTB = @DiemTB , Loai = @Loai , NamHoc = @NamHoc " +
                         "WHERE Id = @Id ";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramTH, DiemTrenLop, DiemTH, DiemTB, Loai, NamHoc, id });
        }

        public bool Xoa(int id)
        {
            string sql = "DELETE FROM Diem WHERE Id = @Id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("SELECT * FROM Diem");
        }

    }
}
