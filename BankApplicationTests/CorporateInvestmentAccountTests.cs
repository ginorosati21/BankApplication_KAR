using BankApplication_KAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationTests
{
    public class CorporateInvestmentAccountTests
    {
        private CorporateInvestmentAccount _corporate = new CorporateInvestmentAccount("John Smith", 0);

        [Fact]
        public void TryDeposit()
        {
            _corporate.Deposit(50);
            Assert.Equal(_corporate.Balance, 50);
        }

        [Fact]
        public void TryNegativeDeposit()
        {
            _corporate.Balance = 0;

            _corporate.Deposit(-10);
            Assert.Equal(_corporate.Balance, 0);
        }

        [Fact]
        public void TryWithdraw()
        {
            _corporate.Balance = 500;

            _corporate.Withdraw(200);
            Assert.Equal(_corporate.Balance, 300);
        }

        [Fact]
        public void TryNegativeWithdraw()
        {
            _corporate.Balance = 500;

            _corporate.Withdraw(-200);
            Assert.Equal(_corporate.Balance, 500);
        }

        [Fact]
        public void TryOverdraw()
        {
            _corporate.Balance = 500;

            _corporate.Withdraw(600);
            Assert.Equal(_corporate.Balance, 500);
        }

        [Fact]
        public void TryTransfer()
        {
            _corporate.Balance = 200;
            CorporateInvestmentAccount corporate2 = new CorporateInvestmentAccount("Mickey Mouse", 300);

            _corporate.Transfer(100, _corporate, corporate2);
            Assert.Equal(_corporate.Balance, 100);
            Assert.Equal(corporate2.Balance, 400);
        }

        [Fact]
        public void TryNegativeTransfer()
        {
            _corporate.Balance = 200;
            CorporateInvestmentAccount corporate2 = new CorporateInvestmentAccount("Mickey Mouse", 300);

            _corporate.Transfer(-100, _corporate, corporate2);
            Assert.Equal(_corporate.Balance, 200);
            Assert.Equal(corporate2.Balance, 300);
        }

        [Fact]
        public void TryOverdrawTransfer()
        {
            _corporate.Balance = 200;
            CorporateInvestmentAccount corporate2 = new CorporateInvestmentAccount("Mickey Mouse", 300);

            _corporate.Transfer(300, _corporate, corporate2);
            Assert.Equal(_corporate.Balance, 200);
            Assert.Equal(corporate2.Balance, 300);
        }

        [Fact]
        public void TryAddInvestment()
        {
            _corporate.Balance = 0;
            _corporate.Investments.Clear();

            _corporate.AddInvestment("TSLA", 500);
            Assert.Equal(_corporate.Balance, 500);
            Assert.NotEmpty(_corporate.Investments);
        }

        [Fact]
        public void TryRemoveInvestment()
        {
            _corporate.Balance = 0;
            _corporate.Investments.Clear();

            _corporate.AddInvestment("TSLA", 500);
            _corporate.RemoveInvestment("TSLA");

            Assert.Equal(_corporate.Balance, 0);
            Assert.Empty(_corporate.Investments);
        }


    }
}
