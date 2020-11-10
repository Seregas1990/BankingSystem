using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Credit : BaseAccount, IAccount
    {
        public Credit(string name, string accountId) : base(name, accountId)
        {
            Balance = 500;
        }
        public override double Withdrawals(double money)
        {
            Balance -= money;
            if (Balance < 0)
            {
                throw Exception();
            }
            return Balance;
        }

        private Exception Exception()
        {
            throw new NotImplementedException();
        }
    }
}
