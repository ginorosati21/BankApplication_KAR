using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public class IndividualInvestmentAccount : InvestmentAccount
    {
        public IndividualInvestmentAccount(string accountOwner, double balance) : base(accountOwner, balance)
        {
        }

       
        public override Dictionary<string, double> Investments { get; set; }
        public override string AccountOwner { get; set; }
        public override double Balance { get; set; }

        public override void Withdraw(double amount)
        {
            if((amount > 0 && amount <= 500) && Balance > amount)
            {
                Balance -= amount;
            }
        }
       
    }
}
