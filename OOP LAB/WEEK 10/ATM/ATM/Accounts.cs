using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Accounts
    {
        private int AccountNumber;
        private float Balance;
        public Accounts(int accountNumber, float balance)
        {
            SetAccountNumber(accountNumber);
            SetBalance(balance);
            
        }
        public void SetAccountNumber(int accountNumber)
        {
            this.AccountNumber = accountNumber;
        }
        public void SetBalance(float balance)
        {
            this.Balance = balance;
        }
        public float GetBalance()
        {
            return this.Balance;
        }
        public int GetAccountNumber()
        {
            return this.AccountNumber;
        }
        public string AccToString()
        {
            return "Account Number: " + GetAccountNumber() + " Balance: " + GetBalance();
        }
    }
}
