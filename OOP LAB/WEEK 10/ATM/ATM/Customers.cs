using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Customers
    {
        private string Name;
        private int CustomerID;
        
        private SavingsAccounts Account;
        private ExpenseAccount exAccount;
        public Customers(string name, int CustomerID, SavingsAccounts Ac, ExpenseAccount exAccount)
        {
            SetName(name);
            SetCid(CustomerID);
            SetSavingAccount(Ac);
            SetExpenseAccount(exAccount);

        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetCid(int cid)
        {
            CustomerID = cid;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetCustomerID()
        {
            return CustomerID;
        }
        public void SetSavingAccount(SavingsAccounts acc)
        {
            Account = acc;
        }
        public void SetExpenseAccount(ExpenseAccount exAccount)
        {
            this.exAccount = exAccount;
        }
        public string ToString()
        {
            return "Customer "+GetCustomerID()+" Name "+GetName();
        }
    }
}
