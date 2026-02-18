using System;
using System.Collections.Generic;
using System.Text;

namespace SP3_BankAccount
{
    class BankAccount
    {
        private Person mPerson;
        private double mBalance;
        public BankAccount()
        { mPerson = new Person(); SetBalance(0); }
        public BankAccount(string firstName, string lastName)
        { mPerson = new Person(firstName, lastName, 0); SetBalance(0); }

        public BankAccount(string firstName, string lastName, double balance)
        { mPerson = new Person(firstName, lastName, 0); SetBalance(balance); }
        public BankAccount(Person p, double balance)
        { mPerson = p; SetBalance(balance); }
        public void SetBalance(double d)
        { if (d >= 0.0) mBalance = d; }
        public double GetBalance()
        { return mBalance; }
        //worker functions
        public void Deposit(double amount)//add to the balance, check for negative, limit
        {
            if (amount > 0.0 && amount <= 1000.0)
                SetBalance(mBalance + amount);
        }
        public void Withdraw(double amount) //take away amount if balance is enough
        {
            if (GetBalance() - amount >= 0.0)
                SetBalance(mBalance - amount);
        }
        public string GetName()
        {
            return mPerson.getFirstName() + " " + mPerson.getLastName();
        }
        public void Inquiry()// print balance
        {
            Console.WriteLine("Balance: $" + mBalance);
        }
        public void Print()
        {
            Console.WriteLine(mPerson.getFirstName() + " " + mPerson.getLastName() + " balance: $" + mBalance);
        }
    }

}
