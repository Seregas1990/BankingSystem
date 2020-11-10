using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public abstract class BaseAccount:IAccount
    {
        public readonly string AccountID;
        public double Balance { get; set; }
        public string Name { get; set; }

        public double Deposit(double money)
        {
            Balance += money;
            return Balance;
        }

        public virtual double Withdrawals(double money)
        {
            Balance -= money;
            return Balance;
        }

        double IAccount.Balance()
        {
            return Balance;
        }

        public BaseAccount(string name, string accountId)
        {
            Name = name;
            AccountID = accountId;
            Balance = 0;
        }
            //public BaseAccount(string name, string accountId, double money)
            //{
            //    Name = name;
            //    AccountID = accountId;
            //    Balance = money;
            //}
        }
}
