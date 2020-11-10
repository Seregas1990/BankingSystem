using System;

namespace BankingSystem
{
    public class Checking : BaseAccount, IAccount
    {
        public Checking(string name, string accountId) : base(name, accountId)
        {
        }

    }
}
