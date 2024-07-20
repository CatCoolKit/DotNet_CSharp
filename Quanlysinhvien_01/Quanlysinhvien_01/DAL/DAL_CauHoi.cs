using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.DAL
{
    internal class DAL_CauHoi
    {
        private static DAL_CauHoi instance; // ctr + r + e

        public static DAL_CauHoi Instance
        {
            get { if (instance == null) instance = new DAL_CauHoi(); return instance; }
            private set => instance = value;
        }
        private DAL_CauHoi() { }

        public bool Them(int ExamID, string QuestionText, string QuestionType)
        {
            int count = DAL_CauHoi.Instance.Find(ExamID, QuestionText).Rows.Count;

            if (count > 0)
            {
                return false;
            }
            string sql = "INSERT INTO ExamQuestions (ExamID, QuestionText, QuestionType) " +
                         "VALUES ( @ExamID , @QuestionText , @QuestionType )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ExamID, QuestionText, QuestionType });
        }


        public bool Sua(int ExamID, string QuestionText, string QuestionType, int id)
        {
            int count = DAL_CauHoi.Instance.Find(ExamID, QuestionText).Rows.Count;

            if (count > 0)
            {
                return false;
            }
            string sql = "UPDATE ExamQuestions " +
                         "SET ExamID = @ExamID , QuestionText = @QuestionText , QuestionType = @QuestionType " +
                         "WHERE Id = @Id ";

            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ExamID, QuestionText, QuestionType, id });
        }



        public bool Xoa(int Id)
        {
            string sql = "DELETE FROM ExamQuestions WHERE Id = @Id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { Id });
        }

        public DataTable DanhSach(int ExamID)
        {
            string sql = "SELECT * FROM ExamQuestions WHERE ExamID = @ExamID ";
            return KetNoi.Instance.ExecuteQuery(sql, new object[] { ExamID });
        }

        public DataTable Find(int examID, string qtext)
        {
            string sql = "SELECT * FROM ExamQuestions Where ExamID = @ExamID AND QuestionText = @QuestionText ";
            return KetNoi.Instance.ExecuteQuery(sql, new object[] { examID, qtext });
        }
    }
}
