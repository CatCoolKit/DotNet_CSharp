using Data;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly Sp25PharmaceuticalDbContext _context;

        public AccountRepository(Sp25PharmaceuticalDbContext context)
        {
            _context = context;
        }

        public void AddAccount(StoreAccount account)
        {
            _context.StoreAccounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccount(StoreAccount account)
        {
            _context.StoreAccounts.Update(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(StoreAccount account)
        {
            _context.StoreAccounts.Remove(account);
            _context.SaveChanges();
        }

        public StoreAccount GetAccountById(int id)
        {
            return _context.StoreAccounts.Find(id);
        }

        public List<StoreAccount> GetAllAccounts()
        {
            return _context.StoreAccounts.ToList();
        }

        public void DeleteAccountById(int id)
        {
            var account = GetAccountById(id);
            if (account != null)
            {
                DeleteAccount(account);
            }
        }

        public StoreAccount Login(string email, string password)
        {
            return _context.StoreAccounts.FirstOrDefault(a => a.EmailAddress == email && a.StoreAccountPassword == password);
        }
    }
}
