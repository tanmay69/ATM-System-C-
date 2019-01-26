using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Loan
    {
        double interestRate;
        Int32 numberOfYears;
        Int32 loanAmount;
        public Loan(double intr,Int32 noy,int la)
        {
            interestRate = intr / 1200;
            numberOfYears = noy;
            loanAmount = la;
        }
        public double monthlyPayment()
        {
            return loanAmount * interestRate / (1 - 1 / Math.Pow(1 + interestRate, numberOfYears * 12));
        }
        public String monthlyPaymentInString()
        {
            return String.Format("{0:C}", Convert.ToString(monthlyPayment()));
        }
        public String totalPaymentInString()
        {
            return String.Format("{0:C}", monthlyPayment() * numberOfYears * 12);
        }
        public String loanAmountInString()
        {
            return String.Format("{0:C}", loanAmount);
        }
    }
}
