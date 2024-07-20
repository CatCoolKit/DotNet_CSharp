using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using WinFormsApp1_1805;

namespace Repository
{
    public class StaffMemberRepository : RepositoryBase<StaffMember>, IStaffMember
    {
        public StaffMember Login(string email, string password)
        {
            password = PasswordHelper.Hash(password);
            // Sử dụng LINQ để tìm StaffMember với email và mật khẩu tương ứng
            return _dbSet.FirstOrDefault(member => member.EmailAddress == email && member.Password == password);
        }
        public StaffMember GetById(int id)
        {
            return _dbSet.FirstOrDefault(member => member.MemberId == id);
        }
    }
}
