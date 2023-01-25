using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public class CheckingAccount : Account
    {
        public override string AccountOwner { get; set; }
        public override double Balance { get; set; }
        public CheckingAccount(string accountOwner, double balance) : base(accountOwner, balance)
        {
            this.AccountOwner = accountOwner;
            this.Balance = balance;
        }
    }
}
