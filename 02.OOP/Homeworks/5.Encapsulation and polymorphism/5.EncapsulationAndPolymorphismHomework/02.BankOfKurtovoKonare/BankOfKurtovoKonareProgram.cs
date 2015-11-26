using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class BankOfKurtovoKonareProgram
    {
        static void Main()
        {
            Deposit depositAccount = new Deposit(Customer.Individual, 1200, 6.5m);
            Loan loanAccount = new Loan(Customer.Company, 20000, 4.5m);
            Mortage mortageAccount = new Mortage(Customer.Individual, 500, 8);

            depositAccount.DepositMoney(800); // 1200 + 800
            Console.WriteLine("Deposit account curent balance: " + depositAccount.Balance); // 2000

            loanAccount.DepositMoney(1000); // 20000 - 1000
            Console.WriteLine("Loan account current balance: " + loanAccount.Balance); // 19000

            mortageAccount.DepositMoney(200); // 500 - 200
            Console.WriteLine("Mortage account current balance: " + mortageAccount.Balance); // 300

            depositAccount.Widthdraw(600.50m); // 2000 - 600.50
            Console.WriteLine("Deposit account current balance: " + depositAccount.Balance); // 1399.50

            Console.WriteLine("Deposit account interset for 7 months: " + depositAccount.CalculateInterest(7));
            Console.WriteLine("Loan account interest for 3 months: " + loanAccount.CalculateInterest(2));
            Console.WriteLine("Motage account interest for 7 months: " + mortageAccount.CalculateInterest(7));

            Console.WriteLine();
            Console.WriteLine("Deposit account info: \n" + depositAccount);
            Console.WriteLine("Loan account info: \n" + loanAccount);
            Console.WriteLine("Mortage acount info: \n" + mortageAccount);
        }
    }
}
