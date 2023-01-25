using BankApplication_KAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationTests
{
    public class IndividualInvestmentAccountTests
    {
        private IndividualInvestmentAccount _individual = new IndividualInvestmentAccount("John Smith", 0);

        [Fact]
        public void TryDeposit()
        {
            _individual.Deposit(50);
            Assert.Equal(_individual.Balance, 50);
        }

        [Fact]
        public void TryNegativeDeposit()
        {
            _individual.Balance = 0;

            _individual.Deposit(-10);
            Assert.Equal(_individual.Balance, 0);
        }

        [Fact]
        public void TryWithdraw()
        {
            _individual.Balance = 500;

            _individual.Withdraw(200);
            Assert.Equal(_individual.Balance, 300);
        }

        [Fact]
        public void TryNegativeWithdraw()
        {
            _individual.Balance = 500;

            _individual.Withdraw(-200);
            Assert.Equal(_individual.Balance, 500);
        }

        [Fact]
        public void TryOverdraw()
        {
            _individual.Balance = 500;

            _individual.Withdraw(600);
            Assert.Equal(_individual.Balance, 500);
        }

        [Fact]
        public void TryTransfer()
        {
            _individual.Balance = 200;
            IndividualInvestmentAccount individual2 = new IndividualInvestmentAccount("Mickey Mouse", 300);

            _individual.Transfer(100, _individual, individual2);
            Assert.Equal(_individual.Balance, 100);
            Assert.Equal(individual2.Balance, 400);
        }

        [Fact]
        public void TryNegativeTransfer()
        {
            _individual.Balance = 200;
            IndividualInvestmentAccount individual2 = new IndividualInvestmentAccount("Mickey Mouse", 300);

            _individual.Transfer(-100, _individual, individual2);
            Assert.Equal(_individual.Balance, 200);
            Assert.Equal(individual2.Balance, 300);
        }

        [Fact]
        public void TryOverdrawTransfer()
        {
            _individual.Balance = 200;
            IndividualInvestmentAccount individual2 = new IndividualInvestmentAccount("Mickey Mouse", 300);

            _individual.Transfer(300, _individual, individual2);
            Assert.Equal(_individual.Balance, 200);
            Assert.Equal(individual2.Balance, 300);
        }

        [Fact]
        public void TryAddInvestment()
        {
            _individual.Balance = 0;
            _individual.Investments.Clear();

            _individual.AddInvestment("TSLA", 500);
            Assert.Equal(_individual.Balance, 500);
            Assert.NotEmpty(_individual.Investments);
        }

        [Fact]
        public void TryRemoveInvestment()
        {
            _individual.Balance = 0;
            _individual.Investments.Clear();

            _individual.AddInvestment("TSLA", 500);
            _individual.RemoveInvestment("TSLA");

            Assert.Equal(_individual.Balance, 0);
            Assert.Empty(_individual.Investments);
        }

        [Fact]
        public void TryIndividualOverdraw()
        {
            _individual.Balance = 600;
            _individual.Investments.Clear();

            _individual.Withdraw(550);
            Assert.Equal(_individual.Balance, 600);
        }
    }
}
