using System;

namespace BankAccounts
{
    abstract class BankAccount
    {
        protected int Id;
        protected int OwnerId;
        protected double Amount;
        protected bool IsClosed;

        public bool CloseAccount()
        {
            if (Amount != 0) return false;

            IsClosed = true;

            return true;
        }
    }
}
