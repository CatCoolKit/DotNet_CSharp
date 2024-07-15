using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_01.BLL
{
    internal class BLL_ThiCu
    {
        public static BLL_ThiCu instance; // ctr + r + e

        public static BLL_ThiCu Instance
        {
            get { if (instance == null) instance = new BLL_ThiCu(); return instance; }
            private set => instance = value;
        }
        private BLL_ThiCu() { }

        public bool Them(string ExamName, DateTime ExamDate, TimeSpan StartTime, TimeSpan EndTime, string CourseID, bool Status)
        {
            return DAL_ThiCu.Instance.Them(ExamName, ExamDate, StartTime, EndTime, CourseID, Status);
        }

        public bool Sua(string ExamName, DateTime ExamDate, TimeSpan StartTime, TimeSpan EndTime, string CourseID, bool Status, int ExamID)
        {
            return DAL_ThiCu.Instance.Sua(ExamName, ExamDate, StartTime, EndTime, CourseID, Status, ExamID);
        }

        public bool Xoa(int id)
        {
            return DAL_ThiCu.Instance.Xoa(id);
        }

        public DataTable DanhSach()
        {
            return DAL_ThiCu.Instance.DanhSach();
        }
    }
}
