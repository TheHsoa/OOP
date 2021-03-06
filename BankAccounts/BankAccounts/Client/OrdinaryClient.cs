﻿namespace BankAccounts.Client
{
    class OrdinaryClient : Client
    {
        public new bool AddNewBankAccount(BankAccount bankAccount)
        {
            if (BankAccounts.Count >= 3) return false;

            base.AddNewBankAccount(bankAccount);

            return true;
        }

        public OrdinaryClient(string fullName) : base(fullName) { }
    }
}
