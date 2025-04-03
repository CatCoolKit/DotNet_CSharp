using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAccountRepository
    {
        void AddAccount(StoreAccount account);
        void UpdateAccount(StoreAccount account);
        void DeleteAccount(StoreAccount account);
        void DeleteAccountById(int id);
        StoreAccount GetAccountById(int id);
        List<StoreAccount> GetAllAccounts();
        StoreAccount Login(string email, string password);
    }
}
