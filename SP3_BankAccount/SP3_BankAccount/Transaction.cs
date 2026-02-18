using System;
using System.Collections.Generic;
using System.Text;

namespace SP3_BankAccount
{
    internal class Transaction
    {
        private BankAccount account;
        private double balance, change;

        public Transaction(BankAccount pAcc, double pCha)
        {
            account = pAcc;
            balance = account.GetBalance();
            change = pCha;
        }

        public string TransactionString()
        {
            return $"[{account.GetName()}] ${Math.Abs(change)} {(change >= 0 ? "Deposit" : "Withdrawal")}: ${balance - change} > ${balance}";
        }
    }
}
