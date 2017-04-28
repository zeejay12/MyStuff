using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(52.00M);
            Account account2 = new Account(-7.00M);
            decimal deposit;

            Console.WriteLine("Starting balance for account1: {0:C}", account1.Balance);
            Console.WriteLine("Starting balance for account2: {0:C}", account2.Balance);
            Console.WriteLine();
            Console.Write("Enter an amount for account1:$");
            deposit = Convert.ToDecimal(Console.ReadLine());
            account1.NewBalance(deposit);
            Console.Write("New balance for account1: {0:C}\n", account1.Balance);
            Console.WriteLine("++++++++++++++++++++++++++++++++\n++++++++++++++++++++++++++++++++\n");
            Console.Write("Enter an amount for account:$");
            deposit = Convert.ToDecimal(Console.ReadLine());
            account2.NewBalance(deposit);
            Console.Write("New balance for account2: {0:C}", account2.Balance);

            Console.ReadLine();
        }
    }
}
