using BankApplication_KAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationTests
{
    public class BankTests
    {
        private Bank _bank = new Bank("KAR Bank");

        [Fact]
        public void TryAddingMultipleAccounts()
        {
            _bank.BankAccounts.Clear();

            CheckingAccount checking = new CheckingAccount("John Smith", 200); 
            _bank.BankAccounts.Add(checking);

            IndividualInvestmentAccount individual = new IndividualInvestmentAccount("Mickey Mouse", 0);
            individual.AddInvestment("DIS", 500);
            _bank.BankAccounts.Add(individual);

            CorporateInvestmentAccount corporate = new CorporateInvestmentAccount("Disney Corp", 0);
            corporate.AddInvestment("DIS", 500000);
            _bank.BankAccounts.Add(corporate);

            Assert.Equal(3, _bank.BankAccounts.Count);

        }
    }
}
