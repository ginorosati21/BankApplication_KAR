using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public abstract class Account
    {
        public abstract string AccountOwner { get; set; }   
        public abstract double Balance { get; set; }

        public Account(string accountOwner, double balance)
        {
            this.AccountOwner = accountOwner;
            this.Balance = balance;

        }
        


        public virtual void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
        }

        public virtual void Withdraw(double amount)
        {
            if(amount > 0 && Balance > amount)
            {
                Balance -= amount;
            }
        }

        public virtual void Transfer(double amount, Account fromAccount, Account toAccount)
        {
            if(amount > 0 && fromAccount.Balance > amount)
            {
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
            }
        }
    }
}
