using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Account
    {
        protected Account(string name, decimal balance) { Name = name; Balance = balance; }

        public string Name { get; set; }
        public decimal Balance { get; set; } = 0;

        public abstract void Deposit(decimal amount);
    }
     class CheckingAccount : ReplaceAccount
    {
        public CheckingAccount(string name, decimal balance)
            : base(name, balance)
        {

        }
        public override void Deposit(decimal amount) { Balance += amount; }
        public override void Withdraw(decimal amount) { 
            Balance -= amount;
        }
    }
    class FixedDepositAcc : Account
    {
        public FixedDepositAcc(string name, decimal balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }


    }

    abstract class ReplaceAccount : Account
    {
        protected ReplaceAccount(string name, decimal balance)
        :base(name, balance)
        { Name = name; Balance = balance; }
        
        public abstract void Withdraw (decimal amount); 
      
    }
}
