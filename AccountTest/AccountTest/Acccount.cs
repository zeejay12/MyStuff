using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Account
    {
        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }             
            }
        }

        public Account (decimal amount)
        {
            Balance = amount;
        }

        public void NewBalance(decimal deposit)
        {
            Balance = Balance + deposit;

        }

    }
}
