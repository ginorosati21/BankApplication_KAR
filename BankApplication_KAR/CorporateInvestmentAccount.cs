using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public class CorporateInvestmentAccount : InvestmentAccount
    {
        public CorporateInvestmentAccount(string accountOwner, double balance) : base(accountOwner, balance)
        {
        }

        public override Dictionary<string, double> Investments { get; set; }
        public override string AccountOwner {get; set;}
        public override double Balance { get; set; }
    }
}
