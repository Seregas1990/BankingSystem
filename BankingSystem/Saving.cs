using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Saving : BaseAccount, IAccount
    {
        public Saving(string name, string accountId) : base(name, accountId)
        {
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
