using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public abstract class InvestmentAccount : Account
    {
        public abstract override string AccountOwner { get; set; }
        public abstract override double Balance { get; set; }
        public abstract Dictionary<string, double> Investments { get; set; } 
        public InvestmentAccount(string accountOwner, double balance) : base(accountOwner, balance)
        {
            this.Investments = new Dictionary<string, double>();
        }


        public virtual void AddInvestment(string investmentName, double value)
        {
            Investments.Add(investmentName, value);
            CalculateInvestmentsValue();
        }

        public virtual void RemoveInvestment(string investmentName)
        {
            Investments.Remove(investmentName);
            CalculateInvestmentsValue();
        }

        public virtual void CalculateInvestmentsValue()
        {
            double total = 0;
            foreach(var investment in Investments)
            {
                total += investment.Value;
            }
            Balance = total;
        }
    }
}
