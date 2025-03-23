using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskbank;

namespace taskbank
{
    class Bank
    {
        private BankAccount[] _bankAccounts = new BankAccount[0];
        public BankAccount[] BankAccounts => _bankAccounts;

        public void Add(BankAccount bankAccount)
        {
            Array.Resize(ref _bankAccounts, _bankAccounts.Length + 1);
            _bankAccounts[^1] = bankAccount;
        }

        public BankAccount GetBankAccountByOwner(string ownerName)
        {
            return _bankAccounts.FirstOrDefault(acc => acc.OwnerName == ownerName) ?? throw new Exception("Account not found");
        }

        public int GetBankAccountsCount() => _bankAccounts.Length;

        public void DeleteBankAccount(BankAccount bankAccount)
        {
            _bankAccounts = _bankAccounts.Where(acc => acc != bankAccount).ToArray();
        }
    }
}

