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
    }
}
