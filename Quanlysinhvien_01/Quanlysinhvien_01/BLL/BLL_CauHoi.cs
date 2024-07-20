using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    internal class BLL_CauHoi
    {
        public static BLL_CauHoi instance; // ctr + r + e

        public static BLL_CauHoi Instance
        {
            get { if (instance == null) instance = new BLL_CauHoi(); return instance; }
            private set => instance = value;
        }
        private BLL_CauHoi() { }

        public bool Them(int ExamID, string QuestionText, string QuestionType)
        {
            return DAL_CauHoi.Instance.Them(ExamID, QuestionText, QuestionType);
        }

        public bool Sua(int ExamID, string QuestionText, string QuestionType, int id)
        {
            return DAL_CauHoi.Instance.Sua(ExamID, QuestionText, QuestionType, id);
        }

        public bool Xoa(int id)
        {
            return DAL_CauHoi.Instance.Xoa(id);
        }

        public DataTable DanhSach(int ExamID)
        {
            return DAL_CauHoi.Instance.DanhSach(ExamID);
        }
    }
}
