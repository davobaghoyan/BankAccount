using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string name { get; set; }
        public double balance { get; set; }
        public double interestrate { get; set; }
        BankAccount () { }
          public   BankAccount(string nameofcustomer, double customerBalance, double customerInterestRate)
        {
            name = nameofcustomer;
            balance = customerBalance;
            if (customerInterestRate >= 0.0 && customerInterestRate <= 22.0)
                interestrate = customerInterestRate;
            else
                throw new WrongRateInteretException("Interestrate must be between 0:22");
        }

        public void Withdraw (double requestedSum)
        {
            if (requestedSum <= this.balance)
                this.balance -= requestedSum;
            else
                throw new NotSufficentAmountException(" You don't have sufficent amount for withdraw.");
        }

        public void Deposit (double depositSum)
        {
            this.balance += depositSum;
        }

        public override string ToString()
        {
            return $"{name} has {balance}$. His interestrate is {interestrate}";
        }
    }
}
