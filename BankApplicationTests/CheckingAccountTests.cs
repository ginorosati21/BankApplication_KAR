using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankApplication_KAR
{
    public class CheckingAccountTests
    {
        private CheckingAccount _checking = new CheckingAccount("John Smith", 0);

        [Fact]
        public void TryDeposit()
        {
            _checking.Deposit(50);
            Assert.Equal(_checking.Balance, 50);
        }

        [Fact]
        public void TryNegativeDeposit()
        {
            _checking.Balance = 0;

            _checking.Deposit(-10);
            Assert.Equal(_checking.Balance, 0);
        }

        [Fact]
        public void TryWithdraw()
        {
            _checking.Balance = 500;

            _checking.Withdraw(200);
            Assert.Equal(_checking.Balance, 300);
        }

        [Fact]
        public void TryNegativeWithdraw()
        {
            _checking.Balance = 500;

            _checking.Withdraw(-200);
            Assert.Equal(_checking.Balance, 500);
        }

        [Fact]
        public void TryOverdraw()
        {
            _checking.Balance = 500;

            _checking.Withdraw(600);
            Assert.Equal(_checking.Balance, 500);
        }

        [Fact]
        public void TryTransfer()
        {
            _checking.Balance = 200;
            CheckingAccount checking2 = new CheckingAccount("Mickey Mouse", 300);

            _checking.Transfer(100, _checking, checking2);
            Assert.Equal(_checking.Balance, 100);
            Assert.Equal(checking2.Balance, 400);
        }

        [Fact]
        public void TryNegativeTransfer()
        {
            _checking.Balance = 200;
            CheckingAccount checking2 = new CheckingAccount("Mickey Mouse", 300);

            _checking.Transfer(-100, _checking, checking2);
            Assert.Equal(_checking.Balance, 200);
            Assert.Equal(checking2.Balance, 300);
        }

        [Fact]
        public void TryOverdrawTransfer()
        {
            _checking.Balance = 200;
            CheckingAccount checking2 = new CheckingAccount("Mickey Mouse", 300);

            _checking.Transfer(300, _checking, checking2);
            Assert.Equal(_checking.Balance, 200);
            Assert.Equal(checking2.Balance, 300);
        }
    }
}
