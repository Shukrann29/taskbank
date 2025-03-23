using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskbank
{
    class BankAccount
    {
        private decimal _balance;
        private readonly string _accountNumber;
        public string OwnerName { get; set; }

        public decimal Balance => _balance;
        public string AccountNumber => _accountNumber;

        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            OwnerName = ownerName;
            _balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} AZN hesabınıza əlavə edildi.");
            }
            else
                Console.WriteLine("Tessufler olsunki deposit məbləğ mənfi ola bilməz");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} AZN çıxarıldı.");
            }
            else
                Console.WriteLine("Tessufler olsunki siz bu meblegi cixarda bilmezsiz");
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Hesab nömrəsi: {_accountNumber}\nSahib: {OwnerName}\nBalans: {_balance} AZN");
        }
        public void TransferFunds(BankAccount recipient, decimal amount)
        {
            if (_balance >= amount && amount > 0)
            {
                _balance -= amount;
                recipient.Deposit(amount);
                Console.WriteLine($"{amount} AZN {recipient.OwnerName}-in hesabına göndərildi.");
            }
            else
            {
                Console.WriteLine("Tessufler olsunki siz bu meblegi transfer ede bilmezsiniz.");
            }
        }
    }
}

