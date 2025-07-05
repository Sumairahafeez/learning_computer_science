using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class SavingsAccounts:Accounts
    {
        private double InterestRate;
        public SavingsAccounts(int AccNo, float Balance, double InterestRate):base(AccNo,Balance)
        {
            SetInterestRate(InterestRate);

        }
        public void SetInterestRate(double  InterestRate)
        {
            this.InterestRate = InterestRate;
        }
        public double getInterestRate()
        {
            return this.InterestRate;
        }
        public string ToString()
        {
            return "Interest Rate: " + InterestRate;
        }
    }
}
