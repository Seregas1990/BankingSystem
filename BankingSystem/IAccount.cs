using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public interface IAccount
    {
        public double Deposit(double money);
        public double Withdrawals(double money);
        public double Balance();
    }
}
