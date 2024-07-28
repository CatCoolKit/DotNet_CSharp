using repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Services
{
    public class StaffMemberRepository : RepositoryBase<StaffMember>
    {
        public StaffMember Login(string email, string password)
        {
            return _context.StaffMembers.FirstOrDefault(x => x.EmailAddress == email && x.Password == password);
        }
    }
}
