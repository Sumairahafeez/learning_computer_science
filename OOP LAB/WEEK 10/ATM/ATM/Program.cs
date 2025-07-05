using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            SavingsAccounts SavAccount = new SavingsAccounts(121,12000,0.25);
            ExpenseAccount ExAccount = new ExpenseAccount(121, 12000, 1000);

            Customers c1 = new Customers("Sumaira", 1, SavAccount, ExAccount);
            Console.WriteLine(c1.ToString()+" Account "+SavAccount.AccToString()+"Saving Account "+SavAccount.ToString()+" Expense Account "+ExAccount.ToString());
            Console.ReadKey();
        }
    }
}
