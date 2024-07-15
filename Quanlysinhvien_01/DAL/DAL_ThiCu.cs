using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    internal class DAL_ThiCu
    {
        private static DAL_ThiCu instance; // ctr + r + e

        public static DAL_ThiCu Instance
        {
            get { if (instance == null) instance = new DAL_ThiCu(); return instance; }
            private set => instance = value;
        }
        private DAL_ThiCu() { }

        public bool Them(string ExamName, DateTime ExamDate, TimeSpan StartTime, TimeSpan EndTime, string CourseID, bool Status)
        {
            string sql = "INSERT INTO Exams (ExamName, ExamDate, StartTime, EndTime, CourseID, Status) " +
                         "VALUES ( @ExamName , @ExamDate , @StartTime , @EndTime , @CourseID , @Status )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ExamName, ExamDate, StartTime, EndTime, CourseID, Status });
        }

        public bool Sua(string ExamName, DateTime ExamDate, TimeSpan StartTime, TimeSpan EndTime, string CourseID, bool Status, int id)
        {
            string sql = "UPDATE Exams " +
                         "SET ExamName = @ExamName , ExamDate = @ExamDate , StartTime = @StartTime , EndTime = @EndTime , " +
                         "CourseID = @CourseID , Status = @Status " +
                         "WHERE ExamID = @ExamID ";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ExamName, ExamDate, StartTime, EndTime, CourseID, Status, id });
        }


        public bool Xoa(int ExamID)
        {
            string sql = "DELETE FROM Exams WHERE ExamID = @ExamID";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ExamID });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("SELECT * FROM Exams");
        }
    }
}
