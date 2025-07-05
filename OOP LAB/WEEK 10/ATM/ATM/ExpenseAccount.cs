using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ExpenseAccount:Accounts
    {
        
        private float TransactionLimit;
        public ExpenseAccount(int accountNumber, float balance, float transactionLimit):base(accountNumber,balance)
        {
            SetTransLimit(transactionLimit);
            
        }
        public void SetTransLimit(float transLimit)
        {
            TransactionLimit = transLimit;
        }
        public float GetTransactionLimit()
        {
            return TransactionLimit;
        }
        public string ToString()
        {
            return " Transaction Limit "+GetTransactionLimit()+" ";
        }
    }
}
