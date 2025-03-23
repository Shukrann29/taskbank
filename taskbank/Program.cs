namespace taskbank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BankAccount myAccount = new BankAccount("2907", "Shukran", 1000);
            BankAccount Account1 = new BankAccount("303", "Sirac", 3000);
            BankAccount Account2 = new BankAccount("4141", "Shahverdi", 500);
            bank.Add(myAccount);

            while (true)
            {
                Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. AccountInfo\n4. Change OwnerName\n5. TransferFunds\n0. Quit Application");
                Console.Write("Seçiminizi edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Məbləği daxil edin: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        myAccount.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.Write("Məbləği daxil edin: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        myAccount.Withdraw(withdrawAmount);
                        break;
                    case "3":
                        myAccount.DisplayAccountInfo();
                        break;
                    case "4":
                        Console.Write("Yeni sahib adını daxil edin: ");
                        myAccount.OwnerName = Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Transfer ediləcək sahibin adını daxil edin: ");
                        string recipientName = Console.ReadLine();
                        BankAccount recipient = bank.GetBankAccountByOwner(recipientName);
                        if (recipient != null)
                        {
                            Console.Write("Məbləği daxil edin: ");
                            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                            myAccount.TransferFunds(recipient, transferAmount);
                        }
                        else
                        {
                            Console.WriteLine("Hesab tapılmadı!");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim! Zəhmət olmasa düzgün seçim edin.");
                        break;
                }
            }
        }
    }

}
    

