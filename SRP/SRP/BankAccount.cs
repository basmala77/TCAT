using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
        }

        public void AccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
        }

        public void SaveAccountData()
        {
            Console.WriteLine("Saving account data to database...");
        }
    }
    ///////////////After///////////////
    public class AccInfo
    {
        public void PrintStatement(BankAccount account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
        }
    }

    // Responsible for saving the account data to a database
    public class SaveAcc
    {
        public void SaveAccountData(BankAccount account)
        {
            Console.WriteLine("Saving account data to database...");
        }
    }

}
