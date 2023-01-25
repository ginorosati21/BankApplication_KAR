using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_KAR
{
    public class Bank
    {
        public string BankName { get; set; }
        public List<Account> BankAccounts { get; set; }

        public Bank(string bankName)
        {
            this.BankName = bankName;
            BankAccounts = new List<Account>();
        }
      

    }
}
