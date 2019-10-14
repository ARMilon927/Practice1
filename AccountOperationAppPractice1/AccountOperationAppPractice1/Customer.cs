using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Customer
    {
        public string accountName;
        public string customerName;
        public double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public string Report()
        {
            string message;
            message = customerName + " , your account Number : " + accountName + " and it's balance : " + balance;
            return message;
        }
    }
}
